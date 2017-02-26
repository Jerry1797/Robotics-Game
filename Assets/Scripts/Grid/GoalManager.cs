using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class GoalManager : MonoBehaviour {

	public List<Transform> Goals;
	public int CurrentGoalIndex;

	// Use this for initialization
	void Start () {
		CurrentGoalIndex = 0;
        for(int i = 0;i < Goals.Count; i++) { 
            Goals[i].GetComponent<Goal>().SetIndex (i);
            Goals[i].GetComponent<Goal>().Activate();
        }
	
	}

	public void DeactivateGoal(int index)
	{
		//Check Index


		//Activate Goal
		Goals[index].GetComponent<Goal>().Deactivate();
		CurrentGoalIndex++;
	}

	public void Reset()
	{
		CurrentGoalIndex = 0;
		foreach (Transform g in Goals) {
			g.GetComponent<Goal> ().Activate ();
		}
	}
}
