using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce;
    public float SidewayForce;
    private void FixedUpdate()
    {
        rb.AddForce(ForwardForce * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(0, 0, -SidewayForce * Time.deltaTime,ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(0, 0, SidewayForce * Time.deltaTime,ForceMode.VelocityChange);
        }
        if(transform.position.y<-1)
        {
            FindObjectOfType<GameManger>().EndGame();
        }
    }
}
