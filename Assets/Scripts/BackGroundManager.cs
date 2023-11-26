using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundManager : MonoBehaviour
{
    private int Background_x = 1, Background_y = 1;
    [SerializeField] float MoveSpeed = 0.5f, StarChange = 0.1f;
    [SerializeField] bool colorChange = false;
    [SerializeField] GameObject Background, Stars;
    SpriteRenderer StarRender, bgRenderer;
    Color StarColor, startColor, endColor;
    // Start is called before the first frame update
    void Start()
    {
       StarRender = Stars.GetComponent<SpriteRenderer>();
       Background.transform.position = new Vector2(0, 0);
       Stars.transform.position = new Vector2(0, 0);

       StarColor = StarRender.color;
       StarColor.a = 0.1f;
       StarRender.color = StarColor;

       StartCoroutine(Invision());

        if(colorChange)
        {
            startColor = Color.green;
            endColor = Color.blue;
            bgRenderer = Background.GetComponent<SpriteRenderer>();
            StartCoroutine(ContinuousColorChangeCoroutine());
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Background.transform.position.y >= 15) Background_y = -1;
        else if(Background.transform.position.y <= -15) Background_y = 1;
            
        if (Background.transform.position.x >= 9) Background_x = -1;
        else if (Background.transform.position.x <= -9) Background_x = 1;

        Background.transform.position = new Vector2(Background.transform.position.x + Background_x * (Time.deltaTime * MoveSpeed), Background.transform.position.y + Background_y * (Time.deltaTime * MoveSpeed));
    }

    IEnumerator Invision()
    {
        yield return new WaitForSeconds(1f);

        while (true)
        {
            for(float i = 0.1f; i < 1f; i += Time.deltaTime)
            {
                StarColor.a = i;
                StarRender.color = StarColor;
                yield return new WaitForSeconds(StarChange);
            }

            yield return new WaitForSeconds(1f);

            for (float i = 1f; i > 0.1f; i -= Time.deltaTime)
            {
                StarColor.a = i;
                StarRender.color = StarColor;
                yield return new WaitForSeconds(StarChange);
            }

            yield return new WaitForSeconds(1f);
        }
    }
    IEnumerator ContinuousColorChangeCoroutine()
    {
        while (true)
        {
            float t = 0f;

            while (t < 10f)
            {
                t += Time.deltaTime;
                bgRenderer.color = Color.Lerp(startColor, endColor, t);
                yield return null;
            }

            yield return new WaitForSeconds(1f); // 변경된 색상을 유지한 후 1초 대기
            SwapColors(); // 색상 변경
        }
    }

    void SwapColors()
    {
        // 시작 색상과 끝 색상을 교환
        Color temp = startColor;
        startColor = endColor;
        endColor = temp;
    }
}
