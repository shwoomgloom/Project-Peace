using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    //bools
    public bool _playerCanMove;
    //[SerializeField] bool _playerHasAPackage;

	//floats
	public float _playerSpeed = 6f;

    //GameObjects
    public GameObject _package1Button;

	// Use this for initialization
	void Start () {

        Debug.Log("Frog in hub.");
        
        _package1Button.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{


        //Movement
        //Gets player postion on screen
        Vector3 _playerPos = Camera.main.WorldToViewportPoint(
            transform.position);

        
            //4-directional movement (top--down)
            if (Input.GetAxisRaw("Vertical") > 0 &&
                _playerPos.y < 0.96f)//up
            {
                transform.position += new Vector3(
                    0, _playerSpeed * Time.deltaTime);
            }
            if (Input.GetAxisRaw("Vertical") < 0 &&
                _playerPos.y > 0.03f) //down
            {
                transform.position -= new Vector3(
                    0, _playerSpeed * Time.deltaTime);
            }
            if (Input.GetAxisRaw("Horizontal") > 0 &&
                _playerPos.x < 0.96f) //right
            {
                transform.position += new Vector3(
                    _playerSpeed * Time.deltaTime, 0);
            }
            if (Input.GetAxisRaw("Horizontal") < 0 &&
               _playerPos.x > 0.03f) //left
            {
                transform.position -= new Vector3(
                    _playerSpeed * Time.deltaTime, 0);
            }
        

    }

    void OnTriggerEnter2D(Collider2D _otherObject)
    {
        if (_otherObject.tag == "Route 1")
        {
            Debug.Log("Player entering Route 1");
        }
    }
}
