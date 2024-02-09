using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer spriteRenderer;
    public GameObject moon;
    public GameObject sun;
    public GameObject grave;
    public GameObject bush;
    public GameObject night;
    void Start()
    {
        moon.SetActive(false);
        sun.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (moon.activeInHierarchy)
        {
            moon.SetActive(false);
            sun.SetActive(true);
            night.SetActive(false);
            grave.SetActive(false);
            bush.SetActive(true);
        }
        else
        {
            moon.SetActive(true);
            sun.SetActive(false);
            night.SetActive(true);
            grave.SetActive(true);
            bush.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
