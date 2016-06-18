using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
   

    }
	
	void Update () {
       
         gameObject.GetComponentInChildren<Text>().text = TimeToDoSequence.ToString();
       

        if ((TimeToDoSequence<=0)&&(Pressed))
        {
            Debug.Log("Prestou");
            Destroy(gameObject);     
        }
        if ((TimeToDoSequence<=0)&&(!Pressed))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game", LoadSceneMode.Single);
            GetComponent<Animator>().SetTrigger("Die");
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
       // Destroy(Enemys[0].gameObject);
        GetComponent<Animator>().SetTrigger("Die");
        StartCoroutine(DestroyObject(0.1f));
    }

}
