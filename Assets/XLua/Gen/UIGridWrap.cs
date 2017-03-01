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
    public class UIGridWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIGrid), L, translator, 0, 7, 11, 12);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetChildList", _m_GetChildList);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetChild", _m_GetChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetIndex", _m_GetIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddChild", _m_AddChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveChild", _m_RemoveChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Reposition", _m_Reposition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ConstrainWithinPanel", _m_ConstrainWithinPanel);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "arrangement", _g_get_arrangement);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sorting", _g_get_sorting);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pivot", _g_get_pivot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxPerLine", _g_get_maxPerLine);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cellWidth", _g_get_cellWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cellHeight", _g_get_cellHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "animateSmoothly", _g_get_animateSmoothly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hideInactive", _g_get_hideInactive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keepWithinPanel", _g_get_keepWithinPanel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onReposition", _g_get_onReposition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onCustomSort", _g_get_onCustomSort);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "repositionNow", _s_set_repositionNow);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "arrangement", _s_set_arrangement);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sorting", _s_set_sorting);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pivot", _s_set_pivot);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxPerLine", _s_set_maxPerLine);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cellWidth", _s_set_cellWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cellHeight", _s_set_cellHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "animateSmoothly", _s_set_animateSmoothly);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hideInactive", _s_set_hideInactive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keepWithinPanel", _s_set_keepWithinPanel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onReposition", _s_set_onReposition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onCustomSort", _s_set_onCustomSort);
            
			Utils.EndObjectRegister(typeof(UIGrid), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIGrid), L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SortByName", _m_SortByName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SortHorizontal", _m_SortHorizontal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SortVertical", _m_SortVertical_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIGrid));
			
			
			Utils.EndClassRegister(typeof(UIGrid), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIGrid __cl_gen_ret = new UIGrid();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIGrid constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetChildList(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_GetChild(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Transform __cl_gen_ret = __cl_gen_to_be_invoked.GetChild( index );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIndex(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Transform trans = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetIndex( trans );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddChild(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 2)) 
                {
                    UnityEngine.Transform trans = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                    __cl_gen_to_be_invoked.AddChild( trans );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Transform trans = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    bool sort = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.AddChild( trans, sort );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIGrid.AddChild!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveChild(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Transform t = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.RemoveChild( t );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SortByName_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Transform a = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform b = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        int __cl_gen_ret = UIGrid.SortByName( a, b );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SortHorizontal_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Transform a = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform b = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        int __cl_gen_ret = UIGrid.SortHorizontal( a, b );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SortVertical_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Transform a = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform b = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        int __cl_gen_ret = UIGrid.SortVertical( a, b );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
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
            
            
            UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_ConstrainWithinPanel(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ConstrainWithinPanel(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_arrangement(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.arrangement);
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
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
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
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.pivot);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxPerLine(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.maxPerLine);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cellWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.cellWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cellHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.cellHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_animateSmoothly(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.animateSmoothly);
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
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
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
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.keepWithinPanel);
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
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
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
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
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
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.repositionNow = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_arrangement(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                UIGrid.Arrangement __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.arrangement = __cl_gen_value;
            
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
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                UIGrid.Sorting __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
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
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                UIWidget.Pivot __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.pivot = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxPerLine(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.maxPerLine = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cellWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.cellWidth = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cellHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.cellHeight = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_animateSmoothly(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.animateSmoothly = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
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
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.keepWithinPanel = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onReposition = translator.GetDelegate<UIGrid.OnReposition>(L, 2);
            
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
			
                UIGrid __cl_gen_to_be_invoked = (UIGrid)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onCustomSort = translator.GetDelegate<System.Comparison<UnityEngine.Transform>>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
