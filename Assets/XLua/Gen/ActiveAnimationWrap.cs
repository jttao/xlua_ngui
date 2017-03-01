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
    public class ActiveAnimationWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(ActiveAnimation), L, translator, 0, 2, 4, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Finish", _m_Finish);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Reset", _m_Reset);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPlaying", _g_get_isPlaying);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onFinished", _g_get_onFinished);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eventReceiver", _g_get_eventReceiver);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "callWhenFinished", _g_get_callWhenFinished);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "onFinished", _s_set_onFinished);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "eventReceiver", _s_set_eventReceiver);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "callWhenFinished", _s_set_callWhenFinished);
            
			Utils.EndObjectRegister(typeof(ActiveAnimation), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(ActiveAnimation), L, __CreateInstance, 2, 1, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Play", _m_Play_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(ActiveAnimation));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "current", _g_get_current);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "current", _s_set_current);
            
			Utils.EndClassRegister(typeof(ActiveAnimation), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					ActiveAnimation __cl_gen_ret = new ActiveAnimation();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ActiveAnimation constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Finish(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            ActiveAnimation __cl_gen_to_be_invoked = (ActiveAnimation)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Finish(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Reset(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            ActiveAnimation __cl_gen_to_be_invoked = (ActiveAnimation)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Reset(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Play_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Animation>(L, 1)&& translator.Assignable<AnimationOrTween.Direction>(L, 2)) 
                {
                    UnityEngine.Animation anim = (UnityEngine.Animation)translator.GetObject(L, 1, typeof(UnityEngine.Animation));
                    AnimationOrTween.Direction playDirection;translator.Get(L, 2, out playDirection);
                    
                        ActiveAnimation __cl_gen_ret = ActiveAnimation.Play( anim, playDirection );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Animation>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<AnimationOrTween.Direction>(L, 3)) 
                {
                    UnityEngine.Animation anim = (UnityEngine.Animation)translator.GetObject(L, 1, typeof(UnityEngine.Animation));
                    string clipName = LuaAPI.lua_tostring(L, 2);
                    AnimationOrTween.Direction playDirection;translator.Get(L, 3, out playDirection);
                    
                        ActiveAnimation __cl_gen_ret = ActiveAnimation.Play( anim, clipName, playDirection );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Animation>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<AnimationOrTween.Direction>(L, 3)&& translator.Assignable<AnimationOrTween.EnableCondition>(L, 4)&& translator.Assignable<AnimationOrTween.DisableCondition>(L, 5)) 
                {
                    UnityEngine.Animation anim = (UnityEngine.Animation)translator.GetObject(L, 1, typeof(UnityEngine.Animation));
                    string clipName = LuaAPI.lua_tostring(L, 2);
                    AnimationOrTween.Direction playDirection;translator.Get(L, 3, out playDirection);
                    AnimationOrTween.EnableCondition enableBeforePlay;translator.Get(L, 4, out enableBeforePlay);
                    AnimationOrTween.DisableCondition disableCondition;translator.Get(L, 5, out disableCondition);
                    
                        ActiveAnimation __cl_gen_ret = ActiveAnimation.Play( anim, clipName, playDirection, enableBeforePlay, disableCondition );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Animator>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<AnimationOrTween.Direction>(L, 3)&& translator.Assignable<AnimationOrTween.EnableCondition>(L, 4)&& translator.Assignable<AnimationOrTween.DisableCondition>(L, 5)) 
                {
                    UnityEngine.Animator anim = (UnityEngine.Animator)translator.GetObject(L, 1, typeof(UnityEngine.Animator));
                    string clipName = LuaAPI.lua_tostring(L, 2);
                    AnimationOrTween.Direction playDirection;translator.Get(L, 3, out playDirection);
                    AnimationOrTween.EnableCondition enableBeforePlay;translator.Get(L, 4, out enableBeforePlay);
                    AnimationOrTween.DisableCondition disableCondition;translator.Get(L, 5, out disableCondition);
                    
                        ActiveAnimation __cl_gen_ret = ActiveAnimation.Play( anim, clipName, playDirection, enableBeforePlay, disableCondition );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ActiveAnimation.Play!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isPlaying(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                ActiveAnimation __cl_gen_to_be_invoked = (ActiveAnimation)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isPlaying);
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
			    translator.Push(L, ActiveAnimation.current);
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
			
                ActiveAnimation __cl_gen_to_be_invoked = (ActiveAnimation)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_eventReceiver(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                ActiveAnimation __cl_gen_to_be_invoked = (ActiveAnimation)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.eventReceiver);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_callWhenFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                ActiveAnimation __cl_gen_to_be_invoked = (ActiveAnimation)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.callWhenFinished);
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
			    ActiveAnimation.current = (ActiveAnimation)translator.GetObject(L, 1, typeof(ActiveAnimation));
            
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
			
                ActiveAnimation __cl_gen_to_be_invoked = (ActiveAnimation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onFinished = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_eventReceiver(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                ActiveAnimation __cl_gen_to_be_invoked = (ActiveAnimation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.eventReceiver = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_callWhenFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                ActiveAnimation __cl_gen_to_be_invoked = (ActiveAnimation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.callWhenFinished = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
