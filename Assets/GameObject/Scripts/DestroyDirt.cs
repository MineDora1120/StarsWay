using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDirt : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    item_12 itemInfo;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rb = player.GetComponent<Rigidbody2D>();
        itemInfo = FindObjectOfType<item_12>();
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && rb.velocity.y > 0f)
        {
            StartCoroutine(itemInfo.FadeIn(0f));
        }
    }
}
