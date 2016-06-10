using UnityEngine;
using System.Collections;

public class Teste : MonoBehaviour {
    public float[] MusicTeste;
    private int cont=0;
	// Use this for initialization
	void Start () {
        MusicTeste = GetComponent<Audio2>().MusicAnaliseVector();
        // InvokeRepeating("ContadorSegundo",0,1);
        for (int i=0;i<MusicTeste.Length;i++)
        {
           Debug.Log( MusicTeste[i]);

        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
   


}
