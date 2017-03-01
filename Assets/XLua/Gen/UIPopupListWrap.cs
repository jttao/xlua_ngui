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
    public class UIPopupListWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIPopupList), L, translator, 0, 6, 23, 21);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddItem", _m_AddItem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveItem", _m_RemoveItem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveItemByData", _m_RemoveItemByData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Close", _m_Close);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Show", _m_Show);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ambigiousFont", _g_get_ambigiousFont);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isOpen", _g_get_isOpen);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "value", _g_get_value);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "data", _g_get_data);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "atlas", _g_get_atlas);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bitmapFont", _g_get_bitmapFont);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trueTypeFont", _g_get_trueTypeFont);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fontSize", _g_get_fontSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fontStyle", _g_get_fontStyle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "backgroundSprite", _g_get_backgroundSprite);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "highlightSprite", _g_get_highlightSprite);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "position", _g_get_position);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alignment", _g_get_alignment);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "items", _g_get_items);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "itemData", _g_get_itemData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "padding", _g_get_padding);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "textColor", _g_get_textColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "backgroundColor", _g_get_backgroundColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "highlightColor", _g_get_highlightColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isAnimated", _g_get_isAnimated);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isLocalized", _g_get_isLocalized);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "openOn", _g_get_openOn);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onChange", _g_get_onChange);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "ambigiousFont", _s_set_ambigiousFont);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "value", _s_set_value);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "atlas", _s_set_atlas);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bitmapFont", _s_set_bitmapFont);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "trueTypeFont", _s_set_trueTypeFont);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fontSize", _s_set_fontSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fontStyle", _s_set_fontStyle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "backgroundSprite", _s_set_backgroundSprite);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "highlightSprite", _s_set_highlightSprite);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "position", _s_set_position);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alignment", _s_set_alignment);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "items", _s_set_items);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "itemData", _s_set_itemData);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "padding", _s_set_padding);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "textColor", _s_set_textColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "backgroundColor", _s_set_backgroundColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "highlightColor", _s_set_highlightColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isAnimated", _s_set_isAnimated);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isLocalized", _s_set_isLocalized);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "openOn", _s_set_openOn);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onChange", _s_set_onChange);
            
			Utils.EndObjectRegister(typeof(UIPopupList), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIPopupList), L, __CreateInstance, 1, 1, 1);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIPopupList));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "current", _g_get_current);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "current", _s_set_current);
            
			Utils.EndClassRegister(typeof(UIPopupList), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIPopupList __cl_gen_ret = new UIPopupList();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIPopupList constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_AddItem(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string text = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.AddItem( text );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string text = LuaAPI.lua_tostring(L, 2);
                    object data = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.AddItem( text, data );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIPopupList.AddItem!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveItem(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.RemoveItem( text );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveItemByData(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    object data = translator.GetObject(L, 2, typeof(object));
                    
                    __cl_gen_to_be_invoked.RemoveItemByData( data );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Close(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Close(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Show(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Show(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambigiousFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.ambigiousFont);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isOpen(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isOpen);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_value(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.value);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_data(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, __cl_gen_to_be_invoked.data);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_current(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UIPopupList.current);
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
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.atlas);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bitmapFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.bitmapFont);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_trueTypeFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.trueTypeFont);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fontSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.fontSize);
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
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.fontStyle);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_backgroundSprite(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.backgroundSprite);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_highlightSprite(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.highlightSprite);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_position(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.position);
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
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.alignment);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_items(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.items);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_itemData(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.itemData);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_padding(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.padding);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_textColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, __cl_gen_to_be_invoked.textColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_backgroundColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, __cl_gen_to_be_invoked.backgroundColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_highlightColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, __cl_gen_to_be_invoked.highlightColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isAnimated(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isAnimated);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isLocalized(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isLocalized);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_openOn(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.openOn);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onChange(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onChange);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambigiousFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.ambigiousFont = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_value(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.value = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_current(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UIPopupList.current = (UIPopupList)translator.GetObject(L, 1, typeof(UIPopupList));
            
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
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.atlas = (UIAtlas)translator.GetObject(L, 2, typeof(UIAtlas));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bitmapFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.bitmapFont = (UIFont)translator.GetObject(L, 2, typeof(UIFont));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_trueTypeFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.trueTypeFont = (UnityEngine.Font)translator.GetObject(L, 2, typeof(UnityEngine.Font));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fontSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fontSize = LuaAPI.xlua_tointeger(L, 2);
            
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
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                UnityEngine.FontStyle __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.fontStyle = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_backgroundSprite(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.backgroundSprite = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_highlightSprite(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.highlightSprite = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_position(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                UIPopupList.Position __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.position = __cl_gen_value;
            
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
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                NGUIText.Alignment __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.alignment = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_items(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.items = (System.Collections.Generic.List<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<string>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_itemData(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.itemData = (System.Collections.Generic.List<object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<object>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_padding(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.padding = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_textColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                UnityEngine.Color __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.textColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_backgroundColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                UnityEngine.Color __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.backgroundColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_highlightColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                UnityEngine.Color __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.highlightColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isAnimated(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.isAnimated = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isLocalized(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.isLocalized = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_openOn(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                UIPopupList.OpenOn __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.openOn = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onChange(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPopupList __cl_gen_to_be_invoked = (UIPopupList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onChange = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
