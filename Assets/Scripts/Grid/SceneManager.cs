using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
	static SceneManager instance = null;
	public GoalManager goalManager;
    public GameObject Grid;



	void Awake()
	{
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}
	public static SceneManager singleton
	{
		get{
			return instance;
		}

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
