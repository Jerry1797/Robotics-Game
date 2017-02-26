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
	void Start () {
		activated = true;
        gameObject.GetComponent<Renderer>().material = Material.Instantiate(ReferenceMaterial);
        m_Material = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Activate()
	{
		Debug.Log ("Goal Was Activated");
        //Set Color
        m_Material.color = ActivateColor;
        m_Material.SetColor("_EmissionColor", ActivateColor);

        activated = true;

	}
	public void Deactivate()
	{
		Debug.Log ("Goal Was Deactivated");
        //Set Color
        m_Material.color = DeactivateColor;
        m_Material.SetColor("_EmissionColor", DeactivateColor);

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
