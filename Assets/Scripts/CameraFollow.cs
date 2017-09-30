using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    void Start()
    {
        transform.position = new Vector3(target.position.x,
                                        transform.position.y,
                                        transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(target.position.x,
                                        transform.position.y,
                                        transform.position.z);
	}
}
