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
    public class UIFontWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIFont), L, translator, 0, 7, 19, 11);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MarkAsChanged", _m_MarkAsChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateUVRect", _m_UpdateUVRect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MatchSymbol", _m_MatchSymbol);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddSymbol", _m_AddSymbol);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveSymbol", _m_RemoveSymbol);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RenameSymbol", _m_RenameSymbol);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UsesSprite", _m_UsesSprite);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "bmFont", _g_get_bmFont);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "texWidth", _g_get_texWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "texHeight", _g_get_texHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasSymbols", _g_get_hasSymbols);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "symbols", _g_get_symbols);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "atlas", _g_get_atlas);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "material", _g_get_material);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "premultipliedAlphaShader", _g_get_premultipliedAlphaShader);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "packedFontShader", _g_get_packedFontShader);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "texture", _g_get_texture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uvRect", _g_get_uvRect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "spriteName", _g_get_spriteName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isValid", _g_get_isValid);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultSize", _g_get_defaultSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sprite", _g_get_sprite);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "replacement", _g_get_replacement);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isDynamic", _g_get_isDynamic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dynamicFont", _g_get_dynamicFont);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dynamicFontStyle", _g_get_dynamicFontStyle);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "bmFont", _s_set_bmFont);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "texWidth", _s_set_texWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "texHeight", _s_set_texHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "atlas", _s_set_atlas);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "material", _s_set_material);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uvRect", _s_set_uvRect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "spriteName", _s_set_spriteName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultSize", _s_set_defaultSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "replacement", _s_set_replacement);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dynamicFont", _s_set_dynamicFont);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dynamicFontStyle", _s_set_dynamicFontStyle);
            
			Utils.EndObjectRegister(typeof(UIFont), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIFont), L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CheckIfRelated", _m_CheckIfRelated_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIFont));
			
			
			Utils.EndClassRegister(typeof(UIFont), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIFont __cl_gen_ret = new UIFont();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIFont constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckIfRelated_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UIFont a = (UIFont)translator.GetObject(L, 1, typeof(UIFont));
                    UIFont b = (UIFont)translator.GetObject(L, 2, typeof(UIFont));
                    
                        bool __cl_gen_ret = UIFont.CheckIfRelated( a, b );
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
            
            
            UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_UpdateUVRect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.UpdateUVRect(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MatchSymbol(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 2);
                    int offset = LuaAPI.xlua_tointeger(L, 3);
                    int textLength = LuaAPI.xlua_tointeger(L, 4);
                    
                        BMSymbol __cl_gen_ret = __cl_gen_to_be_invoked.MatchSymbol( text, offset, textLength );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddSymbol(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sequence = LuaAPI.lua_tostring(L, 2);
                    string spriteName = LuaAPI.lua_tostring(L, 3);
                    
                    __cl_gen_to_be_invoked.AddSymbol( sequence, spriteName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveSymbol(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sequence = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.RemoveSymbol( sequence );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RenameSymbol(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string before = LuaAPI.lua_tostring(L, 2);
                    string after = LuaAPI.lua_tostring(L, 3);
                    
                    __cl_gen_to_be_invoked.RenameSymbol( before, after );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UsesSprite(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string s = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.UsesSprite( s );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bmFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.bmFont);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_texWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.texWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_texHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.texHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasSymbols(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasSymbols);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_symbols(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.symbols);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_atlas(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.atlas);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_material(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.material);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_premultipliedAlphaShader(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.premultipliedAlphaShader);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_packedFontShader(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.packedFontShader);
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
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.texture);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uvRect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.uvRect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_spriteName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.spriteName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isValid(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isValid);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.defaultSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sprite(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.sprite);
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
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.replacement);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isDynamic(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isDynamic);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dynamicFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.dynamicFont);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dynamicFontStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.dynamicFontStyle);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bmFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.bmFont = (BMFont)translator.GetObject(L, 2, typeof(BMFont));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_texWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.texWidth = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_texHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.texHeight = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_atlas(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.atlas = (UIAtlas)translator.GetObject(L, 2, typeof(UIAtlas));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_material(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uvRect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                UnityEngine.Rect __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.uvRect = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_spriteName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.spriteName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.defaultSize = LuaAPI.xlua_tointeger(L, 2);
            
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
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.replacement = (UIFont)translator.GetObject(L, 2, typeof(UIFont));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dynamicFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.dynamicFont = (UnityEngine.Font)translator.GetObject(L, 2, typeof(UnityEngine.Font));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dynamicFontStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIFont __cl_gen_to_be_invoked = (UIFont)translator.FastGetCSObj(L, 1);
                UnityEngine.FontStyle __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.dynamicFontStyle = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
