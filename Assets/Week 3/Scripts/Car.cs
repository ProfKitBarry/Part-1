using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    float accel;
    float steer;
    public float forwSpeed = 500;
    public float steerSpd = 200;
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        accel = Input.GetAxis("Vertical");
        steer = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(steer * -steerSpd * Time.deltaTime);
        Vector2 force = transform.up * accel * forwSpeed * Time.deltaTime;
        rigidbody.AddForce(force);
    }
}
