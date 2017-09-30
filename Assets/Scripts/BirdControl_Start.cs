using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BirdControl_Start : MonoBehaviour {

    public GameObject Bird;

    public float speed = 2;
    public float maxSpeedUp = 1;
    public float maxSpeedDown = 10;
    public float startSpeedUp = 1;
    public float force = 5;

    public GameObject TrunkGenerate;
    public GameObject StartText;
    public GameObject ScoreText;
    public GameObject RestartText;
    public GameObject SoundBackground;
    public GameObject[] SoundEffects;
    private GameObject SoundValuesKeeper;

	// Use this for initialization
	void Start () {
        Bird.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        Bird.GetComponent<Rigidbody2D>().gravityScale = 0;
        TrunkGenerate.SetActive(false);
        ScoreText.SetActive(false);
        StartText.SetActive(true);
        RestartText.SetActive(false);

        SoundValuesKeeper = GameObject.FindGameObjectWithTag("ValuesKeeper");
        int NumSoundEffects = SoundEffects.Length;
        for (int i=0;i<NumSoundEffects;i++)
        {
            SoundEffects[i].GetComponent<AudioSource>().volume = SoundValuesKeeper.GetComponent<SoundValuesKeeper>().getSoundVolume(1);
        }
        SoundBackground.GetComponent<AudioSource>().volume = SoundValuesKeeper.GetComponent<SoundValuesKeeper>().getSoundVolume(0);
        SoundBackground.GetComponent<BirdSoundController>().PlaySound(0);
    }
	
	// Update is called once per frame
	void Update () {
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
                    Bird.GetComponent<BirdSoundController>().PlaySound(0);
                    Bird.GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
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
