using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        door = gameObject.GetComponent<GameObject>();
        door.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (door != null)
        {
            door.SetActive(true);
        }
        else
        {
            door = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
