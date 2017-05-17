using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startText : MonoBehaviour {
    public static GameObject start_text;

    void Start () {
        start_text = GameObject.Find("startText");
	}

    public static void removeStartText() {
        start_text.SetActive(false);
    }
    public static void activeStartText()
    {
        start_text.SetActive(true);
    }
}
