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

    public IEnumerator Printf(float After, float Before, string[] texts) //�ؽ�Ʈ, �����ð�, �ؽ�Ʈ ������Ʈ
    {
        for(int i = 0; i < texts.Length; i++)
        {
            StartCoroutine(ShowText(texts[i], Before));
            yield return new WaitForSeconds(After);
        }
    }

    public IEnumerator ShowText(string fullText, float letterDelay) //�ؽ�Ʈ, �����ð�, �ؽ�Ʈ ������Ʈ
    {
        textObject.text = "";
        for (int i = 0; i <= fullText.Length; i++)
        {
            textObject.text = fullText.Substring(0, i);
            yield return new WaitForSeconds(letterDelay);
        }
    }
}