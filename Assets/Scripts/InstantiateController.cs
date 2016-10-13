using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InstantiateController : MonoBehaviour {
    public GameObject padrao;
    void Start()
    {
        InvokeRepeating("Instantiates", 0, 1);
    }

    public void Instantiates()
    {
        Instantiate(padrao);
    }
}
