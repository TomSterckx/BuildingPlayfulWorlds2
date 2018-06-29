using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Movement : MonoBehaviour {
    public Rigidbody rb;
    public float forcestrength = 25.0f;
    public Animator animator;
    public float desiredSpeed = 0.5f;

    
   
    Enlarge character;
    // Use this for initialization
    void Start () {
        character = GetComponent<Enlarge>();
        animator.speed = desiredSpeed;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Camera.main.transform.up * forcestrength);
            character.Shrink();
            StartCoroutine(ForceChange());
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-Camera.main.transform.up * forcestrength);
            character.Shrink();
            StartCoroutine(ForceChange());
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-Camera.main.transform.right* forcestrength);
            character.Shrink();
            StartCoroutine(ForceChange());
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Camera.main.transform.right * forcestrength);
            character.Shrink();
            StartCoroutine(ForceChange());
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            character.speedScale = 1.5f;
            forcestrength = 500f;
            
        }

    }
    IEnumerator ForceChange()
    {
        yield return new WaitForSeconds(3f);
        forcestrength = 50.0f;
        
    }
}
