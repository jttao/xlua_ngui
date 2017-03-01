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
    public class UIDragResizeWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIDragResize), L, translator, 0, 0, 6, 6);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "target", _g_get_target);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pivot", _g_get_pivot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minWidth", _g_get_minWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minHeight", _g_get_minHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxWidth", _g_get_maxWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxHeight", _g_get_maxHeight);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "target", _s_set_target);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pivot", _s_set_pivot);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "minWidth", _s_set_minWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "minHeight", _s_set_minHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxWidth", _s_set_maxWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxHeight", _s_set_maxHeight);
            
			Utils.EndObjectRegister(typeof(UIDragResize), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIDragResize), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIDragResize));
			
			
			Utils.EndClassRegister(typeof(UIDragResize), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIDragResize __cl_gen_ret = new UIDragResize();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIDragResize constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_target(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragResize __cl_gen_to_be_invoked = (UIDragResize)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.target);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pivot(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragResize __cl_gen_to_be_invoked = (UIDragResize)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.pivot);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragResize __cl_gen_to_be_invoked = (UIDragResize)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.minWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragResize __cl_gen_to_be_invoked = (UIDragResize)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.minHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragResize __cl_gen_to_be_invoked = (UIDragResize)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.maxWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragResize __cl_gen_to_be_invoked = (UIDragResize)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.maxHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_target(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragResize __cl_gen_to_be_invoked = (UIDragResize)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.target = (UIWidget)translator.GetObject(L, 2, typeof(UIWidget));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pivot(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragResize __cl_gen_to_be_invoked = (UIDragResize)translator.FastGetCSObj(L, 1);
                UIWidget.Pivot __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.pivot = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_minWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragResize __cl_gen_to_be_invoked = (UIDragResize)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.minWidth = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_minHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragResize __cl_gen_to_be_invoked = (UIDragResize)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.minHeight = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragResize __cl_gen_to_be_invoked = (UIDragResize)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.maxWidth = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragResize __cl_gen_to_be_invoked = (UIDragResize)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.maxHeight = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
