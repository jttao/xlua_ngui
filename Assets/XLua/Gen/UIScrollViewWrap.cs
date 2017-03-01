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
    public class UIScrollViewWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIScrollView), L, translator, 0, 13, 27, 20);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RestrictWithinBounds", _m_RestrictWithinBounds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DisableSpring", _m_DisableSpring);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateScrollbars", _m_UpdateScrollbars);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDragAmount", _m_SetDragAmount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InvalidateBounds", _m_InvalidateBounds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetPosition", _m_ResetPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePosition", _m_UpdatePosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnScrollBar", _m_OnScrollBar);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveRelative", _m_MoveRelative);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveAbsolute", _m_MoveAbsolute);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Press", _m_Press);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Drag", _m_Drag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Scroll", _m_Scroll);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "panel", _g_get_panel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isDragging", _g_get_isDragging);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bounds", _g_get_bounds);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canMoveHorizontally", _g_get_canMoveHorizontally);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canMoveVertically", _g_get_canMoveVertically);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shouldMoveHorizontally", _g_get_shouldMoveHorizontally);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shouldMoveVertically", _g_get_shouldMoveVertically);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentMomentum", _g_get_currentMomentum);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "movement", _g_get_movement);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dragEffect", _g_get_dragEffect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "restrictWithinPanel", _g_get_restrictWithinPanel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "disableDragIfFits", _g_get_disableDragIfFits);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "smoothDragStart", _g_get_smoothDragStart);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "iOSDragEmulation", _g_get_iOSDragEmulation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollWheelFactor", _g_get_scrollWheelFactor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "momentumAmount", _g_get_momentumAmount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dampenStrength", _g_get_dampenStrength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalScrollBar", _g_get_horizontalScrollBar);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalScrollBar", _g_get_verticalScrollBar);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "showScrollBars", _g_get_showScrollBars);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "customMovement", _g_get_customMovement);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "contentPivot", _g_get_contentPivot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDragStarted", _g_get_onDragStarted);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDragFinished", _g_get_onDragFinished);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onMomentumMove", _g_get_onMomentumMove);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onStoppedMoving", _g_get_onStoppedMoving);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "centerOnChild", _g_get_centerOnChild);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "currentMomentum", _s_set_currentMomentum);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "movement", _s_set_movement);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dragEffect", _s_set_dragEffect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "restrictWithinPanel", _s_set_restrictWithinPanel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "disableDragIfFits", _s_set_disableDragIfFits);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "smoothDragStart", _s_set_smoothDragStart);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "iOSDragEmulation", _s_set_iOSDragEmulation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scrollWheelFactor", _s_set_scrollWheelFactor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "momentumAmount", _s_set_momentumAmount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dampenStrength", _s_set_dampenStrength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalScrollBar", _s_set_horizontalScrollBar);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalScrollBar", _s_set_verticalScrollBar);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "showScrollBars", _s_set_showScrollBars);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "customMovement", _s_set_customMovement);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "contentPivot", _s_set_contentPivot);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDragStarted", _s_set_onDragStarted);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDragFinished", _s_set_onDragFinished);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onMomentumMove", _s_set_onMomentumMove);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onStoppedMoving", _s_set_onStoppedMoving);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "centerOnChild", _s_set_centerOnChild);
            
			Utils.EndObjectRegister(typeof(UIScrollView), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIScrollView), L, __CreateInstance, 1, 1, 1);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIScrollView));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "list", _g_get_list);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "list", _s_set_list);
            
			Utils.EndClassRegister(typeof(UIScrollView), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIScrollView __cl_gen_ret = new UIScrollView();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIScrollView constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RestrictWithinBounds(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool instant = LuaAPI.lua_toboolean(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.RestrictWithinBounds( instant );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    bool instant = LuaAPI.lua_toboolean(L, 2);
                    bool horizontal = LuaAPI.lua_toboolean(L, 3);
                    bool vertical = LuaAPI.lua_toboolean(L, 4);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.RestrictWithinBounds( instant, horizontal, vertical );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIScrollView.RestrictWithinBounds!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DisableSpring(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.DisableSpring(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateScrollbars(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.UpdateScrollbars(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool recalculateBounds = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.UpdateScrollbars( recalculateBounds );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIScrollView.UpdateScrollbars!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDragAmount(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    bool updateScrollbars = LuaAPI.lua_toboolean(L, 4);
                    
                    __cl_gen_to_be_invoked.SetDragAmount( x, y, updateScrollbars );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InvalidateBounds(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.InvalidateBounds(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetPosition(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ResetPosition(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePosition(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.UpdatePosition(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnScrollBar(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.OnScrollBar(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveRelative(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector3 relative;translator.Get(L, 2, out relative);
                    
                    __cl_gen_to_be_invoked.MoveRelative( relative );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveAbsolute(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector3 absolute;translator.Get(L, 2, out absolute);
                    
                    __cl_gen_to_be_invoked.MoveAbsolute( absolute );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Press(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    bool pressed = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Press( pressed );
                    
                    
                    
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
            
            
            UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Drag(  );
                    
                    
                    
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
            
            
            UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
            
            
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
        static int _g_get_panel(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.panel);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isDragging(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isDragging);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bounds(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineBounds(L, __cl_gen_to_be_invoked.bounds);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canMoveHorizontally(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.canMoveHorizontally);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canMoveVertically(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.canMoveVertically);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shouldMoveHorizontally(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.shouldMoveHorizontally);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shouldMoveVertically(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.shouldMoveVertically);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentMomentum(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.currentMomentum);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_list(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UIScrollView.list);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_movement(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.movement);
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
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.dragEffect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_restrictWithinPanel(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.restrictWithinPanel);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_disableDragIfFits(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.disableDragIfFits);
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
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.smoothDragStart);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_iOSDragEmulation(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.iOSDragEmulation);
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
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.scrollWheelFactor);
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
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.momentumAmount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dampenStrength(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.dampenStrength);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_horizontalScrollBar(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.horizontalScrollBar);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_verticalScrollBar(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.verticalScrollBar);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showScrollBars(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.showScrollBars);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_customMovement(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.customMovement);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_contentPivot(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.contentPivot);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDragStarted(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDragStarted);
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
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDragFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onMomentumMove(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onMomentumMove);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onStoppedMoving(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onStoppedMoving);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_centerOnChild(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.centerOnChild);
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
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.currentMomentum = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_list(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UIScrollView.list = (BetterList<UIScrollView>)translator.GetObject(L, 1, typeof(BetterList<UIScrollView>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_movement(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                UIScrollView.Movement __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.movement = __cl_gen_value;
            
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
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                UIScrollView.DragEffect __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.dragEffect = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_restrictWithinPanel(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.restrictWithinPanel = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_disableDragIfFits(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.disableDragIfFits = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.smoothDragStart = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_iOSDragEmulation(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.iOSDragEmulation = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.scrollWheelFactor = (float)LuaAPI.lua_tonumber(L, 2);
            
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
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.momentumAmount = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dampenStrength(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.dampenStrength = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_horizontalScrollBar(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.horizontalScrollBar = (UIProgressBar)translator.GetObject(L, 2, typeof(UIProgressBar));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_verticalScrollBar(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.verticalScrollBar = (UIProgressBar)translator.GetObject(L, 2, typeof(UIProgressBar));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showScrollBars(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                UIScrollView.ShowCondition __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.showScrollBars = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_customMovement(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.customMovement = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_contentPivot(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                UIWidget.Pivot __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.contentPivot = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDragStarted(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDragStarted = translator.GetDelegate<UIScrollView.OnDragNotification>(L, 2);
            
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
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDragFinished = translator.GetDelegate<UIScrollView.OnDragNotification>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onMomentumMove(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onMomentumMove = translator.GetDelegate<UIScrollView.OnDragNotification>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onStoppedMoving(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onStoppedMoving = translator.GetDelegate<UIScrollView.OnDragNotification>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_centerOnChild(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIScrollView __cl_gen_to_be_invoked = (UIScrollView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.centerOnChild = (UICenterOnChild)translator.GetObject(L, 2, typeof(UICenterOnChild));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
