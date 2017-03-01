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
    public class UIViewportWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIViewport), L, translator, 0, 0, 4, 4);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "sourceCamera", _g_get_sourceCamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "topLeft", _g_get_topLeft);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bottomRight", _g_get_bottomRight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fullSize", _g_get_fullSize);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "sourceCamera", _s_set_sourceCamera);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "topLeft", _s_set_topLeft);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bottomRight", _s_set_bottomRight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fullSize", _s_set_fullSize);
            
			Utils.EndObjectRegister(typeof(UIViewport), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIViewport), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIViewport));
			
			
			Utils.EndClassRegister(typeof(UIViewport), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIViewport __cl_gen_ret = new UIViewport();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIViewport constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sourceCamera(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIViewport __cl_gen_to_be_invoked = (UIViewport)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.sourceCamera);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_topLeft(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIViewport __cl_gen_to_be_invoked = (UIViewport)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.topLeft);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bottomRight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIViewport __cl_gen_to_be_invoked = (UIViewport)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.bottomRight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fullSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIViewport __cl_gen_to_be_invoked = (UIViewport)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.fullSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sourceCamera(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIViewport __cl_gen_to_be_invoked = (UIViewport)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.sourceCamera = (UnityEngine.Camera)translator.GetObject(L, 2, typeof(UnityEngine.Camera));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_topLeft(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIViewport __cl_gen_to_be_invoked = (UIViewport)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.topLeft = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bottomRight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIViewport __cl_gen_to_be_invoked = (UIViewport)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.bottomRight = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fullSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIViewport __cl_gen_to_be_invoked = (UIViewport)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fullSize = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
