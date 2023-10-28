using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextTyping : MonoBehaviour
{
    public float letterDelay = 0.1f, AfterDelay = 2;
    Text textObject;
    string[] texts = new string[] { "평화롭던 어느날...", "이상현은 도트르ㅜㄹ 존나잘짠다" };

    private void Start()
    {
        textObject = GetComponent<Text>();
        StartCoroutine(Printf(AfterDelay, letterDelay));
    }

    IEnumerator Printf(float After, float Before) //텍스트, 지연시간, 텍스트 오브젝트
    {
        for(int i = 0; i < texts.Length; i++)
        {
            StartCoroutine(ShowText(texts[i], Before));
            yield return new WaitForSeconds(After);
        }
        yield return new WaitForSeconds(After);
        StartCoroutine(Fade.FadeIn(0));
        textObject.enabled = false;
    }

    IEnumerator ShowText(string fullText, float letterDelay) //텍스트, 지연시간, 텍스트 오브젝트
    {
        textObject.text = "";
        for (int i = 0; i <= fullText.Length; i++)
        {
            textObject.text = fullText.Substring(0, i);
            yield return new WaitForSeconds(letterDelay);
        }
    }
}