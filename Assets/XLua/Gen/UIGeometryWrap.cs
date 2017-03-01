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
    public class UIGeometryWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIGeometry), L, translator, 0, 3, 5, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyTransform", _m_ApplyTransform);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteToBuffers", _m_WriteToBuffers);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasVertices", _g_get_hasVertices);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasTransformed", _g_get_hasTransformed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verts", _g_get_verts);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uvs", _g_get_uvs);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cols", _g_get_cols);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "verts", _s_set_verts);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uvs", _s_set_uvs);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cols", _s_set_cols);
            
			Utils.EndObjectRegister(typeof(UIGeometry), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIGeometry), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIGeometry));
			
			
			Utils.EndClassRegister(typeof(UIGeometry), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIGeometry __cl_gen_ret = new UIGeometry();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIGeometry constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIGeometry __cl_gen_to_be_invoked = (UIGeometry)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyTransform(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIGeometry __cl_gen_to_be_invoked = (UIGeometry)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Matrix4x4 widgetToPanel;translator.Get(L, 2, out widgetToPanel);
                    
                    __cl_gen_to_be_invoked.ApplyTransform( widgetToPanel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteToBuffers(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIGeometry __cl_gen_to_be_invoked = (UIGeometry)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    BetterList<UnityEngine.Vector3> v = (BetterList<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(BetterList<UnityEngine.Vector3>));
                    BetterList<UnityEngine.Vector2> u = (BetterList<UnityEngine.Vector2>)translator.GetObject(L, 3, typeof(BetterList<UnityEngine.Vector2>));
                    BetterList<UnityEngine.Color32> c = (BetterList<UnityEngine.Color32>)translator.GetObject(L, 4, typeof(BetterList<UnityEngine.Color32>));
                    BetterList<UnityEngine.Vector3> n = (BetterList<UnityEngine.Vector3>)translator.GetObject(L, 5, typeof(BetterList<UnityEngine.Vector3>));
                    BetterList<UnityEngine.Vector4> t = (BetterList<UnityEngine.Vector4>)translator.GetObject(L, 6, typeof(BetterList<UnityEngine.Vector4>));
                    
                    __cl_gen_to_be_invoked.WriteToBuffers( v, u, c, n, t );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasVertices(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGeometry __cl_gen_to_be_invoked = (UIGeometry)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasVertices);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasTransformed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGeometry __cl_gen_to_be_invoked = (UIGeometry)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasTransformed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_verts(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGeometry __cl_gen_to_be_invoked = (UIGeometry)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.verts);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uvs(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGeometry __cl_gen_to_be_invoked = (UIGeometry)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.uvs);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cols(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGeometry __cl_gen_to_be_invoked = (UIGeometry)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cols);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_verts(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGeometry __cl_gen_to_be_invoked = (UIGeometry)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.verts = (BetterList<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(BetterList<UnityEngine.Vector3>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uvs(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGeometry __cl_gen_to_be_invoked = (UIGeometry)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.uvs = (BetterList<UnityEngine.Vector2>)translator.GetObject(L, 2, typeof(BetterList<UnityEngine.Vector2>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cols(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIGeometry __cl_gen_to_be_invoked = (UIGeometry)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.cols = (BetterList<UnityEngine.Color32>)translator.GetObject(L, 2, typeof(BetterList<UnityEngine.Color32>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
