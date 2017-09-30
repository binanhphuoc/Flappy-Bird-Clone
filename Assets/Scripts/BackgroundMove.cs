using UnityEngine;
using System.Collections;

public class BackgroundMove : MonoBehaviour {

    public GameObject Bird;
    public float v;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * v;
	}

    void Update()
    {
        if (Bird.GetComponent<DieChecking>().getBoolDie())
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
	
}
