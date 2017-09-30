using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingsMenuController : MonoBehaviour {

    public GameObject SettingsMain;
    public GameObject VideoSettings;
    public GameObject AudioSettings;

    private int[] newResolution;

    private bool FullScreen;
    private int newLevel;

    private 

    //public GameObject AudioSettings;

	// Use this for initialization
	void Start () {
        SettingsMain.SetActive(true);
        VideoSettings.SetActive(false);
        AudioSettings.SetActive(false);
        newResolution = new int[2];
        newResolution[0] = Screen.width;
        newResolution[1] = Screen.height;
        FullScreen = Screen.fullScreen;
        newLevel = QualitySettings.GetQualityLevel();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnVideoClick()
    {
        SettingsMain.SetActive(false);
        VideoSettings.SetActive(true);
    }

    public void OnAudioClick()
    {
        SettingsMain.SetActive(false);
        AudioSettings.SetActive(true);
    }

    // START Video Settings Menu Controller

    public void Resolution(int option)
    {
        if (option == 0)
        {
            newResolution[0] = 640;
            newResolution[1] = 480;
        }
        if (option == 1)
        {
            newResolution[0] = 800;
            newResolution[1] = 600;
        }
        if (option == 2)
        {
            newResolution[0] = 1024;
            newResolution[1] = 768;
        }
        if (option == 3)
        {
            newResolution[0] = 1280;
            newResolution[1] = 720;
        }
        if (option == 4)
        {
            newResolution[0] = 1280;
            newResolution[1] = 768;
        }
        if (option == 5)
        {
            newResolution[0] = 1360;
            newResolution[1] = 768;
        }
    }

    public void GraphicsQuality(int level)
    {
        newLevel = level+1;
    }

    public void WindowedToggle(bool isOn)
    {
        if (isOn)
        {
            FullScreen = false;
        }
        else
        {
            FullScreen = true;
        }
    }

    public void Apply()
    {
        //Windowed Option
        if (Screen.fullScreen && !FullScreen)
        {
            Screen.SetResolution(Screen.width, Screen.height, FullScreen);
        }
        if (!Screen.fullScreen && FullScreen)
        {
            Screen.SetResolution(Screen.width, Screen.height, FullScreen);
        }

        // Set Resolution
        if (newResolution[0]!=Screen.width || newResolution[1] != Screen.height)
        {
            Screen.SetResolution(newResolution[0], newResolution[1], Screen.fullScreen);
        }

        if (newLevel != QualitySettings.GetQualityLevel())
        {
            QualitySettings.SetQualityLevel(newLevel);
        }
    }

    public void Back()
    {
        SettingsMain.SetActive(true);
        VideoSettings.SetActive(false);
        AudioSettings.SetActive(false);
    }

    // END Video Settings Controller

}
