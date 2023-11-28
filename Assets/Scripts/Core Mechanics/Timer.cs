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
	[SerializeField] float GameTimeFull = 120;
	float gameTime;

	//Bool
	public bool stopTimer;

	//Int
	public int minutes, seconds;

	//Color and fill area stuff
	[SerializeField] Color _fillcolor, _fillHalfTimeColor, _fillLowTimeColor;

	//GameObject
	public GameObject _fillArea;

    //Audio
    AudioSource audioSource;
	public AudioClip _timerWarningSound;

    // Use this for initialization
    void Start () {

        audioSource = GetComponent<AudioSource>();

        gameTime = GameTimeFull;
		stopTimer = false;
		timerSlider.maxValue = gameTime;
		timerSlider.value = gameTime;

	}
	
	// Update is called once per frame
	void Update () {
		
		_fillArea.GetComponent<Image>().color = _fillcolor;

		gameTime -= Time.deltaTime;

		//Second to minuet conversion stuff
		minutes = Mathf.FloorToInt(gameTime / 60);
		seconds = Mathf.FloorToInt(gameTime - minutes * 60f);

		string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

		//Change color to yellow at halfway
		if(gameTime <= 30)
		{
			_fillcolor = _fillHalfTimeColor;
		}

		if(gameTime <= 15)
		{
			_fillcolor = _fillLowTimeColor;
            audioSource.PlayOneShot(_timerWarningSound);
        }

		//If time reaches 0, stop the timer
		if(gameTime <= 0)
		{
			stopTimer = true;
		}
		

		//Continue Timer while its not 0
		if(stopTimer == false )
		{
			timerText.text = textTime;
			timerSlider.value = gameTime;
		}


    }
}
