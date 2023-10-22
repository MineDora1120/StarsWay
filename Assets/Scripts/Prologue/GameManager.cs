using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int Background_x = 1, Background_y = 1, InvisionMax = 60;
    public float MoveSpeed = 0.5f, StarChange = 0.1f;
    public GameObject Background, Stars;
    SpriteRenderer StarRender;
    Color StarColor;
    // Start is called before the first frame update
    void Start()
    {
       StarRender = Stars.GetComponent<SpriteRenderer>();
       Background.transform.position = new Vector2(0, 0);
       Stars.transform.position = new Vector2(0, 0);
       StartCoroutine(Invision());
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
        StarColor = StarRender.color;
        while (true)
        {
            for(float i = 0; i < InvisionMax; i += 0.1f)
            {
                StarColor.a = i;
                StarRender.color = StarColor;
                yield return new WaitForSeconds(StarChange);
            }

            yield return new WaitForSeconds(1f);

            for (float i = InvisionMax; i > 0; i -= 0.1f)
            {
                Debug.Log(i);
                StarColor.a = i;
                StarRender.color = StarColor;
                yield return new WaitForSeconds(StarChange);
            }

            yield return new WaitForSeconds(1f);
        }
    }
}
