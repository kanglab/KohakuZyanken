using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanChangeMotion : MonoBehaviour {

    public static Animator animator_kohaku;
    void Start () {
        animator_kohaku = GetComponent<Animator>();
        animator_kohaku.SetBool("pushStartButton", false);
        animator_kohaku.SetBool("pushSelectButton", false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void changeMotion01()
    {
        animator_kohaku.SetBool("pushStartButton", true);
    }
    public static void changeMotion02_on()
    {
        animator_kohaku.SetBool("pushSelectButton", true);
    }
    public static void changeMotion02_off()
    {
        animator_kohaku.SetBool("pushSelectButton", false);
    }
    public static void changeMotion03_on()
    {
        animator_kohaku.SetBool("zyankenLose", true);
    }
    public static void changeMotion03_off()
    {
        animator_kohaku.SetBool("zyankenLose", false);
    }
    public static void changeMotion04_on()
    {
        animator_kohaku.SetBool("zyanlenWin", true);
    }
    public static void changeMotion04_off()
    {
        animator_kohaku.SetBool("zyanlenWin", false);
    }
}
