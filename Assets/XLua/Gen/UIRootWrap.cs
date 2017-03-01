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
    public class UIRootWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIRoot), L, translator, 0, 2, 13, 9);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixelSizeAdjustment", _m_GetPixelSizeAdjustment);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateScale", _m_UpdateScale);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "constraint", _g_get_constraint);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "activeScaling", _g_get_activeScaling);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "activeHeight", _g_get_activeHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelSizeAdjustment", _g_get_pixelSizeAdjustment);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scalingStyle", _g_get_scalingStyle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manualWidth", _g_get_manualWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manualHeight", _g_get_manualHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minimumHeight", _g_get_minimumHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maximumHeight", _g_get_maximumHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fitWidth", _g_get_fitWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fitHeight", _g_get_fitHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "adjustByDPI", _g_get_adjustByDPI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shrinkPortraitUI", _g_get_shrinkPortraitUI);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "scalingStyle", _s_set_scalingStyle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "manualWidth", _s_set_manualWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "manualHeight", _s_set_manualHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "minimumHeight", _s_set_minimumHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maximumHeight", _s_set_maximumHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fitWidth", _s_set_fitWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fitHeight", _s_set_fitHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "adjustByDPI", _s_set_adjustByDPI);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "shrinkPortraitUI", _s_set_shrinkPortraitUI);
            
			Utils.EndObjectRegister(typeof(UIRoot), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIRoot), L, __CreateInstance, 3, 1, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetPixelSizeAdjustment", _m_GetPixelSizeAdjustment_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Broadcast", _m_Broadcast_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIRoot));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "list", _g_get_list);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "list", _s_set_list);
            
			Utils.EndClassRegister(typeof(UIRoot), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIRoot __cl_gen_ret = new UIRoot();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIRoot constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixelSizeAdjustment_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        float __cl_gen_ret = UIRoot.GetPixelSizeAdjustment( go );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixelSizeAdjustment(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int height = LuaAPI.xlua_tointeger(L, 2);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetPixelSizeAdjustment( height );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateScale(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool updateAnchors = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.UpdateScale( updateAnchors );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.UpdateScale(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIRoot.UpdateScale!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Broadcast_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string funcName = LuaAPI.lua_tostring(L, 1);
                    
                    UIRoot.Broadcast( funcName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)) 
                {
                    string funcName = LuaAPI.lua_tostring(L, 1);
                    object param = translator.GetObject(L, 2, typeof(object));
                    
                    UIRoot.Broadcast( funcName, param );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIRoot.Broadcast!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_constraint(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.constraint);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeScaling(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.activeScaling);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.activeHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pixelSizeAdjustment(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.pixelSizeAdjustment);
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
			    translator.Push(L, UIRoot.list);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scalingStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.scalingStyle);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manualWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.manualWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manualHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.manualHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minimumHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.minimumHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maximumHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.maximumHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fitWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.fitWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fitHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.fitHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_adjustByDPI(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.adjustByDPI);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shrinkPortraitUI(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.shrinkPortraitUI);
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
			    UIRoot.list = (System.Collections.Generic.List<UIRoot>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UIRoot>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scalingStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                UIRoot.Scaling __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.scalingStyle = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_manualWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.manualWidth = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_manualHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.manualHeight = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_minimumHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.minimumHeight = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maximumHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.maximumHeight = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fitWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fitWidth = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fitHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fitHeight = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_adjustByDPI(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.adjustByDPI = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_shrinkPortraitUI(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRoot __cl_gen_to_be_invoked = (UIRoot)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.shrinkPortraitUI = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
