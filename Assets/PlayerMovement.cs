using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 1;

    [SerializeField]
    float jumpSpeed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

       

        rb.velocity = new Vector3(h * moveSpeed,
                                  rb.velocity.y,
                                   v * moveSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

    }
     void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x,
                                  jumpSpeed,
                                  rb.velocity.z);
    }

}
