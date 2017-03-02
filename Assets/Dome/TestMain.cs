using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using XLua;
using System;
using System.IO;

public class TestMain : MonoBehaviour {

	void Awake(){

		CheckExtractResource ();

	}

	/// <summary>
	/// 释放资源
	/// </summary>
	public void CheckExtractResource() {
		bool isExists = Directory.Exists(Util.PersistentDataPath) && Directory.Exists(Util.PersistentDataPath + "lua/") && File.Exists(Util.PersistentDataPath + "files.txt");
		if (isExists) { 
			LuaHotfix.Instance.Init ();
			isInitOk = true;
			return;   //文件已经解压过了，自己可添加检查文件列表逻辑
		}
		StartCoroutine(OnExtractResource());    //启动释放协成 
	}

	IEnumerator OnExtractResource() {
		string dataPath = Util.PersistentDataPath;  //数据目录
		string resPath = Util.StreamingAssets; //游戏包资源目录

		if (Application.platform == RuntimePlatform.Android) {
			resPath = Util.WWWStreamingAssets;
		}

		if (Directory.Exists(dataPath)) Directory.Delete(dataPath, true);
		Directory.CreateDirectory(dataPath);

		string infile = resPath + "files.txt";
		string outfile = dataPath + "files.txt";
		if (File.Exists(outfile)) File.Delete(outfile);

		string message = "正在解包文件:>files.txt";
		Debug.Log(message);  
		if (Application.platform == RuntimePlatform.Android) {
			WWW www = new WWW(infile);
			yield return www; 
			if (www.isDone) {
				File.WriteAllBytes(outfile, www.bytes);
			}
			yield return 0;
		} else File.Copy(infile, outfile, true);

		yield return new WaitForEndOfFrame();

		//释放所有文件到数据目录
		string[] files = File.ReadAllLines(outfile);
		foreach (var file in files) {
			string[] fs = file.Split('|');
			infile = resPath + fs[0];  //
			outfile = dataPath + fs[0];

			message = "正在解包文件:>" + fs[0];
			Debug.Log("正在解包文件:>" + infile);
			Debug.Log(message);  

			string dir = Path.GetDirectoryName(outfile);
			if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

			if (Application.platform == RuntimePlatform.Android) {
				WWW www = new WWW(infile);
				yield return www;

				if (www.isDone) {
					File.WriteAllBytes(outfile, www.bytes);
				}
				yield return 0;
			} else {
				if (File.Exists(outfile)) {
					File.Delete(outfile);
				}
				File.Copy(infile, outfile, true);
			}
			yield return new WaitForEndOfFrame();
		}
		message = "解包完成!!!"; 
		Debug.Log(message);  

		yield return new WaitForSeconds(0.1f);
		message = string.Empty; 

		LuaHotfix.Instance.Init ();

		isInitOk = true;
	}

	bool isInitOk= false;
	void Update(){
		if (isInitOk) {
			isInitOk = false;
			LuaBehaviour.AddComponent (gameObject, "luaTest1");
		}
	}

}
