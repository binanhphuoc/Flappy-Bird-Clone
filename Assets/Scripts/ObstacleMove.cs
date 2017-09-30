using UnityEngine;
using System.Collections;

public class ObstacleMove : MonoBehaviour {

    public float speed;
    public float time;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.up*speed;
        InvokeRepeating("ChangeDirection", 1f, time);
	}
	
    void ChangeDirection()
    {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }
}
