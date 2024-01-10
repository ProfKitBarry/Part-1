using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        float keyboardInput = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, keyboardInput * speed * Time.deltaTime);
    }
}
