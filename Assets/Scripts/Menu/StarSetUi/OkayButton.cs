using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OkayButton : MonoBehaviour
{
    // UI 버튼 연결
    public Button okayButton;
    public GameObject starSetUI, uiSet;

    void Start()
    {
        starSetUI.SetActive(true);
        uiSet.SetActive(true);
        okayButton.onClick.AddListener(OnClick);
    }

    // 버튼 클릭 시 호출될 메소드
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
