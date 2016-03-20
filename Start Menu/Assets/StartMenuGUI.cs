using UnityEngine;
using System.Collections;
[ExecuteInEditMode()] 
public class StartMenuGUI : MonoBehaviour {
	public GUISkin gSkin;
	public Texture2D backdrop;
	bool isLoading = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if(gSkin)
			GUI.skin = gSkin;
		else
			Debug.Log("StartMenuGUI: Missing GUI Skin");
		GUIStyle bgStyle = new GUIStyle();
		if(GUI.Button(new Rect((Screen.width/2)-70, Screen.height-170, 140, 30), "Play")){
			Debug.Log("You pressed play");
			Application.LoadLevel("TheGame");
			isLoading = true;
		}
		bool isWebPlayer = (Application.platform == RuntimePlatform.OSXWebPlayer || Application.platform == RuntimePlatform.WindowsWebPlayer);
		if(!isWebPlayer){
			if(GUI.Button(new Rect((Screen.width/2)-70, Screen.height-120, 140, 30), "Quit"))
				Application.Quit();
		}
		if(isLoading)
			GUI.Label(new Rect((Screen.width/2)-110, (Screen.height/2)-60, 400, 70), "Loading...");
	}

}
