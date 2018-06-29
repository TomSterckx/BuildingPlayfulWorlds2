using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;
    public float sizeFactor = 1.0f;
    private float distance = 10.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensivityX = 8.0f;
    private float sensivityY = 2.0f;

    private void Start()
    {
        camTransform = transform;
        cam = Camera.main;


    }

    private void Update()
    {
        currentX += (Input.GetAxis("Mouse X"))*sensivityX;
        currentY -= (Input.GetAxis("Mouse Y")) *sensivityY;

    }
    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance*sizeFactor);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }
}
