using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FaceCamera : MonoBehaviour
{
    private Transform mainCameraTransform;
    
    private void Awake()
    {
        mainCameraTransform = Camera.main.transform;
    }
    
    private void LateUpdate()
    {
        transform.LookAt(
            transform.position + mainCameraTransform.rotation * Vector3.forward, 
            mainCameraTransform.rotation * Vector3.up);
    }
}
