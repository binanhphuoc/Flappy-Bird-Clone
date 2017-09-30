using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverMenuController : MonoBehaviour {

    public GameObject Bird;
    public GameObject GameOverMenu;

    void Start()
    {
        GameOverMenu.SetActive(false);
    }

    void Update()
    {
        if (Bird.GetComponent<DieChecking>().getBoolDie())
        {
            GameOverMenu.SetActive(true);
        }
    }

	public void PlayAgain ()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
	
	// Update is called once per frame
	public void MainMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
