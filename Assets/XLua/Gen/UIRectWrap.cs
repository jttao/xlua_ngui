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
    public class UIRectWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIRect), L, translator, 0, 10, 19, 7);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateFinalAlpha", _m_CalculateFinalAlpha);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Invalidate", _m_Invalidate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSides", _m_GetSides);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Update", _m_Update);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateAnchors", _m_UpdateAnchors);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAnchor", _m_SetAnchor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetAnchors", _m_ResetAnchors);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetAndUpdateAnchors", _m_ResetAndUpdateAnchors);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetRect", _m_SetRect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ParentHasChanged", _m_ParentHasChanged);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "cachedGameObject", _g_get_cachedGameObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cachedTransform", _g_get_cachedTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "anchorCamera", _g_get_anchorCamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isFullyAnchored", _g_get_isFullyAnchored);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isAnchoredHorizontally", _g_get_isAnchoredHorizontally);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isAnchoredVertically", _g_get_isAnchoredVertically);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canBeAnchored", _g_get_canBeAnchored);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "parent", _g_get_parent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "root", _g_get_root);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isAnchored", _g_get_isAnchored);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alpha", _g_get_alpha);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localCorners", _g_get_localCorners);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldCorners", _g_get_worldCorners);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "leftAnchor", _g_get_leftAnchor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rightAnchor", _g_get_rightAnchor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bottomAnchor", _g_get_bottomAnchor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "topAnchor", _g_get_topAnchor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "updateAnchors", _g_get_updateAnchors);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "finalAlpha", _g_get_finalAlpha);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "alpha", _s_set_alpha);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "leftAnchor", _s_set_leftAnchor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rightAnchor", _s_set_rightAnchor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bottomAnchor", _s_set_bottomAnchor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "topAnchor", _s_set_topAnchor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "updateAnchors", _s_set_updateAnchors);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "finalAlpha", _s_set_finalAlpha);
            
			Utils.EndObjectRegister(typeof(UIRect), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIRect), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIRect));
			
			
			Utils.EndClassRegister(typeof(UIRect), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UIRect does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateFinalAlpha(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int frameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.CalculateFinalAlpha( frameID );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Invalidate(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    bool includeChildren = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Invalidate( includeChildren );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSides(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Transform relativeTo = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Vector3[] __cl_gen_ret = __cl_gen_to_be_invoked.GetSides( relativeTo );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Update(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Update(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateAnchors(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.UpdateAnchors(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAnchor(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 2)) 
                {
                    UnityEngine.Transform t = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                    __cl_gen_to_be_invoked.SetAnchor( t );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.GameObject>(L, 2)) 
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    
                    __cl_gen_to_be_invoked.SetAnchor( go );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.GameObject>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    int left = LuaAPI.xlua_tointeger(L, 3);
                    int bottom = LuaAPI.xlua_tointeger(L, 4);
                    int right = LuaAPI.xlua_tointeger(L, 5);
                    int top = LuaAPI.xlua_tointeger(L, 6);
                    
                    __cl_gen_to_be_invoked.SetAnchor( go, left, bottom, right, top );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIRect.SetAnchor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetAnchors(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ResetAnchors(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetAndUpdateAnchors(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ResetAndUpdateAnchors(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetRect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    float width = (float)LuaAPI.lua_tonumber(L, 4);
                    float height = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    __cl_gen_to_be_invoked.SetRect( x, y, width, height );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParentHasChanged(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ParentHasChanged(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cachedGameObject(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cachedGameObject);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cachedTransform(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cachedTransform);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_anchorCamera(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.anchorCamera);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isFullyAnchored(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isFullyAnchored);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isAnchoredHorizontally(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isAnchoredHorizontally);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isAnchoredVertically(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isAnchoredVertically);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canBeAnchored(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.canBeAnchored);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_parent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.parent);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_root(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.root);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isAnchored(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isAnchored);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alpha(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.alpha);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_localCorners(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.localCorners);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_worldCorners(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.worldCorners);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_leftAnchor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.leftAnchor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rightAnchor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.rightAnchor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bottomAnchor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.bottomAnchor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_topAnchor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.topAnchor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_updateAnchors(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.updateAnchors);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_finalAlpha(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.finalAlpha);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alpha(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.alpha = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_leftAnchor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.leftAnchor = (UIRect.AnchorPoint)translator.GetObject(L, 2, typeof(UIRect.AnchorPoint));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rightAnchor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.rightAnchor = (UIRect.AnchorPoint)translator.GetObject(L, 2, typeof(UIRect.AnchorPoint));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bottomAnchor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.bottomAnchor = (UIRect.AnchorPoint)translator.GetObject(L, 2, typeof(UIRect.AnchorPoint));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_topAnchor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.topAnchor = (UIRect.AnchorPoint)translator.GetObject(L, 2, typeof(UIRect.AnchorPoint));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_updateAnchors(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                UIRect.AnchorUpdate __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.updateAnchors = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_finalAlpha(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIRect __cl_gen_to_be_invoked = (UIRect)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.finalAlpha = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
