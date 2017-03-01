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
    public class LuaBehaviourWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(LuaBehaviour), L, translator, 0, 3, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLuaObj", _m_GetLuaObj);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLuaObjs", _m_GetLuaObjs);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartWWW", _m_StartWWW);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ICalc", _g_get_ICalc);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LuaObj", _g_get_LuaObj);
            
			
			Utils.EndObjectRegister(typeof(LuaBehaviour), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(LuaBehaviour), L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "AddComponent", _m_AddComponent_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(LuaBehaviour));
			
			
			Utils.EndClassRegister(typeof(LuaBehaviour), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					LuaBehaviour __cl_gen_ret = new LuaBehaviour();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LuaBehaviour constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddComponent_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject target = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    string luaComponent = LuaAPI.lua_tostring(L, 2);
                    
                    LuaBehaviour.AddComponent( target, luaComponent );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLuaObj(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            LuaBehaviour __cl_gen_to_be_invoked = (LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string luaModel = LuaAPI.lua_tostring(L, 2);
                    
                        XLua.LuaTable __cl_gen_ret = __cl_gen_to_be_invoked.GetLuaObj( luaModel );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLuaObjs(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            LuaBehaviour __cl_gen_to_be_invoked = (LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string luaModel = LuaAPI.lua_tostring(L, 2);
                    
                        XLua.LuaTable[] __cl_gen_ret = __cl_gen_to_be_invoked.GetLuaObjs( luaModel );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartWWW(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            LuaBehaviour __cl_gen_to_be_invoked = (LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string url = LuaAPI.lua_tostring(L, 2);
                    System.Action<UnityEngine.AssetBundle> callback = translator.GetDelegate<System.Action<UnityEngine.AssetBundle>>(L, 3);
                    
                    __cl_gen_to_be_invoked.StartWWW( url, callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ICalc(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                LuaBehaviour __cl_gen_to_be_invoked = (LuaBehaviour)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.ICalc);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LuaObj(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                LuaBehaviour __cl_gen_to_be_invoked = (LuaBehaviour)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.LuaObj);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
