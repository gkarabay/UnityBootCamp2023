using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RollingBall : MonoBehaviour
{

    public float Speed;
    public float JumpSpeed;


    void Start()
    {
        
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rb = GetComponent<Rigidbody>();
        
        
        Vector3 movement = new Vector3(x, 0, z)* Time.deltaTime * Speed;
        movement.y = rb.velocity.y;
        rb.velocity = movement;

        if(Input.GetKeyDown(KeyCode.Space)){

            rb.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
        }
        

    }
}
