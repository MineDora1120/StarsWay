using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    private bool clickOkayButton = false, clickCancelButton = false, menuBackButton = false, startClickButton = false;
    public Button okayButton, cancelButton, startButton, backButton;
    // Start is called before the first frame update
    public static int starNum = 1;
    public static int starSet = 1;
    public static int pendants = 0;
    public static int[,] clearData = new int[5, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
    public static int[,] fragNum = new int[5, 3];
    public GameObject starSetUI, uiSet, starSelUI, uiSel;
    void Start()
    {
        clickOkayButton = false;
        clickCancelButton = false;
        menuBackButton = false;
        startClickButton = false;

        starSetUI.SetActive(true);
        uiSet.SetActive(true);
        starSelUI.SetActive(false);
        uiSel.SetActive(false);

        Application.targetFrameRate = 60;

        okayButton.onClick.AddListener(OnClickOkayButton);
        cancelButton.onClick.AddListener(OnClickCancelButton);
        backButton.onClick.AddListener(OnClickBackButton);
        startButton.onClick.AddListener(OnClickStartButton);
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

    public void OnClickStartButton()
    {
        if (startClickButton == false)
        {
            startClickButton = true;
            StartCoroutine(Fade.FadeOut(0f));
            Invoke("UIFour", 3f);
        }
    }

    public void OnClickOkayButton()
    {
        if (clickOkayButton == false)
        {
            clickOkayButton = true;
            StartCoroutine(Fade.FadeOut(0f));
            Invoke("UIOne", 3f);
            StartCoroutine(Fade.FadeIn(3f));
        }
    }
    public void OnClickCancelButton()
    {
        if (clickCancelButton == false)
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
    void UIFour()
    {
        menuBackButton = false;
        SceneManager.LoadScene("Main");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
