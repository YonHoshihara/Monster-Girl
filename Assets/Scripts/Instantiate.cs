using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Instantiate : MonoBehaviour {

    public GameObject[] SliderToInstantiate;
    public Canvas CanvasInside;
    private GameObject Slider;
    private float Probability;
    
    // Use this for initialization
	void Start() { 
       // InvokeRepeating("IntantiateONRandomPoints", 0, SliderToInstantiate.GetComponent<SliderAtMaximun>().TimeToDoSequence);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

public void IntantiateONRandomPoints()
    {

        Probability = Random.Range(0, 100);

        if ((Probability >= 0) && (Probability <= 33.33))
        {
            Slider = Instantiate(SliderToInstantiate[(int)(Random.Range(0,SliderToInstantiate.Length))], new Vector3(Random.Range(-6.10f, -4.34f),Random.Range(-2.20f,3.5f), 0), Quaternion.identity) as GameObject;
            Slider.gameObject.transform.SetParent(CanvasInside.transform);
        }
        if ((Probability > 33.33) && (Probability <= 66.66))
        {
            Slider = Instantiate(SliderToInstantiate[(int)(Random.Range(0, SliderToInstantiate.Length))], new Vector3(Random.Range(3.93f, 6.1f), Random.Range(-2.20f, 3.5f), 0), Quaternion.identity) as GameObject;
            Slider.gameObject.transform.SetParent(CanvasInside.transform);
        }
        if ((Probability > 66.66) && (Probability <= 100))
        {
            Slider = Instantiate(SliderToInstantiate[(int)(Random.Range(0, SliderToInstantiate.Length))], new Vector3(Random.Range(-4f, 3.93f), Random.Range(2.25f, 3.5f), 0), Quaternion.identity) as GameObject;
            Slider.gameObject.transform.SetParent(CanvasInside.transform);
        }
    }
}


