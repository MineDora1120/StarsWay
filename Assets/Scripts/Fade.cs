using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    static SpriteRenderer BlackScreenRenderer;
    static Color BlackScreenColor;
    // Start is called before the first frame update
    void Start()
    {
        BlackScreenRenderer = GetComponent<SpriteRenderer>();
        BlackScreenColor = BlackScreenRenderer.color;
        BlackScreenRenderer.enabled = true;
        StartCoroutine(FadeIn());
    }

    // Update is called once per frame
    static public IEnumerator FadeOut()
    {
        BlackScreenColor.a = 0;
        BlackScreenRenderer.enabled = true;
        for (float i = 0; i < 1f; i += 0.01f)
        {
            BlackScreenColor.a = i;
            BlackScreenRenderer.color = BlackScreenColor;
            yield return new WaitForSeconds(0.01f);
        }
    }

    static public IEnumerator FadeIn()
    {
        for (float i = 1f; i > 0; i -= 0.01f)
        {
            BlackScreenColor.a = i;
            BlackScreenRenderer.color = BlackScreenColor;
            yield return new WaitForSeconds(0.01f);
        }
        BlackScreenRenderer.enabled = false;
    }
}
