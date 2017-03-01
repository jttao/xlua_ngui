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
    public class NGUITextWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(NGUIText), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(NGUIText), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(NGUIText), L, __CreateInstance, 29, 27, 27);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Update", _m_Update_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Prepare", _m_Prepare_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSymbol", _m_GetSymbol_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlyphWidth", _m_GetGlyphWidth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlyph", _m_GetGlyph_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ParseAlpha", _m_ParseAlpha_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ParseColor", _m_ParseColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ParseColor24", _m_ParseColor24_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ParseColor32", _m_ParseColor32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EncodeColor", _m_EncodeColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EncodeAlpha", _m_EncodeAlpha_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EncodeColor24", _m_EncodeColor24_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EncodeColor32", _m_EncodeColor32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ParseSymbol", _m_ParseSymbol_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsHex", _m_IsHex_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "StripSymbols", _m_StripSymbols_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Align", _m_Align_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetExactCharacterIndex", _m_GetExactCharacterIndex_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetApproximateCharacterIndex", _m_GetApproximateCharacterIndex_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndLine", _m_EndLine_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculatePrintedSize", _m_CalculatePrintedSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculateOffsetToFit", _m_CalculateOffsetToFit_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetEndOfLineThatFits", _m_GetEndOfLineThatFits_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WrapText", _m_WrapText_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Print", _m_Print_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PrintApproximateCharacterPositions", _m_PrintApproximateCharacterPositions_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PrintExactCharacterPositions", _m_PrintExactCharacterPositions_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PrintCaretAndSelection", _m_PrintCaretAndSelection_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(NGUIText));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "bitmapFont", _g_get_bitmapFont);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "dynamicFont", _g_get_dynamicFont);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "glyph", _g_get_glyph);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fontSize", _g_get_fontSize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fontScale", _g_get_fontScale);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "pixelDensity", _g_get_pixelDensity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fontStyle", _g_get_fontStyle);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "alignment", _g_get_alignment);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "tint", _g_get_tint);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "rectWidth", _g_get_rectWidth);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "rectHeight", _g_get_rectHeight);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "regionWidth", _g_get_regionWidth);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "regionHeight", _g_get_regionHeight);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxLines", _g_get_maxLines);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "gradient", _g_get_gradient);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "gradientBottom", _g_get_gradientBottom);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "gradientTop", _g_get_gradientTop);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "encoding", _g_get_encoding);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "spacingX", _g_get_spacingX);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "spacingY", _g_get_spacingY);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "premultiply", _g_get_premultiply);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "symbolStyle", _g_get_symbolStyle);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "finalSize", _g_get_finalSize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "finalSpacingX", _g_get_finalSpacingX);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "finalLineHeight", _g_get_finalLineHeight);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "baseline", _g_get_baseline);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "useSymbols", _g_get_useSymbols);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "bitmapFont", _s_set_bitmapFont);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "dynamicFont", _s_set_dynamicFont);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "glyph", _s_set_glyph);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fontSize", _s_set_fontSize);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fontScale", _s_set_fontScale);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "pixelDensity", _s_set_pixelDensity);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fontStyle", _s_set_fontStyle);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "alignment", _s_set_alignment);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "tint", _s_set_tint);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "rectWidth", _s_set_rectWidth);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "rectHeight", _s_set_rectHeight);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "regionWidth", _s_set_regionWidth);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "regionHeight", _s_set_regionHeight);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maxLines", _s_set_maxLines);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "gradient", _s_set_gradient);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "gradientBottom", _s_set_gradientBottom);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "gradientTop", _s_set_gradientTop);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "encoding", _s_set_encoding);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "spacingX", _s_set_spacingX);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "spacingY", _s_set_spacingY);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "premultiply", _s_set_premultiply);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "symbolStyle", _s_set_symbolStyle);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "finalSize", _s_set_finalSize);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "finalSpacingX", _s_set_finalSpacingX);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "finalLineHeight", _s_set_finalLineHeight);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "baseline", _s_set_baseline);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "useSymbols", _s_set_useSymbols);
            
			Utils.EndClassRegister(typeof(NGUIText), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "NGUIText does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Update_xlua_st_(RealStatePtr L)
        {
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 0) 
                {
                    
                    NGUIText.Update(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)) 
                {
                    bool request = LuaAPI.lua_toboolean(L, 1);
                    
                    NGUIText.Update( request );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUIText.Update!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Prepare_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    
                    NGUIText.Prepare( text );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSymbol_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    int textLength = LuaAPI.xlua_tointeger(L, 3);
                    
                        BMSymbol __cl_gen_ret = NGUIText.GetSymbol( text, index, textLength );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlyphWidth_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int ch = LuaAPI.xlua_tointeger(L, 1);
                    int prev = LuaAPI.xlua_tointeger(L, 2);
                    
                        float __cl_gen_ret = NGUIText.GetGlyphWidth( ch, prev );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlyph_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    int ch = LuaAPI.xlua_tointeger(L, 1);
                    int prev = LuaAPI.xlua_tointeger(L, 2);
                    
                        NGUIText.GlyphInfo __cl_gen_ret = NGUIText.GetGlyph( ch, prev );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParseAlpha_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                        float __cl_gen_ret = NGUIText.ParseAlpha( text, index );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParseColor_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    int offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Color __cl_gen_ret = NGUIText.ParseColor( text, offset );
                        translator.PushUnityEngineColor(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParseColor24_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    int offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Color __cl_gen_ret = NGUIText.ParseColor24( text, offset );
                        translator.PushUnityEngineColor(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParseColor32_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    int offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Color __cl_gen_ret = NGUIText.ParseColor32( text, offset );
                        translator.PushUnityEngineColor(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EncodeColor_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Color>(L, 1)) 
                {
                    UnityEngine.Color c;translator.Get(L, 1, out c);
                    
                        string __cl_gen_ret = NGUIText.EncodeColor( c );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Color>(L, 2)) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Color c;translator.Get(L, 2, out c);
                    
                        string __cl_gen_ret = NGUIText.EncodeColor( text, c );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUIText.EncodeColor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EncodeAlpha_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    float a = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        string __cl_gen_ret = NGUIText.EncodeAlpha( a );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EncodeColor24_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Color c;translator.Get(L, 1, out c);
                    
                        string __cl_gen_ret = NGUIText.EncodeColor24( c );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EncodeColor32_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Color c;translator.Get(L, 1, out c);
                    
                        string __cl_gen_ret = NGUIText.EncodeColor32( c );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParseSymbol_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = NGUIText.ParseSymbol( text, ref index );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    LuaAPI.xlua_pushinteger(L, index);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 10&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<BetterList<UnityEngine.Color>>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    BetterList<UnityEngine.Color> colors = (BetterList<UnityEngine.Color>)translator.GetObject(L, 3, typeof(BetterList<UnityEngine.Color>));
                    bool premultiply = LuaAPI.lua_toboolean(L, 4);
                    int sub = LuaAPI.xlua_tointeger(L, 5);
                    bool bold = LuaAPI.lua_toboolean(L, 6);
                    bool italic = LuaAPI.lua_toboolean(L, 7);
                    bool underline = LuaAPI.lua_toboolean(L, 8);
                    bool strike = LuaAPI.lua_toboolean(L, 9);
                    bool ignoreColor = LuaAPI.lua_toboolean(L, 10);
                    
                        bool __cl_gen_ret = NGUIText.ParseSymbol( text, ref index, colors, premultiply, ref sub, ref bold, ref italic, ref underline, ref strike, ref ignoreColor );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    LuaAPI.xlua_pushinteger(L, index);
                        
                    LuaAPI.xlua_pushinteger(L, sub);
                        
                    LuaAPI.lua_pushboolean(L, bold);
                        
                    LuaAPI.lua_pushboolean(L, italic);
                        
                    LuaAPI.lua_pushboolean(L, underline);
                        
                    LuaAPI.lua_pushboolean(L, strike);
                        
                    LuaAPI.lua_pushboolean(L, ignoreColor);
                        
                    
                    
                    
                    return 8;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUIText.ParseSymbol!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsHex_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    char ch = (char)LuaAPI.xlua_tointeger(L, 1);
                    
                        bool __cl_gen_ret = NGUIText.IsHex( ch );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StripSymbols_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = NGUIText.StripSymbols( text );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Align_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    BetterList<UnityEngine.Vector3> verts = (BetterList<UnityEngine.Vector3>)translator.GetObject(L, 1, typeof(BetterList<UnityEngine.Vector3>));
                    int indexOffset = LuaAPI.xlua_tointeger(L, 2);
                    float printedWidth = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    NGUIText.Align( verts, indexOffset, printedWidth );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetExactCharacterIndex_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    BetterList<UnityEngine.Vector3> verts = (BetterList<UnityEngine.Vector3>)translator.GetObject(L, 1, typeof(BetterList<UnityEngine.Vector3>));
                    BetterList<int> indices = (BetterList<int>)translator.GetObject(L, 2, typeof(BetterList<int>));
                    UnityEngine.Vector2 pos;translator.Get(L, 3, out pos);
                    
                        int __cl_gen_ret = NGUIText.GetExactCharacterIndex( verts, indices, pos );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetApproximateCharacterIndex_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    BetterList<UnityEngine.Vector3> verts = (BetterList<UnityEngine.Vector3>)translator.GetObject(L, 1, typeof(BetterList<UnityEngine.Vector3>));
                    BetterList<int> indices = (BetterList<int>)translator.GetObject(L, 2, typeof(BetterList<int>));
                    UnityEngine.Vector2 pos;translator.Get(L, 3, out pos);
                    
                        int __cl_gen_ret = NGUIText.GetApproximateCharacterIndex( verts, indices, pos );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndLine_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.Text.StringBuilder s = (System.Text.StringBuilder)translator.GetObject(L, 1, typeof(System.Text.StringBuilder));
                    
                    NGUIText.EndLine( ref s );
                    translator.Push(L, s);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculatePrintedSize_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Vector2 __cl_gen_ret = NGUIText.CalculatePrintedSize( text );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateOffsetToFit_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    
                        int __cl_gen_ret = NGUIText.CalculateOffsetToFit( text );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEndOfLineThatFits_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = NGUIText.GetEndOfLineThatFits( text );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WrapText_xlua_st_(RealStatePtr L)
        {
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    string finalText;
                    
                        bool __cl_gen_ret = NGUIText.WrapText( text, out finalText );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    LuaAPI.lua_pushstring(L, finalText);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    string finalText;
                    bool keepCharCount = LuaAPI.lua_toboolean(L, 2);
                    
                        bool __cl_gen_ret = NGUIText.WrapText( text, out finalText, keepCharCount );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    LuaAPI.lua_pushstring(L, finalText);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUIText.WrapText!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Print_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    BetterList<UnityEngine.Vector3> verts = (BetterList<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(BetterList<UnityEngine.Vector3>));
                    BetterList<UnityEngine.Vector2> uvs = (BetterList<UnityEngine.Vector2>)translator.GetObject(L, 3, typeof(BetterList<UnityEngine.Vector2>));
                    BetterList<UnityEngine.Color32> cols = (BetterList<UnityEngine.Color32>)translator.GetObject(L, 4, typeof(BetterList<UnityEngine.Color32>));
                    
                    NGUIText.Print( text, verts, uvs, cols );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PrintApproximateCharacterPositions_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    BetterList<UnityEngine.Vector3> verts = (BetterList<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(BetterList<UnityEngine.Vector3>));
                    BetterList<int> indices = (BetterList<int>)translator.GetObject(L, 3, typeof(BetterList<int>));
                    
                    NGUIText.PrintApproximateCharacterPositions( text, verts, indices );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PrintExactCharacterPositions_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    BetterList<UnityEngine.Vector3> verts = (BetterList<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(BetterList<UnityEngine.Vector3>));
                    BetterList<int> indices = (BetterList<int>)translator.GetObject(L, 3, typeof(BetterList<int>));
                    
                    NGUIText.PrintExactCharacterPositions( text, verts, indices );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PrintCaretAndSelection_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    int start = LuaAPI.xlua_tointeger(L, 2);
                    int end = LuaAPI.xlua_tointeger(L, 3);
                    BetterList<UnityEngine.Vector3> caret = (BetterList<UnityEngine.Vector3>)translator.GetObject(L, 4, typeof(BetterList<UnityEngine.Vector3>));
                    BetterList<UnityEngine.Vector3> highlight = (BetterList<UnityEngine.Vector3>)translator.GetObject(L, 5, typeof(BetterList<UnityEngine.Vector3>));
                    
                    NGUIText.PrintCaretAndSelection( text, start, end, caret, highlight );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bitmapFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, NGUIText.bitmapFont);
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
			    translator.Push(L, NGUIText.dynamicFont);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_glyph(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, NGUIText.glyph);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fontSize(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, NGUIText.fontSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fontScale(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, NGUIText.fontScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pixelDensity(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, NGUIText.pixelDensity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fontStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, NGUIText.fontStyle);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alignment(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, NGUIText.alignment);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tint(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, NGUIText.tint);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rectWidth(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, NGUIText.rectWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rectHeight(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, NGUIText.rectHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_regionWidth(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, NGUIText.regionWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_regionHeight(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, NGUIText.regionHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxLines(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, NGUIText.maxLines);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gradient(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, NGUIText.gradient);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gradientBottom(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, NGUIText.gradientBottom);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gradientTop(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, NGUIText.gradientTop);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_encoding(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, NGUIText.encoding);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_spacingX(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, NGUIText.spacingX);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_spacingY(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, NGUIText.spacingY);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_premultiply(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, NGUIText.premultiply);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_symbolStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, NGUIText.symbolStyle);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_finalSize(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, NGUIText.finalSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_finalSpacingX(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, NGUIText.finalSpacingX);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_finalLineHeight(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, NGUIText.finalLineHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_baseline(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, NGUIText.baseline);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useSymbols(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, NGUIText.useSymbols);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bitmapFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    NGUIText.bitmapFont = (UIFont)translator.GetObject(L, 1, typeof(UIFont));
            
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
			    NGUIText.dynamicFont = (UnityEngine.Font)translator.GetObject(L, 1, typeof(UnityEngine.Font));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_glyph(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    NGUIText.glyph = (NGUIText.GlyphInfo)translator.GetObject(L, 1, typeof(NGUIText.GlyphInfo));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fontSize(RealStatePtr L)
        {
            
            try {
			    NGUIText.fontSize = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fontScale(RealStatePtr L)
        {
            
            try {
			    NGUIText.fontScale = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pixelDensity(RealStatePtr L)
        {
            
            try {
			    NGUIText.pixelDensity = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fontStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.FontStyle __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				NGUIText.fontStyle = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alignment(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			NGUIText.Alignment __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				NGUIText.alignment = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tint(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				NGUIText.tint = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rectWidth(RealStatePtr L)
        {
            
            try {
			    NGUIText.rectWidth = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rectHeight(RealStatePtr L)
        {
            
            try {
			    NGUIText.rectHeight = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_regionWidth(RealStatePtr L)
        {
            
            try {
			    NGUIText.regionWidth = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_regionHeight(RealStatePtr L)
        {
            
            try {
			    NGUIText.regionHeight = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxLines(RealStatePtr L)
        {
            
            try {
			    NGUIText.maxLines = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gradient(RealStatePtr L)
        {
            
            try {
			    NGUIText.gradient = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gradientBottom(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				NGUIText.gradientBottom = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gradientTop(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				NGUIText.gradientTop = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_encoding(RealStatePtr L)
        {
            
            try {
			    NGUIText.encoding = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_spacingX(RealStatePtr L)
        {
            
            try {
			    NGUIText.spacingX = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_spacingY(RealStatePtr L)
        {
            
            try {
			    NGUIText.spacingY = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_premultiply(RealStatePtr L)
        {
            
            try {
			    NGUIText.premultiply = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_symbolStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			NGUIText.SymbolStyle __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				NGUIText.symbolStyle = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_finalSize(RealStatePtr L)
        {
            
            try {
			    NGUIText.finalSize = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_finalSpacingX(RealStatePtr L)
        {
            
            try {
			    NGUIText.finalSpacingX = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_finalLineHeight(RealStatePtr L)
        {
            
            try {
			    NGUIText.finalLineHeight = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_baseline(RealStatePtr L)
        {
            
            try {
			    NGUIText.baseline = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useSymbols(RealStatePtr L)
        {
            
            try {
			    NGUIText.useSymbols = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
