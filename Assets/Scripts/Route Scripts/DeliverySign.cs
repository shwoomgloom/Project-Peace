using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverySign : MonoBehaviour {


    //GameObjects
    public GameObject _package1DropOffMenu;
    public GameObject _playerGuidePoint;

    //bool
    [SerializeField] bool _playerDroppedOffPackage;

    // Use this for initialization
    void Start () {

        _package1DropOffMenu.SetActive(false);
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
                _package1DropOffMenu.SetActive(true);
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
                _package1DropOffMenu.SetActive(false);
            }
        }
    }


    public void PlayerDropsOffPackage()
    {
        Debug.Log("Player dropped off a package.");
        //deactivated menu
        _package1DropOffMenu.SetActive(false);
        _playerGuidePoint.SetActive(false);
        _playerDroppedOffPackage = true;

    }

    public void PlayerDoesNotDropOffPackage()
    {
        Debug.Log("Player did not drop off package.");
        _package1DropOffMenu.SetActive(false);
    }
}
