using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextTyping : MonoBehaviour
{
    Text textObject;

    private void Start()
    {
        textObject = GetComponent<Text>();
    }

    public IEnumerator Printf(float After, float Before, string[] texts) //텍스트, 지연시간, 텍스트 오브젝트
    {
        for(int i = 0; i < texts.Length; i++)
        {
            StartCoroutine(ShowText(texts[i], Before));
            yield return new WaitForSeconds(After);
        }
    }

    public IEnumerator ShowText(string fullText, float letterDelay) //텍스트, 지연시간, 텍스트 오브젝트
    {
        textObject.text = "";
        for (int i = 0; i <= fullText.Length; i++)
        {
            textObject.text = fullText.Substring(0, i);
            yield return new WaitForSeconds(letterDelay);
        }
    }
}