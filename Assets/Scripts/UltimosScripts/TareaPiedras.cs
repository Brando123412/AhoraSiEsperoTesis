using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class TareaPiedras : MonoBehaviour
{
    [SerializeField] CantidadTareasGame gameTareasGame;
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Rodillo"))
        {
            Invoke("DespuesDeCollision",2f);
        }
    }
    void DespuesDeCollision()
    {
        gameObject.GetComponent<XRGrabInteractable>().enabled = false;
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.isKinematic = true;
        }
        gameTareasGame.ControlTareas(3, 1);
    }
}
