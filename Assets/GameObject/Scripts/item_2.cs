using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_2 : MonoBehaviour
{
    private SpriteRenderer spr;
    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            spr.enabled = false;
            MenuManager.fragNum[MenuManager.starSet - 1, MenuManager.starNum - 1] = 1;
        }
    }
}
