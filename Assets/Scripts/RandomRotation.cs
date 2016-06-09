using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomRotation : MonoBehaviour {
    private float  Probability;
//	public AudioSource Audio;
	//float Semente;
    // Use this for initialization
    void Start() {
        GenerateRandomRotation();
		//Semente = Audio.GetSpectrumData
    } 
	
	// Update is called once per frame
	void Update () {
	
	}

public void GenerateRandomRotation()
    {
        Probability = Random.Range(0, 100);

        if ((Probability >= 0) && (Probability <= 16.6))
        {
            gameObject.transform.Rotate(Vector3.forward * 90);
           // Debug.Log(Probability);
        }
        if ((Probability > 16.6) && (Probability <= 33.22))
        {
            gameObject.transform.Rotate(Vector3.forward * 180);
            //Debug.Log(Probability);
        }
        if ((Probability > 33.22) && (Probability <= 49.8))
        {
            gameObject.transform.Rotate(Vector3.forward * 270);
           // Debug.Log(Probability);
        }
        if ((Probability > 49.8) && (Probability <= 66.44))
        {
            gameObject.transform.Rotate(Vector3.forward * 360);
          //  Debug.Log(Probability);
        }
        if ((Probability > 66.44) && (Probability <= 83.04))
        {
            gameObject.transform.Rotate(Vector3.forward * -45);
           // Debug.Log(Probability);
        }
        if ((Probability > 83.04) && (Probability <= 100))
        {
            gameObject.transform.Rotate(Vector3.forward * 45);
           // Debug.Log(Probability);
        }
    }
}


