using UnityEngine;
using System.Collections;

public class Falling : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        doMove();
    }

    void Update()
    {
        doMove();
    }


    void doMove()
    {
        Vector3 movement = new Vector3(rb.velocity.x, speed, rb.velocity.z);
        rb.velocity = movement;
    }
}
