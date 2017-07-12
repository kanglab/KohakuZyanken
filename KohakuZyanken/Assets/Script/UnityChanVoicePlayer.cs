using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityChanLipSync))]
public class UnityChanVoicePlayer : MonoBehaviour {

    private UnityChanLipSync lipSync_;
    public AudioClip audioClip;
    public int index = 0;
    Animator animator_kohaku;

    // Use this for initialization
    void Start () {
        lipSync_ = GetComponent<UnityChanLipSync>();
        animator_kohaku = GetComponent<Animator>();
    }

    public void voicePlay01()
    {
        lipSync_.Play("voice/univ1088");        //「私と一緒にゲームしよっ！」
    }
    public void voicePlay02()
    {
        lipSync_.Play("voice/univ1109");        //「どれを選ぶ？」
    }
    public void voicePlay03()
    {
        lipSync_.Play("voice/univ1015");        //「えー…おほん（咳払いのアドリブ）　アーユーレディ？」
    }
    public void voicePlay04()
    {
        lipSync_.Play("voice/univ1029");        //「おっけー」
    }
    public void voicePlay05()
    {
        lipSync_.Play("voice/univ1139");        //「スリー」
    }
    public void voicePlay06()
    {
        lipSync_.Play("voice/univ1138");        //「ツー」
    }
    public void voicePlay07()
    {
        lipSync_.Play("voice/univ1137");        //「ワン」
    }
    public void voicePlay08()
    {
        lipSync_.Play("voice/univ1016");        //「スタート」
    }
    public void voicePlay09()
    {
        lipSync_.Play("voice/univ1167");        //「ジャンケン」
    }
    public void voicePlay10()
    {
        lipSync_.Play("voice/univ1118");        //「ぽんっ！」
    }
    public void voicePlay11()
    {
        lipSync_.Play("voice/univ1169");        //「グー」
    }
    public void voicePlay12()
    {
        lipSync_.Play("voice/univ1170");        //「パー」
    }
    public void voicePlay13()
    {
        lipSync_.Play("voice/univ1171");        //「チョキ」
    }
    public void voicePlay14()
    {
        lipSync_.Play("voice/univ1173");        //「やったー！私の勝ち！」
    }
    public void voicePlay15()
    {
        lipSync_.Play("voice/univ1174");        //「うふふ、あいこだね」
    }
    public void voicePlay16()
    {
        lipSync_.Play("voice/univ1175");        //「残念、負けちゃった……」
    }

}
