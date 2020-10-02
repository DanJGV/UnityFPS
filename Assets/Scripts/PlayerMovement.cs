using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 1;

    [SerializeField]
    float jumpSpeed;

    [SerializeField]
    float rotSpeed = 1;

    [SerializeField]
    Transform cam;
    [SerializeField]
    int goToLevel = 0;
    [SerializeField]
    int goalScore = 0;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray r = new Ray(transform.position, Vector3.down);
        Debug.DrawLine(r.origin, r.origin + (Vector3.down * 10));
        RaycastHit hit;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Mouse X");

        

        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0;
        camRight.y = 0;
        camForward.Normalize();
        camRight.Normalize();

        transform.Rotate(new Vector3(0, x * rotSpeed, 0));

        Vector3 moveDirection = (camForward * v * moveSpeed) + (camRight * h * moveSpeed);
        rb.velocity = new Vector3(moveDirection.x, rb.velocity.y, moveDirection.z);

        /*new Vector3(h * moveSpeed,
                                  rb.velocity.y,
                                   v * moveSpeed);*/

        if (Input.GetButtonDown("Jump"))
        {
            if (Physics.Raycast(r, out hit, 1))
            {
              
                    Jump();

            }

          

        }

        if (GameManager.instance.score == goalScore)
        {
            SceneManager.LoadScene(goToLevel);
            GameManager.instance.score = 0;
            
        }

    }
     void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x,
                                  jumpSpeed,
                                  rb.velocity.z);
    }

   

}
