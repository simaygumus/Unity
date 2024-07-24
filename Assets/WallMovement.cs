using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public float ForwardForce = -10f;
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
    }
}
