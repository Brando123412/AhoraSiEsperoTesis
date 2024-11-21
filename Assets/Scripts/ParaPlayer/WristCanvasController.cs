using UnityEngine;

public class WristCanvasController : MonoBehaviour
{
    public GameObject wristCanvasL;
    public GameObject wristCanvasR;
    public Transform handTransformL;
    public Transform handTransformR;
    public Transform headTransform;
    public float distanceThreshold = 0.5f;
    public float distanceL, distanceR;

    void Update()
    {
        distanceL = Vector3.Distance(headTransform.position, handTransformL.position);

        distanceR = Vector3.Distance(headTransform.position, handTransformR.position);

        if (distanceL <= distanceThreshold)
        {
            wristCanvasL.SetActive(true);
        }
        else
        {
            wristCanvasL.SetActive(false);
        }

        if (distanceR <= distanceThreshold)
        {
            wristCanvasR.SetActive(true);
        }
        else
        {
            wristCanvasR.SetActive(false);
        }
    }
}
