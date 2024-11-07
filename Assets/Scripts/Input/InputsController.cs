using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InputsController : MonoBehaviour
{
    [Header("InputLeft")]
    [SerializeField] InputActionProperty selectActionLeft;
    //[SerializeField] GameIntEvent leftPress;
    [Header("InputLeft")]
    [SerializeField] InputActionProperty selectActionRight;
    //[SerializeField] GameIntEvent rightPress;

    
    [Header("InputMovement")]
    [SerializeField] InputActionProperty selectActionMovement;
    //[SerializeField] AudioSource movementAudioSource;


    [Header("ObjectInteractable")]
    public bool candado = false;
    [SerializeField]private GameIntEvent eventTarea;
    


    void OnEnable()
    {
        selectActionLeft.action.performed += OnActionPerformedLeft;
        selectActionLeft.action.canceled += OnActionCanceledLeft;

        selectActionRight.action.performed += OnActionPerformedRight;
        selectActionRight.action.canceled += OnActionCanceledRight;

        selectActionMovement.action.performed += OnActionPerformedMovement;
        selectActionMovement.action.canceled += OnActionCanceledMovement;

        
    }

    void OnDisable()
    {
        selectActionLeft.action.performed -= OnActionPerformedLeft;
        selectActionLeft.action.canceled -= OnActionCanceledLeft;

        selectActionRight.action.performed -= OnActionPerformedRight;
        selectActionRight.action.canceled -= OnActionCanceledRight;

        selectActionMovement.action.performed -= OnActionPerformedMovement;
        selectActionMovement.action.canceled -= OnActionCanceledMovement;
    }

    private void OnActionPerformedLeft(InputAction.CallbackContext context)
    {
        print("LeftPer");
        if (candado)
        {
            eventTarea.Raise(9);
        }
    }

    private void OnActionCanceledLeft(InputAction.CallbackContext context)
    {
        print("LeftCance");
    }

    private void OnActionPerformedMovement(InputAction.CallbackContext context)
    {
        /*if (!movementAudioSource.isPlaying)
            movementAudioSource.Play();*/
    }
    private void OnActionCanceledMovement(InputAction.CallbackContext context)
    {
        //movementAudioSource.Stop();
    }
    private void OnActionPerformedRight(InputAction.CallbackContext context)
    {
        print("RightPer");
        if (candado)
        {
            eventTarea.Raise(9);
        }
    }

    private void OnActionCanceledRight(InputAction.CallbackContext context)
    {
        print("RightCancel");
    }
    public void OnHoverEnter(SelectEnterEventArgs args)
    {
        GameObject hoveredObject = args.interactableObject.transform.gameObject;
        Debug.Log("Apuntando al objeto: " + hoveredObject.name);
        if (hoveredObject.name == "CandadoInteractable")
        {
            candado = true;
        }

    }

    public void OnHoverExit(SelectExitEventArgs args)
    {
        GameObject hoveredObject = args.interactableObject.transform.gameObject;
        Debug.Log("Dejaste de apuntar al objeto: " + hoveredObject.name);
        if (hoveredObject.name == "CandadoInteractable")
        {
            candado = false;
        }
    }
}
