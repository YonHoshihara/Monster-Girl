using UnityEngine;
using System.Collections;

public class AlienIA : MonoBehaviour
{
    public GameObject alien;
    public GameObject spaceShip;
    private float spawnTime = 3;
    private int possibility;
    private float [] Music;
    private int EnemyQdt;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("addEnemy", 1, spawnTime);
        Music = GetComponent<Audio2>().MusicAnaliseVector();
    }

    void addEnemy()
	{
		possibility = Random.Range (1, 100);

		GameObject enemy;

		if (possibility >= 1 && possibility <= 40) {
			enemy = alien as GameObject;
            for (int i=0;i< EnemyQdt;i++)
            {
                Instantiate(enemy);


            }
          
					
		}

		if (possibility > 40 && possibility <= 80) {
			enemy = spaceShip as GameObject;
            Instantiate(enemy);
		
		}
	}
}



