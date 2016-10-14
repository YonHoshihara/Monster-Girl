using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {
    public bool menino,menina;
    public float distancia;
    void Start()
    {
        menino = false;
        menina = false;
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
				//Debug.Log ("Prestou");
				menina = false;
            }else
            {
				if((other.gameObject.transform.position - gameObject.transform.position).magnitude < distancia)
					Debug.Log("Perfect");
					Destroy (other.gameObject);
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
			menina = false;
        }
        
    }

    void OnMouseDown()
    {
        if (menina) {
			Debug.Log (gameObject);
			menino = true;

        }
        
    }
}
