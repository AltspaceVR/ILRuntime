using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.Runtime.Intepreter;
using UnityEngine;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;

namespace ILRuntime.Runtime.Stack
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct StackObject
    {
        public static StackObject Null = new StackObject() { ObjectType = ObjectTypes.Null, Value = -1, ValueLow = 0 };
        [FieldOffset(0)] public ObjectTypes ObjectType;
        [FieldOffset(4)] public int Value;
        [FieldOffset(4)] public long ValueLong;
        [FieldOffset(4)] public float ValueFloat;
        [FieldOffset(4)] public double ValueDouble;
        [FieldOffset(8)] public int ValueLow;
        [FieldOffset(12)] public void* ValuePtr;

        public static IStackObjectHandler Handler = new BaseStackObjectHandler();

        public static bool IsCustomValueType(ObjectTypes objectType)
        {
            var i = (int) objectType;
            return i >= 128 && i <= 1023;
        }

        public static void Initialized(ref StackObject esp, int idx, Type t, IType fieldType, IList<object> mStack)
        {
            if (t.IsPrimitive)
            {
                if (t == typeof(int) || t == typeof(uint) || t == typeof(short) || t == typeof(ushort) || t == typeof(byte) || t == typeof(sbyte) || t == typeof(char) || t == typeof(bool))
                {
                    esp.ObjectType = ObjectTypes.Integer;
                    esp.Value = 0;
                    esp.ValueLow = 0;
                }
                else if (t == typeof(long) || t == typeof(ulong))
                {
                    esp.ObjectType = ObjectTypes.Long;
                    esp.Value = 0;
                    esp.ValueLow = 0;
                }
                else if (t == typeof(float))
                {
                    esp.ObjectType = ObjectTypes.Float;
                    esp.Value = 0;
                    esp.ValueLow = 0;
                }
                else if (t == typeof(double))
                {
                    esp.ObjectType = ObjectTypes.Double;
                    esp.Value = 0;
                    esp.ValueLow = 0;
                }
                else
                    throw new NotImplementedException();
            }
            else
            {
                if (fieldType.IsValueType)
                {
                    esp.ObjectType = ObjectTypes.Object;
                    esp.Value = idx;
                    if (fieldType is CLRType)
                    {
                        mStack[idx] = ((CLRType)fieldType).CreateDefaultInstance();
                    }
                    else
                    {
                        mStack[idx] = ((ILType)fieldType).Instantiate();
                    }
                }
                else
                    esp = Null;
            }
        }

        //IL2CPP can't process esp->Initialized() properly, so I can only use static function for this
        public static void Initialized(StackObject* esp, Type t)
        {
            if (t.IsPrimitive)
            {
                if (t == typeof(int) || t == typeof(uint) || t == typeof(short) || t == typeof(ushort) || t == typeof(byte) || t == typeof(sbyte) || t == typeof(char) || t == typeof(bool))
                {
                    esp->ObjectType = ObjectTypes.Integer;
                    esp->Value = 0;
                    esp->ValueLow = 0;
                }
                else if (t == typeof(long) || t == typeof(ulong))
                {
                    esp->ObjectType = ObjectTypes.Long;
                    esp->Value = 0;
                    esp->ValueLow = 0;
                }
                else if (t == typeof(float))
                {
                    esp->ObjectType = ObjectTypes.Float;
                    esp->Value = 0;
                    esp->ValueLow = 0;
                }
                else if (t == typeof(double))
                {
                    esp->ObjectType = ObjectTypes.Double;
                    esp->Value = 0;
                    esp->ValueLow = 0;
                }
                else
                    throw new NotImplementedException();
            }
            else
            {
                *esp = Null;
            }
        }

        public static StackObject* PushFloat(StackObject* esp, float obj)
        {
            esp->ObjectType = ObjectTypes.Float;
            esp->ValueFloat = obj;
            return esp + 1;
        }

        public static StackObject* PushObject(StackObject* esp, IList<object> mStack, object obj, bool isBox = false)
        {
            if (obj != null)
            {
                if (!isBox)
                {
                    var typeFlags = obj.GetType().GetTypeFlags();

                    if ((typeFlags & CLR.Utils.Extensions.TypeFlags.IsPrimitive) != 0)
                    {
                        ILIntepreter.UnboxObject(esp, obj);
                    }
                    else if ((typeFlags & CLR.Utils.Extensions.TypeFlags.IsEnum) != 0)
                    {
                        esp->ObjectType = ObjectTypes.Integer;
                        esp->Value = Convert.ToInt32(obj);
                    }
                    else
                    {
                        esp->ObjectType = ObjectTypes.Object;
                        esp->Value = mStack.Count;
                        mStack.Add(obj);
                    }
                }
                else
                {
                    esp->ObjectType = ObjectTypes.Object;
                    esp->Value = mStack.Count;
                    mStack.Add(obj);
                }
            }
            else
            {
                return ILIntepreter.PushNull(esp);
            }
            return esp + 1;
        }

        public static void PointToNewValueTypeValue(StackObject *loc, ILIntepreter interpreter, IList<object> mStack, CLRType t)
        {
            Handler.PointToNewValueTypeValue(loc, interpreter, mStack, t);
        }

        public static object ToObject(StackObject* esp, AppDomain appdomain, IList<object> mStack)
        {
            return Handler.ToObject(esp, appdomain, mStack);
        }

        public static void PushCustomValueTypeFromField(AppDomain appDomain, StackObject* stackObject, StackObject* objRef, IList<object> mStack, int token)
        {
            Handler.PushCustomValueTypeFromField(appDomain, stackObject, objRef, mStack, token);
        }

        public static void PushCustomValueTypeToArray(Array arr, StackObject* val, int index)
        {
            Handler.PushCustomValueTypeToArray(arr, val, index);
        }

    }

    public enum ObjectTypes
    {
        Null,
        Integer,
        Long,
        Float,
        Double,
        StackObjectReference,//Value = pointer, 
        StaticFieldReference,

        // Custom value types inserted at 128-1023

        Object = 1024,
        FieldReference,//Value = objIdx, ValueLow = fieldIdx
        ArrayReference,//Value = objIdx, ValueLow = elemIdx
    }
}
