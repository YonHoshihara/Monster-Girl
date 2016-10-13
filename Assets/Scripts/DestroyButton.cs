using UnityEngine;
using System.Collections;

public class DestroyButton : MonoBehaviour
{
    public float variavely;
    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        if(gameObject.transform.position.y < variavely)
        {
            Destroy(gameObject);
        }
    }
}
