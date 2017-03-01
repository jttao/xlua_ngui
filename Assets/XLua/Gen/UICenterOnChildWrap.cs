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
    public class UICenterOnChildWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UICenterOnChild), L, translator, 0, 2, 5, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Recenter", _m_Recenter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CenterOn", _m_CenterOn);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "centeredObject", _g_get_centeredObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "springStrength", _g_get_springStrength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "nextPageThreshold", _g_get_nextPageThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onFinished", _g_get_onFinished);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onCenter", _g_get_onCenter);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "springStrength", _s_set_springStrength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "nextPageThreshold", _s_set_nextPageThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onFinished", _s_set_onFinished);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onCenter", _s_set_onCenter);
            
			Utils.EndObjectRegister(typeof(UICenterOnChild), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UICenterOnChild), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UICenterOnChild));
			
			
			Utils.EndClassRegister(typeof(UICenterOnChild), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UICenterOnChild __cl_gen_ret = new UICenterOnChild();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UICenterOnChild constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Recenter(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UICenterOnChild __cl_gen_to_be_invoked = (UICenterOnChild)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Recenter(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CenterOn(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UICenterOnChild __cl_gen_to_be_invoked = (UICenterOnChild)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Transform target = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                    __cl_gen_to_be_invoked.CenterOn( target );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_centeredObject(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICenterOnChild __cl_gen_to_be_invoked = (UICenterOnChild)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.centeredObject);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_springStrength(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICenterOnChild __cl_gen_to_be_invoked = (UICenterOnChild)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.springStrength);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_nextPageThreshold(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICenterOnChild __cl_gen_to_be_invoked = (UICenterOnChild)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.nextPageThreshold);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICenterOnChild __cl_gen_to_be_invoked = (UICenterOnChild)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onCenter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICenterOnChild __cl_gen_to_be_invoked = (UICenterOnChild)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onCenter);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_springStrength(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICenterOnChild __cl_gen_to_be_invoked = (UICenterOnChild)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.springStrength = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_nextPageThreshold(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICenterOnChild __cl_gen_to_be_invoked = (UICenterOnChild)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.nextPageThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICenterOnChild __cl_gen_to_be_invoked = (UICenterOnChild)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onFinished = translator.GetDelegate<SpringPanel.OnFinished>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onCenter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UICenterOnChild __cl_gen_to_be_invoked = (UICenterOnChild)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onCenter = translator.GetDelegate<UICenterOnChild.OnCenterCallback>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
