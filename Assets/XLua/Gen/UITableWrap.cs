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
    public class UITableWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UITable), L, translator, 0, 2, 10, 11);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetChildList", _m_GetChildList);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Reposition", _m_Reposition);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "columns", _g_get_columns);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "direction", _g_get_direction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sorting", _g_get_sorting);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pivot", _g_get_pivot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cellAlignment", _g_get_cellAlignment);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hideInactive", _g_get_hideInactive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keepWithinPanel", _g_get_keepWithinPanel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "padding", _g_get_padding);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onReposition", _g_get_onReposition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onCustomSort", _g_get_onCustomSort);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "repositionNow", _s_set_repositionNow);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "columns", _s_set_columns);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "direction", _s_set_direction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sorting", _s_set_sorting);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pivot", _s_set_pivot);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cellAlignment", _s_set_cellAlignment);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hideInactive", _s_set_hideInactive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keepWithinPanel", _s_set_keepWithinPanel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "padding", _s_set_padding);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onReposition", _s_set_onReposition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onCustomSort", _s_set_onCustomSort);
            
			Utils.EndObjectRegister(typeof(UITable), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UITable), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UITable));
			
			
			Utils.EndClassRegister(typeof(UITable), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UITable __cl_gen_ret = new UITable();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UITable constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetChildList(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        System.Collections.Generic.List<UnityEngine.Transform> __cl_gen_ret = __cl_gen_to_be_invoked.GetChildList(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Reposition(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Reposition(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_columns(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.columns);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_direction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.direction);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sorting(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.sorting);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pivot(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.pivot);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cellAlignment(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cellAlignment);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hideInactive(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hideInactive);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keepWithinPanel(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.keepWithinPanel);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_padding(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.padding);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onReposition(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onReposition);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onCustomSort(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onCustomSort);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_repositionNow(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.repositionNow = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_columns(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.columns = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_direction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                UITable.Direction __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.direction = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sorting(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                UITable.Sorting __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.sorting = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pivot(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                UIWidget.Pivot __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.pivot = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cellAlignment(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                UIWidget.Pivot __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.cellAlignment = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hideInactive(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.hideInactive = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keepWithinPanel(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.keepWithinPanel = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_padding(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.padding = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onReposition(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onReposition = translator.GetDelegate<UITable.OnReposition>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onCustomSort(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITable __cl_gen_to_be_invoked = (UITable)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onCustomSort = translator.GetDelegate<System.Comparison<UnityEngine.Transform>>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
