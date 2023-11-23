using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    private float moveRadius = 2f, moveSpeed = 5f, timer = 0;
    private float[] mainPosition = new float[2];
    private SpriteRenderer monsterSprite;
    private Animator monsterAnime;
    private Color monsterColor;
    MovePlayer itemInfo;
    public GameObject player;
    private Rigidbody2D rb;
    protected bool killed = false;
    protected bool direction = true; //¿ÞÂÊ
    // Start is called before the first frame update
    void Start()
    {
        itemInfo = FindObjectOfType<MovePlayer>();
        player = GameObject.Find("Player");
        rb = player.GetComponent<Rigidbody2D>();
        killed = false;
        mainPosition[0] = transform.position.x;
        mainPosition[1] = transform.position.y;
        monsterSprite = GetComponent<SpriteRenderer>();
        monsterAnime = GetComponent<Animator>();
}

    // Update is called once per frame
    private void FixedUpdate()
    {
         if(timer > 0.1f && !killed)
        {
            timer = 0;
            if (direction)
            {
                if (mainPosition[0] - moveRadius >= transform.position.x) direction = false; 
                transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
                monsterSprite.flipX = false;

            } else if(!direction){
                if (mainPosition[0] + moveRadius <= transform.position.x) direction = true;
                transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
                monsterSprite.flipX = true;
            }
        }
        timer += Time.deltaTime;
    }
   public IEnumerator FadeIn(float delayTime)
    {
        monsterAnime.enabled = false;
        yield return new WaitForSeconds(delayTime);
        for (float i = 1f; i > 0; i -= Time.deltaTime)
        {
            monsterColor = Color.white;
            monsterColor.a = i;
            monsterSprite.color = monsterColor;
            yield return new WaitForSeconds(0.005f);
        }
        monsterSprite.enabled = false;
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && rb.velocity.y < -1f)
        {
            Debug.Log(rb.velocity.y);
            killed = true;
            StartCoroutine(FadeIn(0f));
        }
        else if (collision.CompareTag("Player") && !killed && !itemInfo.grass)
        {
            SceneManager.LoadScene("Main");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !killed && !itemInfo.grass)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
