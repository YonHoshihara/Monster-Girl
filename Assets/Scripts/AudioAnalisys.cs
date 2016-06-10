using UnityEngine;
using System.Collections;

public class AudioAnalisys : MonoBehaviour {

    public AudioSource aud;
   // private int k;
    //private float[] Music;
    void Start()
    {

    }

    public float[] MusicAnaliseVector()
    {
        int k = 0;
        AudioSource aud = GetComponent<AudioSource>();
        float[] samples = new float[aud.clip.samples * aud.clip.channels];
        aud.clip.GetData(samples, 0);
        // print(samples.Length);
        int tam;
        tam = (int)(aud.clip.samples * aud.clip.channels / aud.clip.length);
        var AveragedSound = new float[samples.Length / (int)tam];
        var j = 0;
        for (var i = 0; i < samples.Length / (int)tam; ++i)
        {
            j = 0;
            
            float Soma=0;
           // float Media=0;

            while (j<=tam)
            {
                Soma += samples[k];
                k++;
                j++;
              
            }
            AveragedSound[i] = (Soma * 10000 / tam );
            //Debug.Log((Soma * 100 / tam));

        }

        return AveragedSound;

    }

}
