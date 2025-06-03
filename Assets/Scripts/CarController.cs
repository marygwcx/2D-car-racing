using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f;
    public float steering = 5f;
    public float minMoveSpeedForTurning = 0.5f; 

    private float moveInput;
    private float steeringInput;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = Input.GetAxis("Vertical");
        steeringInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        
        rb.velocity = transform.up * moveInput * speed;

        if (rb.velocity.magnitude > minMoveSpeedForTurning)
        {
            rb.MoveRotation(rb.rotation + steeringInput * (steering * -1));
        }
    }
}