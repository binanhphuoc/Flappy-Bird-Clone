using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ObstacleGenerate : MonoBehaviour {

    public GameObject gameobject;
    public float distance;
    public float invokeTime;
    public float randomRange;
    private float k;

	// Use this for initialization
	void Start () {
        k = 1;
        InvokeRepeating("CreateObstacle", 1f, invokeTime);
	}
	
	void CreateObstacle()
    {
        Vector3 position = new Vector3();
        position.x = gameobject.transform.position.x + k*distance;
        position.y = gameobject.transform.position.y + Random.Range(-randomRange,randomRange);
        position.z = gameobject.transform.position.z;
        Instantiate(gameobject,position,new Quaternion(0,0,0,0));
        k++;
    }
}
