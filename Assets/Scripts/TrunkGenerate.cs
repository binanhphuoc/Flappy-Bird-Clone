using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TrunkGenerate : MonoBehaviour
{

    public GameObject Trunk;
    public GameObject Bird;
    public float distance;
    public float invokeTime;
    public float randomRange;
    private float k;
    private Vector3 firstTrunkPosition;

    // Use this for initialization
    void Start()
    {
        k = 1;

        firstTrunkPosition = new Vector3(Bird.GetComponent<Transform>().position.x + 14f, Random.Range(-randomRange, randomRange) - 0.1f, 0f);

        Instantiate(Trunk, firstTrunkPosition, new Quaternion(0, 0, 0, 0));

        InvokeRepeating("CreateObstacle", 1f, invokeTime);
    }

    void CreateObstacle()
    {
        Vector3 position = new Vector3();
        position.x = firstTrunkPosition.x + k * distance;
        position.y = -0.1f + Random.Range(-randomRange, randomRange);
        position.z = 0f;
        Instantiate(Trunk, position, new Quaternion(0, 0, 0, 0));
        k++;
    }
}