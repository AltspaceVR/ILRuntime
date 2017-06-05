using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using UnityEngine;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;

namespace ILRuntime.Runtime.Stack
{
    [StructLayout(LayoutKind.Explicit)]
    public struct StackValueObject
    {
        [FieldOffset(0)] public Vector3 ValueVector3;
        [FieldOffset(0)] public Quaternion ValueQuaternion;
    }

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

        public static bool IsCustomValueType(ObjectTypes objectType)
        {
            var i = (int) objectType;
            return i >= 128 && i <= 1023;
        }

        public static unsafe void PointToNewValueTypeValue(StackObject *loc, List<object> mStack, CLRType t)
        {
            if (t.TypeForCLR == typeof (Vector3))
            {
                loc->ObjectType = (ObjectTypes)128;
                ((StackValueObject *)loc->ValuePtr)->ValueVector3 = default(Vector3);
                mStack.Add(null);
            }
            else if (t.TypeForCLR == typeof (Quaternion))
            {
                loc->ObjectType = (ObjectTypes)129;
                ((StackValueObject *)loc->ValuePtr)->ValueQuaternion = default(Quaternion);
                mStack.Add(null);
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
                case (ObjectTypes)128:
                    return ((StackValueObject *)esp)->ValueVector3;
                case (ObjectTypes)129:
                    return ((StackValueObject *)esp)->ValueQuaternion;
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
                            CLRType type = (CLRType)t;
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

        public static unsafe StackObject* PushVector3(StackObject* esp, Vector3 obj)
        {
            esp->ObjectType = (ObjectTypes)128;
            ((StackValueObject *)esp->ValuePtr)->ValueVector3 = obj;
            return esp + 1;
        }

        public static unsafe StackObject* PushQuaternion(StackObject* esp, Quaternion obj)
        {
            esp->ObjectType = (ObjectTypes)129;
            ((StackValueObject *)esp->ValuePtr)->ValueQuaternion = obj;
            return esp + 1;
        }

        public static unsafe void PushCustomValueTypeFromField(AppDomain appDomain, StackObject* stackObject, StackObject* objRef, List<object> mStack, int token)
        {
            switch (objRef->ObjectType)
            {
                case (ObjectTypes)128:
                    var _o_128 = ((StackValueObject *)objRef->ValuePtr)->ValueVector3;
                    PushObject(stackObject, mStack, ((CLRType) appDomain.GetType(typeof(Vector3))).GetFieldValue(token, _o_128));
                    break;
                case (ObjectTypes)129:
                    var _o_129 = ((StackValueObject *)objRef->ValuePtr)->ValueQuaternion;
                    PushObject(stackObject, mStack, ((CLRType) appDomain.GetType(typeof(Vector3))).GetFieldValue(token, _o_129));
                    break;
            }
        }

        public static unsafe void PushCustomValueTypeToArray(Array arr, StackObject* val, int index)
        {
            if (arr is object[])
            {
                switch (val->ObjectType)
                {
                    case (ObjectTypes)128:
                        var _o_128 = ((StackValueObject *)val->ValuePtr)->ValueVector3;
                        arr.SetValue(_o_128, index);
                        break;
                    case (ObjectTypes)129:
                        var _o_129 = ((StackValueObject *)val->ValuePtr)->ValueQuaternion;
                        arr.SetValue(_o_129, index);
                        break;
                }
            }
            else
            {
                switch (val->ObjectType)
                {
                    case (ObjectTypes)128:
                        var _o_128 = ((StackValueObject *)val->ValuePtr)->ValueVector3;
                        ((Vector3[])arr)[index] = _o_128;
                        break;
                    case (ObjectTypes)129:
                        var _o_129 = ((StackValueObject *)val->ValuePtr)->ValueQuaternion;
                        ((Quaternion[])arr)[index] = _o_129;
                        break;
                }
            }
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

        // Custom value types inserted at 128-1023

        Object = 1024,
        FieldReference,//Value = objIdx, ValueLow = fieldIdx
        ArrayReference,//Value = objIdx, ValueLow = elemIdx
    }
}
