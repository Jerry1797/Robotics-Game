using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	public int order;
	public bool activated;
    public Color ActivateColor;
    public Color DeactivateColor;
    public Material ReferenceMaterial;
    private Material m_Material;

	// Use this for initialization
	void Awake () {
		activated = true;
        m_Material = Instantiate(ReferenceMaterial);
        gameObject.GetComponent<Renderer>().material = m_Material;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Activate()
	{
		Debug.Log ("Goal Was Activated");
        //Set Color
        gameObject.GetComponent<Renderer>().material.color = ActivateColor;
        gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", ActivateColor);

        activated = true;

	}
	public void Deactivate()
	{
		Debug.Log ("Goal Was Deactivated");
        //Set Color
        gameObject.GetComponent<Renderer>().material.color = DeactivateColor;
        gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", DeactivateColor);

        activated = false;
	}
	public void SetIndex(int i)
	{
		order = i;
	}
	public int GetIndex()
	{
		return order;
	}
}
