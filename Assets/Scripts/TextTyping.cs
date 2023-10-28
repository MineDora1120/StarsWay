using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextTyping : MonoBehaviour
{
    public float letterDelay = 0.1f, AfterDelay = 2;
    Text textObject;
    string[] texts = new string[] { "��ȭ�Ӵ� �����...", "�̻����� ��Ʈ���̤� ������§��" };

    private void Start()
    {
        textObject = GetComponent<Text>();
        StartCoroutine(Printf(AfterDelay, letterDelay));
    }

    IEnumerator Printf(float After, float Before) //�ؽ�Ʈ, �����ð�, �ؽ�Ʈ ������Ʈ
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

    IEnumerator ShowText(string fullText, float letterDelay) //�ؽ�Ʈ, �����ð�, �ؽ�Ʈ ������Ʈ
    {
        textObject.text = "";
        for (int i = 0; i <= fullText.Length; i++)
        {
            textObject.text = fullText.Substring(0, i);
            yield return new WaitForSeconds(letterDelay);
        }
    }
}