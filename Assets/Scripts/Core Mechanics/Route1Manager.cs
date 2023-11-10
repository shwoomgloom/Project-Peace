using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Route1Manager : MonoBehaviour {

    //Text
    public Text _playerTask; //tells the player their task in the hub

    // Use this for initialization
    void Start () {

        _playerTask.text = "Current Task: Deliver the packages.";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
