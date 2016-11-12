using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class bookChangerLeft : MonoBehaviour
{
    public int arraySelector = 0;
    public Image book;
    public Sprite crime;
    public Sprite poetry;
    public Sprite comedy;
    public Sprite thriller;
    public Sprite plays;
    public Button select;

    void TaskOnClick()
    {
        if (arraySelector > 0)
        {
            arraySelector--;
        }
        else
        {
            arraySelector = 0;
        }
        arraySelector--;
    }
}
