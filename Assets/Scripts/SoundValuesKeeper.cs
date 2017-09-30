using UnityEngine;
using System.Collections;

public class SoundValuesKeeper : MonoBehaviour {

    public static SoundValuesKeeper Sound;

    public float BackgroundMusic;
    public float SoundEffects;
    public float MainMenuMusic;

	// Use this for initialization
	void Awake() {
        if (Sound == null)
        {
            DontDestroyOnLoad(gameObject);
            Sound = this;
        }
        else if (Sound != this)
        {
            Destroy(gameObject);
        }
	}

    public void setBackgroundMusic(float value)
    {
        BackgroundMusic = value;
    }

    public void setSoundEffects(float value)
    {
        SoundEffects = value;
    }

    public void setSoundVolume(int sound, float value)
    {
        if (sound == 0)
            BackgroundMusic = value;
        else if (sound == 1)
            SoundEffects = value;
        else if (sound == 2)
            MainMenuMusic = value;
    }

    public float getSoundVolume(int sound)
    {
        if (sound == 0)
            return BackgroundMusic;
        else if (sound == 1)
            return SoundEffects;
        else if (sound == 2)
            return MainMenuMusic;
        else
            return 1;
    }

}
