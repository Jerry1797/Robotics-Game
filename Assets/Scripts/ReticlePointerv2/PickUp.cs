using UnityEngine;
using System.Collections;
using System;

public class PickUp : MonoBehaviour, IGvrGazeResponder {
    GameObject target;
    public bool IsHeld;
    public GameObject Reticle;
    public float MouseWheelAxis;
    public float ScrollSpeed;

    private float _distance;


    // Use this for initialization
    void Start()
    {
        IsHeld = false;
        MouseWheelAxis = 0;
        _distance = 4;
        ScrollSpeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsHeld == true)
        {
            if (Input.GetAxis("Mouse ScrollWheel") != 0)
            {
                MouseWheelAxis = Input.GetAxis("Mouse ScrollWheel");
                _distance += MouseWheelAxis* Mathf.Abs(ScrollSpeed);
            }
            Ray ray = new Ray(Reticle.transform.position , Reticle.transform.forward);
            transform.position = ray.GetPoint(_distance);

        }
    }
    public void OnGazeEnter()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void OnGazeExit()
    {
        GetComponent<Renderer>().material.color = Color.grey;
    }

    public void OnGazeTrigger()
    {
        if (IsHeld == false)
        {
            IsHeld = true;
        }
        else
        {
            IsHeld = false;
            _distance = 4;
        }
    }
}
