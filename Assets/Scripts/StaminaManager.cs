using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StaminaManager : MonoBehaviour {
	public Slider stamina;
	// Use this for initialization
	void Start () {
		stamina.value = 100;
	}

	public void MissOrBad(string mb){
		if (mb == "Miss") {
			stamina.value -= 15;
		} else {
			stamina.value -= 25;
		}
	}
}
