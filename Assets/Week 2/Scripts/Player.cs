using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigidbody;
    public float speed = 500f;
    Vector2 direction;
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 force = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime;
        rigidbody.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        //direction.x = Input.GetAxis("Horizontal");
        //direction.y = Input.GetAxis("Vertical");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("player hit by" + collision.gameObject);
    }
}
