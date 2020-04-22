using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour

{
   
    private CharacterController controller;
    private Vector3 moveVector = Vector3.zero;


    public float jumpSpeed = 10;
    private float speed = 15.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 2.0f;
 
    void Start()
    {
        controller = GetComponent<CharacterController> ();
    }
    void Update()
    {
       
        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
            if (Input.GetKey(KeyCode.Space))
            {
                verticalVelocity = jumpSpeed;
                GetComponent<AudioSource>().Play();
            }
        }
        else
        {
            verticalVelocity -= gravity;
        }

        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;

        moveVector.y = verticalVelocity;

        moveVector.z = speed;

       
        controller.Move(moveVector * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            GetComponent<CoinCounter>().Points++;
           other.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject,1);
        }
    }
}
