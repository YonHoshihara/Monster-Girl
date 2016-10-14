using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {
	public Slider stamina;

	void Update () {
		if (stamina.value <= 0) {
			SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
		}
	}
}
