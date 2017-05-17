using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCountButton : MonoBehaviour {

    public static int countZyanken;         //ジャンケン回数(外部参照用)
    private GameObject select10Button;
    private GameObject select20Button;
    private GameObject select30Button;
    private GameObject selectText;

    void Start()
    {
        select10Button = GameObject.Find("select10Button");
        select20Button = GameObject.Find("select20Button");
        select30Button = GameObject.Find("select30Button");
        selectText = GameObject.Find("selectText");
    }

    /// <summary>
    /// クリックイベント(ジャンケンの回数決定)および次の処理実行 ほとんどキーフレームアニメーション
    /// </summary>
    /// <param name="number"></param>
    public void OnClick01(int number)
    {
        StartCoroutine(setValAndRemoveButton(0.5f, number));
        Invoke("readyStart", 2.0f);
        Invoke("readyStart01", 6.0f);
        Invoke("readyStart02", 7.0f);
        Invoke("readyStart03", 8.0f);
        Invoke("readyStart04", 9.0f);
    }

    private IEnumerator setValAndRemoveButton(float waitTime, int number)
    {
        yield return new WaitForSeconds(waitTime);
        switch (number)
        {
            case 0:
                countZyanken = 10;
                Debug.Log(countZyanken.ToString());
                break;
            case 1:
                countZyanken = 20;
                Debug.Log(countZyanken.ToString());
                break;
            case 2:
                countZyanken = 30;
                Debug.Log(countZyanken.ToString());
                break;
        }
        removeButton();
        UnityChanVoicePlayer.voicePlay04();
    }

    private void removeButton()
    {
        select10Button.SetActive(false);
        select20Button.SetActive(false);
        select30Button.SetActive(false);
        selectText.SetActive(false);
    }

    private void readyStart()
    {
        Debug.Log("ready");
        UnityChanChangeMotion.changeMotion02_on();
        UnityChanVoicePlayer.voicePlay03();
    }
    private void readyStart01()
    {
        UnityChanChangeMotion.changeMotion02_off();
        CountText.enableText();
        CountText.count_text = "3";
        UnityChanVoicePlayer.voicePlay05();         //スリー
    }
    private void readyStart02()
    {
        CountText.count_text = "2";
        UnityChanVoicePlayer.voicePlay06();         //ツー
    }
    private void readyStart03()
    {
        CountText.count_text = "1";
        UnityChanVoicePlayer.voicePlay07();         //ワン
    }
    private void readyStart04()
    {
        CountText.count_text = "Start !";
        UnityChanVoicePlayer.voicePlay08();         //スタート
        Zyanken.Main();                             //ジャンケン開始
    }
}
