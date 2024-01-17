using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
