using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour {

	//Game Objects
	//Title screen and menus
	public GameObject _titleScreen, _controlScreen, _creditScreen;

	//Button Game Objects
	public GameObject _startB, _controlB, _creditB, _backB;
	
	//Misc. Game Objects
	public GameObject _overlay;

	//Buttons

	// Use this for initialization
	void Start () {
		
		_overlay.SetActive(false);

        _backB.SetActive(false);
        _controlScreen.SetActive(false);
		_creditScreen.SetActive(false);	
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	//Starts the game
	public void GameStart()
	{
		//activate overlay
		_overlay.SetActive(true);

		StartCoroutine(LoadLevel());
	}

	//Shows player the control menu
	public void Controls()
	{
		//Disable title, enable control menu
		_titleScreen.SetActive(false);
		_overlay.SetActive(true);
		_backB.SetActive(true);

		_controlScreen.SetActive(true);	

	}

	//Shows player the credits
	public void Credits()
	{
        //Disable title, enable credits
        _titleScreen.SetActive(false);
        _overlay.SetActive(true);
		_backB.SetActive(true);

		_creditScreen.SetActive(true );
	}

	//Back Button control
	public void BackButton()
	{
		//Disable any current open 
		_controlScreen.SetActive(false);
		_creditScreen.SetActive(false);
		_overlay.SetActive(false);	
		_backB.SetActive(false);

		//Enable title screen again
		_titleScreen.SetActive(true);

	}

    IEnumerator LoadLevel()
	{
        for (int i = 0; i <= 255; i += 5)
        {
            //fade the overlay out
            _overlay.GetComponent<Image>().color =
                new Color(0, 0, 0, i / 255.0f);
            yield return new WaitForSeconds(0.02f);
        }

        SceneManager.LoadScene("SampleScene");
    }
}
