#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter((luaenv, translator) => {
			    
				translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Event), UnityEngineEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WWW), UnityEngineWWWWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UI2DSprite), UI2DSpriteWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UI2DSpriteAnimation), UI2DSpriteAnimationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIAnchor), UIAnchorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIAtlas), UIAtlasWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UICamera), UICameraWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIFont), UIFontWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIInput), UIInputWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIInputOnGUI), UIInputOnGUIWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIPanel), UIPanelWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIRoot), UIRootWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UISprite), UISpriteWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UISpriteAnimation), UISpriteAnimationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UISpriteData), UISpriteDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIStretch), UIStretchWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UITextList), UITextListWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UITooltip), UITooltipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIViewport), UIViewportWrap.__Register);
				
				translator.DelayWrapLoader(typeof(AnimatedAlpha), AnimatedAlphaWrap.__Register);
				
				translator.DelayWrapLoader(typeof(AnimatedColor), AnimatedColorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(AnimatedWidget), AnimatedWidgetWrap.__Register);
				
				translator.DelayWrapLoader(typeof(SpringPosition), SpringPositionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenAlpha), TweenAlphaWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenColor), TweenColorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenFOV), TweenFOVWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenHeight), TweenHeightWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenOrthoSize), TweenOrthoSizeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenPosition), TweenPositionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenRotation), TweenRotationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenScale), TweenScaleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenTransform), TweenTransformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenVolume), TweenVolumeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenWidth), TweenWidthWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UITweener), UITweenerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(ActiveAnimation), ActiveAnimationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(AnimationOrTween.Trigger), AnimationOrTweenTriggerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(AnimationOrTween.Direction), AnimationOrTweenDirectionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(AnimationOrTween.DisableCondition), AnimationOrTweenDisableConditionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(AnimationOrTween.EnableCondition), AnimationOrTweenEnableConditionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(BetterList<int>), BetterList_1_SystemInt32_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(BetterList<string>), BetterList_1_SystemString_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(BetterList<float>), BetterList_1_SystemSingle_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(BetterList<double>), BetterList_1_SystemDouble_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(BMFont), BMFontWrap.__Register);
				
				translator.DelayWrapLoader(typeof(BMGlyph), BMGlyphWrap.__Register);
				
				translator.DelayWrapLoader(typeof(BMSymbol), BMSymbolWrap.__Register);
				
				translator.DelayWrapLoader(typeof(ByteReader), ByteReaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(EventDelegate), EventDelegateWrap.__Register);
				
				translator.DelayWrapLoader(typeof(EventDelegate.Parameter), EventDelegateParameterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Localization), LocalizationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(NGUIDebug), NGUIDebugWrap.__Register);
				
				translator.DelayWrapLoader(typeof(NGUIMath), NGUIMathWrap.__Register);
				
				translator.DelayWrapLoader(typeof(NGUIText), NGUITextWrap.__Register);
				
				translator.DelayWrapLoader(typeof(NGUITools), NGUIToolsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(RealTime), RealTimeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(SpringPanel), SpringPanelWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIEventListener), UIEventListenerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIGeometry), UIGeometryWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIRect), UIRectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UISnapshotPoint), UISnapshotPointWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIButton), UIButtonWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIButtonActivate), UIButtonActivateWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIButtonColor), UIButtonColorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIButtonKeys), UIButtonKeysWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIButtonMessage), UIButtonMessageWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIButtonOffset), UIButtonOffsetWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIButtonRotation), UIButtonRotationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIButtonScale), UIButtonScaleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UICenterOnChild), UICenterOnChildWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UICenterOnClick), UICenterOnClickWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIDragCamera), UIDragCameraWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIDragDropContainer), UIDragDropContainerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIDragDropItem), UIDragDropItemWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIDragDropRoot), UIDragDropRootWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIDraggableCamera), UIDraggableCameraWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIDragObject), UIDragObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIDragResize), UIDragResizeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIDragScrollView), UIDragScrollViewWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIEventTrigger), UIEventTriggerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIForwardEvents), UIForwardEventsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIGrid), UIGridWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIImageButton), UIImageButtonWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIKeyBinding), UIKeyBindingWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIKeyNavigation), UIKeyNavigationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIPlayAnimation), UIPlayAnimationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIPlaySound), UIPlaySoundWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIPlayTween), UIPlayTweenWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIPopupList), UIPopupListWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIProgressBar), UIProgressBarWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UISavedOption), UISavedOptionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIScrollBar), UIScrollBarWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIScrollView), UIScrollViewWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UISlider), UISliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UISoundVolume), UISoundVolumeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UITable), UITableWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIToggle), UIToggleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIToggledComponents), UIToggledComponentsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIToggledObjects), UIToggledObjectsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIWidgetContainer), UIWidgetContainerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIWrapContent), UIWrapContentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(HotfixDome), HotfixDomeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LuaBehaviour), LuaBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LuaConfig), LuaConfigWrap.__Register);
				
				
				translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
				
				translator.AddInterfaceBridgeCreator(typeof(LuaBehaviour.ILuaBehaviour), LuaBehaviourILuaBehaviourBridge.__Create);
				
			});
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	public static partial class Utils
    {
	    
	    static Utils()
		{
		    extension_method_map = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
		}
	}
}
