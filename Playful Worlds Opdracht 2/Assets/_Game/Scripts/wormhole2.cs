using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wormhole2 : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.GameWin();
        }


    }
}
 
