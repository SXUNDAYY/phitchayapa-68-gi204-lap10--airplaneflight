using UnityEngine;
using UnityEngine.InputSystem;

public class AirplaneFlightPhysicsSimulation : MonoBehaviour
{
    Rigidbody rb;
    public float
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.centerOfMass = new Vector3(0, -0.6f, -0.02f);
    }

    private void FixedUpdate()
    {
        Keyboard kb = Keyboard.current;
        if (kb == null) return;

        if (kb.spaceKey.isPressed)
        {
            engineOn = true;
            
            rb.AddRelativeForce(Vector3.forward * )
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
