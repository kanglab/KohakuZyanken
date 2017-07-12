using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanChangeMotion : MonoBehaviour {

    public Animator animator_kohaku;
    void Start () {
        animator_kohaku = GetComponent<Animator>();
        animator_kohaku.SetBool("pushStartButton", false);
        animator_kohaku.SetBool("pushSelectButton", false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void changeMotion01()
    {
        animator_kohaku.SetBool("pushStartButton", true);
    }
    public void changeMotion02_on()
    {
        animator_kohaku.SetBool("pushSelectButton", true);
    }
    public void changeMotion02_off()
    {
        animator_kohaku.SetBool("pushSelectButton", false);
    }
    public void changeMotion03_on()
    {
        animator_kohaku.SetBool("zyankenLose", true);
    }
    public void changeMotion03_off()
    {
        animator_kohaku.SetBool("zyankenLose", false);
    }
    public void changeMotion04_on()
    {
        animator_kohaku.SetBool("zyanlenWin", true);
    }
    public void changeMotion04_off()
    {
        animator_kohaku.SetBool("zyanlenWin", false);
    }
}
