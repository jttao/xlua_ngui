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
    public class UIPlayAnimationWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIPlayAnimation), L, translator, 0, 3, 10, 10);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Play", _m_Play);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PlayForward", _m_PlayForward);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PlayReverse", _m_PlayReverse);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "target", _g_get_target);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "animator", _g_get_animator);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clipName", _g_get_clipName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trigger", _g_get_trigger);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playDirection", _g_get_playDirection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "resetOnPlay", _g_get_resetOnPlay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clearSelection", _g_get_clearSelection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ifDisabledOnPlay", _g_get_ifDisabledOnPlay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "disableWhenFinished", _g_get_disableWhenFinished);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onFinished", _g_get_onFinished);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "target", _s_set_target);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "animator", _s_set_animator);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clipName", _s_set_clipName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "trigger", _s_set_trigger);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playDirection", _s_set_playDirection);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "resetOnPlay", _s_set_resetOnPlay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clearSelection", _s_set_clearSelection);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ifDisabledOnPlay", _s_set_ifDisabledOnPlay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "disableWhenFinished", _s_set_disableWhenFinished);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onFinished", _s_set_onFinished);
            
			Utils.EndObjectRegister(typeof(UIPlayAnimation), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIPlayAnimation), L, __CreateInstance, 1, 1, 1);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIPlayAnimation));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "current", _g_get_current);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "current", _s_set_current);
            
			Utils.EndClassRegister(typeof(UIPlayAnimation), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIPlayAnimation __cl_gen_ret = new UIPlayAnimation();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIPlayAnimation constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Play(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool forward = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Play( forward );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    bool forward = LuaAPI.lua_toboolean(L, 2);
                    bool onlyIfDifferent = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.Play( forward, onlyIfDifferent );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIPlayAnimation.Play!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlayForward(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.PlayForward(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlayReverse(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.PlayReverse(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_current(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UIPlayAnimation.current);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_target(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.target);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_animator(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.animator);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clipName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.clipName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_trigger(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                translator.PushAnimationOrTweenTrigger(L, __cl_gen_to_be_invoked.trigger);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_playDirection(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                translator.PushAnimationOrTweenDirection(L, __cl_gen_to_be_invoked.playDirection);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_resetOnPlay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.resetOnPlay);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clearSelection(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.clearSelection);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ifDisabledOnPlay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                translator.PushAnimationOrTweenEnableCondition(L, __cl_gen_to_be_invoked.ifDisabledOnPlay);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_disableWhenFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                translator.PushAnimationOrTweenDisableCondition(L, __cl_gen_to_be_invoked.disableWhenFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_current(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UIPlayAnimation.current = (UIPlayAnimation)translator.GetObject(L, 1, typeof(UIPlayAnimation));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_target(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.target = (UnityEngine.Animation)translator.GetObject(L, 2, typeof(UnityEngine.Animation));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_animator(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clipName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.clipName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_trigger(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                AnimationOrTween.Trigger __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.trigger = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_playDirection(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                AnimationOrTween.Direction __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.playDirection = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_resetOnPlay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.resetOnPlay = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clearSelection(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.clearSelection = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ifDisabledOnPlay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                AnimationOrTween.EnableCondition __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.ifDisabledOnPlay = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_disableWhenFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                AnimationOrTween.DisableCondition __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.disableWhenFinished = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayAnimation __cl_gen_to_be_invoked = (UIPlayAnimation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onFinished = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
