using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //For loading levels

public class Route1 : MonoBehaviour {

	//GameObject
	public GameObject _loadingOverlay;

    //Color
    [SerializeField] Color _highlightColor, _returnColor;
    Color _defaultColor;

    // Use this for initialization
    void Start () {

		_loadingOverlay.SetActive(false);
        _defaultColor = GetComponent<SpriteRenderer>().color;
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

        _loadingOverlay.SetActive(true);
        for (int i = 0; i <= 255; i += 5)
        {
            //fade the overlay out
            _loadingOverlay.GetComponent<Image>().color =
                new Color(0, 0, 0, i / 255.0f);
            yield return new WaitForSeconds(0.02f);
        }

        SceneManager.LoadScene("Route 1");
    }

    //Sign flash
   public  IEnumerator FlashColor()
    {
        //Change color
        GetComponent<SpriteRenderer>().color = _highlightColor;

        //Wait a half second
        yield return new WaitForSeconds(0.5f);

        //Change to defualt color
        GetComponent<SpriteRenderer>().color = _returnColor;

        //Wait a half second
        yield return new WaitForSeconds(0.5f);

        //Change color
        GetComponent<SpriteRenderer>().color = _highlightColor;

        //Wait a half second
        yield return new WaitForSeconds(0.5f);

        //Change to defualt color
        GetComponent<SpriteRenderer>().color = _returnColor;

        //Change color
        GetComponent<SpriteRenderer>().color = _highlightColor;

        //Wait a half second
        yield return new WaitForSeconds(0.5f);

        //Change to defualt color
        GetComponent<SpriteRenderer>().color = _returnColor;
    }
}
