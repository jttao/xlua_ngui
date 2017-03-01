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
    public class UIDraggableCameraWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIDraggableCamera), L, translator, 0, 4, 7, 7);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ConstrainToBounds", _m_ConstrainToBounds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Press", _m_Press);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Drag", _m_Drag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Scroll", _m_Scroll);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentMomentum", _g_get_currentMomentum);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rootForBounds", _g_get_rootForBounds);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scale", _g_get_scale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollWheelFactor", _g_get_scrollWheelFactor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dragEffect", _g_get_dragEffect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "smoothDragStart", _g_get_smoothDragStart);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "momentumAmount", _g_get_momentumAmount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "currentMomentum", _s_set_currentMomentum);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rootForBounds", _s_set_rootForBounds);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scale", _s_set_scale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scrollWheelFactor", _s_set_scrollWheelFactor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dragEffect", _s_set_dragEffect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "smoothDragStart", _s_set_smoothDragStart);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "momentumAmount", _s_set_momentumAmount);
            
			Utils.EndObjectRegister(typeof(UIDraggableCamera), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIDraggableCamera), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIDraggableCamera));
			
			
			Utils.EndClassRegister(typeof(UIDraggableCamera), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIDraggableCamera __cl_gen_ret = new UIDraggableCamera();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIDraggableCamera constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ConstrainToBounds(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    bool immediate = LuaAPI.lua_toboolean(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.ConstrainToBounds( immediate );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Press(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    bool isPressed = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Press( isPressed );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Drag(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector2 delta;translator.Get(L, 2, out delta);
                    
                    __cl_gen_to_be_invoked.Drag( delta );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Scroll(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float delta = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    __cl_gen_to_be_invoked.Scroll( delta );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentMomentum(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.currentMomentum);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rootForBounds(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.rootForBounds);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.scale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scrollWheelFactor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.scrollWheelFactor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dragEffect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.dragEffect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_smoothDragStart(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.smoothDragStart);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_momentumAmount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.momentumAmount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentMomentum(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.currentMomentum = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rootForBounds(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.rootForBounds = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.scale = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scrollWheelFactor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.scrollWheelFactor = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dragEffect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
                UIDragObject.DragEffect __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.dragEffect = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_smoothDragStart(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.smoothDragStart = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_momentumAmount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDraggableCamera __cl_gen_to_be_invoked = (UIDraggableCamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.momentumAmount = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
