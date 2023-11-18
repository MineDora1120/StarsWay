using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_12 : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    private SpriteRenderer dirtSprite;
    private Color dirtColor;
    void Start()
    {
        player = GameObject.Find("Player");
        rb = player.GetComponent<Rigidbody2D>();
        dirtSprite = GetComponent<SpriteRenderer>();
        dirtColor = dirtSprite.color;
    }
    // Start is called before the first frame update
    public IEnumerator FadeIn(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        for (float i = 1f; i > 0; i -= Time.deltaTime)
        {
            dirtColor.a = i;
            dirtSprite.color = dirtColor;
            yield return new WaitForSeconds(0.005f);
        }
        dirtSprite.enabled = false;
        Destroy(gameObject);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && rb.velocity.y != 0f) StartCoroutine(FadeIn(0f));
    }
}
