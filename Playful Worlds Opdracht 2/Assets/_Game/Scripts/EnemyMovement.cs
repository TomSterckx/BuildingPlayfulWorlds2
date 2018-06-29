using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {
    public float lookRadius = 10;
    public float attackRadius = 1f;
    public Transform target;
    NavMeshAgent agent;

	// Use this for initialization
	public virtual void Start () {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
	}
 

    // Update is called once per frame
    public virtual void Update () {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
        }
        if(distance <= attackRadius)
        {
            Attack();
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
	}
    public virtual void Attack()
    {
         
        target.GetComponent<Health>().health -=1.0f;
      
    }
}
