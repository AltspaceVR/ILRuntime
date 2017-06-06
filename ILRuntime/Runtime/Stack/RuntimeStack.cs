using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ILRuntime.CLR.Method;
using ILRuntime.Other;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Runtime.Stack
{
    unsafe class RuntimeStack : IDisposable
    {
        ILIntepreter intepreter;
        StackObject* endOfMemory;

        IntPtr stackMemoryBasePointer;
        IntPtr stackValueMemoryBasePointer;

        public StackObject* stackMemoryBase;
        public byte* stackValueMemoryBase;
        public int stackValueMemorySlotSize;

#if ILRUNTIME_DEBUG
        IList<object> managedStack = new List<object>(32);
#else
        IList<object> managedStack = new UncheckedList<object>(32);
#endif

        Stack<StackFrame> frames = new Stack<StackFrame>();
        const int MAXIMAL_STACK_OBJECTS = 1024 * 16;

        public Stack<StackFrame> Frames { get { return frames; } }
        public RuntimeStack(ILIntepreter intepreter)
        {
            this.intepreter = intepreter;

            stackValueMemorySlotSize = StackObject.Handler.SizeOfStackObjectValue;
            stackMemoryBasePointer = System.Runtime.InteropServices.Marshal.AllocHGlobal(sizeof(StackObject) * MAXIMAL_STACK_OBJECTS);
            stackValueMemoryBasePointer = System.Runtime.InteropServices.Marshal.AllocHGlobal(stackValueMemorySlotSize * MAXIMAL_STACK_OBJECTS);

            stackMemoryBase = (StackObject*)stackMemoryBasePointer.ToPointer();
            stackValueMemoryBase = (byte *)stackValueMemoryBasePointer.ToInt64();

            endOfMemory = Add(stackMemoryBase, MAXIMAL_STACK_OBJECTS);
        }

        ~RuntimeStack()
        {
            Dispose();
        }

        public StackObject* StackBase
        {
            get
            {
                return stackMemoryBase;
            }
        }

        public IList<object> ManagedStack { get { return managedStack; } }

        public void InitializeFrame(ILMethod method, StackObject* esp, out StackFrame res)
        {
            if (esp < stackMemoryBase || esp >= endOfMemory)
                throw new StackOverflowException();
            if (frames.Count > 0 && frames.Peek().BasePointer > esp)
                throw new StackOverflowException();
            res = new StackFrame();
            res.LocalVarPointer = esp;
            res.Method = method;
#if ILRUNTIME_DEBUG
            res.Address = new IntegerReference();
            for (int i = 0; i < method.LocalVariableCount; i++)
            {
                var p = Add(esp, i);
                p->ObjectType = ObjectTypes.Null;
            }
#endif
            res.BasePointer = method.LocalVariableCount > 0 ? Add(esp, method.LocalVariableCount + 1) : esp;
            res.ManagedStackBase = managedStack.Count;
            //frames.Push(res);
        }
        public void PushFrame(ref StackFrame frame)
        {
            frames.Push(frame);
        }

        public StackObject* PopFrame(ref StackFrame frame, StackObject* esp, IList<object> mStack)
        {
            if (frames.Count > 0 && frames.Peek().BasePointer == frame.BasePointer)
                frames.Pop();
            else
                throw new NotSupportedException();
            StackObject* returnVal = esp - 1;
            var method = frame.Method;
            StackObject* ret = frame.LocalVarPointer - method.ParameterCount;
            int mStackBase = frame.ManagedStackBase;
            if (method.HasThis)
                ret--;
            if(method.ReturnType != intepreter.AppDomain.VoidType)
            {
                *ret = *returnVal;
                if(ret->ObjectType == ObjectTypes.Object)
                {
                    ret->Value = mStackBase;
                    mStack[mStackBase] = mStack[returnVal->Value];
                    mStackBase++;
                }
                ret++;
            }
#if ILRUNTIME_DEBUG
            ((List<object>)mStack).RemoveRange(mStackBase, mStack.Count - mStackBase);
#else
            ((UncheckedList<object>)mStack).RemoveRange(mStackBase, mStack.Count - mStackBase);
#endif
            return ret;
        }

        
        public void Dispose()
        {
            if (stackMemoryBasePointer != IntPtr.Zero)
            {
                System.Runtime.InteropServices.Marshal.FreeHGlobal(stackMemoryBasePointer);
                System.Runtime.InteropServices.Marshal.FreeHGlobal(stackValueMemoryBasePointer);

                stackMemoryBasePointer = IntPtr.Zero;
                stackValueMemoryBasePointer = IntPtr.Zero;
            }
        }

        StackObject* Add(StackObject* a, int b)
        {
            return (StackObject*)((long)a + sizeof(StackObject) * b);
        }
    }
}
