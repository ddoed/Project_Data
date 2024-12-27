using UnityEngine;
using UnityEngine.InputSystem;

public class PIMtemp : MonoBehaviour
{
    PlayerControlTemp playerControl;
    Rigidbody rb;

    private void Awake()
    {
        playerControl = new PlayerControlTemp();
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        playerControl.Enable();
        playerControl.Basic.Jump.performed += Jump;
    }

    private void OnDisable()
    {
        playerControl.Disable();
        playerControl.Basic.Jump.performed -= Jump;
    }

    public void OnJump()
    {
        Debug.Log("Jump");
        rb.AddForce(Vector3.up * 4, ForceMode.Impulse);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Debug.Log("Jump");
            rb.AddForce(Vector3.up * 4, ForceMode.Impulse);
        }
    }

    public void OnMove()
    {
        Debug.Log("Move");
        
    }
}
