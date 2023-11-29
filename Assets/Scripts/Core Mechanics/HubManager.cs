using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //For loading levels

public class HubManager : MonoBehaviour {

	public Route1 Route1;

	//Text
	public Text _playerTask, _letterHeader, letterContent, _NumberofLetters; //tells the player their task in the hub

    //Bools
    [SerializeField] bool _level1Selected;

    //Buttons
    public Button _package1YES, _package1NO, _openLetterb, _closeLetterb;

	//GameObjects
	public GameObject _package1SelectionMenu;
	public GameObject _route1TriggerZone, _route1TriggernonFlashable;
	public GameObject _letterToPlayer;

    //Audio Related Work
    AudioSource audioSource;
	public AudioClip _routeReady;


    // Use this for initialization
    void Start () {

        audioSource = GetComponent<AudioSource>();

        _route1TriggerZone.SetActive(false);
		_letterToPlayer.SetActive(false);
        _playerTask.text = "Current Task: Choose a package to deliver.";
    }
	
	// Update is called once per frame
	void Update () {

		//Locks in if the Player selected to drop off package 1
		if(_level1Selected == true)
		{
			_package1YES.interactable = false;
			_package1NO.interactable = false;
			_package1SelectionMenu.SetActive(false);
        }

	}

	public void Level1Selected()
	{
		audioSource.PlayOneShot(_routeReady);

        Debug.Log("Player locked in level one");
        _level1Selected = true;

        _route1TriggernonFlashable.SetActive(false);

        _route1TriggerZone.SetActive(true);

		Route1.StartCoroutine(Route1.FlashColor());

		//Update the objective
        _playerTask.text = "Current Task: Proceed to Route 1.";
    }

	//Button that lets palyer check notices
	public void NoticeSytem()
	{
        _letterToPlayer.SetActive(true);
    }

	public void CloseNotice()
	{
		_letterToPlayer.SetActive(false);
		_NumberofLetters.text = "";
	}
}
