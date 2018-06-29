using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bounds : MonoBehaviour
{
    public GameObject text;

    // Use this for initialization
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.SetActive(true);
        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.SetActive(false);
        }
    }

 
}
