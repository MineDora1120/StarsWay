using System.Collections;
using UnityEngine;

public class startSetImage : MonoBehaviour
{
    [SerializeField] Sprite[] setSprite;
    [SerializeField] GameObject setObject, charactorObj;
    [SerializeField] GameObject[] starObj;
    private SpriteRenderer[] spriteRenderObj = new SpriteRenderer[3];
    private SpriteRenderer setRenderer;
    private float[,] spritePosition = new float[,]
    {
        //x, y, 크기 - x, 크기 - y, 크기 - z
        { -3.64f, -0.86f, 0.5658103f, 0.5696319f, 0.1082142f }, //쌍둥이자리
        { -3.6664f, 0.17f, 0.8917697f, 0.7990804f, 0.135008f }, //양자리
        { -3.6664f, 0.17f, 0.8917697f, 0.7990804f, 0.135008f }, //천징자리 == 양자리
        { -3.59f, -0.15f, 0.5685546f, 0.5094597f, 0.08607539f }, //북두칠성
        { -4.2535f, -0.35f, 0.8004865f, 0.7926394f, 0.08607539f }, //카시오페아자리
    };
    private float[,,] starSpritePosition = new float[,,]
    {//x,y
        { {-0.46f, -3.98f }, { -8.41f,  -0.1f}, { 1.02f, 0.74f} },
        { { 0.38f, -1.98f}, { -2.05f, 0.45f}, { -7.73f, 2.26f} },
        { { 0.38f, -1.98f}, { 0.11f, -0.71f}, { -7.73f, 2.26f} },
        { { -8.2f, -2.09f}, { -2.69f, -0.28f}, { 0.42f, 1.63f} },
        { { -1.58f, -3.29f }, { -4.63f, -0.92f}, { -6.81f, 2.96f} }
    };
    // Start is called before the first frame update
    void Start()
    {
        setRenderer = setObject.GetComponent<SpriteRenderer>();
        for (int i = 0; i < 3; i++)
        {
            spriteRenderObj[i] = starObj[i].GetComponent<SpriteRenderer>();
        }
        StartCoroutine(ChangeImage());
    }

    IEnumerator ChangeImage()
    {
        while (true)
        {
            for (int i = 0; i < 3; i++)
            {
                starObj[i].transform.position = new Vector2(starSpritePosition[MenuManager.starSet - 1, i, 0], starSpritePosition[MenuManager.starSet - 1, i, 1]);
                if (i + 1 == MenuManager.starNum) spriteRenderObj[i].color = Color.yellow;
                else if (MenuManager.clearData[MenuManager.starSet - 1, i] == 1) spriteRenderObj[i].color = Color.green;
                else spriteRenderObj[i].color = Color.white;
                charactorObj.transform.position = new Vector3(starSpritePosition[MenuManager.starSet - 1, MenuManager.starNum - 1, 0] + 0.05f, starSpritePosition[MenuManager.starSet - 1, MenuManager.starNum - 1, 1], 5f);
            }

            setRenderer.sprite = setSprite[MenuManager.starSet - 1];
            setObject.transform.localScale = new Vector3(spritePosition[MenuManager.starSet - 1, 2], spritePosition[MenuManager.starSet - 1, 3], spritePosition[MenuManager.starSet - 1, 4]);
            setObject.transform.position = new Vector3(spritePosition[MenuManager.starSet - 1, 0], spritePosition[MenuManager.starSet - 1, 1], 5);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
