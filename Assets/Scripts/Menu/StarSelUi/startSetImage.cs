using System.Collections;
using UnityEngine;

public class startSetImage : MonoBehaviour
{
    [SerializeField] Sprite[] setSprite, mainSetSprite;
    [SerializeField] GameObject setObject, charactorObj, mainSetObj;
    [SerializeField] GameObject[] starObj;
    private SpriteRenderer[] spriteRenderObj = new SpriteRenderer[3];
    private SpriteRenderer setRenderer, mainSetRenderer;
    private float[,] spritePosition = new float[,]
    {
        //x, y, 크기 - x, 크기 - y, 크기 - z
        { -3.64f, -0.86f, 0.5658103f, 0.5696319f, 0.1082142f }, //쌍둥이자리
        { -3.6664f, 0.17f, 0.8917697f, 0.7990804f, 0.135008f }, //양자리
        { -3.46f, -1.12f, 0.7449844f, 0.6675518f, 0.1127857f }, //천징자리 
        { -3.59f, -0.15f, 0.5685546f, 0.5094597f, 0.08607539f }, //북두칠성
        { -4.2535f, -0.35f, 0.8004865f, 0.7926394f, 0.08607539f }, //카시오페아자리
    };
    private float[,,] starSpritePosition = new float[,,]
    {//x,y
        { {-0.46f, -3.98f }, { -8.41f,  -0.1f}, { 1.02f, 0.74f} },
        { { 0.38f, -1.98f}, { -2.05f, 0.45f}, { -7.73f, 2.26f} },
        { { -5.1f, -4.08f}, { -1.98f, -0.07f}, {-7.15f,0.65f} },
        { { -8.2f, -2.09f}, { -2.69f, -0.28f}, { 0.42f, 1.63f} },
        { { -1.58f, -3.29f }, { -4.63f, -0.92f}, { -6.81f, 2.96f} }
    };
    private float[,] setMapSpritePosition = new float[,]
    {
         {  -0.17f, -1f, 0.5196686f, 0.5196686f, 0.5196686f }, //쌍둥이자리
        { -0.74f, -0.34f, 0.8651966f, 0.7865961f, 0.7387266f }, //양자리
        { 0.22f, -0.41f, 0.597639f, 0.5631959f, 0.5742717f }, //천징자리 
        { -0.15f, 0.1f, 0.6691893f, 0.6691893f, 0.6691893f }, //북두칠성
        { 0f, -0.4f, 0.4892082f, 0.4892082f, 0.4892082f }, //카시오페아자리
    };
    // Start is called before the first frame update
    void Start()
    {
        setRenderer = setObject.GetComponent<SpriteRenderer>();
        mainSetRenderer = mainSetObj.GetComponent<SpriteRenderer>();
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

            mainSetRenderer.sprite  = mainSetSprite[MenuManager.starSet - 1];
            mainSetObj.transform.localScale = new Vector3(setMapSpritePosition[MenuManager.starSet - 1, 2], setMapSpritePosition[MenuManager.starSet - 1, 3], setMapSpritePosition[MenuManager.starSet - 1, 4]);
            mainSetObj.transform.position = new Vector3(setMapSpritePosition[MenuManager.starSet - 1, 0], setMapSpritePosition[MenuManager.starSet - 1, 1], 5);

            setRenderer.sprite = setSprite[MenuManager.starSet - 1];
            setObject.transform.localScale = new Vector3(spritePosition[MenuManager.starSet - 1, 2], spritePosition[MenuManager.starSet - 1, 3], spritePosition[MenuManager.starSet - 1, 4]);
            setObject.transform.position = new Vector3(spritePosition[MenuManager.starSet - 1, 0], spritePosition[MenuManager.starSet - 1, 1], 5);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
