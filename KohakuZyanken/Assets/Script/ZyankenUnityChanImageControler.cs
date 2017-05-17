using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZyankenUnityChanImageControler : MonoBehaviour {

    public static GameObject gu;
    public static GameObject tyoki;
    public static GameObject pa;

    // Use this for initialization
    void Start () {
        gu = GameObject.Find("gu");
        tyoki = GameObject.Find("tyoki");
        pa = GameObject.Find("pa");
        gu.SetActive(false);
        tyoki.SetActive(false);
        pa.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void resetZyankenImage()
    {
        gu.SetActive(false);
        tyoki.SetActive(false);
        pa.SetActive(false);
    }
    public static void setGuImage()
    {
        gu.SetActive(true);
    }
    public static void setTyokiImage()
    {
        tyoki.SetActive(true);
    }
    public static void setPaImage()
    {
        pa.SetActive(true);
    }
}
