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
    
    public class AnimationOrTweenTriggerWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(AnimationOrTween.Trigger), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(AnimationOrTween.Trigger), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(AnimationOrTween.Trigger), L, null, 16, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnClick", AnimationOrTween.Trigger.OnClick);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnHover", AnimationOrTween.Trigger.OnHover);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnPress", AnimationOrTween.Trigger.OnPress);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnHoverTrue", AnimationOrTween.Trigger.OnHoverTrue);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnHoverFalse", AnimationOrTween.Trigger.OnHoverFalse);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnPressTrue", AnimationOrTween.Trigger.OnPressTrue);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnPressFalse", AnimationOrTween.Trigger.OnPressFalse);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnActivate", AnimationOrTween.Trigger.OnActivate);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnActivateTrue", AnimationOrTween.Trigger.OnActivateTrue);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnActivateFalse", AnimationOrTween.Trigger.OnActivateFalse);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnDoubleClick", AnimationOrTween.Trigger.OnDoubleClick);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnSelect", AnimationOrTween.Trigger.OnSelect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnSelectTrue", AnimationOrTween.Trigger.OnSelectTrue);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnSelectFalse", AnimationOrTween.Trigger.OnSelectFalse);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(AnimationOrTween.Trigger));
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(AnimationOrTween.Trigger), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushAnimationOrTweenTrigger(L, (AnimationOrTween.Trigger)LuaAPI.xlua_tointeger(L, 1));
            }
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "OnClick"))
                {
                    translator.PushAnimationOrTweenTrigger(L, AnimationOrTween.Trigger.OnClick);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnHover"))
                {
                    translator.PushAnimationOrTweenTrigger(L, AnimationOrTween.Trigger.OnHover);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnPress"))
                {
                    translator.PushAnimationOrTweenTrigger(L, AnimationOrTween.Trigger.OnPress);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnHoverTrue"))
                {
                    translator.PushAnimationOrTweenTrigger(L, AnimationOrTween.Trigger.OnHoverTrue);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnHoverFalse"))
                {
                    translator.PushAnimationOrTweenTrigger(L, AnimationOrTween.Trigger.OnHoverFalse);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnPressTrue"))
                {
                    translator.PushAnimationOrTweenTrigger(L, AnimationOrTween.Trigger.OnPressTrue);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnPressFalse"))
                {
                    translator.PushAnimationOrTweenTrigger(L, AnimationOrTween.Trigger.OnPressFalse);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnActivate"))
                {
                    translator.PushAnimationOrTweenTrigger(L, AnimationOrTween.Trigger.OnActivate);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnActivateTrue"))
                {
                    translator.PushAnimationOrTweenTrigger(L, AnimationOrTween.Trigger.OnActivateTrue);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnActivateFalse"))
                {
                    translator.PushAnimationOrTweenTrigger(L, AnimationOrTween.Trigger.OnActivateFalse);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnDoubleClick"))
                {
                    translator.PushAnimationOrTweenTrigger(L, AnimationOrTween.Trigger.OnDoubleClick);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnSelect"))
                {
                    translator.PushAnimationOrTweenTrigger(L, AnimationOrTween.Trigger.OnSelect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnSelectTrue"))
                {
                    translator.PushAnimationOrTweenTrigger(L, AnimationOrTween.Trigger.OnSelectTrue);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnSelectFalse"))
                {
                    translator.PushAnimationOrTweenTrigger(L, AnimationOrTween.Trigger.OnSelectFalse);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for AnimationOrTween.Trigger!");
                }
            }
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for AnimationOrTween.Trigger! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class AnimationOrTweenDirectionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(AnimationOrTween.Direction), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(AnimationOrTween.Direction), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(AnimationOrTween.Direction), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Reverse", AnimationOrTween.Direction.Reverse);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Toggle", AnimationOrTween.Direction.Toggle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Forward", AnimationOrTween.Direction.Forward);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(AnimationOrTween.Direction));
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(AnimationOrTween.Direction), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushAnimationOrTweenDirection(L, (AnimationOrTween.Direction)LuaAPI.xlua_tointeger(L, 1));
            }
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Reverse"))
                {
                    translator.PushAnimationOrTweenDirection(L, AnimationOrTween.Direction.Reverse);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Toggle"))
                {
                    translator.PushAnimationOrTweenDirection(L, AnimationOrTween.Direction.Toggle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Forward"))
                {
                    translator.PushAnimationOrTweenDirection(L, AnimationOrTween.Direction.Forward);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for AnimationOrTween.Direction!");
                }
            }
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for AnimationOrTween.Direction! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class AnimationOrTweenDisableConditionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(AnimationOrTween.DisableCondition), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(AnimationOrTween.DisableCondition), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(AnimationOrTween.DisableCondition), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DisableAfterReverse", AnimationOrTween.DisableCondition.DisableAfterReverse);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DoNotDisable", AnimationOrTween.DisableCondition.DoNotDisable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DisableAfterForward", AnimationOrTween.DisableCondition.DisableAfterForward);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(AnimationOrTween.DisableCondition));
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(AnimationOrTween.DisableCondition), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushAnimationOrTweenDisableCondition(L, (AnimationOrTween.DisableCondition)LuaAPI.xlua_tointeger(L, 1));
            }
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "DisableAfterReverse"))
                {
                    translator.PushAnimationOrTweenDisableCondition(L, AnimationOrTween.DisableCondition.DisableAfterReverse);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DoNotDisable"))
                {
                    translator.PushAnimationOrTweenDisableCondition(L, AnimationOrTween.DisableCondition.DoNotDisable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DisableAfterForward"))
                {
                    translator.PushAnimationOrTweenDisableCondition(L, AnimationOrTween.DisableCondition.DisableAfterForward);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for AnimationOrTween.DisableCondition!");
                }
            }
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for AnimationOrTween.DisableCondition! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class AnimationOrTweenEnableConditionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(AnimationOrTween.EnableCondition), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(AnimationOrTween.EnableCondition), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(AnimationOrTween.EnableCondition), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DoNothing", AnimationOrTween.EnableCondition.DoNothing);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EnableThenPlay", AnimationOrTween.EnableCondition.EnableThenPlay);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IgnoreDisabledState", AnimationOrTween.EnableCondition.IgnoreDisabledState);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(AnimationOrTween.EnableCondition));
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(AnimationOrTween.EnableCondition), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushAnimationOrTweenEnableCondition(L, (AnimationOrTween.EnableCondition)LuaAPI.xlua_tointeger(L, 1));
            }
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "DoNothing"))
                {
                    translator.PushAnimationOrTweenEnableCondition(L, AnimationOrTween.EnableCondition.DoNothing);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EnableThenPlay"))
                {
                    translator.PushAnimationOrTweenEnableCondition(L, AnimationOrTween.EnableCondition.EnableThenPlay);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IgnoreDisabledState"))
                {
                    translator.PushAnimationOrTweenEnableCondition(L, AnimationOrTween.EnableCondition.IgnoreDisabledState);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for AnimationOrTween.EnableCondition!");
                }
            }
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for AnimationOrTween.EnableCondition! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}