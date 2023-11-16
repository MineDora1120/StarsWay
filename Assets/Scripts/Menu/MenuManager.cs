using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private bool clickOkayButton = false, clickCancelButton = false, menuBackButton = false;
    public Button okayButton, cancelButton, startButton, backButton;
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
        backButton.onClick.AddListener(OnClickBackButton);
        StartCoroutine(Fade.FadeIn(0f));
    }

    public void OnClickBackButton()
    {
        if (menuBackButton == false)
        {
            menuBackButton = true;
            StartCoroutine(Fade.FadeOut(0f));
            Invoke("UIThree", 3f);
        }
    }

    public void OnClickOkayButton()
    {
        if(clickOkayButton == false)
        {
            clickOkayButton = true;
            StartCoroutine(Fade.FadeOut(0f));
            Invoke("UIOne", 3f);
            StartCoroutine(Fade.FadeIn(3f));
        }
    }
    public void OnClickCancelButton()
    {
        if(clickCancelButton == false)
        {
            clickCancelButton = true;
            StartCoroutine(Fade.FadeOut(0f));
            Invoke("UITwo", 3f);
            StartCoroutine(Fade.FadeIn(3f));
        }
    }

    void UIOne()
    {
        starSetUI.SetActive(false);
        uiSet.SetActive(false);
        starSelUI.SetActive(true);
        uiSel.SetActive(true);
        clickOkayButton = false;
    }
    void UITwo()
    {
        starSetUI.SetActive(true);
        uiSet.SetActive(true);
        starSelUI.SetActive(false);
        uiSel.SetActive(false);
        clickCancelButton = false;
    }

    void UIThree()
    {
        menuBackButton = false;
        SceneManager.LoadScene("Menu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
