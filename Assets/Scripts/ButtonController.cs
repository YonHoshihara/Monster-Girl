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

    void OnTriggerEnter2D(Collider2D other)
    {
        menina = true;
        if (menino)
        {
            menino = false;
            Debug.Log((other.gameObject.transform.position - gameObject.transform.position).magnitude);
            if ((other.gameObject.transform.position - gameObject.transform.position).magnitude >= distancia)
            {
                Debug.Log("Great!");
            }else
            {
                Debug.Log("Perfect");
            }
            Destroy(other);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        menina = false;
        if (!menino){
            Debug.Log("Miss");
        }
        
    }

    void OnMouseDown()
    {
        if (menina) {
            menino = true;
        }
        
    }
}
