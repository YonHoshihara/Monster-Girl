using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InstantiateController : MonoBehaviour {
    public GameObject[] padrao;
    void Start()
    {
        InvokeRepeating("Instantiates", 0, 0.55f);
    }

    public void Instantiates()
    {
		Instantiate(padrao[Random.Range(0,padrao.Length)]);
    }
}
