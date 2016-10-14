using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	public GameObject Score;
	int score;
	// Use this for initialization
	void Start () {
		score = 0;
		Score.GetComponent<Text>().text = "Score: " + score.ToString();
	}

	public void addScore(int ScoreToAdd){
		score = score + ScoreToAdd;
		Score.GetComponent<Text>().text = "Score: " + score.ToString();
	}
}
