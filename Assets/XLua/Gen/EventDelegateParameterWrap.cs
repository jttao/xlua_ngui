#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class EventDelegateParameterWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(EventDelegate.Parameter), L, translator, 0, 0, 8, 7);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "value", _g_get_value);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "type", _g_get_type);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "obj", _g_get_obj);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "field", _g_get_field);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "expectedType", _g_get_expectedType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cached", _g_get_cached);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "propInfo", _g_get_propInfo);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fieldInfo", _g_get_fieldInfo);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "value", _s_set_value);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "obj", _s_set_obj);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "field", _s_set_field);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "expectedType", _s_set_expectedType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cached", _s_set_cached);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "propInfo", _s_set_propInfo);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fieldInfo", _s_set_fieldInfo);
            
			Utils.EndObjectRegister(typeof(EventDelegate.Parameter), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(EventDelegate.Parameter), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(EventDelegate.Parameter));
			
			
			Utils.EndClassRegister(typeof(EventDelegate.Parameter), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					EventDelegate.Parameter __cl_gen_ret = new EventDelegate.Parameter();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Object>(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))
				{
					UnityEngine.Object obj = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
					string field = LuaAPI.lua_tostring(L, 3);
					
					EventDelegate.Parameter __cl_gen_ret = new EventDelegate.Parameter(obj, field);
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<object>(L, 2))
				{
					object val = translator.GetObject(L, 2, typeof(object));
					
					EventDelegate.Parameter __cl_gen_ret = new EventDelegate.Parameter(val);
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to EventDelegate.Parameter constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_value(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, __cl_gen_to_be_invoked.value);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_type(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.type);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_obj(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.obj);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_field(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.field);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_expectedType(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.expectedType);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cached(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.cached);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_propInfo(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.propInfo);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fieldInfo(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.fieldInfo);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_value(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.value = translator.GetObject(L, 2, typeof(object));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_obj(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.obj = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_field(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.field = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_expectedType(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.expectedType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cached(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.cached = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_propInfo(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.propInfo = (System.Reflection.PropertyInfo)translator.GetObject(L, 2, typeof(System.Reflection.PropertyInfo));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fieldInfo(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventDelegate.Parameter __cl_gen_to_be_invoked = (EventDelegate.Parameter)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fieldInfo = (System.Reflection.FieldInfo)translator.GetObject(L, 2, typeof(System.Reflection.FieldInfo));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
