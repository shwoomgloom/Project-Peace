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

    //Audio Related Work
    AudioSource audioSource;
    public AudioClip _packagePopUp;

    // Use this for initialization
    void Start () {

        audioSource = GetComponent<AudioSource>();
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
                _package1Button.SetActive(true);
                audioSource.PlayOneShot(_packagePopUp);
            }
          
        }

    }

    void OnTriggerExit2D(Collider2D _otherObject)
    {
        if( _otherObject.tag == "Player")
        {
            if (_playerHasAPackage == false)
            {
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
        foreach (GameObject package in GameObject.FindGameObjectsWithTag("Route 1 Package"))
        {
            package.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
            Destroy(package);
             //Invoke("DestroyObject", 0.5f);
        }
        
        _playerHasAPackage = true;
    }

    public void PlayerDoesNotTakePackage()
    {
        Debug.Log("Player did not take package.");
        _package1Button.SetActive(false );
    }
}
