using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {
    public bool menino,menina;
    public float distancia;
	private ScoreManager scoreManager;
	private StaminaManager stamina;
	public int scoreGreat, scorePerfect;
	public GameObject feedback;
	private SoundController sound;
	[SerializeField]private Animator MonsterGirl;
	[SerializeField]private Animator Enemy;
	public GameObject EnemyToInstantiate;
	//public GameObject AlienCaralhosao;
	public static int EnemyLife = 0;
	public static int cont;
    void Start()
    {

		Enemy = GameObject.FindGameObjectWithTag ("Enemy").GetComponent<Animator>();
		feedback.SetActive(true);
		feedback.GetComponent<Text>().text = "GO!";
		scoreManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreManager>();
		stamina = GameObject.FindGameObjectWithTag("GameController").GetComponent<StaminaManager>();
        menino = false;
        menina = false;
		sound = GameObject.FindGameObjectWithTag ("GameController").GetComponent<SoundController> ();
    }


		
    void OnTriggerStay2D(Collider2D other)
    {
        menina = true;
        if (menino)
        {
			//Debug.Log ("Prestou");
			menino = false;
           
            if ((other.gameObject.transform.position - gameObject.transform.position).magnitude >= distancia)
            {
				
				Debug.Log("Great!");
				Debug.Log (Enemy);
				MonsterGirl.SetTrigger ("atack");
				Enemy.SetTrigger ("Damage");
				Destroy (other.gameObject);
				feedback.SetActive(true);
				Invoke ("Deactivate", 0.5f);
				feedback.GetComponent<Text>().text = "Great!";
				scoreManager.addScore (scoreGreat);
				menina = false;
            }else
            {
				if((other.gameObject.transform.position - gameObject.transform.position).magnitude < distancia)


					//Debug.Log("Perfect");
					
					MonsterGirl.SetTrigger ("atack");
					Enemy.SetTrigger ("Damage");
					Destroy (other.gameObject);
					feedback.SetActive(true);
					Invoke ("Deactivate", 0.5f);
					feedback.GetComponent<Text>().text = "Perfect!";
					scoreManager.addScore (scorePerfect);
					menina = false;

            }
		
			Destroy (other.gameObject);
			menina = false;

        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        
        if (!menino){
			Enemy.SetTrigger ("Atack");
			MonsterGirl.SetTrigger ("Damage");

			Debug.Log("Miss");
			feedback.SetActive(true);
			Invoke ("Deactivate", 0.5f);
			feedback.GetComponent<Text>().text = "Miss!";
			stamina.MissOrBad ("Miss");
			menina = false;
        }
        
    }

    void OnMouseDown()
    {
		sound.PlayTapSound ();
		if (menina) {
			//Debug.Log (gameObject);
			menino = true;

		} else {
			//Debug.Log ("Bad");
			feedback.SetActive(true);
			Invoke ("Deactivate", 0.5f);
			feedback.GetComponent<Text>().text = "Bad!";
			Enemy.SetTrigger ("Atack");
			MonsterGirl.SetTrigger ("Damage");
			stamina.MissOrBad ("Bad");
		}
    }

	void Deactivate(){
		feedback.SetActive (false);
	}
	IEnumerator InstantiateEnemy(GameObject Objeto){


		yield return new WaitForSeconds (0.1f);
		Instantiate (Objeto);
		Enemy = Objeto.GetComponent<Animator>();
	}


}
