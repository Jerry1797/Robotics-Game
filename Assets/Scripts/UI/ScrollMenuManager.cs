using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ScrollMenuManager : MonoBehaviour {

    public List<GameObject> Buttons;
    public List<string> currentFunctions;
    public float scrollSpeed;
    public int index = 0;
    private RectTransform m_RectTransform;
    private bool m_moving;
    private int m_direction;

	// Use this for initialization
	void Start () {
		foreach (string b in currentFunctions) {
			currentFunctions.Add (b);
		}
        m_RectTransform = GetComponent<RectTransform>();
    }
}
