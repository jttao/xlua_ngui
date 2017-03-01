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
    public class UIPlayTweenWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIPlayTween), L, translator, 0, 1, 10, 10);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Play", _m_Play);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "tweenTarget", _g_get_tweenTarget);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tweenGroup", _g_get_tweenGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trigger", _g_get_trigger);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playDirection", _g_get_playDirection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "resetOnPlay", _g_get_resetOnPlay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "resetIfDisabled", _g_get_resetIfDisabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ifDisabledOnPlay", _g_get_ifDisabledOnPlay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "disableWhenFinished", _g_get_disableWhenFinished);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "includeChildren", _g_get_includeChildren);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onFinished", _g_get_onFinished);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "tweenTarget", _s_set_tweenTarget);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tweenGroup", _s_set_tweenGroup);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "trigger", _s_set_trigger);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playDirection", _s_set_playDirection);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "resetOnPlay", _s_set_resetOnPlay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "resetIfDisabled", _s_set_resetIfDisabled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ifDisabledOnPlay", _s_set_ifDisabledOnPlay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "disableWhenFinished", _s_set_disableWhenFinished);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "includeChildren", _s_set_includeChildren);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onFinished", _s_set_onFinished);
            
			Utils.EndObjectRegister(typeof(UIPlayTween), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIPlayTween), L, __CreateInstance, 1, 1, 1);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIPlayTween));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "current", _g_get_current);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "current", _s_set_current);
            
			Utils.EndClassRegister(typeof(UIPlayTween), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIPlayTween __cl_gen_ret = new UIPlayTween();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIPlayTween constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Play(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    bool forward = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Play( forward );
                    
                    
                    
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
			    translator.Push(L, UIPlayTween.current);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tweenTarget(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.tweenTarget);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tweenGroup(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.tweenGroup);
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
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
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
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
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
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.resetOnPlay);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_resetIfDisabled(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.resetIfDisabled);
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
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
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
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
                translator.PushAnimationOrTweenDisableCondition(L, __cl_gen_to_be_invoked.disableWhenFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_includeChildren(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.includeChildren);
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
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
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
			    UIPlayTween.current = (UIPlayTween)translator.GetObject(L, 1, typeof(UIPlayTween));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tweenTarget(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.tweenTarget = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tweenGroup(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.tweenGroup = LuaAPI.xlua_tointeger(L, 2);
            
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
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
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
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
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
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.resetOnPlay = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_resetIfDisabled(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.resetIfDisabled = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
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
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
                AnimationOrTween.DisableCondition __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.disableWhenFinished = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_includeChildren(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.includeChildren = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UIPlayTween __cl_gen_to_be_invoked = (UIPlayTween)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onFinished = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
