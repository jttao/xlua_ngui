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
    public class UIButtonKeysWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIButtonKeys), L, translator, 0, 1, 5, 5);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Upgrade", _m_Upgrade);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectOnClick", _g_get_selectOnClick);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectOnUp", _g_get_selectOnUp);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectOnDown", _g_get_selectOnDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectOnLeft", _g_get_selectOnLeft);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectOnRight", _g_get_selectOnRight);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectOnClick", _s_set_selectOnClick);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectOnUp", _s_set_selectOnUp);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectOnDown", _s_set_selectOnDown);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectOnLeft", _s_set_selectOnLeft);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectOnRight", _s_set_selectOnRight);
            
			Utils.EndObjectRegister(typeof(UIButtonKeys), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIButtonKeys), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIButtonKeys));
			
			
			Utils.EndClassRegister(typeof(UIButtonKeys), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIButtonKeys __cl_gen_ret = new UIButtonKeys();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIButtonKeys constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Upgrade(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIButtonKeys __cl_gen_to_be_invoked = (UIButtonKeys)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Upgrade(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectOnClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIButtonKeys __cl_gen_to_be_invoked = (UIButtonKeys)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.selectOnClick);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectOnUp(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIButtonKeys __cl_gen_to_be_invoked = (UIButtonKeys)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.selectOnUp);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectOnDown(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIButtonKeys __cl_gen_to_be_invoked = (UIButtonKeys)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.selectOnDown);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectOnLeft(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIButtonKeys __cl_gen_to_be_invoked = (UIButtonKeys)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.selectOnLeft);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectOnRight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIButtonKeys __cl_gen_to_be_invoked = (UIButtonKeys)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.selectOnRight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectOnClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIButtonKeys __cl_gen_to_be_invoked = (UIButtonKeys)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.selectOnClick = (UIButtonKeys)translator.GetObject(L, 2, typeof(UIButtonKeys));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectOnUp(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIButtonKeys __cl_gen_to_be_invoked = (UIButtonKeys)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.selectOnUp = (UIButtonKeys)translator.GetObject(L, 2, typeof(UIButtonKeys));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectOnDown(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIButtonKeys __cl_gen_to_be_invoked = (UIButtonKeys)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.selectOnDown = (UIButtonKeys)translator.GetObject(L, 2, typeof(UIButtonKeys));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectOnLeft(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIButtonKeys __cl_gen_to_be_invoked = (UIButtonKeys)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.selectOnLeft = (UIButtonKeys)translator.GetObject(L, 2, typeof(UIButtonKeys));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectOnRight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIButtonKeys __cl_gen_to_be_invoked = (UIButtonKeys)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.selectOnRight = (UIButtonKeys)translator.GetObject(L, 2, typeof(UIButtonKeys));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
