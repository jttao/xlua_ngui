/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using XLua;
using System;

[LuaCallCSharp]
public class LuaBehaviour : MonoBehaviour {
	
	internal static string luaModel;
	static object mate = new object();

	[CSharpCallLua]
	public interface ILuaBehaviour
	{	
		LuaTable LuaObj { get; set; }
		MonoBehaviour Mono { get; set; }
		void Awake ();
		void Start ();
		void OnEnable();
		void OnDisable();
		void FixedUpdate ();
		void Update ();
		void LateUpdate();
		void OnDestroy ();
		void OnApplicationFocus(bool focus);
		void OnApplicationPause(bool pause); 
	}

	[CSharpCallLua]
	public delegate ILuaBehaviour LuaBehaviourCalc(object obj,MonoBehaviour mono);

	public static void AddComponent(GameObject target,string luaComponent){
		lock(mate){
			luaModel = luaComponent;
			target.AddComponent<LuaBehaviour> ();
		}
	}

	ILuaBehaviour iCalc;

	public ILuaBehaviour ICalc {
		get{
			return iCalc;
		}
	}

	public LuaTable LuaObj {
		get{
			return iCalc.LuaObj;
		}
	}

	public LuaTable GetLuaObj(string luaModel){
		LuaTable[] tabs = GetLuaObjs (luaModel);
		if (tabs != null && tabs.Length > 0) {
			return tabs [0];
		}
		return null;
	}

	public LuaTable[] GetLuaObjs(string luaModel){
		LuaBehaviour[] luas = this.GetComponents<LuaBehaviour> ();
		List<LuaTable> list = new List<LuaTable> (); 
		if (luas != null) {
			for (int i = 0; i < luas.Length; i++) {
				if (luas [i].ICalc.LuaObj ["name"].Equals (luaModel)) {
					list.Add (luas [i].ICalc.LuaObj); 
				}
			}	
		}	
		return list.ToArray();
	}

    void Awake()
	{	
		LuaEnv luaEnv = LuaHotfix.Instance.luaEnv; 

		luaEnv.DoString("require '"+luaModel+"'",luaModel); 
  		
		LuaBehaviourCalc calc_new = luaEnv.Global.GetInPath<LuaBehaviourCalc> ("new_lua_mono");
		
		iCalc = calc_new(luaModel,this); //constructor

		iCalc.Awake ();
    }
    
	// Use this for initialization
	void Start ()
	{ 	
		if(iCalc!=null) iCalc.Start ();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(iCalc!=null) iCalc.Update (); 
	}

    void OnDestroy()
    {
		if (iCalc != null) { 
			iCalc.OnDestroy ();  
		}
		iCalc = null; 
    }

	void OnEnable(){ 
		if(iCalc!=null) iCalc.OnEnable ();
	}

	void OnDisable(){
		if(iCalc!=null) iCalc.OnDisable ();
	}

	void FixedUpdate (){
		if(iCalc!=null) iCalc.FixedUpdate ();
	}

	void LateUpdate(){
		if(iCalc!=null) iCalc.LateUpdate ();
	}

	void OnApplicationFocus(bool focus){
		if(iCalc!=null) iCalc.OnApplicationFocus (focus);
	}

	void OnApplicationPause(bool pause){
		if(iCalc!=null) iCalc.OnApplicationPause (pause);
	}

	public void StartWWW(string url,Action<AssetBundle> callback){ 
		StartCoroutine (LoadWWW (url, callback));
	}

	IEnumerator LoadWWW(string url,Action<AssetBundle> callback){
		WWW www = new WWW (url);
		yield return www;
		if (www.isDone) {
			if (callback!=null) {
				callback (www.assetBundle);   
			}
			www.assetBundle.Unload (false);
		}
		www.Dispose ();
	}

}
