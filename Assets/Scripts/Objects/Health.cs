using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField] Sprite _lostHealth;
    [SerializeField] Sprite _defaultSprite;

    // Use this for initialization
    void Start () {

        _defaultSprite = GetComponent<SpriteRenderer>().sprite;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //Looses Health 
    // Changes the sprite from red to gray to indicate that the health has been lost
    public void LooseHealth()
    {
        GetComponent<SpriteRenderer>().sprite = _lostHealth;
    }
}
