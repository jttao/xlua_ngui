using UnityEngine;
using System.Collections;
using XLua;

[LuaCallCSharp]
[Hotfix]
public class HotfixTest : MonoBehaviour {

	void Awake(){
		Debug.Log ("C# Awake.");
	}

	// Use this for initialization
	void Start () {
		Debug.Log ("C# Start.");
		DoCoroutine (2);
		DoCoroutine0 ();
	}

	public IEnumerator MyCoroutine(int prame){
		yield return new WaitForSeconds(prame);
		Debug.Log ("C# MyCoroutine WaitForSeconds "+prame+"s.");
	}

	public void DoCoroutine(int prame){
		Debug.Log ("C# DoCoroutine."+prame); 
		StartCoroutine (MyCoroutine(prame));
	}

	public IEnumerator MyCoroutine0(){
		yield return new WaitForEndOfFrame();
		Debug.Log ("C# MyCoroutine0 ");
	}

	public void DoCoroutine0(){
		Debug.Log ("C# DoCoroutine0."); 
		StartCoroutine ("MyCoroutine0");
	}

}
