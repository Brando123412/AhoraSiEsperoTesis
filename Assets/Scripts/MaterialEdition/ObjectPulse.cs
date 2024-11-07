using UnityEngine;

public class ObjectPulse : MonoBehaviour
{
    public float moveDistance = 1f;  
    public float moveSpeed = 1f;     

    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        float newY = Mathf.Sin(Time.time * moveSpeed) * moveDistance;

        transform.position = new Vector3(originalPosition.x, originalPosition.y + newY, originalPosition.z);
    }
}
