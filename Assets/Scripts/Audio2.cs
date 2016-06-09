using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Audio2 : MonoBehaviour {
	public AudioSource aud;
    //private float[] Music;
    void Start() {

    }

public float[] MusicAnaliseVector()
    {

        AudioSource aud = GetComponent<AudioSource>();
        float[] samples = new float[aud.clip.samples * aud.clip.channels];
        aud.clip.GetData(samples, 0);
       // print(samples.Length);
        int tam;
        tam = (int)(aud.clip.samples * aud.clip.channels / aud.clip.length);
        var AveragedSound = new float[samples.Length / (int)tam];
        var j = 0;
        for (var i = 0; i < samples.Length / (int)tam ; ++i)
        {
            j += (int)tam;
            if (j >= samples.Length) print(j + " er " + i);
            float average = Mathf.Max(Mathf.Abs(samples[j]), Mathf.Abs(samples[j + 1]));
            average = Mathf.Max(average, Mathf.Abs(samples[j + 2]));
            average = Mathf.Max(average, Mathf.Abs(samples[j + 3]));
            AveragedSound[i] = average * 100;
            //Debug.Log(AveragedSound[i]);

        }

        return AveragedSound;

    }


}







