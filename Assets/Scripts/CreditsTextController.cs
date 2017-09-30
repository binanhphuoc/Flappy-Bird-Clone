using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreditsTextController : MonoBehaviour {

    public GameObject CreditsTextScroll;

    void Start()
    {
        CreditsTextScroll.SetActive(false);
    }

    void OnMouseDown()
    {
        CreditsTextScroll.SetActive(true);
    }

}
