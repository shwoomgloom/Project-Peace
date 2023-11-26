using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    //Access to the timer
    Timer timer;

    //Health bar Hearts
    public Health heart1, heart2, heart3;

    //bools
    public bool _playerCanMove;
    

	//floats
	public float _playerSpeed = 6f;

    //GameObjects
    public GameObject _package1Button;
    public GameObject _playerHealthBar;

    public Animator animator;

    // Use this for initialization
    void Start () {



        animator = GetComponent<Animator>();
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
            //Up
            if (Input.GetAxisRaw("Vertical") > 0 &&
                _playerPos.y < 0.96f)
            {
                transform.position += new Vector3(
                    0, _playerSpeed * Time.deltaTime);
                animator.SetBool("WalkingUp", true);

                animator.SetBool("WalkingDown", false);
                animator.SetBool("WalkingRight", false);
                animator.SetBool("WalkingLeft", false);
            }
            //Down
            if (Input.GetAxisRaw("Vertical") < 0 &&
                _playerPos.y > 0.03f) 
            {
                transform.position -= new Vector3(
                    0, _playerSpeed * Time.deltaTime);
                animator.SetBool("WalkingDown", true);

                animator.SetBool("WalkingRight", false);
                animator.SetBool("WalkingUp", false);
                animator.SetBool("WalkingLeft", false);
            }
            //Right
            if (Input.GetAxisRaw("Horizontal") > 0 &&
                _playerPos.x < 0.96f) 
            {
                transform.position += new Vector3(
                    _playerSpeed * Time.deltaTime, 0);
            
                animator.SetBool("WalkingRight", true);

                animator.SetBool("WalkingDown", false);
                animator.SetBool("WalkingUp", false);
                animator.SetBool("WalkingLeft", false);
            }
            //Left
            if (Input.GetAxisRaw("Horizontal") < 0 &&
               _playerPos.x > 0.03f) 
            {
                transform.position -= new Vector3(
                    _playerSpeed * Time.deltaTime, 0);

                animator.SetBool("WalkingLeft", true);

                animator.SetBool("WalkingDown", false);
                animator.SetBool("WalkingRight", false);
                animator.SetBool("WalkingUp", false);
            }
        

    }

    void OnTriggerEnter2D(Collider2D _otherObject)
    {
        if (_otherObject.tag == "Route 1")
        {
            Debug.Log("Player entering Route 1");
        }

        if(_otherObject.tag == "Angry Resident")
        {
            //If player is hit by a resident, take away health
        }
    }


}
