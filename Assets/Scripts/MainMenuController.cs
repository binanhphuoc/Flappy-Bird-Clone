using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

    public KeepingScore Score;
    public GameObject MainMenuHolder;
    public GameObject SettingsMenuHolder;
    public GameObject CreditsScroll;
    public GameObject OptionsMenuHolder;

    public GameObject SoundBackground;
    public GameObject[] SoundEffects;

    private GameObject SoundValuesKeeper;

    public GameObject StartText;


	void Start () {
        SoundValuesKeeper = GameObject.FindGameObjectWithTag("ValuesKeeper");
        CreditsScroll.SetActive(false);
        MainMenuHolder.SetActive(true);
        SettingsMenuHolder.SetActive(false);
        
        MainMenuHolder.GetComponent<BirdSoundController>().PlaySound(0);
        MainMenuHolder.GetComponent<AudioSource>().volume = SoundValuesKeeper.GetComponent<SoundValuesKeeper>().getSoundVolume(2);

    }
	
	public void ShowCredits()
    {
        if (!CreditsScroll.activeSelf)
        {
            CreditsScroll.SetActive(true);
            SettingsMenuHolder.SetActive(false);
        }
        else
        {
            CreditsScroll.SetActive(false);
        }
	}

    public void StartGame()
    {
        MainMenuHolder.SetActive(false);
        StartText.SetActive(true);
        SoundBackground.GetComponent<AudioSource>().volume = SoundValuesKeeper.GetComponent<SoundValuesKeeper>().getSoundVolume(0);
        int NumSoundEffects = SoundEffects.Length;
        for (int i=0;i<NumSoundEffects;i++)
        {
            SoundEffects[i].GetComponent<AudioSource>().volume = SoundValuesKeeper.GetComponent<SoundValuesKeeper>().getSoundVolume(1);
        }

        SoundBackground.GetComponent<BirdSoundController>().PlaySound(0);

    }

    public void Settings()
    {
        if (SettingsMenuHolder.activeSelf)
        {
            SettingsMenuHolder.SetActive(false);

        }
        else
        {
            SettingsMenuHolder.SetActive(true);
            CreditsScroll.SetActive(false);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
