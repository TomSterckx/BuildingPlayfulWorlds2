using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColissionScipt : MonoBehaviour {
    public GameObject player;
    Enlarge PlayerPrefab ;
    private void Start()
    {
        PlayerPrefab = player.GetComponent<Enlarge>();
    }
    // Use this for initialization
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            PlayerPrefab.Consume();
            PlayerPrefab.Crunch();
           

            if (transform.localScale.x > 0.4f)
            { 
            transform.localScale *= 0.5f;
                
            }
            if (transform.localScale.x <= 0.4f)
            {
                Destroy(gameObject);
                

            }

        }
    }
}
