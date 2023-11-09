using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteTriggerControl : MonoBehaviour {

	//Bools
	[SerializeField] bool _playerIsAtCenter;

	// Use this for initialization
	void Start () {

        Debug.Log("Player is at Center: " + _playerIsAtCenter);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D _otherObject)
    {
        if (_otherObject.tag == "Player")
        {
			_playerIsAtCenter = true;
            Debug.Log("Player is at Center: " + _playerIsAtCenter);
        }
    }
}
