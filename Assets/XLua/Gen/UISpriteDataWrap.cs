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
    public class UISpriteDataWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UISpriteData), L, translator, 0, 5, 15, 13);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetRect", _m_SetRect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPadding", _m_SetPadding);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetBorder", _m_SetBorder);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CopyFrom", _m_CopyFrom);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CopyBorderFrom", _m_CopyBorderFrom);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasBorder", _g_get_hasBorder);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasPadding", _g_get_hasPadding);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "name", _g_get_name);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "x", _g_get_x);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "y", _g_get_y);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "width", _g_get_width);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "height", _g_get_height);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "borderLeft", _g_get_borderLeft);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "borderRight", _g_get_borderRight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "borderTop", _g_get_borderTop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "borderBottom", _g_get_borderBottom);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "paddingLeft", _g_get_paddingLeft);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "paddingRight", _g_get_paddingRight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "paddingTop", _g_get_paddingTop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "paddingBottom", _g_get_paddingBottom);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "name", _s_set_name);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "x", _s_set_x);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "y", _s_set_y);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "width", _s_set_width);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "height", _s_set_height);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "borderLeft", _s_set_borderLeft);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "borderRight", _s_set_borderRight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "borderTop", _s_set_borderTop);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "borderBottom", _s_set_borderBottom);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "paddingLeft", _s_set_paddingLeft);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "paddingRight", _s_set_paddingRight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "paddingTop", _s_set_paddingTop);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "paddingBottom", _s_set_paddingBottom);
            
			Utils.EndObjectRegister(typeof(UISpriteData), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UISpriteData), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UISpriteData));
			
			
			Utils.EndClassRegister(typeof(UISpriteData), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UISpriteData __cl_gen_ret = new UISpriteData();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UISpriteData constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetRect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int x = LuaAPI.xlua_tointeger(L, 2);
                    int y = LuaAPI.xlua_tointeger(L, 3);
                    int width = LuaAPI.xlua_tointeger(L, 4);
                    int height = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.SetRect( x, y, width, height );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPadding(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int left = LuaAPI.xlua_tointeger(L, 2);
                    int bottom = LuaAPI.xlua_tointeger(L, 3);
                    int right = LuaAPI.xlua_tointeger(L, 4);
                    int top = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.SetPadding( left, bottom, right, top );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBorder(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int left = LuaAPI.xlua_tointeger(L, 2);
                    int bottom = LuaAPI.xlua_tointeger(L, 3);
                    int right = LuaAPI.xlua_tointeger(L, 4);
                    int top = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.SetBorder( left, bottom, right, top );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyFrom(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UISpriteData sd = (UISpriteData)translator.GetObject(L, 2, typeof(UISpriteData));
                    
                    __cl_gen_to_be_invoked.CopyFrom( sd );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyBorderFrom(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UISpriteData sd = (UISpriteData)translator.GetObject(L, 2, typeof(UISpriteData));
                    
                    __cl_gen_to_be_invoked.CopyBorderFrom( sd );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasBorder(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasBorder);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasPadding(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasPadding);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_name(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.name);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_x(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.x);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_y(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.y);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_width(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.width);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_height(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.height);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_borderLeft(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.borderLeft);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_borderRight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.borderRight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_borderTop(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.borderTop);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_borderBottom(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.borderBottom);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_paddingLeft(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.paddingLeft);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_paddingRight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.paddingRight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_paddingTop(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.paddingTop);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_paddingBottom(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.paddingBottom);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_name(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.name = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_x(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.x = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_y(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.y = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_width(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.width = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_height(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.height = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_borderLeft(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.borderLeft = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_borderRight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.borderRight = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_borderTop(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.borderTop = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_borderBottom(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.borderBottom = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_paddingLeft(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.paddingLeft = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_paddingRight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.paddingRight = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_paddingTop(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.paddingTop = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_paddingBottom(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISpriteData __cl_gen_to_be_invoked = (UISpriteData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.paddingBottom = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
