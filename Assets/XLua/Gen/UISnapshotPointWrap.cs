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
    public class UISnapshotPointWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UISnapshotPoint), L, translator, 0, 0, 6, 6);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "isOrthographic", _g_get_isOrthographic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "nearClip", _g_get_nearClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "farClip", _g_get_farClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fieldOfView", _g_get_fieldOfView);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "orthoSize", _g_get_orthoSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "thumbnail", _g_get_thumbnail);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "isOrthographic", _s_set_isOrthographic);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "nearClip", _s_set_nearClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "farClip", _s_set_farClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fieldOfView", _s_set_fieldOfView);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "orthoSize", _s_set_orthoSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "thumbnail", _s_set_thumbnail);
            
			Utils.EndObjectRegister(typeof(UISnapshotPoint), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UISnapshotPoint), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UISnapshotPoint));
			
			
			Utils.EndClassRegister(typeof(UISnapshotPoint), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UISnapshotPoint __cl_gen_ret = new UISnapshotPoint();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UISnapshotPoint constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isOrthographic(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISnapshotPoint __cl_gen_to_be_invoked = (UISnapshotPoint)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isOrthographic);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_nearClip(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISnapshotPoint __cl_gen_to_be_invoked = (UISnapshotPoint)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.nearClip);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_farClip(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISnapshotPoint __cl_gen_to_be_invoked = (UISnapshotPoint)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.farClip);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fieldOfView(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISnapshotPoint __cl_gen_to_be_invoked = (UISnapshotPoint)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.fieldOfView);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_orthoSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISnapshotPoint __cl_gen_to_be_invoked = (UISnapshotPoint)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.orthoSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_thumbnail(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISnapshotPoint __cl_gen_to_be_invoked = (UISnapshotPoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.thumbnail);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isOrthographic(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISnapshotPoint __cl_gen_to_be_invoked = (UISnapshotPoint)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.isOrthographic = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_nearClip(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISnapshotPoint __cl_gen_to_be_invoked = (UISnapshotPoint)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.nearClip = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_farClip(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISnapshotPoint __cl_gen_to_be_invoked = (UISnapshotPoint)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.farClip = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fieldOfView(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISnapshotPoint __cl_gen_to_be_invoked = (UISnapshotPoint)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fieldOfView = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_orthoSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISnapshotPoint __cl_gen_to_be_invoked = (UISnapshotPoint)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.orthoSize = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_thumbnail(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISnapshotPoint __cl_gen_to_be_invoked = (UISnapshotPoint)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.thumbnail = (UnityEngine.Texture2D)translator.GetObject(L, 2, typeof(UnityEngine.Texture2D));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
