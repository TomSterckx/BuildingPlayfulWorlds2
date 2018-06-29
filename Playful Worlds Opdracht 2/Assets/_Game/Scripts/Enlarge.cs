using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enlarge : MonoBehaviour {
    public Rigidbody rb;
    float d;
    Ray ray;
    RaycastHit hit;
    OrthoSmoothFollow cam;
    Character_Movement character;
    public GameObject Burst;
    public bool isCreated;
    public float speedScale = 1.0f;
    public Health health;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = GetComponent<OrthoSmoothFollow>();
        character = GetComponent<Character_Movement>();
   
    }
    // Use this for initialization

      
    
    void Update()
    {
      
        
            d = Input.GetAxis("Mouse ScrollWheel");
            if (d > 0f)
            {
            Grow();
           
            }
            if (d < 0f)
            {

            Shrink();
            }
            if (transform.localScale.x <= 3.0f)
        {
            health.Die();
        }


    }
    public void Grow()
    {
        transform.localScale *= 1.001f;
      
    }

    public void Consume()
    {

        transform.localScale += new Vector3(1f, 1f, 1f);
        

    }
    public void Shrink()
    {
     
        transform.localScale *= 0.999f/speedScale;
        speedScale = 1.0f;
        if (!isCreated)
        {
            StartCoroutine(SpawnParticle());
        }

       
        

    }
    IEnumerator SpawnParticle()
    {

      
            GameObject go;
            go = Instantiate(Burst, transform.position, Quaternion.identity) as GameObject;

            go.transform.parent = transform;
            Instantiate(Burst, transform.position, Quaternion.identity);
            isCreated = true;


        yield return new WaitForSeconds(2f);
        isCreated = false;
    }
    public void Crunch()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
         
    }
}
