using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //loading levels
using UnityEngine.UI; //UI text and images

public class PlayerControl : MonoBehaviour {

    //GameObjects
    Survivors _survivorsControl;

    //bools
    //public bool _survivorTakenCareOf;

    //text
    public Text _waterSupply, _rationsSupply, _actionLeft;

    //ints
    public int _DailyActions,  _waterAmount, _RationAmount, _survivorsManaged;

	//floats
    float _minXPosition;
    float _maxXPosition;
    [SerializeField] float _speed = 5f;

    // Use this for initialization
    void Start () {
        _survivorsControl = GameObject.Find("Survivor").GetComponent<Survivors>();
        

        _waterSupply.text = "Water Bottles: " + _waterAmount;
        _rationsSupply.text = "Rations: " + _RationAmount;
        _actionLeft.text = "Actions Left Today: " + _DailyActions;

        //sets the max and min x positions to the camera bounds
        _minXPosition = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).x;
        _maxXPosition = Camera.main.ViewportToWorldPoint(new Vector2(1, 0)).x;
    }
	
	// Update is called once per frame
	void Update () {

       /* if(_survivorTakenCareOf == true)
        {
            _survivorsManaged++;
            
        }
            _waterSupply.text = "Water Bottles: " + _waterAmount;
            _rationsSupply.text = "Rations: " + _RationAmount;
            _actionLeft.text = "Actions Left Today: " + _dailyActions;
       */
    }

    void fixedUpdate()
    {
      
    }
}
