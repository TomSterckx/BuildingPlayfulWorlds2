using UnityEngine;
using System.Collections;

public class OrthoSmoothFollow : MonoBehaviour
{
    public GameObject player;      


    private Vector3 offset;         

    private void Start()
    {


        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}