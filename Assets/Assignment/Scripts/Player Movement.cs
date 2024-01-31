using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D playerBody;
    Vector2 movement;
    public float speed;
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), 0) * speed * Time.deltaTime;
        playerBody.AddForce(movement);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
