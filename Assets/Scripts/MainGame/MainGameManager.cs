using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    int maxHP, latestHP;
    public static int HP;
    public Text messageText;
    public Image pendantsImage;
    public Sprite[] pendantsSprite;
    public GameObject player;
    private Color messageColor;
    private Rigidbody2D rb;
    public static bool pendantsGetTo;
    bool isProtect = false;
    void Start()
    {
        pendantsGetTo = false;
        if(MenuManager.pendants != 0) pendantsImage.sprite = pendantsSprite[MenuManager.pendants - 1];
        else pendantsImage.enabled = false;
        rb = player.GetComponent<Rigidbody2D>();

        rb.mass = 1f;
        if (MenuManager.pendants == 1 || MenuManager.pendants == 5) rb.gravityScale = 0.8f;
        else rb.gravityScale = 1f;

        if (MenuManager.pendants == 2 || MenuManager.pendants == 5) MovePlayer.moveSpeed = 7f;
        else MovePlayer.moveSpeed = 5.5f;

        isProtect = false;
        messageText.enabled = false;
        if (MenuManager.pendants == 3) maxHP = 2;
        else maxHP = 1;

        latestHP = maxHP;
        HP = maxHP;

        if (MenuManager.pendants == 4) player.transform.localScale = new Vector3(0.85f, 0.85f, 0.85f);
        else player.transform.localScale = new Vector3(0.93f, 0.93f, 0.93f);

        Application.targetFrameRate = 60;
        StartCoroutine(Fade.FadeIn(0));
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(MenuManager.pendants == 3)
        {
            if (isProtect)
            {
                HP = latestHP;
                return;
            }
            if (Mathf.Abs(latestHP - HP) > 1) HP = latestHP;
            if (HP <= 0) SceneManager.LoadScene("Main");
            else if ((HP != latestHP) && !isProtect)
            {
                isProtect = true;
                StartCoroutine(FadeIn(0f));
                latestHP = HP;
            }
        }
    }

    private IEnumerator FadeIn(float delayTime)
    {
        messageColor = messageText.color;
        messageColor.a = 1;
        messageText.color = messageColor;

        messageText.enabled = true;
        yield return new WaitForSeconds(delayTime);
        for (float i = 1f; i > 0; i -= Time.deltaTime)
        {
            messageColor = messageText.color;
            messageColor.a = i;
            messageText.color = messageColor;
            yield return new WaitForSeconds(0.005f);
        }
        isProtect = false;

        messageText.enabled = false;
    }
}
