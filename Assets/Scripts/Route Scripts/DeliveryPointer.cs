using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeliveryPointer : MonoBehaviour {

    //Image
    public Image _objectivePoint;

    //transform
    public Transform _target;

    //Route1Manager

    

    void Start()
    {

    }


    private void Update()
    {
        //Limits the pointer's location
        //X
        float minX = _objectivePoint.GetPixelAdjustedRect().width / 2;
        float maxX = Screen.width - minX;

        //Y
        float minY = _objectivePoint.GetPixelAdjustedRect().height / 2;
        float maxY = Screen.width - minY;

        //Puts the pointer above objective location
        Vector2 _position = Camera.main.WorldToScreenPoint(_target.position);

        if(Vector3.Dot((_target.position - transform.position), transform.forward) < 0)
        {
            //If the Target is behind the player
            if(_position.x < Screen.width / 2)
            {
                _position.x = maxX;
            }
            else
            {
                _position.x = minX;
            }
        }

        _position.x = Mathf.Clamp(_position.x, minX, maxX);
        _position.y = Mathf.Clamp(_position.y, minY, maxY);

        _objectivePoint.transform.position = _position;
    }

}
