using UnityEngine;
using System.Collections;

public class CharacterMover : MonoBehaviour {

    public SpriteRenderer character;
    [Range(0.0f, 20.0f)]
    public float characterSpeed;
    public float timeUntilAppear = 15;

	void Start ()
    {
        character.gameObject.transform.position = new Vector3(10, -1, 0);
        character.enabled = false; 
	}

  /*  void CharacterEnterStore()
    {
        while (this.gameObject.activeSelf == false)
        {
            timeUntilAppear -= Time.deltaTime;
            if (timeUntilAppear <= 0)
            {
                this.gameObject.SetActive(true);
                timeUntilAppear = 15;
            }
        }
    } */
    
   /* void CharacterLeaveStore()
    {
        this.gameObject.SetActive(false);
    } */

    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            character.enabled = true;
        }
        if (Input.GetMouseButtonDown(1))
        {
            character.enabled = false;
            character.gameObject.transform.position = new Vector3(10, -1, 0);
        }
        if (character.enabled == true)
        {
            if (character.gameObject.transform.position.x >= -4)
            {
                character.gameObject.transform.Translate(Vector3.left * characterSpeed * Time.deltaTime);
            }  
        }
	}
}
