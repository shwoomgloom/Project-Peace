using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Route1Manager : MonoBehaviour {

    //Timer 
    public Timer timer;

    //Int 
    public int _packagesDelivered;

    //Transform
    public Transform _target;

    //Text
    public Text _playerTask, _packagesDeliveredText; //tells the player their task on the route

    //Game Object
    public GameObject _timerSlider;


    // Use this for initialization
    void Start () {

        _packagesDelivered = 0;
        _playerTask.text = "Current Task: Deliver the packages.";
        _packagesDeliveredText.text = _packagesDelivered + "/3";

        //Sets Delivery menu to one spot

    }
	
	// Update is called once per frame
	void Update () {

        _packagesDeliveredText.text = _packagesDelivered + "/3";
        
        //Stop timer if the player drops off all packages
        if(_packagesDelivered >=3)
        {
            timer.stopTimer = true;
        }

    }

    //Actknowledge a package was dropped off
    public void DeliverAPackage()
    {
        _packagesDelivered ++;
    }

    //Win menu for if the player delivers a package
    public void CompletedLevel()
    {

    }
}
