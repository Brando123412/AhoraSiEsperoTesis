using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketObjectController : MonoBehaviour
{
    public Transform pocketTransform; 
    public float returnSpeed = 5f; 

    private bool isBeingHeld = false;

    void Update()
    {
        if (isBeingHeld == false)
        {
            if (transform.position == pocketTransform.position)
            {
                transform.position = pocketTransform.position;
            }
            else {
                transform.position = Vector3.Lerp(
             transform.position,
             pocketTransform.position,
             Time.deltaTime * returnSpeed
         );
            }

        }
        
    }
    public void StartHolding()
    {
        isBeingHeld = true;
    }

    public void StopHolding()
    {
        isBeingHeld = false;
    }
}
