using UnityEngine;
using System.Collections;
using System.IO;
using XLua;

public class LuaHotfix : MonoBehaviour {
	
	static object mate = new object();
	internal static float lastGCTime = 0;
	internal const float GCInterval = 1;//1 second 

	static LuaHotfix _luaHotfix=null;

	public static LuaHotfix Instance {
		get{ 
			if(_luaHotfix==null){ 
				lock (mate) {
					GameObject root = GameObject.Find ("_hotfix"); 
					if (root == null) {
						root = new GameObject ("_hotfix");
						GameObject.DontDestroyOnLoad (root);
					} 
					_luaHotfix = root.AddComponent<LuaHotfix> ();
				}
			}
			return _luaHotfix;
		}
	}

	LuaEnv _luaEnv;

	public LuaEnv luaEnv {
		get{ 
			return _luaEnv;
		}
	} 

	public void Init (){
		Debug.Log ("Init Hotfix...");
	}

	// Use this for initialization
	void Awake () {
		_luaHotfix = this;
		_luaEnv = new LuaEnv ();
		_luaEnv.AddLoader ((ref string filename) => {
			//lua customer path
			filename = Util.PersistentDataPath+"lua/game/"+filename+".lua";   
			return File.ReadAllBytes(filename);
			/***
			string script= File.ReadAllText(filename);
			return System.Text.Encoding.UTF8.GetBytes(script);
			***/
		}); 
	}

	void Start(){  
		_luaEnv.DoString ("require 'main'","main");
	}

	// Update is called once per frame
	void Update () {
		if (Time.time - lastGCTime > GCInterval)
		{
			if(_luaEnv!=null) _luaEnv.Tick();
			lastGCTime = Time.time;
		}
	}

	void OnDestroy(){ 
		_luaEnv = null;
		_luaHotfix = null;
	}

}
