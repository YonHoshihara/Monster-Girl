using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AlienCommand : MonoBehaviour {
	//public GameObject alien;
	Rigidbody2D alien;
    public Animator PlayerAnimator;
    public AnimationClip Jump;
    public AnimationClip Atack;
    GameObject GameController;
    public GameObject Player;
    public float velocity;
	// Use this for initialization
	void Start () {
		alien = gameObject.GetComponent<Rigidbody2D> ();
		alien.velocity = new Vector2 (velocity, 0);
        GameController = GameObject.FindGameObjectWithTag("GameController");
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerAnimator = Player.GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.position.x<= Player.transform.position.x-3)
        {
            Destroy(gameObject);

        }

	}

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            bool CanInstantiate = true;


            if (CanInstantiate)
            {
                if (this.gameObject.name == "Alien(Clone)")
                {
                    StartCoroutine(Waid(0.1f));
                    PlayerAnimator.SetTrigger("atack");
                    GameController.GetComponent<Instantiate>().IntantiateONRandomPoints();
                    CanInstantiate = false;

                }

                if (this.gameObject.name == "SpaceShip(Clone)")
                {
                    StartCoroutine(Waid(0.1f));
                    PlayerAnimator.SetTrigger("Jump");
                    GameController.GetComponent<Instantiate>().IntantiateONRandomPoints();
                    CanInstantiate = false;

                    //   GameController.GetComponent<Instantiate>().IntantiateONRandomPoints();

                }


            }

        }

    }

    IEnumerator Waid(float time)
    {
      //  Debug.Log("Prestou");
        yield return new WaitForSeconds(time);
        gameObject.GetComponent<Animator>().SetTrigger("Explosion");
      //  Destroy(gameObject);



    }

}
