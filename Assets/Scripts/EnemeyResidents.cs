using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyResidents : MonoBehaviour {

	//GameObjects
	public GameObject _movePoint1, _movePoint2;
    public GameObject _PlayerTarget; //Chase player point

    //Float
    public float speed = 3f;

    // Use this for initialization
    void Start () {
		
        StartCoroutine(ResidentMoveNormal());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /*
    void OnTriggerEnter2D(Collider2D _otherObject)
    {
        if (_otherObject.tag == "Player")
        {
            //Move toward player
            StopCoroutine(ResidentMoveNormal());
            StartCoroutine(TargetPlayer());

        }

    }
    */

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

    //Targets the player
    IEnumerator TargetPlayer()
    {
        while (true)
        {
            //Move towards the player if they are too close
            while (transform.position != _PlayerTarget.transform.position)
            {
                transform.position = Vector3.MoveTowards(
                transform.position, _PlayerTarget.transform.position,
                    speed * Time.deltaTime);
            }
        }
    }
}
