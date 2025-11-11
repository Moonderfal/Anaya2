using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    private void FixedUpdate()
    {


            if (moveDirection > 0 && !facingRight)
                Flip();
            else if (moveDirection < 0 && facingRight)
                Flip();
    }
    void Flip()
    {
        facingright = !facingRight;
        transform.Rotate(Vector3.up, 180f, Space.World);
    }

}
