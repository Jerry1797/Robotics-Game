using UnityEngine;
using System.Collections;

public class Rover : MonoBehaviour {
    private Vector3 m_StartPos;


	// Use this for initialization
	void Start () {
        m_StartPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other)
	{
		Goal g = other.GetComponent<Goal> ();
		if (g != null) {
			SceneManager.singleton.goalManager.DeactivateGoal(g.GetIndex());
		}
	}
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Grid")
        {
            //TODO - Code to stop rover movement and reset position
            Debug.Log("Rover Went Outside of Grid: Reseting Position");
            
        }
    }
}
