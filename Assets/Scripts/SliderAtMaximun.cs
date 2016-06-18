using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SliderAtMaximun : MonoBehaviour {
    public bool ISMaximun;
    private Slider slider;
    private float SliderValue;
    public float TimeToDoSequence;
    private GameObject[] Enemys;
    private int destroyed;
//    public Slider Instantiator;
void Start()
    {
        slider = this.gameObject.GetComponent<Slider>();
        ISMaximun = false;
        InvokeRepeating("Redutor",0,1f);
        Enemys = GameObject.FindGameObjectsWithTag("Enemy");
        destroyed = Enemys.Length;
      //  StartCoroutine(DestroyObject(TimeToDoSequence + 0.2f));

    }

    void FixedUpdate()
    {
     SliderValue = slider.value;
      
        if ((SliderValue >= slider.maxValue)&&(TimeToDoSequence>0))
        {
           ISMaximun = true;
           StartCoroutine(DestroyObject(0.1f)); 
        }
        else
        {
           ISMaximun = false;
        }

        if ((!ISMaximun)&&(TimeToDoSequence<=0))
        {
            StartCoroutine(DestroyObject(0.1f));

            UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
        }
        if( (ISMaximun)&&(TimeToDoSequence>0))
        {
          //  Debug.Log("Pretou");
            Destroy(Enemys[0].gameObject);
            Destroy(slider);
         //   Debug.Log("Prestou2");
         

        }


    }

public void Redutor()
    {
        TimeToDoSequence--;
        if (TimeToDoSequence<=0)
        {
            CancelInvoke();
        }
    }



IEnumerator DestroyObject(float TimeToDestroy)
    {
        yield return new WaitForSeconds(TimeToDestroy);
        Destroy(gameObject);
    }



}
	

