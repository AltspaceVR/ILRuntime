using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;

namespace ILRuntime.Runtime.Stack
{
    [StructLayout(LayoutKind.Explicit)]
    public struct StackObject
    {
        public static StackObject Null = new StackObject() { ObjectType = ObjectTypes.Null, Value = -1, ValueLow = 0 };
        [FieldOffset(0)] public ObjectTypes ObjectType;
        [FieldOffset(4)] public int Value;
        [FieldOffset(4)] public long ValueLong;
        [FieldOffset(4)] public float ValueFloat;
        [FieldOffset(4)] public double ValueDouble;
        [FieldOffset(4)] public DateTime ValueDateTime;
        [FieldOffset(8)] public int ValueLow;

        public static unsafe void PointToNewValueTypeValue(StackObject *loc, List<object> mStack, CLRType t)
        {
            if (t.TypeForCLR == typeof (DateTime))
            {
                loc->ObjectType = ObjectTypes.DateTime;
                loc->ValueDateTime = new DateTime();
            }
            else
            {
                loc->ObjectType = ObjectTypes.Object;
                loc->Value = mStack.Count;
                mStack.Add(t.CreateDefaultInstance());
            }

        }

        //IL2CPP can't process esp->ToObject() properly, so I can only use static function for this
        public static unsafe object ToObject(StackObject* esp, AppDomain appdomain, List<object> mStack)
        {
            switch (esp->ObjectType)
            {
                case ObjectTypes.Integer:
                    return esp->Value;
                case ObjectTypes.Long:
                    {
                        return esp->ValueLong;
                    }
                case ObjectTypes.Float:
                    {
                        return esp->ValueFloat;
                    }
                case ObjectTypes.Double:
                    {
                        return esp->ValueDouble;
                    }
                case ObjectTypes.Object:
                    return mStack[esp->Value];
                case ObjectTypes.FieldReference:
                    {
                        ILTypeInstance instance = mStack[esp->Value] as ILTypeInstance;
                        if (instance != null)
                        {
                            return instance[esp->ValueLow];
                        }
                        else
                        {
                            var obj = mStack[esp->Value];
                            IType t = null;
                            if (obj is CrossBindingAdaptorType)
                            {
                                t = appdomain.GetType(((CrossBindingAdaptor)((CrossBindingAdaptorType)obj).ILInstance.Type.FirstCLRBaseType).BaseCLRType);
                            }
                            else
                                t = appdomain.GetType(obj.GetType());

                            return ((CLRType)t).GetFieldValue(esp->ValueLow, obj);
                        }
                    }
                case ObjectTypes.ArrayReference:
                    {
                        Array instance = mStack[esp->Value] as Array;
                        return instance.GetValue(esp->ValueLow);
                    }
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = appdomain.GetType(esp->Value);
                        if (t is ILType)
                        {
                            ILType type = (ILType)t;
                            return type.StaticInstance[esp->ValueLow];
                        }
                        else
                        {
                            CLR.TypeSystem.CLRType type = (CLR.TypeSystem.CLRType)t;
                            return type.GetFieldValue(esp->ValueLow, null);
                        }
                    }
                case ObjectTypes.StackObjectReference:
                    {
                        return ToObject((*(StackObject**)&esp->Value), appdomain, mStack);
                    }
                case ObjectTypes.Null:
                    return null;
                default:
                    throw new NotImplementedException();
            }
        }

        public unsafe static void Initialized(ref StackObject esp, int idx, Type t, IType fieldType, List<object> mStack)
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
        public unsafe static void Initialized(StackObject* esp, Type t)
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

        public static unsafe StackObject* PushDateTime(StackObject* esp, List<object> mStack, DateTime obj, bool isBox = false)
        {
            esp->ObjectType = ObjectTypes.DateTime;
            esp->ValueDateTime = obj;
            return esp + 1;
        }

        public static unsafe StackObject* PushObject(StackObject* esp, List<object> mStack, object obj, bool isBox = false)
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
        DateTime,
        Object,
        FieldReference,//Value = objIdx, ValueLow = fieldIdx
        ArrayReference,//Value = objIdx, ValueLow = elemIdx
    }
}
