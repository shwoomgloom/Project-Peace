using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class DeliverySign : MonoBehaviour {

    //Sprite
    public Sprite _flash, _defaultSprite;

    //Color
    //using Sprites instead of color
    [SerializeField] Color _highlightColor, _returnColor;
    Color _defaultColor;

    //GameObjects
    public GameObject _package1DropOffMenu;
   // public GameObject _playerGuidePoint;

    //bool
    [SerializeField] bool _playerDroppedOffPackage;

    // Use this for initialization
    void Start () {

        _defaultSprite = GetComponent<SpriteRenderer>().sprite;
        _defaultColor = GetComponent<SpriteRenderer>().color;
        _package1DropOffMenu.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
        if(_playerDroppedOffPackage == false)
        {
            StartCoroutine(FlashColor());
        }

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
                _package1DropOffMenu.SetActive(false);
            }
        }
    }


    public void PlayerDropsOffPackage()
    {
        Debug.Log("Player dropped off a package.");
        //deactivated menu
        _package1DropOffMenu.SetActive(false);
        //_playerGuidePoint.SetActive(false);
        _playerDroppedOffPackage = true;

    }

    public void PlayerDoesNotDropOffPackage()
    {
        Debug.Log("Player did not drop off package.");
        _package1DropOffMenu.SetActive(false);
    }

    //Flash Sign to indicate player needs to drop off package
    public IEnumerator FlashColor()
    {
        //Change color
        GetComponent<SpriteRenderer>().sprite = _flash;

        //Wait a 2 second
        yield return new WaitForSeconds(2f);

        //Change to defualt color
        GetComponent<SpriteRenderer>().sprite = _defaultSprite;

        //Wait a 2 second
        yield return new WaitForSeconds(2f);
        //Change color
        GetComponent<SpriteRenderer>().sprite = _flash;

        //Wait a 2 second
        yield return new WaitForSeconds(2f);

        //Change to defualt color
        GetComponent<SpriteRenderer>().sprite = _defaultSprite;

        //Wait a 2 second
        yield return new WaitForSeconds(2f);
    }
}
