using UnityEngine;
using System.Collections;

public class ScenesManager : MonoBehaviour {

    public GameObject MenuPanel;
    public GameObject Bird;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (Bird.GetComponent<DieChecking>().getBoolDie())
        {
            MenuPanel.SetActive(false);
        }
	}
}
