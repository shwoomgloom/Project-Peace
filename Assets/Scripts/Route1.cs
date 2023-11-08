using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //For loading levels

public class Route1 : MonoBehaviour {

	//GameObject
	public GameObject _loadingOverlay;

	// Use this for initialization
	void Start () {
		_loadingOverlay.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

    }

	//Collider
    void OnTriggerEnter2D(Collider2D _otherObject)
    {
        if (_otherObject.tag == "Player")
        {
            Debug.Log("Loading...");
            LoadLevelOne();
        }

    }

	public void LoadLevelOne()
	{
        
        StartCoroutine(LoadingLevelOne());

    }

    //temp?
    IEnumerator LoadingLevelOne()
    {
        Debug.Log("Overlay activated");
        _loadingOverlay.SetActive(true);
        for (int i = 0; i <= 255; i += 5)
        {
            //fade the overlay out
            _loadingOverlay.GetComponent<Image>().color =
                new Color(0, 0, 0, i / 255.0f);
            yield return new WaitForSeconds(0.02f);
        }

        SceneManager.LoadScene("Route1");
    }
}
