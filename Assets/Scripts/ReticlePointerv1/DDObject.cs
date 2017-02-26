using UnityEngine;
using System.Collections;
using System;

public class DDObject : MonoBehaviour, DropDrag{
    bool IsHeld;
    public GameObject Reticle;
    public void HandleGazeTriggerEnd()
    {
        IsHeld = false;
        GetComponent<Renderer>().material.color = Color.yellow;
        Reticle = GameObject.Find("DDReticlePointer");
    }

    public void HandleGazeTriggerStart()
    {
        IsHeld = true;
        GetComponent<Renderer>().material.color = Color.blue;
    }

    // Use this for initialization
    void Start () {
        IsHeld = false;
        GetComponent<Renderer>().material.color = Color.yellow;
	}
	
	// Update is called once per frame
	void Update () {
        if(IsHeld)
        {
            Ray ray = new Ray(Reticle.transform.position, Reticle.transform.forward);
            transform.position = ray.GetPoint(4);
        }
	
	}
}
