using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountText : MonoBehaviour {

    public static GameObject countText;
    public Text countTextString;
    public static string count_text;

	// Use this for initialization
	void Start () {
        countText = GameObject.Find("countText");
        count_text = "";
        countText.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        countTextString.text = count_text;
	}

    public static void enableText()
    {
        countText.SetActive(true);
    }
    public static void disableText()
    {
        countText.SetActive(false);
    }
}
