using UnityEngine;
using System.Collections;
using System.IO;
using System;
using XLua;

[LuaCallCSharp]
public static class LuaConfig  {

	public static string Suffix
	{   
		get
		{
			return ".assetbundle";
		}
	} 

	public static string StreamingAssets
	{   
		get
		{   
			#if UNITY_EDITOR
			return Application.dataPath + "/StreamingAssets/";
			#elif UNITY_IPHONE
			return Application.dataPath + "/Raw/";
			#elif UNITY_ANDROID   
			return Application.dataPath + "!/assets/";
			#else
			return Application.dataPath + "/StreamingAssets/";
			#endif   
		}
	}
	
	public static string WWWStreamingAssets
	{   
		get
		{   
			#if UNITY_EDITOR
			return "file://"+Application.dataPath + "/StreamingAssets/";
			#elif UNITY_IPHONE
			return "file://"+Application.dataPath + "/Raw/";
			#elif UNITY_ANDROID   
			return "jar:file://"+Application.dataPath + "!/assets/";
			#else
			return "file://"+Application.dataPath + "/StreamingAssets/";
			#endif   
		}
	}

	public static string WWWFile{
		get{
			return "file://";
		}
	}

	public static string AssetsDataPath
	{   
		get
		{
			return Application.dataPath;    
		}
	}
	
	public static string  TempDataPath {
		get{
			#if UNITY_EDITOR 
			return Application.dataPath+"/TempResources/";
			#elif UNITY_IPHONE
			return Application.temporaryCachePath+"/data/";
			#elif UNITY_ANDROID   
			return Application.persistentDataPath+"/data/";
			#else  
			return Application.persistentDataPath+"/data/"; 
			#endif  
		}
	}
	
	public static string PersistentDataPath
	{   
		get
		{
			#if UNITY_EDITOR
			return Application.dataPath+"/StreamingAssets/";
			#elif UNITY_IPHONE
			return Application.temporaryCachePath+"/";
			#elif UNITY_ANDROID   
			return Application.persistentDataPath+"/";
			#else
			return Application.persistentDataPath+"/"; 
			#endif  
		}
	}
	
	public static string WWWPersistentDataPath
	{   
		get
		{
			#if UNITY_EDITOR
			return "file://"+Application.dataPath+"/StreamingAssets/";
			#elif UNITY_IPHONE
			return "file://"+Application.temporaryCachePath+"/";
			#elif UNITY_ANDROID   
			return "file://"+Application.persistentDataPath+"/";
			#else
			return "file://"+Application.persistentDataPath+"/"; 
			#endif  
		}
	} 
	
	public static string AssetsStreamingAssets{
		get{ 
			return "Assets/StreamingAssets/";
		}
	}

}
