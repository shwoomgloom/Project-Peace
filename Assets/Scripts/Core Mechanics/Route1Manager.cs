using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Route1Manager : MonoBehaviour {

    //Player Control Connections
    public PlayerControl playerControl;

    //Timer 
    public Timer timer;
    public Timer overviewTimer;

    //Int 
    public int _packagesDelivered, _injuredResidents, _playerPay;

    //Transform
    public Transform _target;

    //Text
    public Text _playerTask, _packagesDeliveredText, _dailyPayText, _totalDailyPayText; //tells the player their task on the route

    //Text for overview screen.
    public Text _totalPackagesDeliveredText, _residentsInjuredText;

    //Game Object
    public GameObject _timerSlider, _overviewScreen, _overlay, _playerHealthBar, _grayHealthBar;

    //Audio Related Work
    AudioSource audioSource;
    public AudioClip _packageDropOffSound, _endScreenSound;


    // Use this for initialization
    void Start () {

        audioSource = GetComponent<AudioSource>();

        //HEALTH BAR DISABLED BECAUSE IT FEELS UNESSARY AS A PUNISHMENT WHEN PLAYER IS ALREADY CHASED
        _playerHealthBar.SetActive(false);
        _grayHealthBar.SetActive(false);

        _overlay.SetActive(false);
        _overviewScreen.SetActive(false);
        _packagesDelivered = 0;
        _playerTask.text = "Current Task: Deliver the packages.";
        _packagesDeliveredText.text = _packagesDelivered + "/3";

        //Sets player starting pay to 0
        _playerPay = 0;

    }
	
	// Update is called once per frame
	void Update () {

        _playerTask.text = "Current Task: Deliver the packages.";
        _packagesDeliveredText.text = _packagesDelivered + "/3";

        //Stop timer if the player drops off all packages
        if (_packagesDelivered >= 3 ) //|| playerControl._playerHealth <= 0)
        {
            timer.stopTimer = true;
            overviewTimer.stopTimer = true;
        }

        if(timer.stopTimer == true)
        {
            
            CompletedLevel();
        }


    }

    //Actknowledge a package was dropped off
    public void DeliverAPackage()
    {
        audioSource.PlayOneShot(_packageDropOffSound);
        _packagesDelivered ++;
        _playerPay = _playerPay + 50;
    }

    //Win menu for if the player delivers a package
    public void CompletedLevel()
    {
       //audioSource.PlayOneShot(_endScreenSound);
        _playerTask.text = "";
        _packagesDeliveredText.text = "";
        _grayHealthBar.SetActive(false);
        _playerHealthBar.SetActive(false);
        _overviewScreen.SetActive(true);
        _totalPackagesDeliveredText.text = "-Total Packages dropped off: " + _packagesDelivered + "/3";
        
        _residentsInjuredText.text = "-Times Residents got sprayed: " + _injuredResidents;
        _dailyPayText.text = "-Daily Pay: " + _playerPay;
        _totalDailyPayText.text = "-Daily Pay after injury fees: " + (_playerPay - (_injuredResidents * 25));
    }


    public void BackToMenu()
    {
        StartCoroutine(LoadingLevel());
    }

    public void BackToHUb()
    {
        StartCoroutine(LoadingHub());
    }

    IEnumerator LoadingLevel()
    {
        Debug.Log("Overlay activated");
        _overlay.SetActive(true);
        for (int i = 0; i <= 255; i += 5)
        {
            //fade the overlay out
            _overlay.GetComponent<Image>().color =
                new Color(0, 0, 0, i / 255.0f);
            yield return new WaitForSeconds(0.02f);
        }

        SceneManager.LoadScene("MainMenu");
    }

    IEnumerator LoadingHub()
    {
        Debug.Log("Overlay activated");
        _overlay.SetActive(true);
        for (int i = 0; i <= 255; i += 5)
        {
            //fade the overlay out
            _overlay.GetComponent<Image>().color =
                new Color(0, 0, 0, i / 255.0f);
            yield return new WaitForSeconds(0.02f);
        }

        SceneManager.LoadScene("Hub");
    }
}
