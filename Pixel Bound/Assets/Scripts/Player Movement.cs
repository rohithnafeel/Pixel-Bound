using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5f;
    public float jumpForce = 8f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        float horizontal = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(horizontal * moveSpeed, rb.linearVelocity.y);
    }
}
