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
    public class UIEventListenerWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIEventListener), L, translator, 0, 0, 16, 16);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "parameter", _g_get_parameter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onSubmit", _g_get_onSubmit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onClick", _g_get_onClick);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDoubleClick", _g_get_onDoubleClick);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onHover", _g_get_onHover);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onPress", _g_get_onPress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onSelect", _g_get_onSelect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onScroll", _g_get_onScroll);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDragStart", _g_get_onDragStart);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDrag", _g_get_onDrag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDragOver", _g_get_onDragOver);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDragOut", _g_get_onDragOut);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDragEnd", _g_get_onDragEnd);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDrop", _g_get_onDrop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onKey", _g_get_onKey);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onTooltip", _g_get_onTooltip);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "parameter", _s_set_parameter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onSubmit", _s_set_onSubmit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onClick", _s_set_onClick);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDoubleClick", _s_set_onDoubleClick);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onHover", _s_set_onHover);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onPress", _s_set_onPress);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onSelect", _s_set_onSelect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onScroll", _s_set_onScroll);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDragStart", _s_set_onDragStart);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDrag", _s_set_onDrag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDragOver", _s_set_onDragOver);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDragOut", _s_set_onDragOut);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDragEnd", _s_set_onDragEnd);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDrop", _s_set_onDrop);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onKey", _s_set_onKey);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onTooltip", _s_set_onTooltip);
            
			Utils.EndObjectRegister(typeof(UIEventListener), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIEventListener), L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Get", _m_Get_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIEventListener));
			
			
			Utils.EndClassRegister(typeof(UIEventListener), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIEventListener __cl_gen_ret = new UIEventListener();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIEventListener constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Get_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        UIEventListener __cl_gen_ret = UIEventListener.Get( go );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_parameter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, __cl_gen_to_be_invoked.parameter);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onSubmit(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onSubmit);
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
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onClick);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDoubleClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDoubleClick);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onHover(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onHover);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onPress(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onPress);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onSelect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onSelect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onScroll(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onScroll);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDragStart(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDragStart);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDrag(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDrag);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDragOver(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDragOver);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDragOut(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDragOut);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDragEnd(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDragEnd);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDrop(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDrop);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onKey(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onKey);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onTooltip(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onTooltip);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_parameter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.parameter = translator.GetObject(L, 2, typeof(object));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onSubmit(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onSubmit = translator.GetDelegate<UIEventListener.VoidDelegate>(L, 2);
            
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
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onClick = translator.GetDelegate<UIEventListener.VoidDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDoubleClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDoubleClick = translator.GetDelegate<UIEventListener.VoidDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onHover(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onHover = translator.GetDelegate<UIEventListener.BoolDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onPress(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onPress = translator.GetDelegate<UIEventListener.BoolDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onSelect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onSelect = translator.GetDelegate<UIEventListener.BoolDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onScroll(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onScroll = translator.GetDelegate<UIEventListener.FloatDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDragStart(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDragStart = translator.GetDelegate<UIEventListener.VoidDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDrag(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDrag = translator.GetDelegate<UIEventListener.VectorDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDragOver(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDragOver = translator.GetDelegate<UIEventListener.VoidDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDragOut(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDragOut = translator.GetDelegate<UIEventListener.VoidDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDragEnd(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDragEnd = translator.GetDelegate<UIEventListener.VoidDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDrop(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDrop = translator.GetDelegate<UIEventListener.ObjectDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onKey(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onKey = translator.GetDelegate<UIEventListener.KeyCodeDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onTooltip(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventListener __cl_gen_to_be_invoked = (UIEventListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onTooltip = translator.GetDelegate<UIEventListener.BoolDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
