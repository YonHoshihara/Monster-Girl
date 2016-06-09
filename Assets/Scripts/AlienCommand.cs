using UnityEngine;
using System.Collections;

public class AlienCommand : MonoBehaviour {
	//public GameObject alien;
	Rigidbody2D alien;
    GameObject GameController;
    public GameObject Player;
    public float velocity;
	// Use this for initialization
	void Start () {
		alien = gameObject.GetComponent<Rigidbody2D> ();
		alien.velocity = new Vector2 (velocity, 0);
        GameController = GameObject.FindGameObjectWithTag("GameController");
        Player = GameObject.FindGameObjectWithTag("Player"); 
        
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.position.x<= Player.transform.position.x)
        {
            Destroy(gameObject);

        }

	}

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Destroy(this.gameObject);
            GameController.GetComponent<Instantiate>().IntantiateONRandomPoints();

       //     Debug.Log("Prestou");
        }

    }


}
