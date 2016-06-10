using UnityEngine;
using System.Collections;

public class AlienIA : MonoBehaviour
{
    public GameObject alien;
    public GameObject spaceShip;
    public float spawnTime ;
    private int possibility;
    private float [] Music;
    private int EnemyQdt;
    private int musicTime,cont = 0;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("addEnemy", 1, spawnTime);
        Music = GetComponent<Audio2>().MusicAnaliseVector();

    }

   void Update()
    {
     //   Debug.Log(GetComponent<AudioSource>().time);

    }

    void addEnemy()
	{
		possibility = Random.Range (1, 100);

		GameObject enemy;

		if (possibility >= 1 && possibility <= 40) {
			enemy = alien as GameObject;
            EnemyQdt = (int)Music[(int)(GetComponent<AudioSource>().time)+1]/5;
          //  Debug.Log(EnemyQdt);
           // Debug.Log(Music[(int)(GetComponent<AudioSource>().time)]/5);
            if (EnemyQdt<=0)
            {
                EnemyQdt = 1;

            }
            if (EnemyQdt>=3)
            {
                EnemyQdt = 3;

            }
           // Debug.Log(Time.time);
            Debug.Log(GetComponent<AudioSource>().time);
            for (int i=0;i< EnemyQdt;i++)
            {
            //    Instantiate(enemy, new Vector3(enemy.transform.position.x + i+5,enemy.transform.position.y,0),Quaternion.identity);


            }
          
					
		}

		if (possibility > 40 && possibility <= 80) {
			enemy = spaceShip as GameObject;
            EnemyQdt = (int)Music[(int)(GetComponent<AudioSource>().time) +1] / 5;
        //    Debug.Log(EnemyQdt);
          //  Debug.Log(Music[(int)(GetComponent<AudioSource>().time)] / 5);
            if (EnemyQdt <= 0)
            {
                EnemyQdt = 1;

            }
            if (EnemyQdt >= 3)
            {
                EnemyQdt = 3;

            }

           // Debug.Log(Time.time);
            Debug.Log(GetComponent<AudioSource>().time);
            for (int i = 0; i < EnemyQdt; i++)
            {
               // Instantiate(enemy, new Vector3(enemy.transform.position.x + i+5, enemy.transform.position.y, 0), Quaternion.identity);


            }


        }


    }
 


}



