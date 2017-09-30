using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundVolumeFixed : MonoBehaviour {

    private GameObject SoundValuesKeeper;
    public GameObject[] SoundSource;
    public int ChooseSound;

	// Use this for initialization
	void Start () {
        SoundValuesKeeper = GameObject.FindGameObjectWithTag("ValuesKeeper");
        GetComponent<Slider>().value = SoundValuesKeeper.GetComponent<SoundValuesKeeper>().getSoundVolume(ChooseSound);
	}
	
	// Update is called once per frame
	public void OnValueChange(float value)
    {
        SoundValuesKeeper.GetComponent<SoundValuesKeeper>().setSoundVolume(ChooseSound, value);
        int numberSoundSource = SoundSource.Length;
        for (int i = 0; i < numberSoundSource; i++)
        {
            SoundSource[i].GetComponent<AudioSource>().volume = value;
        }
	}
}
