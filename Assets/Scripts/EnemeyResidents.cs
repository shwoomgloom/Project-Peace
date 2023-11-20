using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyResidents : MonoBehaviour {

	//GameObjects
	public GameObject _movePoint1, _movePoint2;

    //Float
    public float speed = 3f;

    // Use this for initialization
    void Start () {
		
        StartCoroutine(ResidentMove());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Move Enumerator 
    IEnumerator ResidentMove()
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

            //Turn around

        }
	}
}
