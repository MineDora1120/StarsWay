using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_5 : MonoBehaviour
{
    public bool grass;
    // Update is called once per frame
    private void Start()
    {
        grass = false;  
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) grass = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) grass = false;
    }
}
