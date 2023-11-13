using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryPointer : MonoBehaviour {

    //Vectors
    private Vector3 _targetPostion;
    private RectTransform _pointerRectTransform;

    //GameObject
    GameObject _DeliverySign; 

    private void Awake()
    {
        _targetPostion = new Vector3(-8.23, -6.73);
        _pointerRectTransform = transform.Find("Pointer").GetComponent < RectTransform() >;

    }

    private void Update()
    {
        Vector3 _toPostion = _targetPostion;
        Vector3 _fromPostion = Camera.main.transform.postion;

        _fromPostion.z = 0f;
        Vector3 _direction = (_toPostion - _fromPostion).normalized;
    }
}
