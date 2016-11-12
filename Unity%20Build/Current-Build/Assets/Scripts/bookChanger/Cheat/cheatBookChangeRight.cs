using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class cheatBookChangeRight : MonoBehaviour
{
    //public int arraySelector = 0;
    //public Image book;
    //public Sprite crime;
    //public Sprite poetry;
    //public Sprite comedy;
    //public Sprite thriller;
    //public Sprite plays;

    void OnMouseDown()
    {
        GameObject bookChoice = GameObject.Find("bookChoice");
        whatBook script = bookChoice.GetComponent<whatBook>();
        if (script.arraySelector < 5)
        {
            script.arraySelector++;
        }
        else
        {
            script.arraySelector = 4;
        }
    }

   /* void Update()
    {
        switch (arraySelector)
        {
            case 0:
                book.sprite = crime;
                break;
            case 1:
                book.sprite = comedy;
                break;
            case 2:
                book.sprite = poetry;
                break;
            case 3:
                book.sprite = plays;
                break;
            case 4:
                book.sprite = thriller;
                break;
        }
    } */
}
