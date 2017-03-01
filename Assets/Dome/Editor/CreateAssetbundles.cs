using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using System.Collections.Generic;

public class CreateAssetbundles
{ 	
	static BuildTarget AssetbundlesBuildTarget =  
		#if UNITY_IPHONE 
			BuildTarget.iOS;
		#elif UNITY_ANDROID
			BuildTarget.Android;
		#else
			BuildTarget.StandaloneWindows;
		#endif    
	
    [MenuItem("GAME/Pack/UI")]
	public static void Pack_UI(){  
		string ui = "ui/"; 
		ExecuteCommunity(AssetbundlesBuildTarget, BuildAssetBundleOptions.None, LuaConfig.TempDataPath+ui,"*.prefab",  LuaConfig.AssetsStreamingAssets+ui);
	}

    static void CreateDirectoryAndDeleteOldFile(string outPath){ 
		Debug.Log("创建目标文件:"+outPath);
        // 创建一个目标文件
		if (!Directory.Exists (outPath)) { 
			Directory.CreateDirectory (outPath); 
		}   

        // 删除旧的assetbundles
        string[] existingAssetbundles = Directory.GetFiles(outPath);
        foreach (string bundle in existingAssetbundles)
        {
			File.Delete(bundle);
        } 

		AssetDatabase.Refresh ();
    }
	
	static void RemoveNotSuffixFile(string outPath){
		if (Directory.Exists (outPath)) { 
			// 删除旧的assetbundles
			string[] existingAssetbundles = Directory.GetFiles(outPath);
			foreach (string bundle in existingAssetbundles)
			{
				if(!bundle.EndsWith(LuaConfig.Suffix))
					File.Delete(bundle);
			} 
		}

		AssetDatabase.Refresh ();
	}
    
    static void ExecuteCommunity(BuildTarget buildTarget, BuildAssetBundleOptions options, string path, string suffix, string outPath, string saveName)
    {
        CreateDirectoryAndDeleteOldFile(outPath);
        string[] aMaterialFiles = Directory.GetFiles(path, suffix, SearchOption.AllDirectories);
        List<string> files = new List<string>();
        foreach (string matFile in aMaterialFiles)
        {
            string[] dpath = Directory.GetParent(matFile).FullName.Split('/');
            string assetPath = "Assets" + matFile.Replace(Application.dataPath, "").Replace('\\', '/');
            Debug.Log("******* Creating assetbundles for: " + assetPath); 
            files.Add(assetPath);//打包的资源包名称 
        }

        AssetBundleBuild[] buildMap = new AssetBundleBuild[1];
		buildMap[0].assetBundleName = saveName + LuaConfig.Suffix;
        buildMap[0].assetNames = files.ToArray();

        BuildPipeline.BuildAssetBundles(outPath, buildMap, options, buildTarget);

		RemoveNotSuffixFile (outPath);

    }
    
    static void ExecuteCommunity(BuildTarget buildTarget, BuildAssetBundleOptions options, string path, string suffix, string outPath)
    {
        CreateDirectoryAndDeleteOldFile(outPath);
        string[] aMaterialFiles = Directory.GetFiles(path, suffix, SearchOption.AllDirectories);
        foreach (string matFile in aMaterialFiles)
        {
            string[] dpath = Directory.GetParent(matFile).FullName.Split('/');
            string assetPath = "Assets" + matFile.Replace(Application.dataPath, "").Replace('\\', '/');
            GameObject o = (GameObject)AssetDatabase.LoadAssetAtPath(assetPath, typeof(GameObject));
            string name = o.name.ToLower();

			string savePath = outPath + name + LuaConfig.Suffix;
            Debug.Log("******* Creating assetbundles for: " + savePath);
            
            AssetBundleBuild[] buildMap = new AssetBundleBuild[1];
			buildMap[0].assetBundleName = name + LuaConfig.Suffix; //打包的资源包名称
            buildMap[0].assetNames = new string[] { assetPath };
            BuildPipeline.BuildAssetBundles(outPath, buildMap, options, buildTarget); 

		}

		RemoveNotSuffixFile (outPath);
    }
    
    static void ExecuteCommunity_AB(BuildTarget buildTarget, BuildAssetBundleOptions options, string path, string suffix, string outPath,string saveName=""){	
		CreateDirectoryAndDeleteOldFile(outPath); 
		string[] aMaterialFiles = Directory.GetFiles(path, suffix, SearchOption.AllDirectories);
		 
		foreach (string matFile in aMaterialFiles)
		{	
			string assetPath = "Assets" + matFile.Replace(Application.dataPath, "").Replace('\\', '/');
			GameObject o = (GameObject)AssetDatabase.LoadAssetAtPath(assetPath, typeof(GameObject)); 
			string name = o.name.ToLower();
			string savePath = outPath + name+LuaConfig.Suffix;
            Debug.Log("******* Creating assetbundles for: " + savePath); 
            AssetBundleBuild[] buildMap = new AssetBundleBuild[1];
			buildMap[0].assetBundleName = name + LuaConfig.Suffix; //打包的资源包名称
            buildMap[0].assetNames = new string[] { assetPath };
            BuildPipeline.BuildAssetBundles(outPath, buildMap, options, buildTarget); 
		}	
		RemoveNotSuffixFile (outPath);
	}
    
	[MenuItem("GAME/Build Lua")]
	public static void BuildLua(){  
			
	}


	static List<string> paths = new List<string>();
	static List<string> files = new List<string>();

	[MenuItem("GAME/Files")]
	public static void BuildFileIndex() {
		
		string resPath = LuaConfig.StreamingAssets;
		///----------------------创建文件列表-----------------------
		string newFilePath = resPath + "files.txt";
		if (File.Exists(newFilePath)) File.Delete(newFilePath); 
		paths.Clear(); 
		files.Clear(); 
		Recursive(resPath); 
		FileStream fs = new FileStream(newFilePath, FileMode.CreateNew);
		StreamWriter sw = new StreamWriter(fs);
		for (int i = 0; i < files.Count; i++) {
			string file = files[i];
			string ext = Path.GetExtension(file);
			if (file.EndsWith(".meta") || file.Contains(".DS_Store")) continue; 
			string md5 = Util.md5file(file);
			string value = file.Replace(resPath, string.Empty);
			sw.WriteLine(value + "|" + md5);
		}	
		sw.Close(); fs.Close(); 
		Debug.Log("*******生成资源管理文件:"+newFilePath); 
	}

	/// <summary>
	/// 遍历目录及其子目录
	/// </summary>
	static void Recursive(string path) {
		string[] names = Directory.GetFiles(path);
		string[] dirs = Directory.GetDirectories(path);
		foreach (string filename in names) {
			string ext = Path.GetExtension(filename);
			if (ext.Equals(".meta")) continue;
			files.Add(filename.Replace('\\', '/'));
		}
		foreach (string dir in dirs) {
			paths.Add(dir.Replace('\\', '/'));
			Recursive(dir);
		}
	}


}
