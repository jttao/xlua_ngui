using UnityEngine;
using System.Collections;
using XLua;

[LuaCallCSharp]
[Hotfix]
public class HotfixDome : MonoBehaviour {
	
	[HideInInspector]
	public UISprite mSprite;

	void Awake(){
		mSprite = transform.FindChild ("Camera/Sprite").GetComponent<UISprite>();
	}

	// Use this for initialization
	void Start () {
		 
		transform.FindChild ("Camera/Button0").GetComponent<UIButton> ().onClick.Add (new EventDelegate (() => {
			Debug.Log("click.1");
		}));

		transform.FindChild ("Camera/Button1").GetComponent<UIButton> ().onClick.Add (new EventDelegate (() => {
			Debug.Log("click.2");
		}));

		UILabel label = null;


	}

	public void HideUI(){ 

		mSprite.gameObject.SetActive (false);	
	}

}
