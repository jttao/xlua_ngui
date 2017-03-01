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
    public class UIDragCameraWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIDragCamera), L, translator, 0, 0, 1, 1);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "draggableCamera", _g_get_draggableCamera);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "draggableCamera", _s_set_draggableCamera);
            
			Utils.EndObjectRegister(typeof(UIDragCamera), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIDragCamera), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIDragCamera));
			
			
			Utils.EndClassRegister(typeof(UIDragCamera), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIDragCamera __cl_gen_ret = new UIDragCamera();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIDragCamera constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_draggableCamera(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragCamera __cl_gen_to_be_invoked = (UIDragCamera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.draggableCamera);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_draggableCamera(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIDragCamera __cl_gen_to_be_invoked = (UIDragCamera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.draggableCamera = (UIDraggableCamera)translator.GetObject(L, 2, typeof(UIDraggableCamera));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
