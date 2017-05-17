using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zyanken : MonoBehaviour {

    //自分の手のボタンインスタンス
    public GameObject guButton;
    public GameObject tyokiButton;
    public GameObject paButton;
    public static bool startFlg;    //trueになったらジャンケン開始
    private bool syncFlg;           //非同期の帳尻合わせようフラグ
    private int count;              //何回やったか
    public int myState;             //自分の手      0:グー, 1:チョキ, 2:パー
    private int unityChanState;     //Unityちゃんの手
    //試合結果状態
    private enum WinState
    {
        win,
        lose,
        draw
    }
    private WinState winstate;


    // Use this for initialization
    void Start () {
        guButton = GameObject.Find("GuButton");
        tyokiButton = GameObject.Find("TyokiButton");
        paButton = GameObject.Find("PaButton");
        guButton.SetActive(false);
        paButton.SetActive(false);
        tyokiButton.SetActive(false);
        count = 0;
        startFlg = false;
        syncFlg = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (startFlg && (count != SelectCountButton.countZyanken)) mainZyanken();
	}

    private void setZyankenButton()
    {
        guButton.SetActive(true);
        paButton.SetActive(true);
        tyokiButton.SetActive(true);
    }
    private void resetZyankenButton()
    {
        guButton.SetActive(false);
        paButton.SetActive(false);
        tyokiButton.SetActive(false);
    }

    /// <summary>
    /// ループおよび例のごとくキーフレームの塊
    /// </summary>
    private void mainZyanken()
    {
        Invoke("zyankenEffect00", 1.0f);
        Invoke("zyankenEffect01", 2.0f);
        Invoke("zyankenEffect02", 3.3f);
        Invoke("zyankenEffect03", 4.8f);
        Invoke("zyankenEffect04", 7.0f);
        count++;
        startFlg = false;
    }

    /// <summary>
    /// 画面のクリア
    /// </summary>
    private void zyankenEffect00()
    {
        CountText.disableText();
    }

    /// <summary>
    ///　ジャンケン音声およびプレハブ表示系その1
    /// </summary>
    private void zyankenEffect01()
    {
        setZyankenButton();
        UnityChanVoicePlayer.voicePlay09();
    }

    /// <summary>
    /// ジャンケンアルゴリズムとか音声とかいろいろ呼び出している
    /// </summary>
    private void zyankenEffect02()
    {
        unityChanHand();        //Unityちゃんの手の内更新
        switch (unityChanState)
        {
            case 0:
                ZyankenUnityChanImageControler.setGuImage();
                UnityChanVoicePlayer.voicePlay11();     //「グー」
                break;
            case 1:
                ZyankenUnityChanImageControler.setTyokiImage();
                UnityChanVoicePlayer.voicePlay13();     //「チョキ」
                break;
            case 2:
                ZyankenUnityChanImageControler.setPaImage();
                UnityChanVoicePlayer.voicePlay12();     //「パー」
                break;
        }
    }

    private void zyankenEffect03()
    {
        resetZyankenButton();
        judgeZyanken();
        ZyankenUnityChanImageControler.resetZyankenImage();
        switch (winstate)
        {
            case WinState.win:
                UnityChanChangeMotion.changeMotion03_on();
                UnityChanVoicePlayer.voicePlay16();
                break;
            case WinState.lose:
                UnityChanChangeMotion.changeMotion04_on();
                UnityChanVoicePlayer.voicePlay14();
                break;
            case WinState.draw:
                UnityChanVoicePlayer.voicePlay15();
                break;
        }
        Invoke("backIdleMotion", 2.5f);
    }

    private void zyankenEffect04()
    {
        startFlg = true;
    }

    private void backIdleMotion()
    {
        UnityChanChangeMotion.changeMotion03_off();
        UnityChanChangeMotion.changeMotion04_off();
    }

    /// <summary>
    /// ジャンケンの勝ち負け判定
    /// </summary>
    private void judgeZyanken()
    {
        int judgeState = (myState - unityChanState + 3) % 3;
        switch (judgeState)
        {
            case 0:
                winstate = WinState.draw;
                break;
            case 1:
                winstate = WinState.lose;
                break;
            case 2:
                winstate = WinState.win;
                break;
        }
    }

    /// <summary>
    /// Unityちゃんの手を決めるランダム関数(先生ＮＮに治してオナシャス！)
    /// </summary>
    private void unityChanHand()
    {
        unityChanState = Random.Range(0, 3);
    }

    public void OnClick(int number)
    {
        switch (number)
        {
            case 0:
                myState = number;
                break;
            case 1:
                myState = number;
                break;
            case 2:
                myState = number;
                break;
        }
    }

    /// <summary>
    /// ここから実行
    /// </summary>
    public static void Main()
    {
        startFlg = true;
    }
}
