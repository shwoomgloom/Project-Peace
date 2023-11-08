using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packages : MonoBehaviour {

    //Connected to PlayerControl

    //Connected to HubManager

    //GameObjects
    public GameObject _package1Button;

    //bool
    [SerializeField] bool _playerHasAPackage;

    // Use this for initialization
    void Start () {

        Debug.Log("Frog has package: " + _playerHasAPackage);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //Collider
    void OnTriggerEnter2D(Collider2D _otherObject)
    {
        if (_otherObject.tag == "Player")
        {

            if (_playerHasAPackage == false)
            {
                Debug.Log("There is a package here.");
                _package1Button.SetActive(true);
            }
          
        }

    }

    void OnTriggerExit2D(Collider2D _otherObject)
    {
        if( _otherObject.tag == "Player")
        {
            if (_playerHasAPackage == false)
            {
                Debug.Log("Player walked away.");
                _package1Button.SetActive(false);
            }
        }
    }

    public void PlayerTakesPackage()
    {
        Debug.Log("Player took package.");
        //deactivated menu
        _package1Button.SetActive(false );

        //destorys package object
        GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        Invoke("DestroyObject", 0.5f);
        _playerHasAPackage = true;
    }

    public void PlayerDoesNotTakePackage()
    {
        Debug.Log("Player did not take package.");
        _package1Button.SetActive(false );
    }
}
