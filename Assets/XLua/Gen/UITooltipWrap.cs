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
    public class UITooltipWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UITooltip), L, translator, 0, 0, 5, 5);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiCamera", _g_get_uiCamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "text", _g_get_text);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "background", _g_get_background);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "appearSpeed", _g_get_appearSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scalingTransitions", _g_get_scalingTransitions);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiCamera", _s_set_uiCamera);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "text", _s_set_text);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "background", _s_set_background);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "appearSpeed", _s_set_appearSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scalingTransitions", _s_set_scalingTransitions);
            
			Utils.EndObjectRegister(typeof(UITooltip), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UITooltip), L, __CreateInstance, 3, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Show", _m_Show_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Hide", _m_Hide_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UITooltip));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "isVisible", _g_get_isVisible);
            
			
			Utils.EndClassRegister(typeof(UITooltip), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UITooltip __cl_gen_ret = new UITooltip();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UITooltip constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Show_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    
                    UITooltip.Show( text );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Hide_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UITooltip.Hide(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isVisible(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UITooltip.isVisible);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uiCamera(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITooltip __cl_gen_to_be_invoked = (UITooltip)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.uiCamera);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_text(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITooltip __cl_gen_to_be_invoked = (UITooltip)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.text);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_background(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITooltip __cl_gen_to_be_invoked = (UITooltip)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.background);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_appearSpeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITooltip __cl_gen_to_be_invoked = (UITooltip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.appearSpeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scalingTransitions(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITooltip __cl_gen_to_be_invoked = (UITooltip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.scalingTransitions);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uiCamera(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITooltip __cl_gen_to_be_invoked = (UITooltip)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.uiCamera = (UnityEngine.Camera)translator.GetObject(L, 2, typeof(UnityEngine.Camera));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_text(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITooltip __cl_gen_to_be_invoked = (UITooltip)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.text = (UILabel)translator.GetObject(L, 2, typeof(UILabel));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_background(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITooltip __cl_gen_to_be_invoked = (UITooltip)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.background = (UISprite)translator.GetObject(L, 2, typeof(UISprite));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_appearSpeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITooltip __cl_gen_to_be_invoked = (UITooltip)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.appearSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scalingTransitions(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITooltip __cl_gen_to_be_invoked = (UITooltip)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.scalingTransitions = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
