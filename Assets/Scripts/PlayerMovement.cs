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
    }
}
