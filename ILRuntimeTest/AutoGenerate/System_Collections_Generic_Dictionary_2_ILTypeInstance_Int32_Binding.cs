using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class System_Collections_Generic_Dictionary_2_ILTypeInstance_Int32_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>);
            args = new Type[]{};
            method = type.GetMethod("get_Comparer", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_Comparer_0); else UnityEngine.Debug.LogWarning("warning missing method get_Comparer"); 
            args = new Type[]{};
            method = type.GetMethod("get_Count", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_Count_1); else UnityEngine.Debug.LogWarning("warning missing method get_Count"); 
            args = new Type[]{};
            method = type.GetMethod("get_Keys", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_Keys_2); else UnityEngine.Debug.LogWarning("warning missing method get_Keys"); 
            args = new Type[]{};
            method = type.GetMethod("get_Values", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_Values_3); else UnityEngine.Debug.LogWarning("warning missing method get_Values"); 
            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance)};
            method = type.GetMethod("get_Item", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_Item_4); else UnityEngine.Debug.LogWarning("warning missing method get_Item"); 
            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance), typeof(System.Int32)};
            method = type.GetMethod("set_Item", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_Item_5); else UnityEngine.Debug.LogWarning("warning missing method set_Item"); 
            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance), typeof(System.Int32)};
            method = type.GetMethod("Add", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Add_6); else UnityEngine.Debug.LogWarning("warning missing method Add"); 
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Clear_7); else UnityEngine.Debug.LogWarning("warning missing method Clear"); 
            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance)};
            method = type.GetMethod("ContainsKey", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, ContainsKey_8); else UnityEngine.Debug.LogWarning("warning missing method ContainsKey"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("ContainsValue", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, ContainsValue_9); else UnityEngine.Debug.LogWarning("warning missing method ContainsValue"); 
            args = new Type[]{};
            method = type.GetMethod("GetEnumerator", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, GetEnumerator_10); else UnityEngine.Debug.LogWarning("warning missing method GetEnumerator"); 
            args = new Type[]{typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext)};
            method = type.GetMethod("GetObjectData", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, GetObjectData_11); else UnityEngine.Debug.LogWarning("warning missing method GetObjectData"); 
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("OnDeserialization", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, OnDeserialization_12); else UnityEngine.Debug.LogWarning("warning missing method OnDeserialization"); 
            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance)};
            method = type.GetMethod("Remove", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Remove_13); else UnityEngine.Debug.LogWarning("warning missing method Remove"); 
            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance), typeof(System.Int32).MakeByRefType()};
            method = type.GetMethod("TryGetValue", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, TryGetValue_14); else UnityEngine.Debug.LogWarning("warning missing method TryGetValue"); 


            app.RegisterCLRCreateDefaultInstance(type, () => new System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>());
            app.RegisterCLRCreateArrayInstance(type, s => new System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);
            args = new Type[]{typeof(System.Collections.Generic.IEqualityComparer<ILRuntime.Runtime.Intepreter.ILTypeInstance>)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_2);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.IEqualityComparer<ILRuntime.Runtime.Intepreter.ILTypeInstance>)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_3);
            args = new Type[]{typeof(System.Collections.Generic.IDictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_4);
            args = new Type[]{typeof(System.Collections.Generic.IDictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>), typeof(System.Collections.Generic.IEqualityComparer<ILRuntime.Runtime.Intepreter.ILTypeInstance>)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_5);

        }


        static StackObject* get_Comparer_0(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Comparer;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return StackObject.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Count_1(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Count;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_Keys_2(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Keys;

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Values_3(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Values;

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Item_4(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ILRuntime.Runtime.Intepreter.ILTypeInstance key = (ILRuntime.Runtime.Intepreter.ILTypeInstance)typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method[key];

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_Item_5(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ILRuntime.Runtime.Intepreter.ILTypeInstance key = (ILRuntime.Runtime.Intepreter.ILTypeInstance)typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method[key] = value;

            return __ret;
        }

        static StackObject* Add_6(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ILRuntime.Runtime.Intepreter.ILTypeInstance key = (ILRuntime.Runtime.Intepreter.ILTypeInstance)typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Add(key, value);

            return __ret;
        }

        static StackObject* Clear_7(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }

        static StackObject* ContainsKey_8(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ILRuntime.Runtime.Intepreter.ILTypeInstance key = (ILRuntime.Runtime.Intepreter.ILTypeInstance)typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ContainsKey(key);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ContainsValue_9(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ContainsValue(value);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetEnumerator_10(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetEnumerator();

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetObjectData_11(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Runtime.Serialization.StreamingContext context = (System.Runtime.Serialization.StreamingContext)typeof(System.Runtime.Serialization.StreamingContext).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Runtime.Serialization.SerializationInfo info = (System.Runtime.Serialization.SerializationInfo)typeof(System.Runtime.Serialization.SerializationInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetObjectData(info, context);

            return __ret;
        }

        static StackObject* OnDeserialization_12(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object sender = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDeserialization(sender);

            return __ret;
        }

        static StackObject* Remove_13(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ILRuntime.Runtime.Intepreter.ILTypeInstance key = (ILRuntime.Runtime.Intepreter.ILTypeInstance)typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Remove(key);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TryGetValue_14(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ILRuntime.Runtime.Intepreter.ILTypeInstance key = (ILRuntime.Runtime.Intepreter.ILTypeInstance)typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryGetValue(key, out value);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        ___dst->ObjectType = ObjectTypes.Integer;
                        ___dst->Value = value;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = value;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, value);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = value;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, value);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Int32[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = value;
                    }
                    break;
            }

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>();

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 capacity = ptr_of_this_method->Value;

            var result_of_this_method = new System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>(capacity);

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_2(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEqualityComparer<ILRuntime.Runtime.Intepreter.ILTypeInstance> comparer = (System.Collections.Generic.IEqualityComparer<ILRuntime.Runtime.Intepreter.ILTypeInstance>)typeof(System.Collections.Generic.IEqualityComparer<ILRuntime.Runtime.Intepreter.ILTypeInstance>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>(comparer);

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_3(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEqualityComparer<ILRuntime.Runtime.Intepreter.ILTypeInstance> comparer = (System.Collections.Generic.IEqualityComparer<ILRuntime.Runtime.Intepreter.ILTypeInstance>)typeof(System.Collections.Generic.IEqualityComparer<ILRuntime.Runtime.Intepreter.ILTypeInstance>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 capacity = ptr_of_this_method->Value;

            var result_of_this_method = new System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>(capacity, comparer);

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_4(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IDictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> dictionary = (System.Collections.Generic.IDictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.IDictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>(dictionary);

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_5(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEqualityComparer<ILRuntime.Runtime.Intepreter.ILTypeInstance> comparer = (System.Collections.Generic.IEqualityComparer<ILRuntime.Runtime.Intepreter.ILTypeInstance>)typeof(System.Collections.Generic.IEqualityComparer<ILRuntime.Runtime.Intepreter.ILTypeInstance>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.IDictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> dictionary = (System.Collections.Generic.IDictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.IDictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>(dictionary, comparer);

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
