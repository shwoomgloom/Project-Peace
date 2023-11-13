using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteCameraControl : MonoBehaviour {

    public RouteTriggerControl RouteTriggerControl;
    
    //GameObject
    GameObject _player;
    GameObject _cameraTriggerZone;

    //Vector
    Vector3 _offset; //Distance between player & cam

    //Floats
    public float minX, maxX, maxY, minY;
   

    //Bool
    //public bool _PlayerIsAtCenterOfScreen;

    // Use this for initialization
    void Start()
    {
        //Hooks up  to objects in scene
        _player = GameObject.Find("Player");
        _cameraTriggerZone = GameObject.Find("Camera Follows player Trigger");

        //offset = camera possition - player position
        _offset = transform.position -
            _player.transform.position;
        Debug.Log(_offset);

       Debug.Log( RouteTriggerControl._playerIsAtCenter);
    }

    // Update is called once per frame
    void Update()
    {

        //Tracks player position
        Vector3 _playerPos = _offset + _player.transform.position;


        if (RouteTriggerControl._playerIsAtCenter == true) { 
        //Only follow up to max/min x, y
            if (_playerPos.x > maxX)
                _playerPos = new Vector3(maxX, _playerPos.y, _playerPos.z);
            if (_playerPos.x < minX)
                _playerPos = new Vector3(minX, _playerPos.y, _playerPos.z);
            if (_playerPos.y > maxY)
                _playerPos = new Vector3(_playerPos.x, maxY, _playerPos.z);
            if (_playerPos.y < minY)
                _playerPos = new Vector3(_playerPos.x, minY, _playerPos.z);

            transform.position = _playerPos;
        }

        _offset = transform.position -
           _player.transform.position;
        
    }
}
