using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReportSheet : MonoBehaviour
{
    public GameObject wristCanvasL;
    public Transform handTransformL;
    public Transform headTransform;
    public float distanceThreshold = 0.5f;
    public float distanceL;

    void Update()
    {
        distanceL = Vector3.Distance(headTransform.position, handTransformL.position);

        if ((distanceL <= distanceThreshold))
        {
            wristCanvasL.SetActive(true);
        }
        else
        {
            wristCanvasL.SetActive(false);
        }
    }
}
