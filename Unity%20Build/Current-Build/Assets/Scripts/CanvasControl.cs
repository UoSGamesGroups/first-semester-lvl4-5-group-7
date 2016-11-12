using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CanvasControl : MonoBehaviour
{
    public Canvas canvas;

    public Image feedback;
    public Image bookChoice;
    public SpriteRenderer bookSelectLeft;
    public SpriteRenderer bookSelectRight;

    public GameObject enabler;
   
	void Start ()
    {
        canvas.enabled = false;
        feedback.enabled = false;
        bookChoice.enabled = false;
        bookSelectLeft.enabled = false;
        bookSelectRight.enabled = false;
	}
	
    void Update()
    {
       if (enabler.transform.position.x <= -4)
        {
            canvas.enabled = true;
            bookChoice.enabled = true;
            bookSelectLeft.enabled = true;
            bookSelectRight.enabled = true;
        }
       else
        {
            canvas.enabled = false;
            feedback.enabled = false;
            bookChoice.enabled = false;
            bookSelectLeft.enabled = false;
            bookSelectRight.enabled = false;
        }
    }

}
