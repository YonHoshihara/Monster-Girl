using UnityEngine;
using System.Collections;

public class Background_Scroll : MonoBehaviour {
    public GameObject BGPrefab;
    public Vector2 initialForce;
	// Use this for initialization
	void Start () {
        BGPrefab = GameObject.FindGameObjectWithTag("BGBase");
        gameObject.GetComponent<Rigidbody2D>().AddForce(initialForce);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnBecameInvisible()
    {
        GameObject BG = Instantiate(BGPrefab);
        BG.SetActive(true);
        BG.GetComponent<SpriteRenderer>().enabled = true;
        BG.GetComponent <Background_Scroll>().enabled = true;
        Destroy(gameObject);
    }
}
