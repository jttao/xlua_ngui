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
    public class UIProgressBarWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIProgressBar), L, translator, 0, 1, 11, 9);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ForceUpdate", _m_ForceUpdate);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "cachedTransform", _g_get_cachedTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cachedCamera", _g_get_cachedCamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "foregroundWidget", _g_get_foregroundWidget);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "backgroundWidget", _g_get_backgroundWidget);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fillDirection", _g_get_fillDirection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "value", _g_get_value);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alpha", _g_get_alpha);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDragFinished", _g_get_onDragFinished);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "thumb", _g_get_thumb);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "numberOfSteps", _g_get_numberOfSteps);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onChange", _g_get_onChange);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "foregroundWidget", _s_set_foregroundWidget);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "backgroundWidget", _s_set_backgroundWidget);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fillDirection", _s_set_fillDirection);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "value", _s_set_value);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alpha", _s_set_alpha);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDragFinished", _s_set_onDragFinished);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "thumb", _s_set_thumb);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "numberOfSteps", _s_set_numberOfSteps);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onChange", _s_set_onChange);
            
			Utils.EndObjectRegister(typeof(UIProgressBar), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIProgressBar), L, __CreateInstance, 1, 1, 1);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIProgressBar));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "current", _g_get_current);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "current", _s_set_current);
            
			Utils.EndClassRegister(typeof(UIProgressBar), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIProgressBar __cl_gen_ret = new UIProgressBar();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIProgressBar constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForceUpdate(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ForceUpdate(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cachedTransform(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cachedTransform);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cachedCamera(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cachedCamera);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_foregroundWidget(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.foregroundWidget);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_backgroundWidget(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.backgroundWidget);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fillDirection(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.fillDirection);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_value(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.value);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alpha(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.alpha);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_current(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UIProgressBar.current);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDragFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDragFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_thumb(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.thumb);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_numberOfSteps(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.numberOfSteps);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onChange(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onChange);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_foregroundWidget(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.foregroundWidget = (UIWidget)translator.GetObject(L, 2, typeof(UIWidget));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_backgroundWidget(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.backgroundWidget = (UIWidget)translator.GetObject(L, 2, typeof(UIWidget));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fillDirection(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                UIProgressBar.FillDirection __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.fillDirection = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_value(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.value = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alpha(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.alpha = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_current(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UIProgressBar.current = (UIProgressBar)translator.GetObject(L, 1, typeof(UIProgressBar));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDragFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDragFinished = translator.GetDelegate<UIProgressBar.OnDragFinished>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_thumb(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.thumb = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_numberOfSteps(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.numberOfSteps = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onChange(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIProgressBar __cl_gen_to_be_invoked = (UIProgressBar)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onChange = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
