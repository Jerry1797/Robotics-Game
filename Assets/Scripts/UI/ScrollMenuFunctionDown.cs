using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class ScrollMenuFunctionDown : MonoBehaviour, IGvrGazeResponder
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
        ScrollDown();
    }
    void ScrollDown()
    {
        if (m_ScrollMenuManager.index < m_ScrollMenuManager.currentFunctions.Count-3)
        {
            m_ScrollMenuManager.index++;
            m_ScrollMenuManager.Buttons[0].transform.GetChild(0).GetComponent<Text>().text = m_ScrollMenuManager.currentFunctions[m_ScrollMenuManager.index];
            m_ScrollMenuManager.Buttons[1].transform.GetChild(0).GetComponent<Text>().text = m_ScrollMenuManager.currentFunctions[m_ScrollMenuManager.index+1];
            m_ScrollMenuManager.Buttons[2].transform.GetChild(0).GetComponent<Text>().text = m_ScrollMenuManager.currentFunctions[m_ScrollMenuManager.index+2];
        }

    }
    // Use this for initialization
    void Start()
    {
        m_ScrollMenuManager = ScrollMenu.GetComponent<ScrollMenuManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
