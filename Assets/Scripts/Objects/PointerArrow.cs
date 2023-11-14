using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerArrow : MonoBehaviour {

    //transform
    public Transform _target;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //Rotate towards the target
        Vector3 _difference = _target.position - transform.position;

        _difference.Normalize();
        float rotation_z = Mathf.Atan2(_difference.y, _difference.x)
            * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f,
            rotation_z - 90);

        //Get position on screen (0-1 in X and Y)
        Vector3 pos = _target.position;
    }
}
