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
    public class LuaConfigWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(LuaConfig), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(LuaConfig), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(LuaConfig), L, __CreateInstance, 1, 9, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(LuaConfig));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Suffix", _g_get_Suffix);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "StreamingAssets", _g_get_StreamingAssets);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "WWWStreamingAssets", _g_get_WWWStreamingAssets);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "WWWFile", _g_get_WWWFile);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "AssetsDataPath", _g_get_AssetsDataPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "TempDataPath", _g_get_TempDataPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "PersistentDataPath", _g_get_PersistentDataPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "WWWPersistentDataPath", _g_get_WWWPersistentDataPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "AssetsStreamingAssets", _g_get_AssetsStreamingAssets);
            
			
			Utils.EndClassRegister(typeof(LuaConfig), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "LuaConfig does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Suffix(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, LuaConfig.Suffix);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_StreamingAssets(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, LuaConfig.StreamingAssets);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WWWStreamingAssets(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, LuaConfig.WWWStreamingAssets);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WWWFile(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, LuaConfig.WWWFile);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetsDataPath(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, LuaConfig.AssetsDataPath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TempDataPath(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, LuaConfig.TempDataPath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PersistentDataPath(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, LuaConfig.PersistentDataPath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WWWPersistentDataPath(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, LuaConfig.WWWPersistentDataPath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetsStreamingAssets(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, LuaConfig.AssetsStreamingAssets);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
