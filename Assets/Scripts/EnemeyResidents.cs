using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyResidents : MonoBehaviour {

    //Route1 Manager
    public Route1Manager RouteManager;

	//GameObjects
	public GameObject _movePoint1, _movePoint2;
    public GameObject _orginalPoint1, _orginalPoint2;
    public GameObject _PlayerTarget; //Chase player point

    //Float
    public float speed = 3f;

    //Bools
    public bool chasingPlayer;

    // Use this for initialization
    void Start () {

        chasingPlayer = false;
        StartCoroutine(ResidentMoveNormal());

	}
	
	// Update is called once per frame
	void Update () {

        //If player pepper sprays enemey, they leave player alone
        if ((Input.GetKeyDown(KeyCode.E)) && chasingPlayer == true)
        {
            Debug.Log("WOAH MAN YOU'RE WAY TO CLOSE PEPPER SPRAAAYYY!");
            chasingPlayer = false;

            RouteManager._injuredResidents++;

            //set move points to normal
            _movePoint1 = _orginalPoint1;
            _movePoint2 = _orginalPoint2;

        }

	}

    
    void OnTriggerEnter2D(Collider2D _otherObject)
    {
        if (_otherObject.tag == "Player")
        {
            //Move toward player
            _movePoint2 = _PlayerTarget;
            _movePoint1 = _PlayerTarget;
            chasingPlayer = true;
        }

    }
    

    //Move Enumerator 
    IEnumerator ResidentMoveNormal()
	{
		while (true)
		{
            //Move towards one location
            while (transform.position != _movePoint2.transform.position)
            {
                transform.position = Vector3.MoveTowards(
                transform.position, _movePoint2.transform.position,
                    speed * Time.deltaTime);
                yield return new WaitForSeconds(Time.deltaTime);
            }

            //Wait
            yield return new WaitForSeconds(0.5f);

            //Turn around
            transform.localScale = new Vector3(
                transform.localScale.x, -transform.localScale.y,
                transform.localScale.z);

            //Retrun to orginial location
            while (transform.position != _movePoint1.transform.position)
            {
                transform.position = Vector3.MoveTowards(
                transform.position, _movePoint1.transform.position,
                speed * Time.deltaTime);
                yield return new WaitForSeconds(Time.deltaTime);
            }

            //Wait
            yield return new WaitForSeconds(0.5f);

            //Turn around agian
            transform.localScale = new Vector3(
                transform.localScale.x, -transform.localScale.y,
                transform.localScale.z);
        }
	}

}
