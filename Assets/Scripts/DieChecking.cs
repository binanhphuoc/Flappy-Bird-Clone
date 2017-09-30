using UnityEngine;
using System.Collections;

public class DieChecking : MonoBehaviour {

    private bool die;
    public GameObject SoundDie;

	// Use this for initialization
	void Start () {
        die = false;
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ground") || coll.gameObject.CompareTag("Trunk"))
        {
            SoundDie.GetComponent<BirdSoundController>().PlaySound(0);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            die = true;
        }
    }

    public bool getBoolDie()
    {
        return die;
    }
}
