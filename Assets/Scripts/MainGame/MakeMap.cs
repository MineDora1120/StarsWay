using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeMap : MonoBehaviour
{
    public GameObject[] gameObj = new GameObject[16];
    List<List<List<List<List<float>>>>> mapData = new List<List<List<List<List<float>>>>>
    {   
        new List<List<List<List<float>>>> //별자리 1
        {
            new List<List<List<float>>>  //배열 스테이지 (1)
            {
                new List<List<float>>   //아이템 코드 (0)
                    {
                        new List<float> { -17.98f, -7.16f }, //X, Y좌표 [1][1][0][0][0, 1]
                        new List<float> { -17.48f, -7.16f },
                        new List<float> { -16.97f, -7.16f },
                        new List<float> { -11.48f, -7.16f },
                        new List<float> { -11.04f, -7.16f },
                        new List<float> { -10.52f, -7.16f },
                        new List<float> { -10.03f, -7.16f },
                        new List<float> { -9.49f, -7.16f },
                        new List<float> { -8.96f, -7.16f },
                        new List<float> { 10.51f, -7.16f },
                        new List<float> { 11.09f, -7.16f },
                        new List<float> { 11.67f, -7.16f },
                        new List<float> { 12.10f, -7.16f },
                        new List<float> { 12.75f, -7.16f },
                        new List<float> { 13.25f, -7.16f },
                        new List<float> { 13.77f, -7.16f },
                        new List<float> { 14.25f, -7.16f },
                        new List<float> { 14.75f, -7.16f },
                        new List<float> { 15.27f, -7.16f },
                        new List<float> { 15.77f, -7.16f },
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                        new List<float> { -15.07f, -6.25f }, //X, Y좌표
                        new List<float> { -0.75f, -6.59f },
                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                        new List<float> { -14.28f, -5.5f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                        new List<float> { -5.18f, -6.66f }, //X, Y좌표
                        new List<float> { 6.12f, -6.72f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -15.95f, -7.16f }, //X, Y좌표
                        new List<float> { -12.75f, -7.16f }, //X, Y좌표
                        new List<float> { -8.83f, -5.5f }, //X, Y좌표
                        new List<float> { 3.81f, -7.16f }, //X, Y좌표
                        new List<float> { 6.16f, -5.97f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { -2.33f, -7.2f }, //X, Y좌표
                        new List<float> { -2f, -6.8f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                        new List<float> { -14.53f, -6.25f }, //X, Y좌표
                        new List<float> { -14f, -6.25f }, //X, Y좌표
                        new List<float> { -0.2f, -6.59f }, //X, Y좌표
                        new List<float> { 0.32f, -6.59f }, //X, Y좌표
                        new List<float> { 0.81f, -6.59f }, //X, Y좌표
                        new List<float> { 1.34f, -6.59f }, //X, Y좌표
                        new List<float> { 1.83f, -6.59f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                        new List<float> { -13.45f, -6.25f }, //X, Y좌표
                        new List<float> { 2.35f, -6.59f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                        new List<float> { -5.79f, -6.65f }, //X, Y좌표
                        new List<float> { 5.6f, -6.72f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                        new List<float> { -4.63f, -6.65f }, //X, Y좌표
                        new List<float> { 6.67f, -6.72f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                        new List<float> { -7.48f, -7.09f }, //X, Y좌표
                        new List<float> { 0.7f, -7.09f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                        new List<float> { -11.5f, -6.30f }, //X, Y좌표
                        new List<float> { -10.96f, -6.30f }, //X, Y좌표
                        new List<float> { -10.42f, -6.30f }, //X, Y좌표
                        new List<float> { -9.88f, -6.30f }, //X, Y좌표
                        new List<float> { -9.4f, -6.30f }, //X, Y좌표
                        new List<float> { -8.85f, -6.30f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 18.62f, -7.1f }, //X, Y좌표
                    },
            }
        }
    };
    //첫번째 배열 별자리, 두번째 배열 스테이지
    //세번째 배열 0 가시, 1 왼잔디, 2 별자리 파편, 3 돌, 4 빨간 버섯, 5 잎, 6 박스, 7 중간잔디, 8오잔디, 9왼돌 10오돌, 11 썩은 버섯, 12 흙, 13 잘린 나무, 14 몬스터, 15도착지점  //네번째 배열은 좌표를 담습니다 으으살려주세요
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(mapData.Count); //1
        Debug.Log(mapData[MenuManager.starSet - 1].Count); //1
        Debug.Log(mapData[MenuManager.starSet - 1][MenuManager.starNum - 1].Count); //16
        Debug.Log(mapData[MenuManager.starSet - 1][MenuManager.starNum - 1][0].Count); //20
        Debug.Log(mapData[MenuManager.starSet - 1][MenuManager.starNum - 1][0][1].Count); //2
        for (int i = 0; i <= 15; i++)
        {
            for (int j = 0; j < mapData[MenuManager.starSet - 1][MenuManager.starNum - 1][i].Count; j++)
            {
                transform.position = new Vector2(mapData[MenuManager.starSet - 1][MenuManager.starNum - 1][i][j][0], mapData[MenuManager.starSet - 1][MenuManager.starNum - 1][i][j][1]);
                Instantiate(gameObj[i], transform.position, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
