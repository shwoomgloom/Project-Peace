using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Slider timerSlider;

	//Txet
	public Text timerText;

	//Float
	public float gameTime;

	//Bool
	public bool stopTimer;

	public int minutes, seconds;

    // Use this for initialization
    void Start () {
		
		stopTimer = false;
		timerSlider.maxValue = gameTime;
		timerSlider.value = gameTime;

	}
	
	// Update is called once per frame
	void Update () {

		float time = gameTime - Time.time;

		//Second to minuet conversion stuff
		minutes = Mathf.FloorToInt(time / 60);
		seconds = Mathf.FloorToInt(time - minutes * 60f);

		string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

		//If time reaches 0, stop the timer
		if(time <= 0)
		{
			stopTimer = true;
		}
		

		//Continue Timer while its not 0
		if(stopTimer == false )
		{
			timerText.text = textTime;
			timerSlider.value = time;
		}

		
	}
}
