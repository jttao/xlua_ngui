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
    public class UICameraWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UICamera), L, translator, 0, 5, 26, 25);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ProcessMouse", _m_ProcessMouse);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ProcessTouches", _m_ProcessTouches);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ProcessOthers", _m_ProcessOthers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ProcessTouch", _m_ProcessTouch);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ShowTooltip", _m_ShowTooltip);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "cachedCamera", _g_get_cachedCamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eventType", _g_get_eventType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eventsGoToColliders", _g_get_eventsGoToColliders);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eventReceiverMask", _g_get_eventReceiverMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "debug", _g_get_debug);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useMouse", _g_get_useMouse);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useTouch", _g_get_useTouch);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowMultiTouch", _g_get_allowMultiTouch);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useKeyboard", _g_get_useKeyboard);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useController", _g_get_useController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stickyTooltip", _g_get_stickyTooltip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tooltipDelay", _g_get_tooltipDelay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "longPressTooltip", _g_get_longPressTooltip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseDragThreshold", _g_get_mouseDragThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseClickThreshold", _g_get_mouseClickThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "touchDragThreshold", _g_get_touchDragThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "touchClickThreshold", _g_get_touchClickThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rangeDistance", _g_get_rangeDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollAxisName", _g_get_scrollAxisName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalAxisName", _g_get_verticalAxisName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalAxisName", _g_get_horizontalAxisName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "commandClick", _g_get_commandClick);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "submitKey0", _g_get_submitKey0);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "submitKey1", _g_get_submitKey1);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cancelKey0", _g_get_cancelKey0);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cancelKey1", _g_get_cancelKey1);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "eventType", _s_set_eventType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "eventsGoToColliders", _s_set_eventsGoToColliders);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "eventReceiverMask", _s_set_eventReceiverMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "debug", _s_set_debug);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useMouse", _s_set_useMouse);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useTouch", _s_set_useTouch);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowMultiTouch", _s_set_allowMultiTouch);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useKeyboard", _s_set_useKeyboard);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useController", _s_set_useController);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stickyTooltip", _s_set_stickyTooltip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tooltipDelay", _s_set_tooltipDelay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "longPressTooltip", _s_set_longPressTooltip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseDragThreshold", _s_set_mouseDragThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseClickThreshold", _s_set_mouseClickThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "touchDragThreshold", _s_set_touchDragThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "touchClickThreshold", _s_set_touchClickThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rangeDistance", _s_set_rangeDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scrollAxisName", _s_set_scrollAxisName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalAxisName", _s_set_verticalAxisName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalAxisName", _s_set_horizontalAxisName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "commandClick", _s_set_commandClick);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "submitKey0", _s_set_submitKey0);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "submitKey1", _s_set_submitKey1);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cancelKey0", _s_set_cancelKey0);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cancelKey1", _s_set_cancelKey1);
            
			Utils.EndObjectRegister(typeof(UICamera), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UICamera), L, __CreateInstance, 10, 46, 41);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "IsPressed", _m_IsPressed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CountInputSources", _m_CountInputSources_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Raycast", _m_Raycast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsHighlighted", _m_IsHighlighted_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindCameraForLayer", _m_FindCameraForLayer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Notify", _m_Notify_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMouse", _m_GetMouse_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTouch", _m_GetTouch_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RemoveTouch", _m_RemoveTouch_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UICamera));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "currentRay", _g_get_currentRay);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "isOverUI", _g_get_isOverUI);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "selectedObject", _g_get_selectedObject);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "dragCount", _g_get_dragCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "mainCamera", _g_get_mainCamera);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "eventHandler", _g_get_eventHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "list", _g_get_list);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "GetKeyDown", _g_get_GetKeyDown);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "GetKeyUp", _g_get_GetKeyUp);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "GetKey", _g_get_GetKey);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "GetAxis", _g_get_GetAxis);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onScreenResize", _g_get_onScreenResize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onCustomInput", _g_get_onCustomInput);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "showTooltips", _g_get_showTooltips);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "lastTouchPosition", _g_get_lastTouchPosition);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "lastWorldPosition", _g_get_lastWorldPosition);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "lastHit", _g_get_lastHit);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "current", _g_get_current);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "currentCamera", _g_get_currentCamera);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "currentScheme", _g_get_currentScheme);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "currentTouchID", _g_get_currentTouchID);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "currentKey", _g_get_currentKey);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "currentTouch", _g_get_currentTouch);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "inputHasFocus", _g_get_inputHasFocus);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fallThrough", _g_get_fallThrough);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onClick", _g_get_onClick);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onDoubleClick", _g_get_onDoubleClick);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onHover", _g_get_onHover);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onPress", _g_get_onPress);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onSelect", _g_get_onSelect);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onScroll", _g_get_onScroll);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onDrag", _g_get_onDrag);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onDragStart", _g_get_onDragStart);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onDragOver", _g_get_onDragOver);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onDragOut", _g_get_onDragOut);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onDragEnd", _g_get_onDragEnd);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onDrop", _g_get_onDrop);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onKey", _g_get_onKey);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onTooltip", _g_get_onTooltip);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onMouseMove", _g_get_onMouseMove);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "controller", _g_get_controller);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "activeTouches", _g_get_activeTouches);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "isDragging", _g_get_isDragging);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "hoveredObject", _g_get_hoveredObject);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "GetInputTouchCount", _g_get_GetInputTouchCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "GetInputTouch", _g_get_GetInputTouch);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "selectedObject", _s_set_selectedObject);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "list", _s_set_list);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "GetKeyDown", _s_set_GetKeyDown);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "GetKeyUp", _s_set_GetKeyUp);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "GetKey", _s_set_GetKey);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "GetAxis", _s_set_GetAxis);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onScreenResize", _s_set_onScreenResize);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onCustomInput", _s_set_onCustomInput);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "showTooltips", _s_set_showTooltips);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "lastTouchPosition", _s_set_lastTouchPosition);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "lastWorldPosition", _s_set_lastWorldPosition);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "lastHit", _s_set_lastHit);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "current", _s_set_current);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "currentCamera", _s_set_currentCamera);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "currentScheme", _s_set_currentScheme);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "currentTouchID", _s_set_currentTouchID);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "currentKey", _s_set_currentKey);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "currentTouch", _s_set_currentTouch);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "inputHasFocus", _s_set_inputHasFocus);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fallThrough", _s_set_fallThrough);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onClick", _s_set_onClick);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onDoubleClick", _s_set_onDoubleClick);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onHover", _s_set_onHover);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onPress", _s_set_onPress);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onSelect", _s_set_onSelect);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onScroll", _s_set_onScroll);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onDrag", _s_set_onDrag);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onDragStart", _s_set_onDragStart);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onDragOver", _s_set_onDragOver);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onDragOut", _s_set_onDragOut);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onDragEnd", _s_set_onDragEnd);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onDrop", _s_set_onDrop);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onKey", _s_set_onKey);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onTooltip", _s_set_onTooltip);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onMouseMove", _s_set_onMouseMove);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "controller", _s_set_controller);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "activeTouches", _s_set_activeTouches);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "isDragging", _s_set_isDragging);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "hoveredObject", _s_set_hoveredObject);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "GetInputTouchCount", _s_set_GetInputTouchCount);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "GetInputTouch", _s_set_GetInputTouch);
            
			Utils.EndClassRegister(typeof(UICamera), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UICamera __cl_gen_ret = new UICamera();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UICamera constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsPressed_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        bool __cl_gen_ret = UICamera.IsPressed( go );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CountInputSources_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = UICamera.CountInputSources(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Raycast_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector3 inPos;translator.Get(L, 1, out inPos);
                    
                        bool __cl_gen_ret = UICamera.Raycast( inPos );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsHighlighted_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        bool __cl_gen_ret = UICamera.IsHighlighted( go );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindCameraForLayer_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    int layer = LuaAPI.xlua_tointeger(L, 1);
                    
                        UICamera __cl_gen_ret = UICamera.FindCameraForLayer( layer );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Notify_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    string funcName = LuaAPI.lua_tostring(L, 2);
                    object obj = translator.GetObject(L, 3, typeof(object));
                    
                    UICamera.Notify( go, funcName, obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMouse_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    int button = LuaAPI.xlua_tointeger(L, 1);
                    
                        UICamera.MouseOrTouch __cl_gen_ret = UICamera.GetMouse( button );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTouch_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    
                        UICamera.MouseOrTouch __cl_gen_ret = UICamera.GetTouch( id );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveTouch_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    
                    UICamera.RemoveTouch( id );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ProcessMouse(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ProcessMouse(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ProcessTouches(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ProcessTouches(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ProcessOthers(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ProcessOthers(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ProcessTouch(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    bool pressed = LuaAPI.lua_toboolean(L, 2);
                    bool released = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.ProcessTouch( pressed, released );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShowTooltip(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    bool val = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.ShowTooltip( val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentRay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineRay(L, UICamera.currentRay);
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
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cachedCamera);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isOverUI(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UICamera.isOverUI);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectedObject(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.selectedObject);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dragCount(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UICamera.dragCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mainCamera(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.mainCamera);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_eventHandler(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.eventHandler);
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
			    translator.Push(L, UICamera.list);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GetKeyDown(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.GetKeyDown);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GetKeyUp(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.GetKeyUp);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GetKey(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.GetKey);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GetAxis(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.GetAxis);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onScreenResize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.onScreenResize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_eventType(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.eventType);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_eventsGoToColliders(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.eventsGoToColliders);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_eventReceiverMask(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.eventReceiverMask);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_debug(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.debug);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useMouse(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useMouse);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useTouch(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useTouch);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowMultiTouch(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.allowMultiTouch);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useKeyboard(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useKeyboard);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useController(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useController);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stickyTooltip(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.stickyTooltip);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tooltipDelay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.tooltipDelay);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_longPressTooltip(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.longPressTooltip);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseDragThreshold(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.mouseDragThreshold);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseClickThreshold(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.mouseClickThreshold);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_touchDragThreshold(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.touchDragThreshold);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_touchClickThreshold(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.touchClickThreshold);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rangeDistance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.rangeDistance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scrollAxisName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.scrollAxisName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_verticalAxisName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.verticalAxisName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_horizontalAxisName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.horizontalAxisName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_commandClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.commandClick);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_submitKey0(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.submitKey0);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_submitKey1(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.submitKey1);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cancelKey0(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cancelKey0);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cancelKey1(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cancelKey1);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onCustomInput(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.onCustomInput);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showTooltips(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UICamera.showTooltips);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastTouchPosition(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineVector2(L, UICamera.lastTouchPosition);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastWorldPosition(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineVector3(L, UICamera.lastWorldPosition);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastHit(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.lastHit);
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
			    translator.Push(L, UICamera.current);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentCamera(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.currentCamera);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentScheme(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.currentScheme);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentTouchID(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UICamera.currentTouchID);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentKey(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.currentKey);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentTouch(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.currentTouch);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inputHasFocus(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UICamera.inputHasFocus);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fallThrough(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.fallThrough);
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
			    translator.Push(L, UICamera.onClick);
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
			    translator.Push(L, UICamera.onDoubleClick);
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
			    translator.Push(L, UICamera.onHover);
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
			    translator.Push(L, UICamera.onPress);
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
			    translator.Push(L, UICamera.onSelect);
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
			    translator.Push(L, UICamera.onScroll);
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
			    translator.Push(L, UICamera.onDrag);
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
			    translator.Push(L, UICamera.onDragStart);
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
			    translator.Push(L, UICamera.onDragOver);
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
			    translator.Push(L, UICamera.onDragOut);
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
			    translator.Push(L, UICamera.onDragEnd);
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
			    translator.Push(L, UICamera.onDrop);
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
			    translator.Push(L, UICamera.onKey);
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
			    translator.Push(L, UICamera.onTooltip);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onMouseMove(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.onMouseMove);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_controller(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.controller);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeTouches(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.activeTouches);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isDragging(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UICamera.isDragging);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoveredObject(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.hoveredObject);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GetInputTouchCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.GetInputTouchCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GetInputTouch(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UICamera.GetInputTouch);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectedObject(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.selectedObject = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
            
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
			    UICamera.list = (BetterList<UICamera>)translator.GetObject(L, 1, typeof(BetterList<UICamera>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_GetKeyDown(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.GetKeyDown = translator.GetDelegate<UICamera.GetKeyStateFunc>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_GetKeyUp(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.GetKeyUp = translator.GetDelegate<UICamera.GetKeyStateFunc>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_GetKey(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.GetKey = translator.GetDelegate<UICamera.GetKeyStateFunc>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_GetAxis(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.GetAxis = translator.GetDelegate<UICamera.GetAxisFunc>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onScreenResize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.onScreenResize = translator.GetDelegate<UICamera.OnScreenResize>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_eventType(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                UICamera.EventType __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.eventType = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_eventsGoToColliders(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.eventsGoToColliders = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_eventReceiverMask(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                UnityEngine.LayerMask __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.eventReceiverMask = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_debug(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.debug = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useMouse(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useMouse = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useTouch(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useTouch = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowMultiTouch(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.allowMultiTouch = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useKeyboard(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useKeyboard = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useController(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useController = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stickyTooltip(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.stickyTooltip = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tooltipDelay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.tooltipDelay = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_longPressTooltip(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.longPressTooltip = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseDragThreshold(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.mouseDragThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseClickThreshold(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.mouseClickThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_touchDragThreshold(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.touchDragThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_touchClickThreshold(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.touchClickThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rangeDistance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.rangeDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scrollAxisName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.scrollAxisName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_verticalAxisName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.verticalAxisName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_horizontalAxisName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.horizontalAxisName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_commandClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.commandClick = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_submitKey0(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                UnityEngine.KeyCode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.submitKey0 = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_submitKey1(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                UnityEngine.KeyCode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.submitKey1 = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cancelKey0(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                UnityEngine.KeyCode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.cancelKey0 = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cancelKey1(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICamera __cl_gen_to_be_invoked = (UICamera)translator.FastGetCSObj(L, 1);
                UnityEngine.KeyCode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.cancelKey1 = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onCustomInput(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.onCustomInput = translator.GetDelegate<UICamera.OnCustomInput>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showTooltips(RealStatePtr L)
        {
            
            try {
			    UICamera.showTooltips = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lastTouchPosition(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UICamera.lastTouchPosition = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lastWorldPosition(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UICamera.lastWorldPosition = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lastHit(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.RaycastHit __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UICamera.lastHit = __cl_gen_value;
            
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
			    UICamera.current = (UICamera)translator.GetObject(L, 1, typeof(UICamera));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentCamera(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.currentCamera = (UnityEngine.Camera)translator.GetObject(L, 1, typeof(UnityEngine.Camera));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentScheme(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UICamera.ControlScheme __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UICamera.currentScheme = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentTouchID(RealStatePtr L)
        {
            
            try {
			    UICamera.currentTouchID = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentKey(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.KeyCode __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UICamera.currentKey = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentTouch(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.currentTouch = (UICamera.MouseOrTouch)translator.GetObject(L, 1, typeof(UICamera.MouseOrTouch));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inputHasFocus(RealStatePtr L)
        {
            
            try {
			    UICamera.inputHasFocus = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fallThrough(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.fallThrough = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
            
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
			    UICamera.onClick = translator.GetDelegate<UICamera.VoidDelegate>(L, 1);
            
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
			    UICamera.onDoubleClick = translator.GetDelegate<UICamera.VoidDelegate>(L, 1);
            
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
			    UICamera.onHover = translator.GetDelegate<UICamera.BoolDelegate>(L, 1);
            
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
			    UICamera.onPress = translator.GetDelegate<UICamera.BoolDelegate>(L, 1);
            
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
			    UICamera.onSelect = translator.GetDelegate<UICamera.BoolDelegate>(L, 1);
            
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
			    UICamera.onScroll = translator.GetDelegate<UICamera.FloatDelegate>(L, 1);
            
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
			    UICamera.onDrag = translator.GetDelegate<UICamera.VectorDelegate>(L, 1);
            
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
			    UICamera.onDragStart = translator.GetDelegate<UICamera.VoidDelegate>(L, 1);
            
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
			    UICamera.onDragOver = translator.GetDelegate<UICamera.ObjectDelegate>(L, 1);
            
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
			    UICamera.onDragOut = translator.GetDelegate<UICamera.ObjectDelegate>(L, 1);
            
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
			    UICamera.onDragEnd = translator.GetDelegate<UICamera.VoidDelegate>(L, 1);
            
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
			    UICamera.onDrop = translator.GetDelegate<UICamera.ObjectDelegate>(L, 1);
            
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
			    UICamera.onKey = translator.GetDelegate<UICamera.KeyCodeDelegate>(L, 1);
            
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
			    UICamera.onTooltip = translator.GetDelegate<UICamera.BoolDelegate>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onMouseMove(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.onMouseMove = translator.GetDelegate<UICamera.MoveDelegate>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_controller(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.controller = (UICamera.MouseOrTouch)translator.GetObject(L, 1, typeof(UICamera.MouseOrTouch));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_activeTouches(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.activeTouches = (System.Collections.Generic.List<UICamera.MouseOrTouch>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UICamera.MouseOrTouch>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isDragging(RealStatePtr L)
        {
            
            try {
			    UICamera.isDragging = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoveredObject(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.hoveredObject = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_GetInputTouchCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.GetInputTouchCount = translator.GetDelegate<UICamera.GetTouchCountCallback>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_GetInputTouch(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UICamera.GetInputTouch = translator.GetDelegate<UICamera.GetTouchCallback>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
