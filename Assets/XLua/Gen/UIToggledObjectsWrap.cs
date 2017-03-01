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
    public class UIToggledObjectsWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIToggledObjects), L, translator, 0, 1, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Toggle", _m_Toggle);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "activate", _g_get_activate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "deactivate", _g_get_deactivate);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "activate", _s_set_activate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "deactivate", _s_set_deactivate);
            
			Utils.EndObjectRegister(typeof(UIToggledObjects), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIToggledObjects), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIToggledObjects));
			
			
			Utils.EndClassRegister(typeof(UIToggledObjects), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIToggledObjects __cl_gen_ret = new UIToggledObjects();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIToggledObjects constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Toggle(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIToggledObjects __cl_gen_to_be_invoked = (UIToggledObjects)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Toggle(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIToggledObjects __cl_gen_to_be_invoked = (UIToggledObjects)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.activate);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deactivate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIToggledObjects __cl_gen_to_be_invoked = (UIToggledObjects)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.deactivate);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_activate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIToggledObjects __cl_gen_to_be_invoked = (UIToggledObjects)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.activate = (System.Collections.Generic.List<UnityEngine.GameObject>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.GameObject>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_deactivate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIToggledObjects __cl_gen_to_be_invoked = (UIToggledObjects)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.deactivate = (System.Collections.Generic.List<UnityEngine.GameObject>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.GameObject>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
