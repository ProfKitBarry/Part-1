using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject missilePrefab;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
     GameObject newMissile = Instantiate(missilePrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
