﻿using System;
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
    unsafe class System_Console_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(System.Console);
            args = new Type[]{};
            method = type.GetMethod("get_Error", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_Error_0); else UnityEngine.Debug.LogWarning("warning missing method get_Error"); 
            args = new Type[]{};
            method = type.GetMethod("get_In", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_In_1); else UnityEngine.Debug.LogWarning("warning missing method get_In"); 
            args = new Type[]{};
            method = type.GetMethod("get_Out", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_Out_2); else UnityEngine.Debug.LogWarning("warning missing method get_Out"); 
            args = new Type[]{};
            method = type.GetMethod("get_InputEncoding", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_InputEncoding_3); else UnityEngine.Debug.LogWarning("warning missing method get_InputEncoding"); 
            args = new Type[]{typeof(System.Text.Encoding)};
            method = type.GetMethod("set_InputEncoding", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_InputEncoding_4); else UnityEngine.Debug.LogWarning("warning missing method set_InputEncoding"); 
            args = new Type[]{};
            method = type.GetMethod("get_OutputEncoding", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_OutputEncoding_5); else UnityEngine.Debug.LogWarning("warning missing method get_OutputEncoding"); 
            args = new Type[]{typeof(System.Text.Encoding)};
            method = type.GetMethod("set_OutputEncoding", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_OutputEncoding_6); else UnityEngine.Debug.LogWarning("warning missing method set_OutputEncoding"); 
            args = new Type[]{};
            method = type.GetMethod("Beep", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Beep_7); else UnityEngine.Debug.LogWarning("warning missing method Beep"); 
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("Beep", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Beep_8); else UnityEngine.Debug.LogWarning("warning missing method Beep"); 
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Clear_9); else UnityEngine.Debug.LogWarning("warning missing method Clear"); 
            args = new Type[]{};
            method = type.GetMethod("get_BackgroundColor", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_BackgroundColor_10); else UnityEngine.Debug.LogWarning("warning missing method get_BackgroundColor"); 
            args = new Type[]{typeof(System.ConsoleColor)};
            method = type.GetMethod("set_BackgroundColor", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_BackgroundColor_11); else UnityEngine.Debug.LogWarning("warning missing method set_BackgroundColor"); 
            args = new Type[]{};
            method = type.GetMethod("get_ForegroundColor", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_ForegroundColor_12); else UnityEngine.Debug.LogWarning("warning missing method get_ForegroundColor"); 
            args = new Type[]{typeof(System.ConsoleColor)};
            method = type.GetMethod("set_ForegroundColor", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_ForegroundColor_13); else UnityEngine.Debug.LogWarning("warning missing method set_ForegroundColor"); 
            args = new Type[]{};
            method = type.GetMethod("ResetColor", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, ResetColor_14); else UnityEngine.Debug.LogWarning("warning missing method ResetColor"); 
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("MoveBufferArea", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, MoveBufferArea_15); else UnityEngine.Debug.LogWarning("warning missing method MoveBufferArea"); 
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Char), typeof(System.ConsoleColor), typeof(System.ConsoleColor)};
            method = type.GetMethod("MoveBufferArea", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, MoveBufferArea_16); else UnityEngine.Debug.LogWarning("warning missing method MoveBufferArea"); 
            args = new Type[]{};
            method = type.GetMethod("get_BufferHeight", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_BufferHeight_17); else UnityEngine.Debug.LogWarning("warning missing method get_BufferHeight"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_BufferHeight", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_BufferHeight_18); else UnityEngine.Debug.LogWarning("warning missing method set_BufferHeight"); 
            args = new Type[]{};
            method = type.GetMethod("get_BufferWidth", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_BufferWidth_19); else UnityEngine.Debug.LogWarning("warning missing method get_BufferWidth"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_BufferWidth", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_BufferWidth_20); else UnityEngine.Debug.LogWarning("warning missing method set_BufferWidth"); 
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetBufferSize", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, SetBufferSize_21); else UnityEngine.Debug.LogWarning("warning missing method SetBufferSize"); 
            args = new Type[]{};
            method = type.GetMethod("get_WindowHeight", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_WindowHeight_22); else UnityEngine.Debug.LogWarning("warning missing method get_WindowHeight"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_WindowHeight", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_WindowHeight_23); else UnityEngine.Debug.LogWarning("warning missing method set_WindowHeight"); 
            args = new Type[]{};
            method = type.GetMethod("get_WindowWidth", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_WindowWidth_24); else UnityEngine.Debug.LogWarning("warning missing method get_WindowWidth"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_WindowWidth", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_WindowWidth_25); else UnityEngine.Debug.LogWarning("warning missing method set_WindowWidth"); 
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetWindowSize", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, SetWindowSize_26); else UnityEngine.Debug.LogWarning("warning missing method SetWindowSize"); 
            args = new Type[]{};
            method = type.GetMethod("get_LargestWindowWidth", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_LargestWindowWidth_27); else UnityEngine.Debug.LogWarning("warning missing method get_LargestWindowWidth"); 
            args = new Type[]{};
            method = type.GetMethod("get_LargestWindowHeight", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_LargestWindowHeight_28); else UnityEngine.Debug.LogWarning("warning missing method get_LargestWindowHeight"); 
            args = new Type[]{};
            method = type.GetMethod("get_WindowLeft", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_WindowLeft_29); else UnityEngine.Debug.LogWarning("warning missing method get_WindowLeft"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_WindowLeft", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_WindowLeft_30); else UnityEngine.Debug.LogWarning("warning missing method set_WindowLeft"); 
            args = new Type[]{};
            method = type.GetMethod("get_WindowTop", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_WindowTop_31); else UnityEngine.Debug.LogWarning("warning missing method get_WindowTop"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_WindowTop", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_WindowTop_32); else UnityEngine.Debug.LogWarning("warning missing method set_WindowTop"); 
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetWindowPosition", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, SetWindowPosition_33); else UnityEngine.Debug.LogWarning("warning missing method SetWindowPosition"); 
            args = new Type[]{};
            method = type.GetMethod("get_CursorLeft", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_CursorLeft_34); else UnityEngine.Debug.LogWarning("warning missing method get_CursorLeft"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_CursorLeft", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_CursorLeft_35); else UnityEngine.Debug.LogWarning("warning missing method set_CursorLeft"); 
            args = new Type[]{};
            method = type.GetMethod("get_CursorTop", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_CursorTop_36); else UnityEngine.Debug.LogWarning("warning missing method get_CursorTop"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_CursorTop", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_CursorTop_37); else UnityEngine.Debug.LogWarning("warning missing method set_CursorTop"); 
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetCursorPosition", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, SetCursorPosition_38); else UnityEngine.Debug.LogWarning("warning missing method SetCursorPosition"); 
            args = new Type[]{};
            method = type.GetMethod("get_CursorSize", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_CursorSize_39); else UnityEngine.Debug.LogWarning("warning missing method get_CursorSize"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_CursorSize", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_CursorSize_40); else UnityEngine.Debug.LogWarning("warning missing method set_CursorSize"); 
            args = new Type[]{};
            method = type.GetMethod("get_CursorVisible", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_CursorVisible_41); else UnityEngine.Debug.LogWarning("warning missing method get_CursorVisible"); 
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_CursorVisible", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_CursorVisible_42); else UnityEngine.Debug.LogWarning("warning missing method set_CursorVisible"); 
            args = new Type[]{};
            method = type.GetMethod("get_Title", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_Title_43); else UnityEngine.Debug.LogWarning("warning missing method get_Title"); 
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_Title", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_Title_44); else UnityEngine.Debug.LogWarning("warning missing method set_Title"); 
            args = new Type[]{};
            method = type.GetMethod("ReadKey", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, ReadKey_45); else UnityEngine.Debug.LogWarning("warning missing method ReadKey"); 
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("ReadKey", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, ReadKey_46); else UnityEngine.Debug.LogWarning("warning missing method ReadKey"); 
            args = new Type[]{};
            method = type.GetMethod("get_KeyAvailable", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_KeyAvailable_47); else UnityEngine.Debug.LogWarning("warning missing method get_KeyAvailable"); 
            args = new Type[]{};
            method = type.GetMethod("get_NumberLock", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_NumberLock_48); else UnityEngine.Debug.LogWarning("warning missing method get_NumberLock"); 
            args = new Type[]{};
            method = type.GetMethod("get_CapsLock", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_CapsLock_49); else UnityEngine.Debug.LogWarning("warning missing method get_CapsLock"); 
            args = new Type[]{};
            method = type.GetMethod("get_TreatControlCAsInput", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, get_TreatControlCAsInput_50); else UnityEngine.Debug.LogWarning("warning missing method get_TreatControlCAsInput"); 
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_TreatControlCAsInput", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, set_TreatControlCAsInput_51); else UnityEngine.Debug.LogWarning("warning missing method set_TreatControlCAsInput"); 
            args = new Type[]{};
            method = type.GetMethod("OpenStandardError", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, OpenStandardError_52); else UnityEngine.Debug.LogWarning("warning missing method OpenStandardError"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("OpenStandardError", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, OpenStandardError_53); else UnityEngine.Debug.LogWarning("warning missing method OpenStandardError"); 
            args = new Type[]{};
            method = type.GetMethod("OpenStandardInput", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, OpenStandardInput_54); else UnityEngine.Debug.LogWarning("warning missing method OpenStandardInput"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("OpenStandardInput", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, OpenStandardInput_55); else UnityEngine.Debug.LogWarning("warning missing method OpenStandardInput"); 
            args = new Type[]{};
            method = type.GetMethod("OpenStandardOutput", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, OpenStandardOutput_56); else UnityEngine.Debug.LogWarning("warning missing method OpenStandardOutput"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("OpenStandardOutput", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, OpenStandardOutput_57); else UnityEngine.Debug.LogWarning("warning missing method OpenStandardOutput"); 
            args = new Type[]{typeof(System.IO.TextReader)};
            method = type.GetMethod("SetIn", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, SetIn_58); else UnityEngine.Debug.LogWarning("warning missing method SetIn"); 
            args = new Type[]{typeof(System.IO.TextWriter)};
            method = type.GetMethod("SetOut", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, SetOut_59); else UnityEngine.Debug.LogWarning("warning missing method SetOut"); 
            args = new Type[]{typeof(System.IO.TextWriter)};
            method = type.GetMethod("SetError", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, SetError_60); else UnityEngine.Debug.LogWarning("warning missing method SetError"); 
            args = new Type[]{};
            method = type.GetMethod("Read", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Read_61); else UnityEngine.Debug.LogWarning("warning missing method Read"); 
            args = new Type[]{};
            method = type.GetMethod("ReadLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, ReadLine_62); else UnityEngine.Debug.LogWarning("warning missing method ReadLine"); 
            args = new Type[]{};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_63); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_64); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.Char)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_65); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.Char[])};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_66); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.Char[]), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_67); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.Decimal)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_68); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_69); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_70); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_71); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_72); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.Int64)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_73); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_74); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_75); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_76); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.String), typeof(System.Object)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_77); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.String), typeof(System.Object), typeof(System.Object)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_78); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_79); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object), typeof(System.Object)};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_80); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.String), typeof(System.Object[])};
            method = type.GetMethod("WriteLine", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, WriteLine_81); else UnityEngine.Debug.LogWarning("warning missing method WriteLine"); 
            args = new Type[]{typeof(System.String), typeof(System.Object)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_82); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.String), typeof(System.Object), typeof(System.Object)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_83); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_84); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object), typeof(System.Object)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_85); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.String), typeof(System.Object[])};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_86); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_87); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.Char)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_88); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.Char[])};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_89); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.Char[]), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_90); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_91); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.Decimal)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_92); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_93); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_94); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_95); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.Int64)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_96); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_97); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_98); else UnityEngine.Debug.LogWarning("warning missing method Write"); 
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("Write", flag, null, args, null);
            if (method != null) app.RegisterCLRMethodRedirection(method, Write_99); else UnityEngine.Debug.LogWarning("warning missing method Write"); 




        }


        static StackObject* get_Error_0(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.Error;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return StackObject.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_In_1(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.In;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return StackObject.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Out_2(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.Out;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return StackObject.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_InputEncoding_3(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.InputEncoding;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return StackObject.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_InputEncoding_4(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Text.Encoding value = (System.Text.Encoding)typeof(System.Text.Encoding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.InputEncoding = value;

            return __ret;
        }

        static StackObject* get_OutputEncoding_5(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.OutputEncoding;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return StackObject.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_OutputEncoding_6(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Text.Encoding value = (System.Text.Encoding)typeof(System.Text.Encoding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.OutputEncoding = value;

            return __ret;
        }

        static StackObject* Beep_7(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            System.Console.Beep();

            return __ret;
        }

        static StackObject* Beep_8(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 duration = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 frequency = ptr_of_this_method->Value;

            System.Console.Beep(frequency, duration);

            return __ret;
        }

        static StackObject* Clear_9(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            System.Console.Clear();

            return __ret;
        }

        static StackObject* get_BackgroundColor_10(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.BackgroundColor;

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_BackgroundColor_11(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.ConsoleColor value = (System.ConsoleColor)typeof(System.ConsoleColor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.BackgroundColor = value;

            return __ret;
        }

        static StackObject* get_ForegroundColor_12(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.ForegroundColor;

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_ForegroundColor_13(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.ConsoleColor value = (System.ConsoleColor)typeof(System.ConsoleColor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.ForegroundColor = value;

            return __ret;
        }

        static StackObject* ResetColor_14(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            System.Console.ResetColor();

            return __ret;
        }

        static StackObject* MoveBufferArea_15(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 targetTop = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 targetLeft = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 sourceHeight = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 sourceWidth = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 sourceTop = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 sourceLeft = ptr_of_this_method->Value;

            System.Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);

            return __ret;
        }

        static StackObject* MoveBufferArea_16(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.ConsoleColor sourceBackColor = (System.ConsoleColor)typeof(System.ConsoleColor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.ConsoleColor sourceForeColor = (System.ConsoleColor)typeof(System.ConsoleColor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Char sourceChar = (char)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 targetTop = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 targetLeft = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 sourceHeight = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 sourceWidth = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 sourceTop = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            System.Int32 sourceLeft = ptr_of_this_method->Value;

            System.Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);

            return __ret;
        }

        static StackObject* get_BufferHeight_17(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.BufferHeight;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_BufferHeight_18(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;

            System.Console.BufferHeight = value;

            return __ret;
        }

        static StackObject* get_BufferWidth_19(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.BufferWidth;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_BufferWidth_20(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;

            System.Console.BufferWidth = value;

            return __ret;
        }

        static StackObject* SetBufferSize_21(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 height = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 width = ptr_of_this_method->Value;

            System.Console.SetBufferSize(width, height);

            return __ret;
        }

        static StackObject* get_WindowHeight_22(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.WindowHeight;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_WindowHeight_23(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;

            System.Console.WindowHeight = value;

            return __ret;
        }

        static StackObject* get_WindowWidth_24(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.WindowWidth;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_WindowWidth_25(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;

            System.Console.WindowWidth = value;

            return __ret;
        }

        static StackObject* SetWindowSize_26(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 height = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 width = ptr_of_this_method->Value;

            System.Console.SetWindowSize(width, height);

            return __ret;
        }

        static StackObject* get_LargestWindowWidth_27(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.LargestWindowWidth;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_LargestWindowHeight_28(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.LargestWindowHeight;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_WindowLeft_29(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.WindowLeft;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_WindowLeft_30(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;

            System.Console.WindowLeft = value;

            return __ret;
        }

        static StackObject* get_WindowTop_31(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.WindowTop;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_WindowTop_32(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;

            System.Console.WindowTop = value;

            return __ret;
        }

        static StackObject* SetWindowPosition_33(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 top = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 left = ptr_of_this_method->Value;

            System.Console.SetWindowPosition(left, top);

            return __ret;
        }

        static StackObject* get_CursorLeft_34(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.CursorLeft;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_CursorLeft_35(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;

            System.Console.CursorLeft = value;

            return __ret;
        }

        static StackObject* get_CursorTop_36(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.CursorTop;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_CursorTop_37(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;

            System.Console.CursorTop = value;

            return __ret;
        }

        static StackObject* SetCursorPosition_38(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 top = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 left = ptr_of_this_method->Value;

            System.Console.SetCursorPosition(left, top);

            return __ret;
        }

        static StackObject* get_CursorSize_39(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.CursorSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_CursorSize_40(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;

            System.Console.CursorSize = value;

            return __ret;
        }

        static StackObject* get_CursorVisible_41(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.CursorVisible;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_CursorVisible_42(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;

            System.Console.CursorVisible = value;

            return __ret;
        }

        static StackObject* get_Title_43(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.Title;

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Title_44(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.Title = value;

            return __ret;
        }

        static StackObject* ReadKey_45(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.ReadKey();

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ReadKey_46(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean intercept = ptr_of_this_method->Value == 1;

            var result_of_this_method = System.Console.ReadKey(intercept);

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_KeyAvailable_47(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.KeyAvailable;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_NumberLock_48(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.NumberLock;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_CapsLock_49(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.CapsLock;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_TreatControlCAsInput_50(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.TreatControlCAsInput;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_TreatControlCAsInput_51(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;

            System.Console.TreatControlCAsInput = value;

            return __ret;
        }

        static StackObject* OpenStandardError_52(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.OpenStandardError();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return StackObject.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OpenStandardError_53(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 bufferSize = ptr_of_this_method->Value;

            var result_of_this_method = System.Console.OpenStandardError(bufferSize);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return StackObject.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OpenStandardInput_54(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.OpenStandardInput();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return StackObject.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OpenStandardInput_55(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 bufferSize = ptr_of_this_method->Value;

            var result_of_this_method = System.Console.OpenStandardInput(bufferSize);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return StackObject.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OpenStandardOutput_56(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.OpenStandardOutput();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return StackObject.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OpenStandardOutput_57(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 bufferSize = ptr_of_this_method->Value;

            var result_of_this_method = System.Console.OpenStandardOutput(bufferSize);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return StackObject.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetIn_58(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.IO.TextReader newIn = (System.IO.TextReader)typeof(System.IO.TextReader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.SetIn(newIn);

            return __ret;
        }

        static StackObject* SetOut_59(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.IO.TextWriter newOut = (System.IO.TextWriter)typeof(System.IO.TextWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.SetOut(newOut);

            return __ret;
        }

        static StackObject* SetError_60(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.IO.TextWriter newError = (System.IO.TextWriter)typeof(System.IO.TextWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.SetError(newError);

            return __ret;
        }

        static StackObject* Read_61(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.Read();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ReadLine_62(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Console.ReadLine();

            return StackObject.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WriteLine_63(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            System.Console.WriteLine();

            return __ret;
        }

        static StackObject* WriteLine_64(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;

            System.Console.WriteLine(value);

            return __ret;
        }

        static StackObject* WriteLine_65(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Char value = (char)ptr_of_this_method->Value;

            System.Console.WriteLine(value);

            return __ret;
        }

        static StackObject* WriteLine_66(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Char[] buffer = (System.Char[])typeof(System.Char[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.WriteLine(buffer);

            return __ret;
        }

        static StackObject* WriteLine_67(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Char[] buffer = (System.Char[])typeof(System.Char[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.WriteLine(buffer, index, count);

            return __ret;
        }

        static StackObject* WriteLine_68(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Decimal value = (System.Decimal)typeof(System.Decimal).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.WriteLine(value);

            return __ret;
        }

        static StackObject* WriteLine_69(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double value = *(double*)&ptr_of_this_method->Value;

            System.Console.WriteLine(value);

            return __ret;
        }

        static StackObject* WriteLine_70(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;

            System.Console.WriteLine(value);

            return __ret;
        }

        static StackObject* WriteLine_71(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;

            System.Console.WriteLine(value);

            return __ret;
        }

        static StackObject* WriteLine_72(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;

            System.Console.WriteLine(value);

            return __ret;
        }

        static StackObject* WriteLine_73(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 value = *(long*)&ptr_of_this_method->Value;

            System.Console.WriteLine(value);

            return __ret;
        }

        static StackObject* WriteLine_74(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 value = *(ulong*)&ptr_of_this_method->Value;

            System.Console.WriteLine(value);

            return __ret;
        }

        static StackObject* WriteLine_75(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object value = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.WriteLine(value);

            return __ret;
        }

        static StackObject* WriteLine_76(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.WriteLine(value);

            return __ret;
        }

        static StackObject* WriteLine_77(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object arg0 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String format = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.WriteLine(format, arg0);

            return __ret;
        }

        static StackObject* WriteLine_78(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object arg1 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object arg0 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String format = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.WriteLine(format, arg0, arg1);

            return __ret;
        }

        static StackObject* WriteLine_79(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object arg2 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object arg1 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Object arg0 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String format = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.WriteLine(format, arg0, arg1, arg2);

            return __ret;
        }

        static StackObject* WriteLine_80(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object arg3 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object arg2 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Object arg1 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Object arg0 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.String format = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.WriteLine(format, arg0, arg1, arg2, arg3);

            return __ret;
        }

        static StackObject* WriteLine_81(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object[] arg = (System.Object[])typeof(System.Object[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String format = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.WriteLine(format, arg);

            return __ret;
        }

        static StackObject* Write_82(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object arg0 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String format = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.Write(format, arg0);

            return __ret;
        }

        static StackObject* Write_83(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object arg1 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object arg0 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String format = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.Write(format, arg0, arg1);

            return __ret;
        }

        static StackObject* Write_84(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object arg2 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object arg1 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Object arg0 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String format = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.Write(format, arg0, arg1, arg2);

            return __ret;
        }

        static StackObject* Write_85(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object arg3 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object arg2 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Object arg1 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Object arg0 = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.String format = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.Write(format, arg0, arg1, arg2, arg3);

            return __ret;
        }

        static StackObject* Write_86(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object[] arg = (System.Object[])typeof(System.Object[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String format = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.Write(format, arg);

            return __ret;
        }

        static StackObject* Write_87(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;

            System.Console.Write(value);

            return __ret;
        }

        static StackObject* Write_88(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Char value = (char)ptr_of_this_method->Value;

            System.Console.Write(value);

            return __ret;
        }

        static StackObject* Write_89(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Char[] buffer = (System.Char[])typeof(System.Char[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.Write(buffer);

            return __ret;
        }

        static StackObject* Write_90(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Char[] buffer = (System.Char[])typeof(System.Char[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.Write(buffer, index, count);

            return __ret;
        }

        static StackObject* Write_91(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double value = *(double*)&ptr_of_this_method->Value;

            System.Console.Write(value);

            return __ret;
        }

        static StackObject* Write_92(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Decimal value = (System.Decimal)typeof(System.Decimal).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.Write(value);

            return __ret;
        }

        static StackObject* Write_93(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;

            System.Console.Write(value);

            return __ret;
        }

        static StackObject* Write_94(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;

            System.Console.Write(value);

            return __ret;
        }

        static StackObject* Write_95(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;

            System.Console.Write(value);

            return __ret;
        }

        static StackObject* Write_96(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 value = *(long*)&ptr_of_this_method->Value;

            System.Console.Write(value);

            return __ret;
        }

        static StackObject* Write_97(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 value = *(ulong*)&ptr_of_this_method->Value;

            System.Console.Write(value);

            return __ret;
        }

        static StackObject* Write_98(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object value = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.Write(value);

            return __ret;
        }

        static StackObject* Write_99(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.Console.Write(value);

            return __ret;
        }





    }
}
