using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterBody : MonoBehaviour
{
    Monster monsterMain;
    public bool killed = false;
    item_5 itemInfo;
    private GameObject player;
    private Rigidbody2D rb;

    private void Start()
    {
        player = GameObject.Find("Player");
        itemInfo = FindObjectOfType<item_5>();
        rb = player.GetComponent<Rigidbody2D>();
        monsterMain = FindObjectOfType<Monster>();
        killed = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && rb.velocity.y < 0f)
        {
            Debug.Log(rb.velocity.y);
            killed = true;
            StartCoroutine(monsterMain.FadeIn(0f));
        }
        else if (collision.CompareTag("Player") && !killed && !itemInfo.grass) SceneManager.LoadScene("Main");
    }
}
