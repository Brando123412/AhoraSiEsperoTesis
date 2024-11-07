using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InputsController : MonoBehaviour
{
    [Header("InputLeft")]
    [SerializeField] InputActionProperty buttonX;
    //[SerializeField] GameIntEvent leftPress;
    [Header("InputLeft")]
    [SerializeField] InputActionProperty buttonA;
    //[SerializeField] GameIntEvent rightPress;

    
    [Header("InputMovement")]
    [SerializeField] InputActionProperty selectActionMovement;
    //[SerializeField] AudioSource movementAudioSource;


    [Header("ObjectInteractable")]
    public GameObject candado = null;
    [SerializeField]private GameIntEvent eventTarea;
    


    void OnEnable()
    {
        buttonA.action.performed += OnActionPerformedButtonA;
        buttonA.action.canceled += OnActionCanceledButtonA;

        buttonX.action.performed += OnActionPerformedButtonX;
        buttonX.action.canceled += OnActionCanceledButtonX;

        selectActionMovement.action.performed += OnActionPerformedMovement;
        selectActionMovement.action.canceled += OnActionCanceledMovement;

        
    }

    void OnDisable()
    {
        buttonA.action.performed -= OnActionPerformedButtonA;
        buttonA.action.canceled -= OnActionCanceledButtonA;

        buttonX.action.performed -= OnActionPerformedButtonX;
        buttonX.action.canceled -= OnActionCanceledButtonX;

        selectActionMovement.action.performed -= OnActionPerformedMovement;
        selectActionMovement.action.canceled -= OnActionCanceledMovement;
    }

    private void OnActionPerformedButtonA(InputAction.CallbackContext context)
    {
        print("ButtonA");
        if (candado != null)
        {
            eventTarea.Raise(9);
            candado.SetActive(false);
        }
    }

    private void OnActionCanceledButtonA(InputAction.CallbackContext context)
    {
        print("ButtonA");
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
    private void OnActionPerformedButtonX(InputAction.CallbackContext context)
    {
        print("ButtonX");
        if (candado != null && candado.activeSelf)
        {
            eventTarea.Raise(9); 
            candado.SetActive(false);
        }
        if (candado != null && !candado.activeSelf)
        {
            candado.SetActive(true);
        }
    }

    private void OnActionCanceledButtonX(InputAction.CallbackContext context)
    {
        print("ButtonXCancel");
    }
    public void OnHoverEnter(SelectEnterEventArgs args)
    {
        GameObject hoveredObject = args.interactableObject.transform.gameObject;
        Debug.Log("Apuntando al objeto: " + hoveredObject.name);
        if (hoveredObject.name == "CandadoInteractable")
        {
            candado = hoveredObject;
        }

    }

    public void OnHoverExit(SelectExitEventArgs args)
    {
        GameObject hoveredObject = args.interactableObject.transform.gameObject;
        Debug.Log("Dejaste de apuntar al objeto: " + hoveredObject.name);
        if (hoveredObject.name == "CandadoInteractable")
        {
            candado = null;
        }
    }
}
