using UnityEngine;
using System.Collections;

public class ButtonControllerTime : MonoBehaviour {
    public bool Pressed;
    public float TimeToDoSequence;
    private GameObject[] Enemys;
    private int destroyed;
    


    void Start () {

        Pressed = false;
        InvokeRepeating("Redutor", 0, 1f);
        Enemys = GameObject.FindGameObjectsWithTag("Enemy");
        destroyed = Enemys.Length;
       // StartCoroutine(DestroyObject(TimeToDoSequence+ 0.2f));

    }
	
	void Update () {
        //  Debug.Log(Pressed);
    

        if ((TimeToDoSequence<=0)&&(Pressed))
        {
            Debug.Log("Prestou");
            Destroy(Enemys[0].gameObject);
            Destroy(gameObject);
            
        }
        if ((TimeToDoSequence<=0)&&(!Pressed))
        {
            Debug.Log("Game over porra");
            Time.timeScale = 0;
            Destroy(gameObject);
          
        }
    }

    public void Redutor()
    {
        TimeToDoSequence--;
        if (TimeToDoSequence <= 0)
        {
            CancelInvoke();
        }
    }

    IEnumerator DestroyObject(float TimeToDestroy)
    {
        yield return new WaitForSeconds(TimeToDestroy);
        Destroy(gameObject);
    }

    public void SetPressed()
    {
        Pressed = true;
        Destroy(Enemys[0].gameObject);
        StartCoroutine(DestroyObject(0.1f));
    }

}
