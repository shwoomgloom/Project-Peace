using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    [SerializeField] Image _lostHealth;
    [SerializeField] Image _defaultSprite;

    // Use this for initialization
    void Start () {

        _defaultSprite = GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //Looses Health 
    // Changes the sprite from red to gray to indicate that the health has been lost
    public void LooseHealth()
    {
        _defaultSprite = _lostHealth;
    }
}
