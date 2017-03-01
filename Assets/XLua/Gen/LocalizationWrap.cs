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
    public class LocalizationWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(Localization), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(Localization), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(Localization), L, __CreateInstance, 7, 6, 5);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Load", _m_Load_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Set", _m_Set_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadCSV", _m_LoadCSV_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Get", _m_Get_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Format", _m_Format_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Exists", _m_Exists_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(Localization));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "dictionary", _g_get_dictionary);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "knownLanguages", _g_get_knownLanguages);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "language", _g_get_language);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "loadFunction", _g_get_loadFunction);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onLocalize", _g_get_onLocalize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "localizationHasBeenSet", _g_get_localizationHasBeenSet);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "dictionary", _s_set_dictionary);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "language", _s_set_language);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "loadFunction", _s_set_loadFunction);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onLocalize", _s_set_onLocalize);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "localizationHasBeenSet", _s_set_localizationHasBeenSet);
            
			Utils.EndClassRegister(typeof(Localization), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "Localization does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Load_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.TextAsset asset = (UnityEngine.TextAsset)translator.GetObject(L, 1, typeof(UnityEngine.TextAsset));
                    
                    Localization.Load( asset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Set_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string languageName = LuaAPI.lua_tostring(L, 1);
                    byte[] bytes = LuaAPI.lua_tobytes(L, 2);
                    
                    Localization.Set( languageName, bytes );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.Dictionary<string, string>>(L, 2)) 
                {
                    string languageName = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.Dictionary<string, string> dictionary = (System.Collections.Generic.Dictionary<string, string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, string>));
                    
                    Localization.Set( languageName, dictionary );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    string value = LuaAPI.lua_tostring(L, 2);
                    
                    Localization.Set( key, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Localization.Set!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadCSV_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.TextAsset>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.TextAsset asset = (UnityEngine.TextAsset)translator.GetObject(L, 1, typeof(UnityEngine.TextAsset));
                    bool merge = LuaAPI.lua_toboolean(L, 2);
                    
                        bool __cl_gen_ret = Localization.LoadCSV( asset, merge );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.TextAsset>(L, 1)) 
                {
                    UnityEngine.TextAsset asset = (UnityEngine.TextAsset)translator.GetObject(L, 1, typeof(UnityEngine.TextAsset));
                    
                        bool __cl_gen_ret = Localization.LoadCSV( asset );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    byte[] bytes = LuaAPI.lua_tobytes(L, 1);
                    bool merge = LuaAPI.lua_toboolean(L, 2);
                    
                        bool __cl_gen_ret = Localization.LoadCSV( bytes, merge );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] bytes = LuaAPI.lua_tobytes(L, 1);
                    
                        bool __cl_gen_ret = Localization.LoadCSV( bytes );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Localization.LoadCSV!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Get_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = Localization.Get( key );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Format_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    object[] parameters = translator.GetParams<object>(L, 2);
                    
                        string __cl_gen_ret = Localization.Format( key, parameters );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Exists_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    
                        bool __cl_gen_ret = Localization.Exists( key );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dictionary(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, Localization.dictionary);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_knownLanguages(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, Localization.knownLanguages);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_language(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, Localization.language);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_loadFunction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, Localization.loadFunction);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onLocalize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, Localization.onLocalize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_localizationHasBeenSet(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, Localization.localizationHasBeenSet);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dictionary(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    Localization.dictionary = (System.Collections.Generic.Dictionary<string, string[]>)translator.GetObject(L, 1, typeof(System.Collections.Generic.Dictionary<string, string[]>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_language(RealStatePtr L)
        {
            
            try {
			    Localization.language = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_loadFunction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    Localization.loadFunction = translator.GetDelegate<Localization.LoadFunction>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onLocalize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    Localization.onLocalize = translator.GetDelegate<Localization.OnLocalizeNotification>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_localizationHasBeenSet(RealStatePtr L)
        {
            
            try {
			    Localization.localizationHasBeenSet = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
