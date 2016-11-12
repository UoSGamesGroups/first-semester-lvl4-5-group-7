using UnityEngine;
using System.Collections;

public class leftButtonBool : MonoBehaviour
{
    public bool isLeft;

    void Start()
    {
        if (transform.position.x < -350)
        {
            isLeft = true;
        }
        else
        {
            isLeft = false;
        }
    }
}
