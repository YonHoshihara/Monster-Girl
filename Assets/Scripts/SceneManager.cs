using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {

    public void LoadLevel(string scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene, LoadSceneMode.Single);
        Debug.Log("game start!");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
