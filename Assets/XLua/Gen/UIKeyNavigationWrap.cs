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
    public class UIKeyNavigationWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIKeyNavigation), L, translator, 0, 0, 7, 7);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "constraint", _g_get_constraint);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onUp", _g_get_onUp);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDown", _g_get_onDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onLeft", _g_get_onLeft);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onRight", _g_get_onRight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onClick", _g_get_onClick);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startsSelected", _g_get_startsSelected);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "constraint", _s_set_constraint);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onUp", _s_set_onUp);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDown", _s_set_onDown);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onLeft", _s_set_onLeft);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onRight", _s_set_onRight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onClick", _s_set_onClick);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startsSelected", _s_set_startsSelected);
            
			Utils.EndObjectRegister(typeof(UIKeyNavigation), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIKeyNavigation), L, __CreateInstance, 1, 1, 1);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIKeyNavigation));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "list", _g_get_list);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "list", _s_set_list);
            
			Utils.EndClassRegister(typeof(UIKeyNavigation), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIKeyNavigation __cl_gen_ret = new UIKeyNavigation();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIKeyNavigation constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_list(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UIKeyNavigation.list);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_constraint(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIKeyNavigation __cl_gen_to_be_invoked = (UIKeyNavigation)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.constraint);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onUp(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIKeyNavigation __cl_gen_to_be_invoked = (UIKeyNavigation)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onUp);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDown(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIKeyNavigation __cl_gen_to_be_invoked = (UIKeyNavigation)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDown);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onLeft(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIKeyNavigation __cl_gen_to_be_invoked = (UIKeyNavigation)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onLeft);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onRight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIKeyNavigation __cl_gen_to_be_invoked = (UIKeyNavigation)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onRight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIKeyNavigation __cl_gen_to_be_invoked = (UIKeyNavigation)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onClick);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startsSelected(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIKeyNavigation __cl_gen_to_be_invoked = (UIKeyNavigation)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.startsSelected);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_list(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UIKeyNavigation.list = (BetterList<UIKeyNavigation>)translator.GetObject(L, 1, typeof(BetterList<UIKeyNavigation>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_constraint(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIKeyNavigation __cl_gen_to_be_invoked = (UIKeyNavigation)translator.FastGetCSObj(L, 1);
                UIKeyNavigation.Constraint __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.constraint = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onUp(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIKeyNavigation __cl_gen_to_be_invoked = (UIKeyNavigation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onUp = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDown(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIKeyNavigation __cl_gen_to_be_invoked = (UIKeyNavigation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDown = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onLeft(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIKeyNavigation __cl_gen_to_be_invoked = (UIKeyNavigation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onLeft = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onRight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIKeyNavigation __cl_gen_to_be_invoked = (UIKeyNavigation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onRight = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIKeyNavigation __cl_gen_to_be_invoked = (UIKeyNavigation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onClick = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startsSelected(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIKeyNavigation __cl_gen_to_be_invoked = (UIKeyNavigation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.startsSelected = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
