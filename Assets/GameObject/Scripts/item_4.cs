using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_4 : MonoBehaviour
{

    private GameObject player;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rb = player.GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce((Vector2.up * MovePlayer.moveSpeed)*1.25f, ForceMode2D.Impulse);
        }
    }
}
