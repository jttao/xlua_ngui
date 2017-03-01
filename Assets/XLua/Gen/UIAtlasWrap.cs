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
    public class UIAtlasWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIAtlas), L, translator, 0, 6, 6, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSprite", _m_GetSprite);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRandomSprite", _m_GetRandomSprite);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MarkSpriteListAsChanged", _m_MarkSpriteListAsChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SortAlphabetically", _m_SortAlphabetically);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetListOfSprites", _m_GetListOfSprites);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MarkAsChanged", _m_MarkAsChanged);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "spriteMaterial", _g_get_spriteMaterial);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "premultipliedAlpha", _g_get_premultipliedAlpha);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "spriteList", _g_get_spriteList);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "texture", _g_get_texture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelSize", _g_get_pixelSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "replacement", _g_get_replacement);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "spriteMaterial", _s_set_spriteMaterial);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "spriteList", _s_set_spriteList);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pixelSize", _s_set_pixelSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "replacement", _s_set_replacement);
            
			Utils.EndObjectRegister(typeof(UIAtlas), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIAtlas), L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CheckIfRelated", _m_CheckIfRelated_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIAtlas));
			
			
			Utils.EndClassRegister(typeof(UIAtlas), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIAtlas __cl_gen_ret = new UIAtlas();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIAtlas constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSprite(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        UISpriteData __cl_gen_ret = __cl_gen_to_be_invoked.GetSprite( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRandomSprite(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string startsWith = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetRandomSprite( startsWith );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MarkSpriteListAsChanged(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.MarkSpriteListAsChanged(  );
                    
                    
                    
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
            
            
            UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_GetListOfSprites(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                        BetterList<string> __cl_gen_ret = __cl_gen_to_be_invoked.GetListOfSprites(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string match = LuaAPI.lua_tostring(L, 2);
                    
                        BetterList<string> __cl_gen_ret = __cl_gen_to_be_invoked.GetListOfSprites( match );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIAtlas.GetListOfSprites!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckIfRelated_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UIAtlas a = (UIAtlas)translator.GetObject(L, 1, typeof(UIAtlas));
                    UIAtlas b = (UIAtlas)translator.GetObject(L, 2, typeof(UIAtlas));
                    
                        bool __cl_gen_ret = UIAtlas.CheckIfRelated( a, b );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MarkAsChanged(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.MarkAsChanged(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_spriteMaterial(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.spriteMaterial);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_premultipliedAlpha(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.premultipliedAlpha);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_spriteList(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.spriteList);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_texture(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.texture);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pixelSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.pixelSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_replacement(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.replacement);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_spriteMaterial(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.spriteMaterial = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_spriteList(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.spriteList = (System.Collections.Generic.List<UISpriteData>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UISpriteData>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pixelSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.pixelSize = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_replacement(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIAtlas __cl_gen_to_be_invoked = (UIAtlas)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.replacement = (UIAtlas)translator.GetObject(L, 2, typeof(UIAtlas));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
