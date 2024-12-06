using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCameraController : MonoBehaviour
{
    [SerializeField]
    private Camera targetCamera;

    private void Start()
    {
        if (targetCamera == null)
        {
            targetCamera = Camera.main;
        }
    }

    private void Update()
    {
        if (targetCamera != null)
        {
            transform.LookAt(targetCamera.transform.position);
        }
    }
}
