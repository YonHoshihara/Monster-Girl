using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour {
	[SerializeField] private AudioSource TapSound;
	public AudioSource music;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
	
	}
	public void PlayTapSound(){
	
		TapSound.Play ();
	}

	public void MuteMusic(){
		if (music.volume!=0) {
			music.volume = 0;
		} else {
			music.volume = 0.473f;
		}
	}


		
}
