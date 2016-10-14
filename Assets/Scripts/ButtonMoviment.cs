using UnityEngine;
using System.Collections;

public class ButtonMoviment : MonoBehaviour {
    public Vector3[] pos;
    public float speed;
    private ButtonController button;
    Vector3 vector;
    int num;

    // Use this for initialization
    void Start () {
        num = Random.Range(0, 100);
        vector = Probability(num);
		GetComponent<Rigidbody2D>().AddForce((vector - gameObject.transform.position) * speed);
    }
	
	Vector3 Probability(int num)
    {
        if((num>=0) && (num < 16.6))
        {
            return pos[0];
        }
        if ((num >= 16.6) && (num < 32.2))
        {
            return pos[1];
        }
        if ((num >= 32.2) && (num < 49.8))
        {
            return pos[2];
        }
        if ((num >= 49.8) && (num < 66.4))
        {
            return pos[3];
        }
        if ((num >= 66.4) && (num < 83))
        {
            return pos[4];
        }
        else
        {
            return pos[5];
        }   
    }

}
