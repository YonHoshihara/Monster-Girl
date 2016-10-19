using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour {
	[SerializeField] private AudioSource TapSound;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
	
	}
	public void PlayTapSound(){
	
		TapSound.Play ();
	}
		
}
