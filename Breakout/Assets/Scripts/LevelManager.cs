using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	//Level load method
	public void LoadLevel(string name) {
		Debug.Log ("Level load requested for level " + name);
		Application.LoadLevel (name);
	}
	
	//Game quit method
	public void QuitRequest() {
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
}
