using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class VictoryCondition : MonoBehaviour {
	public AudioSource audio;
	public string scene;
	// Use this for initialization
	void Start () {
		//ßaudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!audio.isPlaying){

			SceneManager.LoadScene (scene);
		}
	}
}
