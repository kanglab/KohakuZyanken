using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityChanLipSync))]
public class UnityChanVoicePlayer : MonoBehaviour {

    private static UnityChanLipSync lipSync_;
    public static AudioClip audioClip;
    public int index = 0;
    static Animator animator_kohaku;

    // Use this for initialization
    void Start () {
        lipSync_ = GetComponent<UnityChanLipSync>();
        animator_kohaku = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

	}

    public static void voicePlay01()
    {
        lipSync_.Play("voice/univ1088");        //「私と一緒にゲームしよっ！」
    }
    public static void voicePlay02()
    {
        lipSync_.Play("voice/univ1109");        //「どれを選ぶ？」
    }
    public static void voicePlay03()
    {
        lipSync_.Play("voice/univ1015");        //「えー…おほん（咳払いのアドリブ）　アーユーレディ？」
    }
    public static void voicePlay04()
    {
        lipSync_.Play("voice/univ1029");        //「おっけー」
    }
    public static void voicePlay05()
    {
        lipSync_.Play("voice/univ1139");        //「スリー」
    }
    public static void voicePlay06()
    {
        lipSync_.Play("voice/univ1138");        //「ツー」
    }
    public static void voicePlay07()
    {
        lipSync_.Play("voice/univ1137");        //「ワン」
    }
    public static void voicePlay08()
    {
        lipSync_.Play("voice/univ1016");        //「スタート」
    }
    public static void voicePlay09()
    {
        lipSync_.Play("voice/univ1167");        //「ジャンケン」
    }
    public static void voicePlay10()
    {
        lipSync_.Play("voice/univ1118");        //「ぽんっ！」
    }
    public static void voicePlay11()
    {
        lipSync_.Play("voice/univ1169");        //「グー」
    }
    public static void voicePlay12()
    {
        lipSync_.Play("voice/univ1170");        //「パー」
    }
    public static void voicePlay13()
    {
        lipSync_.Play("voice/univ1171");        //「チョキ」
    }
    public static void voicePlay14()
    {
        lipSync_.Play("voice/univ1173");        //「やったー！私の勝ち！」
    }
    public static void voicePlay15()
    {
        lipSync_.Play("voice/univ1174");        //「うふふ、あいこだね」
    }
    public static void voicePlay16()
    {
        lipSync_.Play("voice/univ1175");        //「残念、負けちゃった……」
    }

}
