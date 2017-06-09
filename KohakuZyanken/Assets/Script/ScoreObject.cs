using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour {

	public GameObject summaryText;
	public GameObject winRateText;

	// Use this for initialization
	void Start () {
		initScoreText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void initScoreText(){
		summaryText.SetActive(false);
		winRateText.SetActive(false);
	}
}
