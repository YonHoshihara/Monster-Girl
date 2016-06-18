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
    
    }

   void Update()
    {


    }

    void addEnemy()
	{
		possibility = Random.Range (1, 100);

		GameObject enemy;

		if (possibility >= 1 && possibility <= 40) {

            enemy = alien as GameObject;
               Instantiate(enemy, new Vector3(enemy.transform.position.x + (Random.Range(1, 3)), enemy.transform.position.y,0),Quaternion.identity);		
		}

		if (possibility > 40 && possibility <= 80) {
			enemy = spaceShip as GameObject;
        
                Instantiate(enemy, new Vector3(enemy.transform.position.x +(Random.Range(1,3)), enemy.transform.position.y, 0), Quaternion.identity);

        }


    }
 


}



