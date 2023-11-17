using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Route1Manager : MonoBehaviour {

    //Timer 
    public Timer timer;
    public Timer overviewTimer;

    //Int 
    public int _packagesDelivered, _injuredResidents;

    //Transform
    public Transform _target;

    //Text
    public Text _playerTask, _packagesDeliveredText; //tells the player their task on the route

    //Text for overview screen.
    public Text _totalPackagesDeliveredText, _residentsInjuredText;

    //Game Object
    public GameObject _timerSlider, _overviewScreen;


    // Use this for initialization
    void Start () {

        _overviewScreen.SetActive(false);
        _packagesDelivered = 0;
        _playerTask.text = "Current Task: Deliver the packages.";
        _packagesDeliveredText.text = _packagesDelivered + "/3";

        //Sets Delivery menu to one spot

    }
	
	// Update is called once per frame
	void Update () {

        _playerTask.text = "Current Task: Deliver the packages.";
        _packagesDeliveredText.text = _packagesDelivered + "/3";

        //Stop timer if the player drops off all packages
        if (_packagesDelivered >= 3)
        {
            timer.stopTimer = true;
            overviewTimer.stopTimer = true;
        }

        if(timer.stopTimer == true)
        {
            CompletedLevel();
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
        _playerTask.text = "";
        _packagesDeliveredText.text = "";
        _overviewScreen.SetActive(true);
        _totalPackagesDeliveredText.text = "-Total Packages dropped off: " + _packagesDelivered + "/3";
        
        _residentsInjuredText.text = "-Residents Injured: " + _injuredResidents;
    }
}
