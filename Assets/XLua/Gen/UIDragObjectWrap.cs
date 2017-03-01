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
    public class UIDragObjectWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIDragObject), L, translator, 0, 2, 8, 8);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CancelMovement", _m_CancelMovement);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CancelSpring", _m_CancelSpring);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "dragMovement", _g_get_dragMovement);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "target", _g_get_target);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "panelRegion", _g_get_panelRegion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollMomentum", _g_get_scrollMomentum);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "restrictWithinPanel", _g_get_restrictWithinPanel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "contentRect", _g_get_contentRect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dragEffect", _g_get_dragEffect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "momentumAmount", _g_get_momentumAmount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "dragMovement", _s_set_dragMovement);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "target", _s_set_target);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "panelRegion", _s_set_panelRegion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scrollMomentum", _s_set_scrollMomentum);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "restrictWithinPanel", _s_set_restrictWithinPanel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "contentRect", _s_set_contentRect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dragEffect", _s_set_dragEffect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "momentumAmount", _s_set_momentumAmount);
            
			Utils.EndObjectRegister(typeof(UIDragObject), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIDragObject), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIDragObject));
			
			
			Utils.EndClassRegister(typeof(UIDragObject), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIDragObject __cl_gen_ret = new UIDragObject();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIDragObject constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CancelMovement(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.CancelMovement(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CancelSpring(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.CancelSpring(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dragMovement(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.dragMovement);
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
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.target);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_panelRegion(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.panelRegion);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scrollMomentum(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.scrollMomentum);
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
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.restrictWithinPanel);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_contentRect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.contentRect);
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
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.dragEffect);
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
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.momentumAmount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dragMovement(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.dragMovement = __cl_gen_value;
            
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
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.target = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_panelRegion(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.panelRegion = (UIPanel)translator.GetObject(L, 2, typeof(UIPanel));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scrollMomentum(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.scrollMomentum = __cl_gen_value;
            
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
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.restrictWithinPanel = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_contentRect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.contentRect = (UIRect)translator.GetObject(L, 2, typeof(UIRect));
            
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
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                UIDragObject.DragEffect __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.dragEffect = __cl_gen_value;
            
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
			
                UIDragObject __cl_gen_to_be_invoked = (UIDragObject)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.momentumAmount = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
