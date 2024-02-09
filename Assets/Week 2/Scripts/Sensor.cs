using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer spriterenderer;
    void Start()
    {
        if (spriterenderer != null)
        {
            spriterenderer.color = Color.green;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject + " is in the trigger");
        if (spriterenderer != null) { spriterenderer.color = Color.red; }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (spriterenderer != null) spriterenderer.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
