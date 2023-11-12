using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button okayButton, cancelButton, startButton;
    // Start is called before the first frame update
    public static int starNum = 1;
    public static int starSet = 1;
    public static int[] pendants = new int[3];
    public static int[,] clearData = new int[5, 3] { { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }};
    public GameObject starSetUI, uiSet, starSelUI, uiSel;
    void Start()
    {
        starSetUI.SetActive(true);
        uiSet.SetActive(true);
        starSelUI.SetActive(false);
        uiSel.SetActive(false);

        Application.targetFrameRate = 60;

        okayButton.onClick.AddListener(OnClickOkayButton);
        cancelButton.onClick.AddListener(OnClickCancelButton);
        StartCoroutine(Fade.FadeIn(0f));
    }

    public void OnClickOkayButton()
    {
        StartCoroutine(Fade.FadeOut(0f));
        Invoke("UIOne", 1.5f);
        StartCoroutine(Fade.FadeIn(2.5f));
    }
    public void OnClickCancelButton()
    {
        StartCoroutine(Fade.FadeOut(0f));
        Invoke("UITwo", 1.5f);
        StartCoroutine(Fade.FadeIn(2.5f));
    }

    void UIOne()
    {
        starSetUI.SetActive(false);
        uiSet.SetActive(false);
        starSelUI.SetActive(true);
        uiSel.SetActive(true);
    }
    void UITwo()
    {
        starSetUI.SetActive(true);
        uiSet.SetActive(true);
        starSelUI.SetActive(false);
        uiSel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
