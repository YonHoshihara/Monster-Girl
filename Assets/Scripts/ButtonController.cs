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

    void Start()
    {
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
			Debug.Log ("Prestou");
			menino = false;
           
            if ((other.gameObject.transform.position - gameObject.transform.position).magnitude >= distancia)
            {
                Debug.Log("Great!");
				Destroy (other.gameObject);
				feedback.SetActive(true);
				Invoke ("Deactivate", 0.5f);
				feedback.GetComponent<Text>().text = "Great!";
				scoreManager.addScore (scoreGreat);
				menina = false;
            }else
            {
				if((other.gameObject.transform.position - gameObject.transform.position).magnitude < distancia)
					Debug.Log("Perfect");
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
			Debug.Log (gameObject);
			menino = true;

		} else {
			Debug.Log ("Bad");
			feedback.SetActive(true);
			Invoke ("Deactivate", 0.5f);
			feedback.GetComponent<Text>().text = "Bad!";
			stamina.MissOrBad ("Bad");
		}
    }

	void Deactivate(){
		feedback.SetActive (false);
	}
}
