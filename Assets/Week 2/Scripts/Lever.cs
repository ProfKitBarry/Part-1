using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(door.activeInHierarchy);
        door.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (door.activeInHierarchy)
        {
            Debug.Log("Door is open");
            door.SetActive(false);
        }
        else
        {
            door.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
