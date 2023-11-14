using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Route1Manager : MonoBehaviour {

    //Int 
    public int _packagesDelivered = 0;

    //Transform
    public Transform _target;

    //Text
    public Text _playerTask, _packagesDeliveredText; //tells the player their task on the route


    // Use this for initialization
    void Start () {

        _playerTask.text = "Current Task: Deliver the packages.";
        _packagesDeliveredText.text = _packagesDelivered + "/3";

        //Sets Delivery menu to one spot

    }
	
	// Update is called once per frame
	void Update () {

        _packagesDeliveredText.text = _packagesDelivered + "/3";
    }

    public void DeliverAPackage()
    {
        _packagesDelivered++;
    }
}
