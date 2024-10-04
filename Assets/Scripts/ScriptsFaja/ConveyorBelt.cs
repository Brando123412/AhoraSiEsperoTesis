using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float speed = 5.0f;
    public Vector3 direction = Vector3.forward; 

    void OnCollisionStay(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;
        if (rb != null)
        {
            Vector3 movement = direction * speed * Time.deltaTime;
            rb.MovePosition(rb.position + movement);
        }
    }
}
