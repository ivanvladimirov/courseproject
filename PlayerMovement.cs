using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sideWaysForce = 50f;
    public float rotationForce = 1;
    
    void FixedUpdate()
    {
        // Movement

        if (Input.GetKey("a"))
        {
            rb.AddForce(sideWaysForce, 0, 0);
            rb.transform.Rotate(0, -rotationForce, 0);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(-sideWaysForce, 0, 0);
            rb.transform.Rotate(0, rotationForce, 0);
        }

        // Turbo Mode

        if(Input.GetKey("space"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime * 2);
        }

        rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
    }
}
