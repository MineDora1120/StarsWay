using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private float moveRadius = 1f, moveSpeed = 2f, timer = 0;
    private float[] mainPosition = new float[2];
    private SpriteRenderer monsterSprite;
    private Animator monsterAnime;
    private Color monsterColor;
    MonsterBody monsterBody;
    bool direction = true; //¿ÞÂÊ
    // Start is called before the first frame update
    void Start()
    {
        mainPosition[0] = transform.position.x;
        mainPosition[1] = transform.position.y;
        monsterSprite = GetComponent<SpriteRenderer>();
        monsterAnime = GetComponent<Animator>();
        monsterBody = FindObjectOfType<MonsterBody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
         if(timer > 0.1f && !monsterBody.killed)
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
}
