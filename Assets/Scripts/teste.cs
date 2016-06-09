using UnityEngine;
using System.Collections;

public class teste : MonoBehaviour {
private float[]Music;
	// Use this for initialization
	void Start () {
        Music = GetComponent<Audio2>().MusicAnaliseVector();
        for(int i = 0; i < Music.Length; i++)
        {
            Debug.Log(Music[i]);

        }

       Debug.Log(Music.Length);

        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
