using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;
	
	void Awake () {
		//gameObject REFERS TO THE MusicPlayer parent GameObject (and the MusicPlayer parent attributes)
		if (instance != null) {
			Destroy (gameObject);
			print ("Duplicate music player destroyed!");
		}
		else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
