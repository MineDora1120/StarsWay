using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OkayButton : MonoBehaviour
{
    // UI ��ư ����
    public Button okayButton;
    public GameObject starSetUI, uiSet;

    void Start()
    {
        starSetUI.SetActive(true);
        uiSet.SetActive(true);
        okayButton.onClick.AddListener(OnClick);
    }

    // ��ư Ŭ�� �� ȣ��� �޼ҵ�
    void OnClick()
    {
        StartCoroutine(Fade.FadeOut(0f));
        Invoke("delUi", 1.5f);
        StartCoroutine(Fade.FadeIn(2f));
    }

    void delUi()
    {
        starSetUI.SetActive(false);
        uiSet.SetActive(false);
    }
}
