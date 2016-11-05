using UnityEngine;
using System.Collections;

public class CharacterMover : MonoBehaviour {

    public Transform mover;

	void Start ()
    {
        this.gameObject.SetActive(false);
        mover.position = new Vector3(10, -1, 0);
	}

    void CharacterEnterStore()
    {
        this.gameObject.SetActive(true);
    }

    void CharacterLeaveStore()
    {
        this.gameObject.SetActive(false);
    }

    void Update ()
    {
	    while (isActiveAndEnabled == true)
        {
            mover.Translate(-2, 0, 0);
        }
	}
}
