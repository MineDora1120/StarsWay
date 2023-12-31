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
    }

    // Update is called once per frame
    static public IEnumerator FadeOut(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        BlackScreenColor.a = 0;     
        for (float i = 0; i <= 1f; i += Time.deltaTime)
        {
            BlackScreenRenderer.enabled = true;
            BlackScreenColor.a = i;
            BlackScreenRenderer.color = BlackScreenColor;
            yield return new WaitForSeconds(0.01f);
        }
        BlackScreenColor.a = 1f;
        BlackScreenRenderer.color = BlackScreenColor;
    }
    static public IEnumerator FadeIn(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        for (float i = 1f; i > 0; i -= Time.deltaTime)
        {
            BlackScreenColor.a = i;
            BlackScreenRenderer.enabled = true;
            BlackScreenRenderer.color = BlackScreenColor;
            yield return new WaitForSeconds(0.01f);
        }
        BlackScreenColor.a = 0f;
        BlackScreenRenderer.color = BlackScreenColor;
        BlackScreenRenderer.enabled = false;
    }

    private void Update()
    {
        
    }
}
