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
    public class NGUIMathWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(NGUIMath), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(NGUIMath), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(NGUIMath), L, __CreateInstance, 35, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Lerp", _m_Lerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClampIndex", _m_ClampIndex_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RepeatIndex", _m_RepeatIndex_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WrapAngle", _m_WrapAngle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Wrap01", _m_Wrap01_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HexToDecimal", _m_HexToDecimal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DecimalToHexChar", _m_DecimalToHexChar_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DecimalToHex8", _m_DecimalToHex8_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DecimalToHex24", _m_DecimalToHex24_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DecimalToHex32", _m_DecimalToHex32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ColorToInt", _m_ColorToInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IntToColor", _m_IntToColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IntToBinary", _m_IntToBinary_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HexToColor", _m_HexToColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ConvertToTexCoords", _m_ConvertToTexCoords_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ConvertToPixels", _m_ConvertToPixels_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MakePixelPerfect", _m_MakePixelPerfect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ConstrainRect", _m_ConstrainRect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculateAbsoluteWidgetBounds", _m_CalculateAbsoluteWidgetBounds_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculateRelativeWidgetBounds", _m_CalculateRelativeWidgetBounds_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SpringDampen", _m_SpringDampen_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SpringLerp", _m_SpringLerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RotateTowards", _m_RotateTowards_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DistanceToRectangle", _m_DistanceToRectangle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetPivotOffset", _m_GetPivotOffset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetPivot", _m_GetPivot_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MoveWidget", _m_MoveWidget_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MoveRect", _m_MoveRect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ResizeWidget", _m_ResizeWidget_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AdjustWidget", _m_AdjustWidget_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AdjustByDPI", _m_AdjustByDPI_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ScreenToPixels", _m_ScreenToPixels_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ScreenToParentPixels", _m_ScreenToParentPixels_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WorldToLocalPoint", _m_WorldToLocalPoint_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(NGUIMath));
			
			
			Utils.EndClassRegister(typeof(NGUIMath), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "NGUIMath does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lerp_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    float from = (float)LuaAPI.lua_tonumber(L, 1);
                    float to = (float)LuaAPI.lua_tonumber(L, 2);
                    float factor = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        float __cl_gen_ret = NGUIMath.Lerp( from, to, factor );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClampIndex_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int val = LuaAPI.xlua_tointeger(L, 1);
                    int max = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = NGUIMath.ClampIndex( val, max );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RepeatIndex_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int val = LuaAPI.xlua_tointeger(L, 1);
                    int max = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = NGUIMath.RepeatIndex( val, max );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WrapAngle_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    float angle = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        float __cl_gen_ret = NGUIMath.WrapAngle( angle );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Wrap01_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    float val = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        float __cl_gen_ret = NGUIMath.Wrap01( val );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HexToDecimal_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    char ch = (char)LuaAPI.xlua_tointeger(L, 1);
                    
                        int __cl_gen_ret = NGUIMath.HexToDecimal( ch );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DecimalToHexChar_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int num = LuaAPI.xlua_tointeger(L, 1);
                    
                        char __cl_gen_ret = NGUIMath.DecimalToHexChar( num );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DecimalToHex8_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int num = LuaAPI.xlua_tointeger(L, 1);
                    
                        string __cl_gen_ret = NGUIMath.DecimalToHex8( num );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DecimalToHex24_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int num = LuaAPI.xlua_tointeger(L, 1);
                    
                        string __cl_gen_ret = NGUIMath.DecimalToHex24( num );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DecimalToHex32_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int num = LuaAPI.xlua_tointeger(L, 1);
                    
                        string __cl_gen_ret = NGUIMath.DecimalToHex32( num );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ColorToInt_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Color c;translator.Get(L, 1, out c);
                    
                        int __cl_gen_ret = NGUIMath.ColorToInt( c );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IntToColor_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    int val = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.Color __cl_gen_ret = NGUIMath.IntToColor( val );
                        translator.PushUnityEngineColor(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IntToBinary_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int val = LuaAPI.xlua_tointeger(L, 1);
                    int bits = LuaAPI.xlua_tointeger(L, 2);
                    
                        string __cl_gen_ret = NGUIMath.IntToBinary( val, bits );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HexToColor_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    uint val = LuaAPI.xlua_touint(L, 1);
                    
                        UnityEngine.Color __cl_gen_ret = NGUIMath.HexToColor( val );
                        translator.PushUnityEngineColor(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ConvertToTexCoords_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Rect rect;translator.Get(L, 1, out rect);
                    int width = LuaAPI.xlua_tointeger(L, 2);
                    int height = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.Rect __cl_gen_ret = NGUIMath.ConvertToTexCoords( rect, width, height );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ConvertToPixels_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Rect rect;translator.Get(L, 1, out rect);
                    int width = LuaAPI.xlua_tointeger(L, 2);
                    int height = LuaAPI.xlua_tointeger(L, 3);
                    bool round = LuaAPI.lua_toboolean(L, 4);
                    
                        UnityEngine.Rect __cl_gen_ret = NGUIMath.ConvertToPixels( rect, width, height, round );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakePixelPerfect_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Rect>(L, 1)) 
                {
                    UnityEngine.Rect rect;translator.Get(L, 1, out rect);
                    
                        UnityEngine.Rect __cl_gen_ret = NGUIMath.MakePixelPerfect( rect );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Rect rect;translator.Get(L, 1, out rect);
                    int width = LuaAPI.xlua_tointeger(L, 2);
                    int height = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.Rect __cl_gen_ret = NGUIMath.MakePixelPerfect( rect, width, height );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUIMath.MakePixelPerfect!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ConstrainRect_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector2 minRect;translator.Get(L, 1, out minRect);
                    UnityEngine.Vector2 maxRect;translator.Get(L, 2, out maxRect);
                    UnityEngine.Vector2 minArea;translator.Get(L, 3, out minArea);
                    UnityEngine.Vector2 maxArea;translator.Get(L, 4, out maxArea);
                    
                        UnityEngine.Vector2 __cl_gen_ret = NGUIMath.ConstrainRect( minRect, maxRect, minArea, maxArea );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateAbsoluteWidgetBounds_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Transform trans = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Bounds __cl_gen_ret = NGUIMath.CalculateAbsoluteWidgetBounds( trans );
                        translator.PushUnityEngineBounds(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateRelativeWidgetBounds_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Transform>(L, 1)) 
                {
                    UnityEngine.Transform trans = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Bounds __cl_gen_ret = NGUIMath.CalculateRelativeWidgetBounds( trans );
                        translator.PushUnityEngineBounds(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Transform trans = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    bool considerInactive = LuaAPI.lua_toboolean(L, 2);
                    
                        UnityEngine.Bounds __cl_gen_ret = NGUIMath.CalculateRelativeWidgetBounds( trans, considerInactive );
                        translator.PushUnityEngineBounds(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)) 
                {
                    UnityEngine.Transform relativeTo = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Bounds __cl_gen_ret = NGUIMath.CalculateRelativeWidgetBounds( relativeTo, content );
                        translator.PushUnityEngineBounds(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Transform relativeTo = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    bool considerInactive = LuaAPI.lua_toboolean(L, 3);
                    bool considerParents = LuaAPI.lua_toboolean(L, 4);
                    
                        UnityEngine.Bounds __cl_gen_ret = NGUIMath.CalculateRelativeWidgetBounds( relativeTo, content, considerInactive, considerParents );
                        translator.PushUnityEngineBounds(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Transform relativeTo = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    bool considerInactive = LuaAPI.lua_toboolean(L, 3);
                    
                        UnityEngine.Bounds __cl_gen_ret = NGUIMath.CalculateRelativeWidgetBounds( relativeTo, content, considerInactive );
                        translator.PushUnityEngineBounds(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUIMath.CalculateRelativeWidgetBounds!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SpringDampen_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 velocity;translator.Get(L, 1, out velocity);
                    float strength = (float)LuaAPI.lua_tonumber(L, 2);
                    float deltaTime = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Vector3 __cl_gen_ret = NGUIMath.SpringDampen( ref velocity, strength, deltaTime );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    translator.PushUnityEngineVector3(L, velocity);
                        translator.UpdateUnityEngineVector3(L, 1, velocity);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 velocity;translator.Get(L, 1, out velocity);
                    float strength = (float)LuaAPI.lua_tonumber(L, 2);
                    float deltaTime = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Vector2 __cl_gen_ret = NGUIMath.SpringDampen( ref velocity, strength, deltaTime );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    translator.PushUnityEngineVector2(L, velocity);
                        translator.UpdateUnityEngineVector2(L, 1, velocity);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUIMath.SpringDampen!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SpringLerp_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float strength = (float)LuaAPI.lua_tonumber(L, 1);
                    float deltaTime = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        float __cl_gen_ret = NGUIMath.SpringLerp( strength, deltaTime );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float from = (float)LuaAPI.lua_tonumber(L, 1);
                    float to = (float)LuaAPI.lua_tonumber(L, 2);
                    float strength = (float)LuaAPI.lua_tonumber(L, 3);
                    float deltaTime = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        float __cl_gen_ret = NGUIMath.SpringLerp( from, to, strength, deltaTime );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 from;translator.Get(L, 1, out from);
                    UnityEngine.Vector2 to;translator.Get(L, 2, out to);
                    float strength = (float)LuaAPI.lua_tonumber(L, 3);
                    float deltaTime = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Vector2 __cl_gen_ret = NGUIMath.SpringLerp( from, to, strength, deltaTime );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 from;translator.Get(L, 1, out from);
                    UnityEngine.Vector3 to;translator.Get(L, 2, out to);
                    float strength = (float)LuaAPI.lua_tonumber(L, 3);
                    float deltaTime = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Vector3 __cl_gen_ret = NGUIMath.SpringLerp( from, to, strength, deltaTime );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Quaternion>(L, 1)&& translator.Assignable<UnityEngine.Quaternion>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Quaternion from;translator.Get(L, 1, out from);
                    UnityEngine.Quaternion to;translator.Get(L, 2, out to);
                    float strength = (float)LuaAPI.lua_tonumber(L, 3);
                    float deltaTime = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Quaternion __cl_gen_ret = NGUIMath.SpringLerp( from, to, strength, deltaTime );
                        translator.PushUnityEngineQuaternion(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUIMath.SpringLerp!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RotateTowards_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    float from = (float)LuaAPI.lua_tonumber(L, 1);
                    float to = (float)LuaAPI.lua_tonumber(L, 2);
                    float maxAngle = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        float __cl_gen_ret = NGUIMath.RotateTowards( from, to, maxAngle );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DistanceToRectangle_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2[]>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2[] screenPoints = (UnityEngine.Vector2[])translator.GetObject(L, 1, typeof(UnityEngine.Vector2[]));
                    UnityEngine.Vector2 mousePos;translator.Get(L, 2, out mousePos);
                    
                        float __cl_gen_ret = NGUIMath.DistanceToRectangle( screenPoints, mousePos );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3[]>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Camera>(L, 3)) 
                {
                    UnityEngine.Vector3[] worldPoints = (UnityEngine.Vector3[])translator.GetObject(L, 1, typeof(UnityEngine.Vector3[]));
                    UnityEngine.Vector2 mousePos;translator.Get(L, 2, out mousePos);
                    UnityEngine.Camera cam = (UnityEngine.Camera)translator.GetObject(L, 3, typeof(UnityEngine.Camera));
                    
                        float __cl_gen_ret = NGUIMath.DistanceToRectangle( worldPoints, mousePos, cam );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUIMath.DistanceToRectangle!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPivotOffset_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UIWidget.Pivot pv;translator.Get(L, 1, out pv);
                    
                        UnityEngine.Vector2 __cl_gen_ret = NGUIMath.GetPivotOffset( pv );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPivot_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector2 offset;translator.Get(L, 1, out offset);
                    
                        UIWidget.Pivot __cl_gen_ret = NGUIMath.GetPivot( offset );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveWidget_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UIRect w = (UIRect)translator.GetObject(L, 1, typeof(UIRect));
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    NGUIMath.MoveWidget( w, x, y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveRect_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UIRect rect = (UIRect)translator.GetObject(L, 1, typeof(UIRect));
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    NGUIMath.MoveRect( rect, x, y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResizeWidget_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 6&& translator.Assignable<UIWidget>(L, 1)&& translator.Assignable<UIWidget.Pivot>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UIWidget w = (UIWidget)translator.GetObject(L, 1, typeof(UIWidget));
                    UIWidget.Pivot pivot;translator.Get(L, 2, out pivot);
                    float x = (float)LuaAPI.lua_tonumber(L, 3);
                    float y = (float)LuaAPI.lua_tonumber(L, 4);
                    int minWidth = LuaAPI.xlua_tointeger(L, 5);
                    int minHeight = LuaAPI.xlua_tointeger(L, 6);
                    
                    NGUIMath.ResizeWidget( w, pivot, x, y, minWidth, minHeight );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& translator.Assignable<UIWidget>(L, 1)&& translator.Assignable<UIWidget.Pivot>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UIWidget w = (UIWidget)translator.GetObject(L, 1, typeof(UIWidget));
                    UIWidget.Pivot pivot;translator.Get(L, 2, out pivot);
                    float x = (float)LuaAPI.lua_tonumber(L, 3);
                    float y = (float)LuaAPI.lua_tonumber(L, 4);
                    int minWidth = LuaAPI.xlua_tointeger(L, 5);
                    int minHeight = LuaAPI.xlua_tointeger(L, 6);
                    int maxWidth = LuaAPI.xlua_tointeger(L, 7);
                    int maxHeight = LuaAPI.xlua_tointeger(L, 8);
                    
                    NGUIMath.ResizeWidget( w, pivot, x, y, minWidth, minHeight, maxWidth, maxHeight );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUIMath.ResizeWidget!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AdjustWidget_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 5&& translator.Assignable<UIWidget>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UIWidget w = (UIWidget)translator.GetObject(L, 1, typeof(UIWidget));
                    float left = (float)LuaAPI.lua_tonumber(L, 2);
                    float bottom = (float)LuaAPI.lua_tonumber(L, 3);
                    float right = (float)LuaAPI.lua_tonumber(L, 4);
                    float top = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    NGUIMath.AdjustWidget( w, left, bottom, right, top );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UIWidget>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UIWidget w = (UIWidget)translator.GetObject(L, 1, typeof(UIWidget));
                    float left = (float)LuaAPI.lua_tonumber(L, 2);
                    float bottom = (float)LuaAPI.lua_tonumber(L, 3);
                    float right = (float)LuaAPI.lua_tonumber(L, 4);
                    float top = (float)LuaAPI.lua_tonumber(L, 5);
                    int minWidth = LuaAPI.xlua_tointeger(L, 6);
                    int minHeight = LuaAPI.xlua_tointeger(L, 7);
                    
                    NGUIMath.AdjustWidget( w, left, bottom, right, top, minWidth, minHeight );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 9&& translator.Assignable<UIWidget>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UIWidget w = (UIWidget)translator.GetObject(L, 1, typeof(UIWidget));
                    float left = (float)LuaAPI.lua_tonumber(L, 2);
                    float bottom = (float)LuaAPI.lua_tonumber(L, 3);
                    float right = (float)LuaAPI.lua_tonumber(L, 4);
                    float top = (float)LuaAPI.lua_tonumber(L, 5);
                    int minWidth = LuaAPI.xlua_tointeger(L, 6);
                    int minHeight = LuaAPI.xlua_tointeger(L, 7);
                    int maxWidth = LuaAPI.xlua_tointeger(L, 8);
                    int maxHeight = LuaAPI.xlua_tointeger(L, 9);
                    
                    NGUIMath.AdjustWidget( w, left, bottom, right, top, minWidth, minHeight, maxWidth, maxHeight );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUIMath.AdjustWidget!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AdjustByDPI_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    float height = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        int __cl_gen_ret = NGUIMath.AdjustByDPI( height );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScreenToPixels_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector2 pos;translator.Get(L, 1, out pos);
                    UnityEngine.Transform relativeTo = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Vector2 __cl_gen_ret = NGUIMath.ScreenToPixels( pos, relativeTo );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScreenToParentPixels_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector2 pos;translator.Get(L, 1, out pos);
                    UnityEngine.Transform relativeTo = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Vector2 __cl_gen_ret = NGUIMath.ScreenToParentPixels( pos, relativeTo );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WorldToLocalPoint_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector3 worldPos;translator.Get(L, 1, out worldPos);
                    UnityEngine.Camera worldCam = (UnityEngine.Camera)translator.GetObject(L, 2, typeof(UnityEngine.Camera));
                    UnityEngine.Camera uiCam = (UnityEngine.Camera)translator.GetObject(L, 3, typeof(UnityEngine.Camera));
                    UnityEngine.Transform relativeTo = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Vector3 __cl_gen_ret = NGUIMath.WorldToLocalPoint( worldPos, worldCam, uiCam, relativeTo );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
