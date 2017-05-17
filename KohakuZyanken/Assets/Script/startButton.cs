using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      //SceneManager

public class startButton : MonoBehaviour {

    public static GameObject start_button;
    void Start()
    {
        start_button = GameObject.Find("startButton");
    }
    public void buttonPush()
    {
        Debug.Log("Start Button Push !!");
        removeStartButton();
        startText.removeStartText();
        UnityChanChangeMotion.changeMotion01();
        UnityChanVoicePlayer.voicePlay01();             //私と一緒にゲームしよう
        //SceneManager.LoadScene("Zyanken", LoadSceneMode.Additive);
        

        //Destroy(start_button);
    }
    public static void removeStartButton()
    {
        start_button.SetActive(false);
    }
    public static void activeStartButton()
    {
        start_button.SetActive(true);
    }
}
