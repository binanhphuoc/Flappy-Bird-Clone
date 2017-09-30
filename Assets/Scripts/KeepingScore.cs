using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeepingScore : MonoBehaviour {

    private int Score;
    private int HighScore;
    public Text scoreText;
    public Text GameOverText;
    public Text RestartText;
    public Text StartText;

    public GameObject SoundObstacles;

	// Use this for initialization
	void Start () {
        Score = 0;
        scoreText.text = "Score: " +  Score;
        StartText.text = "Press [UpArrow] to start";
        GameOverText.text = "";
        RestartText.text = "";
        HighScore = PlayerPrefs.GetInt("High Score");
    }
	
    void Update()
    {
        scoreText.text = "Score: " + Score;
        if (this.GetComponent<DieChecking>().getBoolDie())
        {
            GameOverText.text = "Game Over";
            RestartText.text = "Press [Enter] to restart";
            scoreText.rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
            scoreText.rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
            scoreText.rectTransform.anchoredPosition = Vector2.up*35;
            scoreText.fontSize = 40;
        }
    }

	// Update is called once per frame

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("TrunkSpace"))
        {
            SoundObstacles.GetComponent<BirdSoundController>().PlaySound(0);
            Score += 1;
        }
    }

    public int getScore()
    {
        return Score;
    }

}
