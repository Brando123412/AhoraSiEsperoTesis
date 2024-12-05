using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RodilloMantenimiento : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rodillo"))
        {
            transform.position= other.gameObject.transform.position;
            transform.rotation= other.transform.rotation;
            gameObject.GetComponent<XRGrabInteractable>().enabled = false;
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            
            if (rb != null)
            {
                rb.isKinematic = true;
            }
            other.gameObject.SetActive(false);
            
        }
    }
}
