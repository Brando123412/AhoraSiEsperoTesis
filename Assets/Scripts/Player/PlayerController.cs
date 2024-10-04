using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] Vector2 movementVector;
    private float saveSpeed;
    [SerializeField] float runniig;
    [SerializeField] float cauteloso;

    public float jumpForce = 7.0f;
    public float groundCheckDistance = 1.0f;
    [SerializeField] LayerMask layerMask;

    private Camera playerCamera;
    public float mouseSensitivity = 100.0f;
    float rotationX;

    [SerializeField] Vector2 currentLook;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        saveSpeed = speed;
        playerCamera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        HandleMouseLook();
    }
    private void FixedUpdate()
    {
        MovementPlayer();
    }
    #region Inputs
    void OnPositionMouse(InputValue value)
    {
        currentLook = value.Get<Vector2>();
    }
    void OnMovement(InputValue value)
    {
        movementVector = value.Get<Vector2>();
    }
    void OnCauteloso(InputValue value)
    {
        if (value.isPressed)
        {
            speed = cauteloso;
        }
        if (!value.isPressed)
        {
            speed = saveSpeed;
        }
    }
    void OnJump(InputValue value)
    {
        if (value.isPressed && IsGrounded())
        {
            Jump();
        }
    }
    void OnCorrer(InputValue value)
    {
        if (value.isPressed )
        {
            speed  = runniig;
        }
        if (!value.isPressed)
        {
            speed = saveSpeed;
        }
    }
    #endregion

    void MovementPlayer()
    {
        Vector3 movement = (transform.right * movementVector.x + transform.forward * movementVector.y) * speed;
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, layerMask);
    }
    private void HandleMouseLook()
    {
        rotationX -= currentLook.y * mouseSensitivity * Time.deltaTime;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        playerCamera.transform.localEulerAngles = new Vector3(rotationX, 0, 0);
        transform.Rotate(Vector3.up * currentLook.x * mouseSensitivity * Time.deltaTime);

                     /*
        
        float mouseX = currentLook.x * mouseSensitivity;
        float mouseY = currentLook.y * mouseSensitivity;
        transform.Rotate(Vector3.up * mouseX);

        // Rotate the camera vertically
        Vector3 currentRotation = playerCamera.transform.rotation.eulerAngles;
        float desiredRotationX = currentRotation.x - mouseY;
        if (desiredRotationX > 180)
            desiredRotationX -= 360;
        desiredRotationX = Mathf.Clamp(desiredRotationX, -90f, 90f);
        playerCamera.transform.rotation = Quaternion.Euler(desiredRotationX, currentRotation.y, currentRotation.z); */
    }
}