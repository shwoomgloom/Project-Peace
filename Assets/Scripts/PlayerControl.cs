using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	//floats
	public float _playerSpeed = 6f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
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
}
