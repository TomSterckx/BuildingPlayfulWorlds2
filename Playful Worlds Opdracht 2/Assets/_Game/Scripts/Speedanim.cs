using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedanim : MonoBehaviour {
    public Animator animator;
    public float desiredSpeed = 0.5f;
    // Use this for initialization
    void Start () {
        animator.speed = desiredSpeed;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
