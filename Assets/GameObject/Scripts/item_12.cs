using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_12 : MonoBehaviour
{
    private SpriteRenderer dirtSprite;
    private Color dirtColor;

    void Start()
    {
        dirtSprite = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    public IEnumerator FadeIn(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        for (float i = 1f; i > 0; i -= Time.deltaTime)
        {
            dirtColor = Color.white;
            dirtColor.a = i;
            dirtSprite.color = dirtColor;
            yield return new WaitForSeconds(0.005f);
        }
        dirtSprite.enabled = false;
        Destroy(gameObject);
    }
}
