using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverySign : MonoBehaviour {

    //bool
    [SerializeField] bool _playerDroppedOffPackage;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Collider
    void OnTriggerEnter2D(Collider2D _otherObject)
    {
        if (_otherObject.tag == "Player")
        {

            if (_playerDroppedOffPackage == false)
            {
                Debug.Log("Player hit sign");
              
            }

        }

    }

    void OnTriggerExit2D(Collider2D _otherObject)
    {
        if (_otherObject.tag == "Player")
        {
            if (_playerDroppedOffPackage == false)
            {
                Debug.Log("Player walked away.");
                
            }
        }
    }
}
