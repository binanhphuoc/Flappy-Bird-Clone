using UnityEngine;
using System.Collections;

public class BirdSoundController : MonoBehaviour {

    public AudioClip[] audioClip;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	
	}

    public void PlaySound(int clip)
    {
        GetComponent<AudioSource>().clip = audioClip[clip];
        GetComponent<AudioSource>().Play();
    }
}
