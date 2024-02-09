using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject grave;
    public GameObject stop;
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        grave.SetActive(true);
        stop.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        grave.SetActive(false);
        stop.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    { //example of rotation here, silly but necessary for assignment
        stop.transform.Rotate(Vector3.forward, 20 * Time.deltaTime);
    }
}
