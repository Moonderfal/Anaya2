using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed = 6.0f;
    public float moveDirection;
    public bool facingRight = true;
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        moveDirection = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbody.linearVelocity = new Vector2(moveDirection * maxSpeed, rigidbody.linearVelocity.y);
        if (moveDirection > 0.0f && !facingRight)
        {
            Flip();
        }else if (moveDirection < 0.0f && facingRight)
        {
            Flip();
        }
    }


    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(Vector3.up, 180.0f, Space World);
    }

    
}
