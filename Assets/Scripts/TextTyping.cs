using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextTyping : MonoBehaviour
{
    public Text textObject;
    public string fullText;
    public float letterDelay = 0.1f;

    private void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            textObject.text = fullText.Substring(0, i);
            yield return new WaitForSeconds(letterDelay);
        }
    }
}