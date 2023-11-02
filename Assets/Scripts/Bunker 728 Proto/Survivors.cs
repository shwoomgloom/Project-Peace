using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Survivors : MonoBehaviour {

	//bools
	public bool _drankWater = false, _ateFood = false;
	public bool _survivorTakenCareOf;

	//ints
	public int _dailyActions,  _waterAmount, _RationAmount;

	//Game Object
	PlayerControl _playerControl;

	// Use this for initialization
	void Start () {
		_playerControl = GameObject.Find("Player").GetComponent<PlayerControl>();

		_playerControl._DailyActions = 1;
		
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0) )
		{
			PlayerGivesFood();
			PlayerGivesWater();
		}


    }

	//if the player gives water the amount of water goes down and they loose an action
    public void PlayerGivesWater() 
	{
		//Survivor gets to drink
		_drankWater = true;

		_waterAmount--;
		_dailyActions--;
	}

	public void PlayerGivesFood()
	{
		//Survivor gets to eat
		_ateFood = true;

		_RationAmount--;
		_dailyActions--;
	}
}
