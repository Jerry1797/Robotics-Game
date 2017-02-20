using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class ScrollMenuFunctionUp : MonoBehaviour, IGvrGazeResponder
{

    public GameObject ScrollMenu;
    public int index = -1;
    private ScrollMenuManager m_ScrollMenuManager;
    public void OnGazeEnter()
    {
        
    }

    public void OnGazeExit()
    {
       
    }

    public void OnGazeTrigger()
    {
        ScrollUp();
    }
    void ScrollUp()
    {
        if (m_ScrollMenuManager.index > 0)
        {
            m_ScrollMenuManager.index--;
            m_ScrollMenuManager.Buttons[0].transform.GetChild(0).GetComponent<Text>().text = m_ScrollMenuManager.currentFunctions[m_ScrollMenuManager.index];
            m_ScrollMenuManager.Buttons[1].transform.GetChild(0).GetComponent<Text>().text = m_ScrollMenuManager.currentFunctions[m_ScrollMenuManager.index + 1];
            m_ScrollMenuManager.Buttons[2].transform.GetChild(0).GetComponent<Text>().text = m_ScrollMenuManager.currentFunctions[m_ScrollMenuManager.index + 2];
        }
    }
    // Use this for initialization
    void Start () {
        m_ScrollMenuManager = ScrollMenu.GetComponent<ScrollMenuManager>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
