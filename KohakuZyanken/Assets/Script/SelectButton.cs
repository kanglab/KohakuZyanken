using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectButton : MonoBehaviour {

    public GameObject select10Button;
    public GameObject select20Button;
    public GameObject select30Button;
    public GameObject selectText;
    private bool voice02Flg = false;
    private GameObject refObj;

    // Use this for initialization
    void Start ()
    {
        select10Button = GameObject.Find("select10Button");
        select20Button = GameObject.Find("select20Button");
        select30Button = GameObject.Find("select30Button");
        selectText = GameObject.Find("selectText");
        refObj = GameObject.Find("unitychan");
        initButton();
    }
	
	// Update is called once per frame
	void Update () {
		if (UnityChanChangeMotion.animator_kohaku.GetBool("pushStartButton"))
        {
            StartCoroutine(setButton(2.8f));
        }
	}
    private void initButton()
    {
        select10Button.SetActive(false);
        select20Button.SetActive(false);
        select30Button.SetActive(false);
        selectText.SetActive(false);
    }

    /// <summary>
    /// 渡された処理を指定時間後に実行する。
    /// </summary>
    /// <param name="waitTime"></param>
    /// <returns></returns>
    private IEnumerator setButton(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        //Invoke("setButton02", 3.0f);
        select10Button.SetActive(true);
        select20Button.SetActive(true);
        select30Button.SetActive(true);
        selectText.SetActive(true);
        if (!voice02Flg)
        {
            // UnityChanVoicePlayer.voicePlay02();
            UnityChanVoicePlayer unityChanVoice = refObj.GetComponent<UnityChanVoicePlayer>();
            unityChanVoice.voicePlay02();
            voice02Flg = true;
        }
        UnityChanChangeMotion.animator_kohaku.SetBool("pushStartButton", false);
    }
    private void setButton02()
    {
        
    }
}
