using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class SpaceshipController : MonoBehaviour
{

   // [SerializeField] private Rigidbody rb;
    [SerializeField] private float thrust = 100f;
    [SerializeField] private float rotationForce = 10f;
    [SerializeField] private float rollForce = 30f;

    private float moveInput;
    private float rollInput;
    private Vector2 lookInput;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Start()
    {
        LockCursor();
    }
    
    public void OnMove(InputValue value){
        moveInput = value.Get<float>();
    }

    public void OnLook(InputValue value)
    {
        lookInput += value.Get<Vector2>();
    }

    public void OnRoll(InputValue value){
        rollInput = value.Get<float>();
    }

    private void FixedUpdate(){

        rb.AddForce(rb.transform.forward * moveInput * thrust);

        // Maus Steuerung: 
        float pitch = -lookInput.y * rotationForce;
        float yaw = lookInput.x * rotationForce;

        // Roll Steuerung:
        float roll = -rollInput * rollForce;

        // Rotationskräfte:
        Vector3 torque = rb.transform.right * pitch + rb.transform.up * yaw + rb.transform.forward * roll;

        rb.AddTorque(torque);

        lookInput = Vector2.zero;

    }

    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
   
}
