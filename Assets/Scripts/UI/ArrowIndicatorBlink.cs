using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ArrowIndicatorBlink : MonoBehaviour {
    public bool isEnabled;
    public float speed;
    private Image image;
    bool goingUp;
    

	// Use this for initialization
	void Awake () {
        isEnabled = false;
        goingUp = false;
    }
    void Start()
    {
        image = GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
        if(isEnabled)
        {

            if (image.color.a > .2 && !goingUp)
            {
                image.color = Color.Lerp(image.color, new Color(image.color.r,
                    image.color.g,
                    image.color.b,
                    0),speed* Time.deltaTime);
                if (image.color.a < .4)
                    goingUp = true;
         
            }
            else
            {
                image.color = Color.Lerp(image.color, new Color(image.color.r,
                    image.color.g,
                    image.color.b,
                    1), speed * Time.deltaTime);
                if (image.color.a >= .8)
                    goingUp = false;
            }
        }


    }
    public void Enable()
    {
        isEnabled = true;
    }

    public void Disable()
    {
        image.color = new Color(image.color.r,
                    image.color.g,
                    image.color.b,
                    0);
        isEnabled = false;
    }

}
