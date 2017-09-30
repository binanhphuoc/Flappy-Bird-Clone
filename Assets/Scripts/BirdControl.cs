using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BirdControl : MonoBehaviour {

    public GameObject Bird;

    public float speed = 2;
    public float maxSpeedUp = 1;
    public float maxSpeedDown = 10;
    public float startSpeedUp = 1;
    public float force = 5;

    public GameObject MenuPanel;
    public GameObject TrunkGenerate;
    public GameObject StartText;
    public GameObject ScoreText;
    public GameObject RestartText;
    public GameObject Infomation;

	// Use this for initialization
	void Start () {
        Bird.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        Bird.GetComponent<Rigidbody2D>().gravityScale = 0;
        TrunkGenerate.SetActive(false);
        ScoreText.SetActive(false);
        StartText.SetActive(false);
        RestartText.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.F1))
        {
            Infomation.SetActive(true);
        }
        else
        {
            Infomation.SetActive(false);
        }

        if (!MenuPanel.activeSelf)
        {
            if (Bird.GetComponent<Rigidbody2D>().gravityScale == 0 && Input.GetKeyDown(KeyCode.UpArrow))
            {
                Bird.GetComponent<Rigidbody2D>().gravityScale = 4;
                TrunkGenerate.SetActive(true);
                ScoreText.SetActive(true);
                StartText.SetActive(false);
            }


            if (!Bird.GetComponent<DieChecking>().getBoolDie())
            {

                Vector2 velocity = Bird.GetComponent<Rigidbody2D>().velocity;

                if (velocity.y > maxSpeedUp)
                {
                    velocity.y = maxSpeedUp;
                    Bird.GetComponent<Rigidbody2D>().velocity = velocity;
                }

                if (velocity.y < -maxSpeedDown)
                {
                    velocity.y = -maxSpeedDown;
                    Bird.GetComponent<Rigidbody2D>().velocity = velocity;
                }

                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (velocity.y <= startSpeedUp)
                    {
                        velocity.y = startSpeedUp;
                        Bird.GetComponent<Rigidbody2D>().velocity = velocity;
                    }
                    Bird.GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
                    Bird.GetComponent<BirdSoundController>().PlaySound(0);
                }
            }
            /*else //If die
            {
                RestartText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    SceneManager.LoadScene("Start", LoadSceneMode.Single);
                }
            }*/
        }
    }

}
