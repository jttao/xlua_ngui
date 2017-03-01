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
    public class UIWrapContentWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIWrapContent), L, translator, 0, 3, 5, 5);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SortBasedOnScrollMovement", _m_SortBasedOnScrollMovement);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SortAlphabetically", _m_SortAlphabetically);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WrapContent", _m_WrapContent);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "itemSize", _g_get_itemSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cullContent", _g_get_cullContent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minIndex", _g_get_minIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxIndex", _g_get_maxIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onInitializeItem", _g_get_onInitializeItem);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "itemSize", _s_set_itemSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cullContent", _s_set_cullContent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "minIndex", _s_set_minIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxIndex", _s_set_maxIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onInitializeItem", _s_set_onInitializeItem);
            
			Utils.EndObjectRegister(typeof(UIWrapContent), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIWrapContent), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIWrapContent));
			
			
			Utils.EndClassRegister(typeof(UIWrapContent), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIWrapContent __cl_gen_ret = new UIWrapContent();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIWrapContent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SortBasedOnScrollMovement(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWrapContent __cl_gen_to_be_invoked = (UIWrapContent)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SortBasedOnScrollMovement(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SortAlphabetically(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWrapContent __cl_gen_to_be_invoked = (UIWrapContent)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SortAlphabetically(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WrapContent(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWrapContent __cl_gen_to_be_invoked = (UIWrapContent)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.WrapContent(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_itemSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWrapContent __cl_gen_to_be_invoked = (UIWrapContent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.itemSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cullContent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWrapContent __cl_gen_to_be_invoked = (UIWrapContent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.cullContent);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minIndex(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWrapContent __cl_gen_to_be_invoked = (UIWrapContent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.minIndex);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxIndex(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWrapContent __cl_gen_to_be_invoked = (UIWrapContent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.maxIndex);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onInitializeItem(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWrapContent __cl_gen_to_be_invoked = (UIWrapContent)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onInitializeItem);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_itemSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWrapContent __cl_gen_to_be_invoked = (UIWrapContent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.itemSize = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cullContent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWrapContent __cl_gen_to_be_invoked = (UIWrapContent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.cullContent = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_minIndex(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWrapContent __cl_gen_to_be_invoked = (UIWrapContent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.minIndex = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxIndex(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWrapContent __cl_gen_to_be_invoked = (UIWrapContent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.maxIndex = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onInitializeItem(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWrapContent __cl_gen_to_be_invoked = (UIWrapContent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onInitializeItem = translator.GetDelegate<UIWrapContent.OnInitializeItem>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
