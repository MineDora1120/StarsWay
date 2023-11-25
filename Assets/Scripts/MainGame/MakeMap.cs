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
                        new List<float> { -17.98f, -7.16f, 0f }, //X, Y좌표 [1][1][0][0][0, 1]
                        new List<float> { -17.48f, -7.16f, 0f },
                        new List<float> { -16.97f, -7.16f, 0f },
                        new List<float> { -11.48f, -7.16f, 0f },
                        new List<float> { -11.04f, -7.16f, 0f },
                        new List<float> { -10.52f, -7.16f, 0f },
                        new List<float> { -10.03f, -7.16f, 0f },
                        new List<float> { -9.49f, -7.16f, 0f },
                        new List<float> { -8.96f, -7.16f, 0f },
                        new List<float> { 10.51f, -7.16f, 0f },
                        new List<float> { 11.09f, -7.16f, 0f },
                        new List<float> { 11.67f, -7.16f, 0f },
                        new List<float> { 12.10f, -7.16f, 0f },
                        new List<float> { 12.75f, -7.16f, 0f },
                        new List<float> { 13.25f, -7.16f, 0f },
                        new List<float> { 13.77f, -7.16f, 0f },
                        new List<float> { 14.25f, -7.16f, 0f },
                        new List<float> { 14.75f, -7.16f, 0f },
                        new List<float> { 15.27f, -7.16f, 0f },
                        new List<float> { 15.77f, -7.16f, 0f },
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                        new List<float> { -15.07f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -0.75f, -6.59f, 0f },
                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                        new List<float> { -14.28f, -5.5f, 0f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                        new List<float> { -5.18f, -6.66f, 0f }, //X, Y좌표
                        new List<float> { 6.12f, -6.72f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -15.95f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { -12.75f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { -8.83f, -5.5f, 0f }, //X, Y좌표
                        new List<float> { 3.81f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 6.16f, -5.97f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { -2.33f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { -2f, -6.8f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                        new List<float> { -14.53f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -14f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -0.2f, -6.59f, 0f }, //X, Y좌표
                        new List<float> { 0.32f, -6.59f, 0f }, //X, Y좌표
                        new List<float> { 0.81f, -6.59f, 0f }, //X, Y좌표
                        new List<float> { 1.34f, -6.59f, 0f }, //X, Y좌표
                        new List<float> { 1.83f, -6.59f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                        new List<float> { -13.45f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { 2.35f, -6.59f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                        new List<float> { -5.79f, -6.65f, 0f }, //X, Y좌표
                        new List<float> { 5.6f, -6.72f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                        new List<float> { -4.63f, -6.65f, 0f }, //X, Y좌표
                        new List<float> { 6.67f, -6.72f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                        new List<float> { -7.48f, -7.09f, 0f }, //X, Y좌표
                        new List<float> { 0.7f, -7.09f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                        new List<float> { -11.5f, -6.30f, 0f }, //X, Y좌표
                        new List<float> { -10.96f, -6.30f, 0f }, //X, Y좌표
                        new List<float> { -10.42f, -6.30f, 0f }, //X, Y좌표
                        new List<float> { -9.88f, -6.30f, 0f }, //X, Y좌표
                        new List<float> { -9.4f, -6.30f, 0f }, //X, Y좌표
                        new List<float> { -8.85f, -6.30f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 18.62f, -7.1f, 0f }, //X, Y좌표
                    },
            },
             new List<List<List<float>>>  //배열 스테이지 (2)
            {
                new List<List<float>>   //아이템 코드 (0)
                    {
                        new List<float> { -17.92f, -7.16f, 0f },
                        new List<float> { -0.9f, -6f, 0f },//X, Y좌표 [1][1][0][0][0, 1]
                        new List<float> { 14.67f, -7.16f, 0f },
                        new List<float> { 15.19f, -7.16f, 0f },
                        new List<float> { 15.74f, -7.16f, 0f },
                        new List<float> { 16.3f, -7.16f, 0f },
                        new List<float> { 16.8f, -7.16f, 0f },
                        new List<float> { 17.32f, -7.16f, 0f },
                        new List<float> { 17.87f, -7.16f, 0f },
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                        new List<float> { 6.2f, -6.25f, 0f }, //X, Y좌표
                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                        new List<float> { -11.44f, -6f, 0f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                        new List<float> { -4f, -6.6f, 0f }, //X, Y좌표
                        new List<float> { -3.45f, -6.6f, 0f }, //X, Y좌표
                        new List<float> { -2.9f, -6.6f, 0f }, //X, Y좌표
                        new List<float> { -2.35f, -6.6f, 0f }, //X, Y좌표
                        new List<float> { -1.26f, -6.6f, 0f }, //X, Y좌표
                        new List<float> { -1.81f, -6.6f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -5.67f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 0.7f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 2.34f, -5.76f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                        new List<float> { -15f, -7.1f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { 2.33f, -6.36f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                        new List<float> { 6.74f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { 7.24f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { 7.8f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { 8.3f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { 8.87f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { 9.38f, -6.25f ,0f}, //X, Y좌표
                        new List<float> { 9.91f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { 10.4f, -6.25f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                        new List<float> { 11f, -6.25f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                        new List<float> { -4.52f, -6.6f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                        new List<float> { -0.74f, -6.65f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                        new List<float> { -8f, -7.09f, 0f }, //X, Y좌표
                        new List<float> { -3f, -7.09f, 0f }, //X, Y좌표
                        new List<float> { 7.29f, -7.09f, 0f }, //X, Y좌표
                        new List<float> { 9.7f, -7.09f, 0f }, //X, Y좌표
                        new List<float> { 12.76f, -7.09f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                        new List<float> { -11.42f, -6.6f, 0f }, //X, Y좌표
                        new List<float> { 17f, -6.4f, 0f }, //X, Y좌표
                        new List<float> { 17.58f, -6.4f, 0f }, //X, Y좌표
                        new List<float> { 18.11f, -6.4f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                        new List<float> { -3.9f, -6.1f, 0f }, //X, Y좌표
                        new List<float> { -2.48f, -6.1f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                        new List<float> { -12.52f, -7.1f, 0f }, //X, Y좌표
                        new List<float> { 8.8f, -5f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 19.34f, -7.1f, 0f }, //X, Y좌표
                    },
            },
            new List<List<List<float>>>  //배열 스테이지 (3)
            {
                new List<List<float>>   //아이템 코드 (0)
                    {
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                        new List<float> { -15.7f, -6f, 0f }, //X, Y좌표
                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                        new List<float> { -5.9f, -7.16f, 0f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -0.85f, -7.16f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                        new List<float> { -17.5f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { -7.36f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 8.46f, -7.16f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { 10.41f, -7.25f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                        new List<float> { -15.13f, -6f, 0f }, //X, Y좌표
                        new List<float> { -14.56f, -6f, 0f }, //X, Y좌표
                        new List<float> { -14.03f, -6f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                        new List<float> { -13.5f, -6f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                        new List<float> { -10.4f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 5.16f, -7.16f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                        new List<float> { 3.3f, -6.73f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                        new List<float> { -14.21f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { -3.88f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { 1.4f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { 11.54f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { 14.6f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { 17.7f, -7.2f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 19.73f, -7.1f, 0f }, //X, Y좌표
                    },
            }
        },
        new List<List<List<List<float>>>> //별자리 2
        {
            new List<List<List<float>>>  //배열 스테이지 (1)
            {
                new List<List<float>>   //아이템 코드 (0)
                    {
                        new List<float> { -18.92f, -7.16f, 0f }, //X, Y좌표 [1][1][0][0][0, 1]
                        new List<float> { 5f, -7.16f, 0f },
                        new List<float> { 4.55f, -7.16f, 0f },
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                        new List<float> { -5.72f, -6.25f, 0f }, //X, Y좌표
                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                        new List<float> { -8.65f, -5.4f, 0f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                        new List<float> { -10.13f, -6.3f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -13.72f, -6f, 0f }, //X, Y좌표
                        new List<float> { 1.62f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 6.58f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 7.21f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 7.81f, -7.16f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                        new List<float> { -5.46f, -7.1f, 0f }, //X, Y좌표
                        new List<float> { -3.04f, -7.1f, 0f }, //X, Y좌표
                        new List<float> { 0f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 11f, -7.16f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { -11.4f, -7.26f, 0f }, //X, Y좌표
                        new List<float> { 15.8f, -7.26f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                        new List<float> { -5.16f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -4.65f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -4.1f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -3.53f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -3f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -2.44f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -1.93f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -1.38f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -0.82f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -0.27f, -6.25f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                        new List<float> { 0.27f, -6.25f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                        new List<float> { -10.68f, -6.25f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                        new List<float> { -9.58f, -6.3f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                        new List<float> { -10f, -6f, 0f }, //X, Y좌표
                        new List<float> { -5f, -5.5f, 0f }, //X, Y좌표
                        new List<float> { -2f, -5.5f, 0f }, //X, Y좌표
                        new List<float> { -0.67f, -5.5f, 0f }, //X, Y좌표
                        new List<float> { 10f, -6.8f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                        new List<float> { -18.92f, -6.7f, 0f }, //X, Y좌표
                        new List<float> { -13.76f, -6.7f, 0f }, //X, Y좌표
                        new List<float> { 4.28f, -6.7f, 0f }, //X, Y좌표
                        new List<float> { 4.78f, -6.7f, 0f }, //X, Y좌표
                        new List<float> { 5.3f, -6.7f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                        new List<float> { -18.91f, -6.2f, 0f }, //X, Y좌표
                        new List<float> { 9.96f, -7.33f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                        new List<float> { -16.43f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { -4.44f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { -1.4f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { 7.33f, -5.6f, 0f }, //X, Y좌표
                        new List<float> { 14.74f, -7.28f, 0f }, //X, Y좌표
                        new List<float> { 16.74f, -7.23f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 18.62f, -7.1f, 0f }, //X, Y좌표
                    },
            },
             new List<List<List<float>>>  //배열 스테이지 (2)
            {
                new List<List<float>>   //아이템 코드 (0)
                    {
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                     new List<float> { 13f, -6.1f, 0f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -6.10f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 13.37f, -7.16f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                        new List<float> { -19.16f, -7.16f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { -18.83f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { 0.8f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { 3.6f, -7.27f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                        new List<float> { 15.21f, -6f, 0f }, //X, Y좌표
                        new List<float> { 15.77f, -6f, 0f }, //X, Y좌표
                        new List<float> { 16.32f, -6f, 0f }, //X, Y좌표
                        new List<float> { 16.87f, -6f, 0f }, //X, Y좌표
                        new List<float> { 17.41f, -6f, 0f }, //X, Y좌표
                        new List<float> { 17.93f, -6f, 0f }, //X, Y좌표
                        new List<float> { 18.49f, -6f, 0f }, //X, Y좌표
                        new List<float> { 14.78f, -6f, 0f }, //X, Y좌표
                        new List<float> { -8.1f, -6f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                        new List<float> { 8.85f, -7.3f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                         new List<float> { -18.08f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { -17.07f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { -16.08f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { -15.08f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { -14.08f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { -13.08f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { -12.08f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { -11.08f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { -9.08f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { -4.4f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { -2.4f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { 0.5f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { 5.33f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { 6.77f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { 8.10f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { 12.22f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { 10.2f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { 12.07f, -7.1f, 0f }, //X, Y좌표
                         new List<float> { 15.94f, -5f, 0f }, //X, Y좌표
                         new List<float> { 16.74f, -5f, 0f },
                         new List<float> { 17.94f, -5f, 0f },
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 19.34f, -7.1f, 0f }, //X, Y좌표
                    },
            },
            new List<List<List<float>>>  //배열 스테이지 (3)
            {
                new List<List<float>>   //아이템 코드 (0)
                    {
                        new List<float> { -12.13f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { -17.01f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 4.14f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 4.65f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 5.18f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 5.77f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 6.28f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 6.86f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 7.38f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 7.9f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 8.43f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 8.92f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 9.45f, -7.16f, 0f }, //X, Y좌표
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                        new List<float> { -14.6f, -6.5f, 0f }, //X, Y좌표
                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                        new List<float> { -16.16f, -7.32f, 0f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -17.70f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { -8.32f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 4.77f, -4.9f, 0f }, //X, Y좌표
                        new List<float> { 8.27f, -3.46f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                        new List<float> { -9.6f, -7.16f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { -6.52f, -5.57f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                        new List<float> { -14.13f, -6.5f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                        new List<float> { -13.63f, -6.5f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                        new List<float> { -14.75f, -7.1f, 0f }, //X, Y좌표
                        new List<float> { -5.48f, -7.1f, 0f }, //X, Y좌표
                        new List<float> { -3f, -7.1f, 0f }, //X, Y좌표
                        new List<float> { -0.5f, -7.1f, 0f }, //X, Y좌표
                        new List<float> { 19.23f, -7.1f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                        new List<float> { -6.8f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -6.32f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -5.73f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -5.17f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -4.64f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -4.08f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -3.57f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -3.04f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -2.5f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -1.94f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -1.4f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -0.87f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { -0.31f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { 0.23f, -6.25f, 0f }, //X, Y좌표
                        new List<float> { 4.76f, -5.78f, 0f }, //X, Y좌표
                        new List<float> { 8.25f, -4.26f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                        new List<float> { -4.01f, -5.6f, 0f }, //X, Y좌표
                        new List<float> { -1.41f, -5.6f, 0f }, //X, Y좌표
                        new List<float> { 16.22f, -7.2f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 12.77f, -7.13f, 0f }, //X, Y좌표
                    },
            }
        },
        new List<List<List<List<float>>>> //별자리 3
        {
            new List<List<List<float>>>  //배열 스테이지 (1)
            {
                new List<List<float>>   //아이템 코드 (0)
                    {
                        new List<float> { -9.62f, -7.16f, 0f }, //X, Y좌표 [1][1][0][0][0, 1]
                        new List<float> { -7.56f, -7.16f, 0f },
                        new List<float> { 6.84f, -7.16f, 0f },
                        new List<float> { 15.38f, -7.16f, 0f },
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                        new List<float> { -12.75f, -6.5f, 0f }, //X, Y좌표
                        new List<float> { -13.24f, -6.5f, 0f }, //X, Y좌표
                        new List<float> { 5.23f, -2.7f, 0f }, //X, Y좌표
                        new List<float> { 12.39f, -4.7f, 0f }, //X, Y좌표
                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                        new List<float> { -13.18f, -7.24f, 0f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                        new List<float> { -4.15f, -4.8f, 0f }, //X, Y좌표
                        new List<float> { 9.9f, -6.3f, 0f }, //X, Y좌표
                        new List<float> { 10.36f, -6.3f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -17.78f, -6.56f, 0f }, //X, Y좌표
                        new List<float> { -11.624f, -5.7f, 0f }, //X, Y좌표
                        new List<float> { -4f, -4.02f, 0f }, //X, Y좌표
                        new List<float> { 12.42f, -4f, 0f }, //X, Y좌표
                        new List<float> { 19.22f, -7.12f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                        new List<float> { -14.30f, -7.1f, 0f }, //X, Y좌표                  
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { -0.52f, -3.7f, 0f }, //X, Y좌표
                        new List<float> { 2.43f, -2.67f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                        new List<float> { -12.22f, -6.5f, 0f }, //X, Y좌표
                        new List<float> { -5.80f, -2.7f, 0f }, //X, Y좌표
                        new List<float> { -6.36f, -2.7f, 0f }, //X, Y좌표
                        new List<float> { -7f, -2.7f, 0f }, //X, Y좌표
                        new List<float> { 12.9f, -4.7f, 0f }, //X, Y좌표
                        new List<float> { 13.43f, -4.7f, 0f }, //X, Y좌표
                        new List<float> { 5.77f, -2.7f, 0f }, //X, Y좌표
                        new List<float> { 6.21f, -2.7f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                        new List<float> { -11.65f, -6.5f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                        new List<float> { -4.72f, -4.77f, 0f }, //X, Y좌표
                        new List<float> { 9.36f, -6.25f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                        new List<float> { -3.6f, -4.7f, 0f }, //X, Y좌표
                        new List<float> { 10.93f, -6.3f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                        new List<float> { -16.6f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { -8.56f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { -6.46f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 0.10f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 10f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 13.57f, -7.16f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                        new List<float> { -17.83f, -7.35f, 0f }, //X, Y좌표
                        new List<float> { -9.66f, -5.74f, 0f }, //X, Y좌표
                        new List<float> { -9.13f, -5.74f, 0f }, //X, Y좌표
                        new List<float> { -8.58f, -5.7f, 0f }, //X, Y좌표
                        new List<float> { -8.03f, -5.7f, 0f }, //X, Y좌표
                        new List<float> { -7.45f, -5.7f, 0f }, //X, Y좌표
                        new List<float> { -7f, -5.7f, 0f }, //X, Y좌표
                        new List<float> { -6.33f, -5.7f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                        new List<float> { -18.62f, -7.34f, 0f }, //X, Y좌표
                        new List<float> { -14.16f, -7.22f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                        new List<float> { -11.6f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { -2.94f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { 3.67f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { 17.91f, -7.2f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 6.21f, -2f, 0f }, //X, Y좌표
                    },
            },
             new List<List<List<float>>>  //배열 스테이지 (2)
            {
                new List<List<float>>   //아이템 코드 (0)
                    {
                        new List<float> { -16.22265f , -7.16f , 0f },
                        new List<float> { -12.97f , -6.6f , 180f },
                        new List<float> { -12.51f , -6.6f , 180f },
                        new List<float> { -12.05f , -6.6f , 180f },
                        new List<float> { -11.53f , -6.6f , 180f },
                        new List<float> { -5.714f , -5.31f , 0f },
                        new List<float> { -5.930361f , -7.16f , 0f },
                        new List<float> { -3.054439f , -5.31f , 0f },
                        new List<float> { 7.48f , -4.655503f , 0f },
                        new List<float> { 8f , -4.66f , 0f },
                        new List<float> { 8.5f , -4.64f , 0f },
                        new List<float> { 8.98f , -4.64f , 0f },
                        new List<float> { 9.474844f , -4.666163f , 0f }
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                     new List<float> { -15.65727f , -6.610206f , 0f },
                    new List<float> { -1.75f , -5.252196f , 0f },

                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                     new List<float> { -12.88f , -7.14f , 0f },
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                        new List<float> { -12.04728f , -6.065955f , 0f },
                        new List<float> { -12.48276f , -6.065955f , 0f },
                        new List<float> { 7.908933f , -5.328313f , 0f },
                        new List<float> { 8.457324f , -5.328313f , 0f },
                        new List<float> { 9.005787f , -5.328313f , 0f },
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -7.92f , -7.11f , 0f },
                        new List<float> { 8.50472f , -7.057255f , 0f },
                        new List<float> { -1.71734f , -4.511337f , 0f },

                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                        new List<float> { -11.31757f , -7.10168f , 0f },
                        new List<float> { 15.35f , -7.08f , 0f },

                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { 1.348552f , -6.100121f , 0f },
                        new List<float> { 12.03215f , -7.279532f , 0f },
                        new List<float> { 3.481184f , -7.278146f , 0f },
                        new List<float> { 16.56f , -7.238769f , 0f },

                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                       new List<float> { -15.13f , -6.610206f , 0f },
                        new List<float> { -0.69f , -5.252196f , 0f },
                        new List<float> { -0.2058401f , -5.252196f , 0f },
                        new List<float> { -1.18f , -5.252196f , 0f },

                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                       new List<float> { -14.63984f , -6.610206f , 0f },
                        new List<float> { 0.334985f , -5.252196f , 0f },

                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                        new List<float> { -13.02416f , -6.065955f , 0f },
                        new List<float> { 7.340231f , -5.328313f , 0f },

                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                        new List<float> { -11.50588f , -6.065955f , 0f },
                        new List<float> { 9.54f , -5.328313f , 0f },
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                        new List<float> { -16.88456f , -7.148005f , 0f },
                        new List<float> { -12.20029f , -5.26f , 0f },
                        new List<float> { -1.95586f , -7.114934f , 0f },
                        new List<float> { 2.262537f , -7.095349f , 0f },
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                            new List<float> { -19.11849f , -7.410009f , 0f },
                            new List<float> { -3.1053f , -6.06f , 0f },
                            new List<float> { -5.696139f , -6.06f , 0f },
                            new List<float> { -5.213083f , -6.06f , 0f },
                            new List<float> { -3.588334f , -6.06f , 0f },
                            new List<float> { -4.715411f , -6.06f , 0f },
                            new List<float> { -4.15f , -6.06f , 0f },
                            new List<float> { 5.272874f , -6.312663f , 0f },

                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                        new List<float> { -14.63659f , -6.1f , 0f },
                        new List<float> { 1.391491f , -5.726494f , 0f },

                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                        new List<float> { -18.24974f , -7.341061f , 0f },
                        new List<float> { -9.9876f , -7.372381f , 0f },
                        new List<float> { 14.41238f , -6.965412f , 0f },

                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 18.33003f , -7.085908f , 0f },

                    },
            },
            new List<List<List<float>>>  //배열 스테이지 (3)
            {
            new List<List<float>>   //아이템 코드 (0)
                    {
                        new List<float> { -8.86256f, 1.438178f, 0f }, //X, Y좌표
                        new List<float> { -8.398781f, 1.44f, 0f }, //X, Y좌표
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {

                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                        new List<float> { -18.19612f, -2.445975f, 0f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                    },
                   new List<List<float>>   //아이템 코드 (4)
                        {
                        },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                        new List<float> { -17.90626f, -7.025797f, 0f }, //X, Y좌표
                        new List<float> { -14.89169f, -7.025797f, 0f }, //X, Y
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { -15.70331f, -6.504045f, 0f }, //X, Y좌표
                        new List<float> { -10.02201f, -6.562017f, 0f }, //X, Y좌표
                        new List<float> { -9.906064f, -2.967727f, 0f }, //X, Y좌표
                        new List<float> { -15.58736f, 0.8584535f, 0f }, //X, Y좌표
                        new List<float> { -7.181359f, 0.6845365f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {

                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {

                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                        new List<float> { -16.86276f, -6.562017f, 0f }, //X, Y좌표
                        new List<float> { -16.28303f, -6.562017f, 0f }, //X, Y좌표
                        new List<float> { -11.2974f, -6.562017f, 0f }, //X, Y좌표
                        new List<float> { -10.71768f, -6.562017f, 0f }, //X, Y좌표
                        new List<float> { -6.94947f, -6.677962f, 0f }, //X, Y좌표
                        new List<float> { -6.311773f, -6.735935f, 0f }, //X, Y좌표
                        new List<float> { -8.746615f, -4.24312f, 0f }, //X, Y좌표
                        new List<float> { -4.80449f, -5.866348f, 0f }, //X, Y좌표
                        new List<float> { -3.355179f, -4.359065f, 0f }, //X, Y좌표
                        new List<float> { -5.674076f, -3.721368f, 0f }, //X, Y좌표
                        new List<float> { -8.166891f, -4.24312f, 0f }, //X, Y좌표
                        new List<float> { -9.036477f,-3.141644f, 0f }, //X, Y좌표
                        new List<float> { -18.19612f, -3.083672f, 0f }, //X, Y좌표
                        new List<float> { -19.87732f, -1.576388f, 0f }, //X, Y좌표
                        new List<float> { -18.2541f, -0.4169399f, 0f }, //X, Y좌표
                        new List<float> { -16.39898f, 0.858453f, 0f }, //X, Y좌표
                        new List<float> { -8.86256f, 0.7425089f, 0f }, //X, Y좌표
                        new List<float> { -9.442285f, 0.8004813f, 0f }, //X, Y좌표
                        new List<float> { -10.02201f, 0.684536f, 0f }, //X, Y좌표
                        new List<float> { -8.398781f, 0.74f, 0f }, //X, Y좌표
                        new List<float> { -7.82f, 0.63f, 0f }, //X, Y좌표
                        new List<float> { -1.326143f, 0.3367019f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                        new List<float> { -15.99317f, -7.257687f, 0f }, //X, Y좌표
                        new List<float> { -13.50035f, -7.199714f, 0f }, //X, Y좌표
                        new List<float> { -11.47132f, -7.141742f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { -1.384116f, 1.206288f, 0f }, //X, Y좌표
                    },
            }
         },
                new List<List<List<List<float>>>> //별자리 4
        {
            new List<List<List<float>>>  //배열 스테이지 (1)
            {
            new List<List<float>>   //아이템 코드 (0)
                    {

        new List<float> { -16.21f , 0.349f , 0f },
        new List<float> { -15.60639f , 0.4146578f , 0f },
        new List<float> { -18.776f , -5.568f , 180f },
        new List<float> { -17.788f , -5.577f , 180f },
        new List<float> { -18.282f , -5.577f , 180f },
        new List<float> { -8.984693f , 11.23933f , 0f },
        new List<float> { -8.573992f , 11.26039f , 0f },
        new List<float> { -14.151f , -7.173f , 0f },
        new List<float> { -13.56672f , -7.188751f , 0f },
        new List<float> { -8.959571f , -7.120999f , 0f },
        new List<float> { -8.46f , -7.120999f , 0f },
        new List<float> { -7.92f , -7.14f , 0f },
        new List<float> { -7.39f , -7.13f , 0f },
        new List<float> { 7.23f , 0.33f , 0f },
        new List<float> { 1.199521f , -2.444557f , 0f },
        new List<float> { 1.598733f , -2.454793f , 0f },
        new List<float> { 4.37f , -5.45f , 90f },
        new List<float> { 4.41f , -5.98f , 90f },
        new List<float> { -0.2745017f , -4.031152f , 0f },
        new List<float> { -4.839f , -3.994f , 180f },
        new List<float> { -4.839f , -3.994f , 180f },
        new List<float> { -0.7556034f , -4.01068f , 0f },
        new List<float> { -5.417f , -3.934f , 180f },
        new List<float> { -4.311f , -3.984f , 180f },
        new List<float> { -1.45f , -4.77f , 90f },
        new List<float> { -4.348861f , -2.356211f , 0f },
        new List<float> { -5.5f , -2.33f , 0f },
        new List<float> { -6.86f , -7.120999f , 0f },
        new List<float> { -1.43f , -5.19f , 90f },
        new List<float> { -0.3f , -7.165867f , 0f },
        new List<float> { -4.91735f , -2.32848f , 0f },
        new List<float> { 4.44f , -6.51f , 90f },
        new List<float> { 4.41f , -4.88f , 90f },
        new List<float> { 7.596337f , 0.32f , 0f },
        new List<float> { 6.188051f , -7.138558f , 0f },



                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {

                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
        new List<float> { -10.55358f , 7.527061f , 0f }

                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
        new List<float> { -15.802f , -0.3276138f , 0f },
        new List<float> { -15.802f , -0.3276138f , 0f },
        new List<float> { -15.802f , -0.3276138f , 0f },
        new List<float> { -15.296f , -0.3276138f , 0f },
        new List<float> { -15.267f , -0.49f , 180f },
        new List<float> { -16.859f , -0.315f , 270f },
        new List<float> { -15.038f , 0.605f , 90.71217f },
        new List<float> { -14.5f , 0.839f , 180f },
        new List<float> { -14.724f , -0.053f , 270f },
        new List<float> { -14.481f , 1.165f , 0f },
        new List<float> { -15.022f , 0.132f , 90.71217f },
        new List<float> { -17.432f , 0.665f , 90f },
        new List<float> { -17.81f , -0.574f , 0f },
        new List<float> { -17.412f , -0.833f , 180f },
        new List<float> { -17.427f , -0.291f , 90.71217f },
        new List<float> { -17.428f , 0.1729999f , 90.71217f },
        new List<float> { -16.866f , 0.125f , 270f },
        new List<float> { -15.83f , -0.506f , 180f },
        new List<float> { -16.369f , -0.53f , 180f },
        new List<float> { -16.373f , -0.3276138f , 0f },
        new List<float> { -16.866f , 0.623f , 270f },
        new List<float> { -18.294f , -4.417f , 270f },
        new List<float> { -17.864f , -4.969f , 180f },
        new List<float> { -18.85f , -4.402f , 90.71217f },
        new List<float> { -15.33f , -6.315f , 90f },
        new List<float> { -14.807f , -6.354f , 270f },
        new List<float> { -18.3057f , -3.426f , 270f },
        new List<float> { -18.839f , -3.454f , 90f },
        new List<float> { -18.868f , -3.954f , 90.71217f },
        new List<float> { -18.3057f , -3.945f , 270f },
        new List<float> { -18.313f , -4.96f , 180f },
        new List<float> { -17.762f , -4.664f , 0f },
        new List<float> { -12.56f , -1.286f , 270f },
        new List<float> { -13.104f , -1.796f , 90f },
        new List<float> { -13.133f , -2.296f , 90f },
        new List<float> { -13.083f , -1.247f , 90f },
        new List<float> { -12.5707f , -2.287f , 270f },
        new List<float> { -12.05f , 1.165f , 0f },
        new List<float> { -12.49f , 1.149f , 0f },
        new List<float> { -12.5707f , -1.768f , 270f },
        new List<float> { -12.053f , 0.823f , 180f },
        new List<float> { -12.305f , 0.823f , 180f },
        new List<float> { -13.382f , 0.831f , 180f },
        new List<float> { -13.037f , 1.157f , 0f },
        new List<float> { -12.835f , 0.823f , 180f },
        new List<float> { -13.518f , 1.149f , 0f },
        new List<float> { -13.96684f , 1.140682f , 0f },
        new List<float> { -13.953f , 0.855f , 180f },
        new List<float> { -11.26301f , 1.180526f , 0f },
        new List<float> { -11.528f , 1.157f , 0f },
        new List<float> { -10.422f , 1.398f , 270f },
        new List<float> { -10.992f , 0.839f , 180f },
        new List<float> { -10.414f , 1.945f , 270f },
        new List<float> { -10.89f , 1.36f , 79.99999f },
        new List<float> { -10.422f , 1.398f , 270f },
        new List<float> { -9.89f , 6.37f , 180f },
        new List<float> { -10.882f , 6.011f , 79.99999f },
        new List<float> { -10.414f , 6.489f , 270f },
        new List<float> { -10.882f , 5.587f , 79.99999f },
        new List<float> { -10.414f , 5.625f , 270f },
        new List<float> { -10.414f , 6.049f , 270f },
        new List<float> { -10.882f , 6.451f , 79.99999f },
        new List<float> { -10.414f , 5.176f , 270f },
        new List<float> { -10.882f , 5.138f , 79.99999f },
        new List<float> { -10.882f , 3.482f , 79.99999f },
        new List<float> { -10.882f , 2.976f , 79.99999f },
        new List<float> { -10.414f , 2.459f , 270f },
        new List<float> { -10.882f , 4.037f , 79.99999f },
        new List<float> { -10.414f , 3.014f , 270f },
        new List<float> { -10.882f , 1.907f , 79.99999f },
        new List<float> { -10.882f , 2.421f , 79.99999f },
        new List<float> { -14.748f , 0.387f , 270f },
        new List<float> { -11.539f , 0.823f , 180f },
        new List<float> { -8.54f , 7.98f , 270f },
        new List<float> { -9.03f , 7.41f , 90f },
        new List<float> { -9.08f , 7.07f , 90f },
        new List<float> { -9.04f , 9.4f , 90f },
        new List<float> { -9.03f , 9.88f , 90f },
        new List<float> { -8.55f , 9.45f , 270f },
        new List<float> { -8.54f , 9.93f , 270f },
        new List<float> { -8.56f , 8.93f , 270f },
        new List<float> { -9.03f , 8.4f , 90f },
        new List<float> { -9.03f , 7.93f , 90f },
        new List<float> { -8.54f , 7.46f , 270f },
        new List<float> { -8.54f , 6.9f , 270f },
        new List<float> { -9.05f , 8.88f , 90f },
        new List<float> { -8.54f , 8.45f , 270f },
        new List<float> { -8.54f , 10.26f , 270f },
        new List<float> { -9.03f , 10.21f , 90f },
        new List<float> { -9.36f , 6.4f , 180f },
        new List<float> { -9.21f , 6.82f , 0f },
        new List<float> { -8.99f , 6.81f , 0f },
        new List<float> { -14.8177f , -7.355f , 270f },
        new List<float> { -14.8177f , -6.836f , 270f },
        new List<float> { -15.351f , -6.864f , 90f },
        new List<float> { -15.38f , -7.364f , 90f },
        new List<float> { -8.532525f , -6.432967f , 0f },
        new List<float> { -8.48f , -6.81f , 180f },
        new List<float> { -8.48f , -5.093359f , 180f },
        new List<float> { -7.93f , -6.82f , 180f },
        new List<float> { -7.435f , -4.716359f , 0f },
        new List<float> { -7.5f , -6.82f , 180f },
        new List<float> { -7.435f , -6.433f , 0f },
        new List<float> { -7.93f , -5.103359f , 180f },
        new List<float> { -7.974f , -4.716359f , 0f },
        new List<float> { -8.532525f , -4.716326f , 0f },
        new List<float> { -10.414f , 4.075f , 270f },
        new List<float> { -9.01f , 6.39f , 180f },
        new List<float> { -10.414f , 4.613f , 270f },
        new List<float> { -10.882f , 4.575f , 79.99999f },
        new List<float> { -9.73f , 6.82f , 0f },
        new List<float> { -7.974f , -6.433f , 0f },
        new List<float> { -7.5f , -5.103359f , 180f },
        new List<float> { 7.092999f , -3.36f , 90f },
        new List<float> { 7.171f , -3.115f , 90f },
        new List<float> { 7.17f , -3.899001f , 180f },
        new List<float> { 6.621219f , -3.526325f , 0f },
        new List<float> { 6.640828f , -3.908449f , 180f },
        new List<float> { 7.171f , -2.674f , 90f },
        new List<float> { 7.63f , -2.615f , 270f },
        new List<float> { 7.171f , -2.125f , 90f },
        new List<float> { 7.63f , -2.978f , 270f },
        new List<float> { 7.63f , -1.821f , 270f },
        new List<float> { 7.63f , -1.468f , 270f },
        new List<float> { 7.171f , -1.664f , 90f },
        new List<float> { 7.63f , -1.135f , 270f },
        new List<float> { 7.171f , -1.213f , 90f },
        new List<float> { 7.63f , -0.87f , 270f },
        new List<float> { 7.171f , -0.87f , 90f },
        new List<float> { 11.88233f , 6.938928f , 0f },
        new List<float> { 12.43111f , 6.968322f , 0f },
        new List<float> { 11.51f , 6.62f , 180f },
        new List<float> { 12.01911f , 6.62f , 180f },
        new List<float> { 12.51911f , 6.62f , 180f },
        new List<float> { 5.13f , -5.285f , 90f },
        new List<float> { 5.13f , -6.079f , 90f },
        new List<float> { 5.589001f , -5.55f , 270f },
        new List<float> { 1.625f , -4.996f , 270f },
        new List<float> { 1.165999f , -4.869f , 90f },
        new List<float> { 5.589001f , -5.285f , 270f },
        new List<float> { 1.625f , -3.614f , 270f },
        new List<float> { 2.97f , -2.289f , 90f },
        new List<float> { 7.63f , -2.252f , 270f },
        new List<float> { 3.19f , -2.789f , 180f },
        new List<float> { 3.52f , -2.789f , 180f },
        new List<float> { 1.625f , -5.722f , 270f },
        new List<float> { 1.625f , -5.359f , 270f },
        new List<float> { 1.43f , -6.25f , 180f },
        new List<float> { 1.76f , -6.25f , 180f },
        new List<float> { 1.76824f , -6.064225f , 0f },
        new List<float> { 1.195999f , -6.079f , 90f },
        new List<float> { 5.589001f , -5.883f , 270f },
        new List<float> { 3.429001f , -0.7499998f , 270f },
        new List<float> { 3.429001f , -1.083f , 270f },
        new List<float> { 3.429001f , -1.436f , 270f },
        new List<float> { 2.5f , -0.35f , 180f },
        new List<float> { 2.05f , -0.34f , 180f },
        new List<float> { 2.39f , 0.05f , 0f },
        new List<float> { 1.52f , -0.313f , 180f },
        new List<float> { 0.5f , -0.33f , 180f },
        new List<float> { 0.4f , 0.04f , 0f },
        new List<float> { -0.021f , 0.033f , 0f },
        new List<float> { -0.033f , -0.313f , 180f },
        new List<float> { 1.37f , 0.02f , 0f },
        new List<float> { 1.01f , -0.33f , 180f },
        new List<float> { 2.97f , -0.4849999f , 90f },
        new List<float> { 2.97f , -0.8279996f , 90f },
        new List<float> { -10.414f , 3.52f , 270f },
        new List<float> { -10.3f , 6.81f , 0f },
        new List<float> { -4.476f , -3.332323f , 180f },
        new List<float> { -4.976f , -3.332323f , 180f },
        new List<float> { -4.564f , -2.984f , 0f },
        new List<float> { -5.112777f , -3.013394f , 0f },
        new List<float> { -3.6f , -7.39f , 90f },
        new List<float> { -3.04f , -7.36f , 270f },
        new List<float> { -5.485107f , -3.332323f , 180f },
        new List<float> { 3.429001f , -1.867f , 270f },
        new List<float> { 3.51f , -2.279f , 270f },
        new List<float> { 2.95737f , 0.009361088f , 0f },
        new List<float> { 3.429001f , -0.4849999f , 270f },
        new List<float> { 1.625f , -3.879f , 270f },
        new List<float> { 1.175999f , -5.709f , 90f },
        new List<float> { 1.625f , -4.565f , 270f },
        new List<float> { 1.625f , -4.212f , 270f },
        new List<float> { 1.165999f , -4.408f , 90f },
        new List<float> { 1.86f , 0.03f , 0f },
        new List<float> { 1.165999f , -5.418f , 90f },
        new List<float> { -3.61f , -7.19f , 90f },
        new List<float> { -3.06f , -7.17f , 270f },
        new List<float> { 0.85f , 0.03f , 0f },
        new List<float> { 5.13f , -7.53f , 90f },
        new List<float> { 5.13f , -7.089f , 90f },
        new List<float> { 1.165999f , -3.614f , 90f },
        new List<float> { 1.165999f , -3.957f , 90f },
        new List<float> { 2.97f , -1.279f , 90f },
        new List<float> { 2.97f , -1.74f , 90f },
        new List<float> { 7.63f , -3.428339f , 270f },
        new List<float> { 5.589001f , -6.236f , 270f },
        new List<float> { 5.589001f , -6.667f , 270f },
        new List<float> { 5.13f , -6.54f , 90f },
        new List<float> { 5.13f , -5.628f , 90f },
        new List<float> { 5.589001f , -7.03f , 270f },
        new List<float> { 5.589001f , -7.393f , 270f },
                    },
                   new List<List<float>>   //아이템 코드 (4)
                        {
                new List<float> { -17.96361f , 0.1311477f , 0f },
                new List<float> { -18.80547f , -2.46769f , 0f },
                new List<float> { -11.49103f , 1.877258f , 0f },
                new List<float> { -11.52904f , 7.045697f , 0f },
                new List<float> { -11.49103f , 4.474143f , 0f },
                new List<float> { 6.61f , 4.9f , 0f },
                new List<float> { 8.63f , 5.93f , 0f },
                new List<float> { 4.010425f , -1.611825f , 0f },
                new List<float> { 4.11f , 3.58f , 0f },
                new List<float> { 1.9f , 2.61f , 0f },
                new List<float> { -0.3919892f , 0.7364949f , 0f },
                new List<float> { -4.250741f , -7.089446f , 0f },
                new List<float> { -4.701456f , -7.148235f , 0f },
                new List<float> { -5.632281f , -7.148235f , 0f },
                new List<float> { -6.122189f , -7.148235f , 0f },
                new List<float> { -5.161969f , -7.128638f , 0f },

                        },
                    new List<List<float>>   //아이템 코드 (5)
                    {
        new List<float> { -17.63187f , -3.993119f , 0f },
        new List<float> { -11.43f , -7.08f , 0f },

                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
        new List<float> { -17.72775f , -7.241319f , 0f },
        new List<float> { 2.45f , -7.26f , 0f },

                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {

                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {

                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                        new List<float> { -14.744f , -0.496f , 180f },
                        new List<float> { -14.744f , -0.496f , 180f },
                        new List<float> { -15.03545f , 1.148843f , 0f },
                        new List<float> { -17.4745f , 1.187201f , 0f },
                        new List<float> { -17.898f , -0.853f , 90f },
                        new List<float> { -16.874f , -0.838f , 180f },
                        new List<float> { -18.852f , -4.932f , 90f },
                        new List<float> { -15.3365f , -6.002f , 0f },
                        new List<float> { -18.815f , -3.132f , 0f },
                        new List<float> { -17.507f , -4.96f , 180f },
                        new List<float> { -13.08f , -2.72f , 90f },
                        new List<float> { -12.58f , -2.72f , 180f },
                        new List<float> { -13.0895f , -0.934f , 0f },
                        new List<float> { -10.462f , 0.85f , 180f },
                        new List<float> { -9.066148f , -4.73f , 0f },
                        new List<float> { -9.02f , -5.073359f , 90f },
                        new List<float> { -10.84498f , 6.817673f , 0f },
                        new List<float> { -9.052399f , 10.58633f , 0f },
                        new List<float> { -8.55f , 6.39f , 180f },
                        new List<float> { -9.02f , -6.79f , 90f },
                        new List<float> { -9.066148f , -6.446641f , 0f },
                        new List<float> { 6.151f , -3.928f , 90f },
                        new List<float> { 11.31411f , 6.704f , 90f },
                        new List<float> { 11.33411f , 6.899735f , 0f },
                        new List<float> { 12.95111f , 6.616f , 180f },
                        new List<float> { 6.131311f , -3.516527f , 0f },
                        new List<float> { 7.174855f , -0.3468252f , 0f },
                        new List<float> { 5.133856f , -4.761825f , 0f },
                        new List<float> { 1.169855f , -3.090825f , 0f },
                        new List<float> { 2.99f , -2.799f , 90f },
                        new List<float> { -4.044f , -3.336322f , 180f },
                        new List<float> { -0.45f , -0.3f , 90f },
                        new List<float> { -0.5035542f , 0.04324697f , 0f },
                        new List<float> { -5.681f , -3.248322f , 90f },
                        new List<float> { -0.3f , -5.18f , 180f },
                        new List<float> { -0.8f , -5.22f , 90f },
                        new List<float> { -0.79f , -4.695099f , 0f },
                        new List<float> { -5.661f , -3.052587f , 0f },
                        new List<float> { -3.633456f , -6.648529f , 0f },
                        new List<float> { 1.23f , -6.26f , 90f },
                        new List<float> { 3.93f , -2.839f , 180f },
                        new List<float> { 2.17f , -6.3f , 180f },
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {

                        new List<float> { -16.916f , 1.181f , 0f },
                        new List<float> { -17.46942f , -4.709659f , 0f },
                        new List<float> { -14.827f , -6.048f , 0f },
                        new List<float> { -18.306f , -3.122f , 0f },
                        new List<float> { -12.58f , -0.98f , 0f },
                        new List<float> { -8.52f , 10.6f , 0f },
                        new List<float> { 12.95011f , 6.929323f , 0f },
                        new List<float> { 5.594001f , -4.791f , 0f },
                        new List<float> { 7.635f , -0.376f , 0f },
                        new List<float> { -0.2676752f , -4.695099f , 0f },
                        new List<float> { 7.63f , -3.908f , 270f },
                        new List<float> { 1.63f , -3.12f , 0f },
                        new List<float> { 3.434001f , 0.009000063f , 0f },
                        new List<float> { -4.045f , -3.023f , 0f },
                        new List<float> { -6.97f , -5.113359f , 270f },
                        new List<float> { -6.925627f , -6.423169f , 0f },
                        new List<float> { -6.97f , -6.83f , 270f },
                        new List<float> { -6.925627f , -4.706528f , 0f },
                        new List<float> { 3.969308f , -2.3448f , 0f },
                        new List<float> { -3.065163f , -6.658327f , 0f },
                        new List<float> { 2.185431f , -6.064225f , 0f },
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {

                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
        new List<float> { -11.51734f , -7.22305f , 0f },

                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
        new List<float> { 12.817f , 7.722f , 0f },

                    },
            },
             new List<List<List<float>>>  //배열 스테이지 (2)
            {
                  new List<List<float>> {
new List<float> { 7.24337f , 1.856073f , 0f },
new List<float> { 4.898749f , 7.912011f , 0f },
new List<float> { 4.407f , 7.925f , 0f },
new List<float> { 3.861659f , 7.934371f , 0f },
new List<float> { 13.63f , -0.3207746f , 0f },
new List<float> { -3.360637f , 9.368402f , 0f },
new List<float> { -3.94f , 9.368402f , 0f },
new List<float> { 13.631f , -4.272f , 180f },
new List<float> { 13.638f , -4.393f , 0f },
new List<float> { 16.974f , -7.135f , 0f },
new List<float> { 16.495f , -7.144f , 0f },
new List<float> { 17.509f , -7.144f , 0f },
new List<float> { 17.978f , -7.163f , 0f },
new List<float> { -1.332057f , -7.136671f , 0f },
new List<float> { 13.64f , -2.364f , 0f },
new List<float> { -5.48f , 9.35f , 0f },
new List<float> { -4.98f , 9.368402f , 0f },
new List<float> { -4.45f , 9.368402f , 0f },
new List<float> { -9.21f , 2.98f , 90f },
new List<float> { -9.152f , 0.814f , 90f },
new List<float> { -12.26f , 3.02f , 270f },
new List<float> { -12.25f , 2.47f , 270f },
new List<float> { -12.25f , 2.47f , 270f },
new List<float> { -12.24f , 1.49f , 270f },
new List<float> { -9.153f , -0.257f , 90f },
new List<float> { -10f , -0.911f , 90f },
new List<float> { -9.187f , 2.43f , 90f },
new List<float> { -9.22f , 3.52f , 90f },
new List<float> { -9.184f , 1.89f , 90f },
new List<float> { -9.127f , 0.278f , 90f },
new List<float> { -9.166f , 1.341f , 90f },
new List<float> { -12.215f , -2.891f , 270f },
new List<float> { -9.104f , -3.412f , 90f },
new List<float> { -6.88f , -3.31f , 90f },
new List<float> { -12.234f , -5.017f , 270f },
new List<float> { -12.196f , -1.765f , 270f },
new List<float> { -12.2f , -1.23f , 270f },
new List<float> { -12.191f , -2.309f , 270f },
new List<float> { -12.249f , -6.678f , 270f },
new List<float> { -6.86f , -3.854f , 90f },
new List<float> { -16.36f , -3.6f , 270f },
new List<float> { -14.21f , -2.27f , 90f },
new List<float> { -16.33f , 2.083f , 270f },
new List<float> { -16.33f , 2.083f , 270f },
new List<float> { -14.166f , 0.74f , 90f },
new List<float> { -16.311f , -0.959f , 270f },
new List<float> { -16.311f , -0.959f , 270f },
new List<float> { -14.155f , -5.402f , 90f },
new List<float> { -12.275f , -7.247f , 270f },
new List<float> { -12.241f , -3.46f , 270f },
new List<float> { -12.22f , 0.2999995f , 270f },
new List<float> { -12.22f , 0.2999995f , 270f },
new List<float> { -12.25f , 1.97f , 270f },
new List<float> { -12.225f , -6.096f , 270f },
new List<float> { -12.23f , -5.552f , 270f },
new List<float> { -16.36f , -3.6f , 270f },
new List<float> { -19.591f , -5.845f , 270f },
new List<float> { -19.174f , -5.852f , 270f },
new List<float> { -18.204f , -5.845f , 90f },
new List<float> { -18.601f , -5.838f , 90f },
new List<float> { -14.176f , 3.441f , 90f },
new List<float> { -12.26f , 3.02f , 270f },
new List<float> { -12.21f , -0.2500002f , 270f },
new List<float> { -12.21f , -0.7500002f , 270f },
new List<float> { -11.353f , 0.966f , 270f },
new List<float> { -12.21f , -0.2500002f , 270f },
},
new List<List<float>> {
new List<float> { 1.11f , 15.08f , 0f },
new List<float> { 10.16854f , 12.24f , 0f },
new List<float> { 7.307999f , 10.948f , 0f },
new List<float> { 10.35f , 9.48f , 0f },
new List<float> { 7.19f , 4.47f , 0f },
new List<float> { 13.22454f , 7.535f , 0f },
new List<float> { 10.221f , 6.411f , 0f },
new List<float> { 7.51f , 13.66f , 0f },
new List<float> { 3.816f , 7.22f , 0f },
new List<float> { 3.816f , 2.981f , 0f },
},
new List<List<float>> {
new List<float> { -18.88f , -3.77f , 0f },
},
new List<List<float>> {
new List<float> { 8.58392f , -1.449f , 180f },
new List<float> { 9.615003f , -0.9719136f , 0f },
new List<float> { 10.14516f , -0.9719136f , 0f },
new List<float> { 8.03f , -1.449f , 180f },
new List<float> { 6.453079f , -1.449f , 180f },
new List<float> { 7.499843f , -1.449f , 180f },
new List<float> { 6.960841f , -1.449f , 180f },
new List<float> { 7.491923f , -0.9639136f , 0f },
new List<float> { 8.576001f , -0.9639134f , 0f },
new List<float> { 6.952922f , -0.9639136f , 0f },
new List<float> { 9.076001f , -0.9719136f , 0f },
new List<float> { 10.20592f , 1.168f , 0f },
new List<float> { 8.620919f , 0.6909136f , 180f },
new List<float> { 9.17484f , 0.6909136f , 180f },
new List<float> { 6.490078f , 0.6909136f , 180f },
new List<float> { 6.490078f , 0.6909136f , 180f },
new List<float> { 7.543841f , 1.176f , 0f },
new List<float> { 7.551761f , 0.6909136f , 180f },
new List<float> { 6.482159f , 1.176f , 0f },
new List<float> { 6.482159f , 1.176f , 0f },
new List<float> { 8.082843f , 1.176f , 0f },
new List<float> { 8.082843f , 1.176f , 0f },
new List<float> { 5.959921f , 0.6909136f , 180f },
new List<float> { 6.44516f , -0.9639136f , 0f },
new List<float> { 5.891239f , -0.9639136f , 0f },
new List<float> { 5.361082f , -0.9639136f , 0f },
new List<float> { 5.952002f , 1.176f , 0f },
new List<float> { 7.491923f , -0.9639136f , 0f },
new List<float> { 7.551761f , 0.6909136f , 180f },
new List<float> { 5.899158f , -1.449f , 180f },
new List<float> { 5.891239f , -0.9639136f , 0f },
new List<float> { 2.642922f , 0.6930001f , 180f },
new List<float> { 2.635003f , 1.256087f , 0f },
new List<float> { 3.427f , 1.206f , 0f },
new List<float> { 3.163f , 1.222f , 0f },
new List<float> { 3.861918f , 0.6999135f , 180f },
new List<float> { 3.802081f , -0.9549136f , 0f },
new List<float> { 3.34f , -0.938f , 0f },
new List<float> { 4.340157f , -1.44f , 180f },
new List<float> { 2.089002f , 0.6930001f , 180f },
new List<float> { 4.923157f , 1.185f , 0f },
new List<float> { 5.952002f , 1.176f , 0f },
new List<float> { 5.959921f , 0.6909136f , 180f },
new List<float> { 4.931077f , 0.6999135f , 180f },
new List<float> { 4.393f , 1.185f , 0f },
new List<float> { 4.393f , 1.185f , 0f },
new List<float> { 3.853999f , 1.185f , 0f },
new List<float> { 3.853999f , 1.185f , 0f },
new List<float> { 5.413f , 1.176f , 0f },
new List<float> { 10.707f , -1.457f , 180f },
new List<float> { 10.69908f , -0.9719136f , 0f },
new List<float> { 9.08392f , -1.457f , 180f },
new List<float> { 8.576001f , -0.9639136f , 0f },
new List<float> { 11.216f , -0.9799137f , 0f },
new List<float> { 9.615003f , -0.9719136f , 0f },
new List<float> { 10.14516f , -0.9719136f , 0f },
new List<float> { 9.08392f , -1.457f , 180f },
new List<float> { 9.622922f , -1.457f , 180f },
new List<float> { 10.744f , 0.6829135f , 180f },
new List<float> { 11.81484f , 0.6749134f , 180f },
new List<float> { 12.28516f , -0.9799137f , 0f },
new List<float> { 11.76292f , -1.465f , 180f },
new List<float> { 11.76292f , -1.465f , 180f },
new List<float> { 12.83908f , -0.9799137f , 0f },
new List<float> { 11.755f , -0.9799137f , 0f },
new List<float> { 11.755f , -0.9799137f , 0f },
new List<float> { 12.847f , -1.465f , 180f },
new List<float> { 12.83908f , -0.9799136f , 0f },
new List<float> { 13.43792f , 0.6749134f , 180f },
new List<float> { 12.884f , 0.6749134f , 180f },
new List<float> { 12.87608f , 1.16f , 0f },
new List<float> { 12.87608f , 1.16f , 0f },
new List<float> { 11.80692f , 1.16f , 0f },
new List<float> { 12.35384f , 0.6749134f , 180f },
new List<float> { 12.35384f , 0.6749134f , 180f },
new List<float> { 12.34592f , 1.16f , 0f },
new List<float> { 10.73608f , 1.168f , 0f },
new List<float> { 10.73608f , 1.168f , 0f },
new List<float> { 11.29f , 1.168f , 0f },
new List<float> { 11.29f , 1.168f , 0f },
new List<float> { 11.29792f , 0.6829135f , 180f },
new List<float> { 11.29792f , 0.6829135f , 180f },
new List<float> { 11.81484f , 0.6749134f , 180f },
new List<float> { 9.67484f , 0.6829135f , 180f },
new List<float> { 9.666921f , 1.168f , 0f },
new List<float> { 9.666921f , 1.168f , 0f },
new List<float> { 10.20592f , 1.168f , 0f },
new List<float> { 3.81f , -1.44f , 180f },
new List<float> { 3.81f , -1.44f , 180f },
new List<float> { 2.78f , -1.420032f , 90f },
new List<float> { 3.311f , -1.502f , 270f },
new List<float> { 2.78f , -1.98f , 90f },
new List<float> { 1.558845f , 0.6930001f , 180f },
new List<float> { 3.294f , -1.972f , 270f },
new List<float> { 8.02208f , -0.9639136f , 0f },
new List<float> { 6.44516f , -0.9639134f , 0f },
new List<float> { 6.960841f , -1.449f , 180f },
new List<float> { 8.03f , -1.449f , 180f },
new List<float> { 8.58392f , -1.449f , 180f },
new List<float> { 6.453079f , -1.449f , 180f },
new List<float> { 4.332238f , -0.9549136f , 0f },
new List<float> { 4.332238f , -0.9549136f , 0f },
new List<float> { 4.822081f , -0.9639136f , 0f },
new List<float> { 4.83f , -1.449f , 180f },
new List<float> { 4.340157f , -1.44f , 180f },
new List<float> { 5.369001f , -1.449f , 180f },
new List<float> { -3.931357f , -0.6572275f , 90f },
new List<float> { -3.931357f , -0.6572275f , 90f },
new List<float> { -3.926357f , -1.208228f , 90f },
new List<float> { -3.926357f , -1.208228f , 90f },
new List<float> { -3.936357f , -0.1012275f , 90f },
new List<float> { -3.936357f , -0.1012275f , 90f },
new List<float> { -3.390357f , -0.6672275f , 270f },
new List<float> { -3.385357f , -1.218228f , 270f },
new List<float> { -3.390357f , -0.6672275f , 270f },
new List<float> { -3.385357f , -1.218228f , 270f },
new List<float> { -3.395357f , -0.1112275f , 270f },
new List<float> { -3.395357f , -0.1112275f , 270f },
new List<float> { -3.952357f , 0.4597725f , 90f },
new List<float> { -3.952357f , 0.4597725f , 90f },
new List<float> { -3.411357f , 0.4497725f , 270f },
new List<float> { -3.411357f , 0.4497725f , 270f },
new List<float> { -3.944699f , 0.9685702f , 0f },
new List<float> { -2.739001f , 3.4f , 0f },
new List<float> { -2.2f , 3.4f , 0f },
new List<float> { -2.19208f , 2.914913f , 180f },
new List<float> { -3.285003f , 2.914913f , 180f },
new List<float> { -3.841325f , 3.394937f , 90f },
new List<float> { -3.292922f , 3.4f , 0f },
new List<float> { -3.841325f , 4.516905f , 90f },
new List<float> { -3.841325f , 3.956937f , 90f },
new List<float> { -3.301766f , 3.926905f , 270f },
new List<float> { -2.731082f , 2.914913f , 180f },
new List<float> { -1.661923f , 2.914913f , 180f },
new List<float> { -1.108003f , 2.914913f , 180f },
new List<float> { -1.669843f , 3.4f , 0f },
new List<float> { -1.115922f , 3.4f , 0f },
new List<float> { -3.84f , 7.23f , 90f },
new List<float> { -3.84f , 7.789968f , 90f },
new List<float> { -3.841325f , 6.191937f , 90f },
new List<float> { -3.300441f , 7.759937f , 270f },
new List<float> { -3.829116f , 8.169f , 180f },
new List<float> { -3.301766f , 6.161905f , 270f },
new List<float> { -3.301766f , 6.721874f , 270f },
new List<float> { -3.300441f , 7.199968f , 270f },
new List<float> { -3.301766f , 4.486874f , 270f },
new List<float> { -3.304207f , 5.038905f , 270f },
new List<float> { -3.843766f , 5.628905f , 90f },
new List<float> { -3.304207f , 5.598874f , 270f },
new List<float> { -3.285f , 3.722f , 270f },
new List<float> { -3.843766f , 5.068937f , 90f },
new List<float> { -3.266116f , 8.150999f , 270f },
new List<float> { -3.841325f , 6.751905f , 90f },
new List<float> { -3.759116f , 8.672999f , 0f },
new List<float> { 5.413f , 1.176f , 0f },
new List<float> { 5.420919f , 0.6909136f , 180f },
new List<float> { 5.420919f , 0.6909136f , 180f },
new List<float> { 4.931077f , 0.6999135f , 180f },
new List<float> { 4.400919f , 0.6999135f , 180f },
new List<float> { 4.400919f , 0.6999135f , 180f },
new List<float> { 4.923157f , 1.185f , 0f },
new List<float> { 2.642922f , 0.6930001f , 180f },
new List<float> { 2.635003f , 1.256086f , 0f },
new List<float> { 3.362f , 0.706f , 180f },
new List<float> { 3.173f , 0.706f , 180f },
new List<float> { 3.861918f , 0.6999135f , 180f },
new List<float> { 7.036079f , 1.176f , 0f },
new List<float> { 7.036079f , 1.176f , 0f },
new List<float> { 7.043999f , 0.6909136f , 180f },
new List<float> { 7.043999f , 0.6909136f , 180f },
new List<float> { 4.822081f , -0.9639136f , 0f },
new List<float> { 4.83f , -1.449f , 180f },
new List<float> { 3.802081f , -0.9549136f , 0f },
new List<float> { 5.361082f , -0.9639136f , 0f },
new List<float> { 5.899158f , -1.449f , 180f },
new List<float> { 6.952922f , -0.9639136f , 0f },
new List<float> { 5.369001f , -1.449f , 180f },
new List<float> { 7.499843f , -1.449f , 180f },
new List<float> { 8.02208f , -0.9639136f , 0f },
new List<float> { 7.543841f , 1.176f , 0f },
new List<float> { 8.620919f , 0.6909136f , 180f },
new List<float> { 9.67484f , 0.6829135f , 180f },
new List<float> { 10.21384f , 0.6829135f , 180f },
new List<float> { 8.613f , 1.176f , 0f },
new List<float> { 9.166921f , 1.176f , 0f },
new List<float> { 11.216f , -0.9799137f , 0f },
new List<float> { 11.22392f , -1.465f , 180f },
new List<float> { 10.69908f , -0.9719135f , 0f },
new List<float> { 11.22392f , -1.465f , 180f },
new List<float> { 0.2080001f , -1.867968f , 270f },
new List<float> { -0.3059999f , -1.875969f , 90f },
new List<float> { -0.306f , -1.316f , 90f },
new List<float> { -0.209f , 1.109f , 90f },
new List<float> { 0.208f , -1.308f , 270f },
new List<float> { 0.5220809f , 1.265086f , 0f },
new List<float> { 0.5220809f , 1.265086f , 0f },
new List<float> { 1.011924f , 1.256086f , 0f },
new List<float> { 1.011924f , 1.256086f , 0f },
new List<float> { 0.357f , 1.275f , 0f },
new List<float> { 0.5300002f , 0.702f , 180f },
new List<float> { 0.53f , 0.702f , 180f },
new List<float> { 0.352f , 0.71f , 180f },
new List<float> { 1.019843f , 0.6930001f , 180f },
new List<float> { 1.019843f , 0.6930001f , 180f },
new List<float> { 0.327f , 2.862f , 270f },
new List<float> { 0.32f , 2.02f , 270f },
new List<float> { -0.2171185f , 1.498f , 90f },
new List<float> { 0.3224404f , 1.467968f , 270f },
new List<float> { -0.569f , 3.377f , 0f },
new List<float> { -0.234f , 3.369f , 0f },
new List<float> { -0.5690012f , 2.914913f , 180f },
new List<float> { -0.2195599f , 2.61f , 90f },
new List<float> { 0.3199999f , 2.579968f , 270f },
new List<float> { -0.2195599f , 2.050032f , 90f },
new List<float> { -0.219f , 2.908f , 180f },
new List<float> { 2.089002f , 0.6930001f , 180f },
new List<float> { 1.558845f , 0.6930001f , 180f },
new List<float> { 1.550925f , 1.256086f , 0f },
new List<float> { 1.550925f , 1.256086f , 0f },
new List<float> { 2.081082f , 1.256086f , 0f },
new List<float> { 2.081082f , 1.256086f , 0f },
new List<float> { 13.08792f , -3.541087f , 180f },
new List<float> { 13.08792f , -3.541087f , 180f },
new List<float> { 12.55776f , -3.541087f , 180f },
new List<float> { 12.55776f , -3.541087f , 180f },
new List<float> { 13.40208f , -1.473f , 180f },
new List<float> { 13.09208f , -5.080914f , 0f },
new List<float> { 13.09208f , -5.080914f , 0f },
new List<float> { 12.56192f , -5.080914f , 0f },
new List<float> { 13.1f , -5.566f , 180f },
new List<float> { 12.56984f , -5.566f , 180f },
new List<float> { 12.03084f , -5.566f , 180f },
new List<float> { 12.03084f , -5.566f , 180f },
new List<float> { 11.51392f , -5.558001f , 180f },
new List<float> { 12.02292f , -5.080914f , 0f },
new List<float> { 11.506f , -5.072914f , 0f },
new List<float> { 11.506f , -5.072914f , 0f },
new List<float> { 12.56192f , -5.080914f , 0f },
new List<float> { 13.1f , -5.566f , 180f },
new List<float> { 12.54984f , -3.056f , 0f },
new List<float> { 12.54984f , -3.056f , 0f },
new List<float> { 12.01876f , -3.541087f , 180f },
new List<float> { 12.01876f , -3.541087f , 180f },
new List<float> { 11.50184f , -3.533087f , 180f },
new List<float> { 10.41776f , -3.533087f , 180f },
new List<float> { 9.878761f , -3.533087f , 180f },
new List<float> { 9.878761f , -3.533087f , 180f },
new List<float> { 10.94f , -3.048f , 0f },
new List<float> { 10.94f , -3.048f , 0f },
new List<float> { 11.49392f , -3.048f , 0f },
new List<float> { 11.50184f , -3.533087f , 180f },
new List<float> { 10.94792f , -3.533087f , 180f },
new List<float> { 10.94792f , -3.533087f , 180f },
new List<float> { 10.40984f , -3.048f , 0f },
new List<float> { 10.40984f , -3.048f , 0f },
new List<float> { 9.890841f , -5.558001f , 180f },
new List<float> { 9.890841f , -5.558001f , 180f },
new List<float> { 10.96f , -5.558001f , 180f },
new List<float> { 10.95208f , -5.072914f , 0f },
new List<float> { 10.42192f , -5.072914f , 0f },
new List<float> { 12.56984f , -5.566f , 180f },
new List<float> { 11.51392f , -5.558001f , 180f },
new List<float> { 10.96f , -5.558001f , 180f },
new List<float> { 12.02292f , -5.080914f , 0f },
new List<float> { 9.882922f , -5.072914f , 0f },
new List<float> { 10.42984f , -5.558001f , 180f },
new List<float> { 10.42984f , -5.558001f , 180f },
new List<float> { 8.824841f , -3.525086f , 180f },
new List<float> { 8.816921f , -3.04f , 0f },
new List<float> { 8.816921f , -3.04f , 0f },
new List<float> { 9.370842f , -3.04f , 0f },
new List<float> { 9.378761f , -3.525086f , 180f },
new List<float> { 9.390841f , -5.55f , 180f },
new List<float> { 9.390841f , -5.55f , 180f },
new List<float> { 9.382922f , -5.064914f , 0f },
new List<float> { 9.382922f , -5.064914f , 0f },
new List<float> { 9.882922f , -5.072914f , 0f },
new List<float> { 7.747762f , -3.04f , 0f },
new List<float> { 7.747762f , -3.04f , 0f },
new List<float> { 7.247919f , -3.525086f , 180f },
new List<float> { 6.693998f , -3.525086f , 180f },
new List<float> { 6.686079f , -3.04f , 0f },
new List<float> { 8.286764f , -3.04f , 0f },
new List<float> { 8.294683f , -3.525086f , 180f },
new List<float> { 6.686079f , -3.04f , 0f },
new List<float> { 7.252081f , -5.064914f , 0f },
new List<float> { 7.26f , -5.55f , 180f },
new List<float> { 8.306764f , -5.55f , 180f },
new List<float> { 7.759843f , -5.064914f , 0f },
new List<float> { 8.829001f , -5.064914f , 0f },
new List<float> { 8.298844f , -5.064914f , 0f },
new List<float> { 8.836921f , -5.55f , 180f },
new List<float> { 8.298844f , -5.064914f , 0f },
new List<float> { 7.26f , -5.55f , 180f },
new List<float> { 7.767762f , -5.55f , 180f },
new List<float> { 6.706079f , -5.55f , 180f },
new List<float> { 7.767762f , -5.55f , 180f },
new List<float> { 6.706079f , -5.55f , 180f },
new List<float> { 8.306764f , -5.55f , 180f },
new List<float> { 6.175922f , -5.55f , 180f },
new List<float> { 6.175922f , -5.55f , 180f },
new List<float> { 8.829001f , -5.064914f , 0f },
new List<float> { 8.836921f , -5.55f , 180f },
new List<float> { 6.69816f , -5.064914f , 0f },
new List<float> { 7.252081f , -5.064914f , 0f },
new List<float> { 7.759843f , -5.064914f , 0f },
new List<float> { 6.69816f , -5.064914f , 0f },
new List<float> { 6.168003f , -5.064914f , 0f },
new List<float> { 6.168003f , -5.064914f , 0f },
new List<float> { 6.163841f , -3.525086f , 180f },
new List<float> { 6.163841f , -3.525086f , 180f },
new List<float> { 3.360559f , -5.875969f , 270f },
new List<float> { 2.821f , -5.845937f , 90f },
new List<float> { 2.821f , -5.285969f , 90f },
new List<float> { 3.381f , -5.869f , 270f },
new List<float> { 3.38f , -5.306f , 270f },
new List<float> { 3.292f , -2.513031f , 270f },
new List<float> { 2.821f , -5.845937f , 90f },
new List<float> { 0.2060001f , -2.968968f , 270f },
new List<float> { -1.138635f , -5.432712f , 180f },
new List<float> { -2.253817f , -5.432856f , 180f },
new List<float> { -3.202f , -3.522f , 180f },
new List<float> { -2.703f , -3.522f , 180f },
new List<float> { -3.739f , -3.528203f , 180f },
new List<float> { -3.209658f , -3.327798f , 0f },
new List<float> { -3.746658f , -3.334f , 0f },
new List<float> { -2.710658f , -3.327798f , 0f },
new List<float> { -0.803f , -3.529f , 180f },
new List<float> { -0.329f , -3.529f , 180f },
new List<float> { -0.308f , -2.417f , 90f },
new List<float> { -1.168817f , -4.951856f , 0f },
new List<float> { -1.738817f , -4.946856f , 0f },
new List<float> { -0.5988173f , -4.946856f , 0f },
new List<float> { -1.78f , -3.51f , 180f },
new List<float> { -0.3079999f , -2.976969f , 90f },
new List<float> { -0.336658f , -3.334798f , 0f },
new List<float> { -1.277658f , -3.327798f , 0f },
new List<float> { -0.810658f , -3.334798f , 0f },
new List<float> { -1.787658f , -3.315798f , 0f },
new List<float> { -2.254658f , -3.308798f , 0f },
new List<float> { -2.247f , -3.503f , 180f },
new List<float> { -2.284f , -4.952f , 0f },
new List<float> { 3.322f , -3.077032f , 270f },
new List<float> { 2.78244f , -3.047f , 90f },
new List<float> { 0.206f , -2.409f , 270f },
new List<float> { 2.778f , -2.521032f , 90f },
new List<float> { -0.5686347f , -5.427712f , 180f },
new List<float> { -1.708635f , -5.427712f , 180f },
new List<float> { 8.294683f , -3.525086f , 180f },
new List<float> { 7.755681f , -3.525086f , 180f },
new List<float> { 6.155922f , -3.04f , 0f },
new List<float> { 6.693998f , -3.525086f , 180f },
new List<float> { 7.24f , -3.04f , 0f },
new List<float> { 6.155922f , -3.04f , 0f },
new List<float> { 9.378761f , -3.525086f , 180f },
new List<float> { 9.870842f , -3.048f , 0f },
new List<float> { 9.870842f , -3.048f , 0f },
new List<float> { 10.41776f , -3.533087f , 180f },
new List<float> { 10.95208f , -5.072914f , 0f },
new List<float> { 8.824841f , -3.525086f , 180f },
new List<float> { 7.755681f , -3.525086f , 180f },
new List<float> { 7.24f , -3.04f , 0f },
new List<float> { 7.247919f , -3.525086f , 180f },
new List<float> { 13.43f , 1.16f , 0f },
new List<float> { 12.34592f , 1.16f , 0f },
new List<float> { 13.43792f , 0.6749134f , 180f },
new List<float> { 13.43f , 1.16f , 0f },
new List<float> { 11.80692f , 1.16f , 0f },
new List<float> { 8.090762f , 0.6909136f , 180f },
new List<float> { 8.090762f , 0.6909136f , 180f },
new List<float> { 8.613f , 1.176f , 0f },
new List<float> { 9.166921f , 1.176f , 0f },
new List<float> { 9.17484f , 0.6909136f , 180f },
new List<float> { 10.21384f , 0.6829135f , 180f },
new List<float> { 10.744f , 0.6829135f , 180f },
new List<float> { 12.884f , 0.6749134f , 180f },
new List<float> { 13.39416f , -0.9879136f , 0f },
new List<float> { 12.29308f , -1.465f , 180f },
new List<float> { 12.28516f , -0.9799137f , 0f },
new List<float> { 12.29308f , -1.465f , 180f },
new List<float> { 9.076001f , -0.9719136f , 0f },
new List<float> { 10.707f , -1.457f , 180f },
new List<float> { 12.01084f , -3.056f , 0f },
new List<float> { 12.01084f , -3.056f , 0f },
new List<float> { 11.49392f , -3.048f , 0f },
new List<float> { 13.08f , -3.056f , 0f },
new List<float> { 13.08f , -3.056f , 0f },
new List<float> { 12.847f , -1.465f , 180f },
new List<float> { 10.15308f , -1.457f , 180f },
new List<float> { 10.15308f , -1.457f , 180f },
new List<float> { 9.622922f , -1.457f , 180f },
new List<float> { 8.286764f , -3.04f , 0f },
new List<float> { 9.370842f , -3.04f , 0f },
new List<float> { 10.42192f , -5.072914f , 0f },
new List<float> { -9.741734f , 6.01f , 0f },
new List<float> { -8.643f , 6.01f , 0f },
new List<float> { -8.322929f , 8.182913f , 180f },
new List<float> { -8.340117f , 8.683f , 0f },
new List<float> { -11.91873f , 6.01f , 0f },
new List<float> { -12.40389f , 5.524913f , 180f },
new List<float> { -7.901f , 5.493f , 270f },
new List<float> { -8.473558f , 4.590064f , 90f },
new List<float> { -6.729929f , 8.667999f , 0f },
new List<float> { -8.352117f , 9.184f , 270f },
new List<float> { -7.769009f , 8.182913f , 180f },
new List<float> { -8.897117f , 8.708f , 90f },
new List<float> { -4.559929f , 8.182913f , 180f },
new List<float> { -5.652851f , 8.182913f , 180f },
new List<float> { -4.567848f , 8.677999f , 0f },
new List<float> { -8.473558f , 2.915032f , 90f },
new List<float> { -8.473558f , 2.355063f , 90f },
new List<float> { -7.93644f , 3.997f , 270f },
new List<float> { -8.473558f , 1.233094f , 90f },
new List<float> { -8.469559f , 0.7130318f , 90f },
new List<float> { -7.919f , 0.654f , 270f },
new List<float> { -6.466f , 0.944f , 0f },
new List<float> { -7.52f , 0.75f , 180f },
new List<float> { -7.934f , 1.203063f , 270f },
new List<float> { -12.94344f , 0.4339372f , 270f },
new List<float> { -12.56966f , 1.040202f , 0f },
new List<float> { -7.934f , 5.12f , 270f },
new List<float> { -9.194813f , 5.524913f , 180f },
new List<float> { -9.733814f , 5.524913f , 180f },
new List<float> { -10.28773f , 5.524913f , 180f },
new List<float> { -10.81789f , 5.524913f , 180f },
new List<float> { -11.35689f , 5.524913f , 180f },
new List<float> { -11.36481f , 6.01f , 0f },
new List<float> { -12.99488f , 6.572f , 270f },
new List<float> { -12.46281f , 6.020913f , 0f },
new List<float> { -12.975f , 6.025f , 0f },
new List<float> { -4.00593f , 8.182913f , 180f },
new List<float> { -5.09893f , 8.182913f , 180f },
new List<float> { -4.008116f , 8.667999f , 0f },
new List<float> { -5.10685f , 8.667999f , 0f },
new List<float> { -7.827929f , 8.678913f , 0f },
new List<float> { -7.28385f , 8.667999f , 0f },
new List<float> { -6.183008f , 8.182913f , 180f },
new List<float> { -5.66077f , 8.667999f , 0f },
new List<float> { -6.190928f , 8.667999f , 0f },
new List<float> { -6.72201f , 8.182913f , 180f },
new List<float> { -7.27593f , 8.182913f , 180f },
new List<float> { -8.36f , 9.23f , 270f },
new List<float> { -8.332116f , 9.716999f , 270f },
new List<float> { -10.98192f , 9.744912f , 180f },
new List<float> { -10.43592f , 10.23f , 0f },
new List<float> { -9.980194f , 10.226f , 0f },
new List<float> { -11.52f , 10.23f , 0f },
new List<float> { -12.05108f , 9.744912f , 180f },
new List<float> { -12.61292f , 10.23f , 0f },
new List<float> { -13.067f , 9.744912f , 180f },
new List<float> { -13.07492f , 10.23f , 0f },
new List<float> { -8.886552f , 10.23076f , 0f },
new List<float> { -8.889116f , 9.721f , 90f },
new List<float> { -8.899558f , 9.260031f , 90f },
new List<float> { -8.899558f , 9.260031f , 90f },
new List<float> { -8.897117f , 8.708f , 90f },
new List<float> { -9.441193f , 10.226f , 0f },
new List<float> { -9.394116f , 9.735f , 180f },
new List<float> { -9.957116f , 9.735f , 180f },
new List<float> { -10.98984f , 10.23f , 0f },
new List<float> { -10.428f , 9.744912f , 180f },
new List<float> { -7.908f , -0.461f , 270f },
new List<float> { -8.462999f , -0.3839684f , 90f },
new List<float> { -8.462999f , -0.513f , 90f },
new List<float> { -8.808275f , -1.009767f , 180f },
new List<float> { -8.38f , -0.99f , 180f },
new List<float> { -8.815933f , -0.8155649f , 0f },
new List<float> { -8.476f , 4.027031f , 90f },
new List<float> { -7.934f , 4.560031f , 270f },
new List<float> { -7.93644f , 3.437032f , 270f },
new List<float> { -7.934f , 2.885f , 270f },
new List<float> { -8.473558f , 1.793063f , 90f },
new List<float> { -7.934f , 2.325032f , 270f },
new List<float> { -7.934f , 1.763031f , 270f },
new List<float> { -7f , 0.95f , 0f },
new List<float> { -5.938342f , 0.9497977f , 0f },
new List<float> { -4.345f , 0.738f , 180f },
new List<float> { -4.51f , 0.95f , 0f },
new List<float> { -7.527658f , 0.9442022f , 0f },
new List<float> { -6.992342f , 0.7557977f , 180f },
new List<float> { -6.458342f , 0.7497978f , 180f },
new List<float> { -7.908f , 0.104f , 270f },
new List<float> { -8.469559f , 0.1530633f , 90f },
new List<float> { -7.92344f , -3.211f , 270f },
new List<float> { -6.15656f , -3.197f , 90f },
new List<float> { -6.15656f , -4.318969f , 90f },
new List<float> { -6.15656f , -3.756968f , 90f },
new List<float> { -5.617001f , -4.349f , 270f },
new List<float> { -6.15656f , -6.553968f , 90f },
new List<float> { -5.619441f , -6.031969f , 270f },
new List<float> { -6.15656f , -4.878937f , 90f },
new List<float> { -5.617001f , -3.787f , 270f },
new List<float> { -8.462999f , -3.180969f , 90f },
new List<float> { -5.617f , -6.584f , 270f },
new List<float> { -5.589f , -7.404f , 270f },
new List<float> { -5.231342f , -3.528203f , 180f },
new List<float> { -5.619441f , -2.115031f , 270f },
new List<float> { -5.623441f , -1.594969f , 270f },
new List<float> { -4.733658f , -3.334f , 0f },
new List<float> { -5.619441f , -2.675f , 270f },
new List<float> { -5.617001f , -3.227031f , 270f },
new List<float> { -5.239f , -3.334f , 0f },
new List<float> { -6.159f , -2.644968f , 90f },
new List<float> { -6.159f , -2.085f , 90f },
new List<float> { -6.163f , -1.564937f , 90f },
new List<float> { -12.937f , -3.442063f , 270f },
new List<float> { -12.93944f , -4.565063f , 270f },
new List<float> { -13.479f , -4.535031f , 90f },
new List<float> { -13.47656f , -2.850031f , 90f },
new List<float> { -13.47656f , -3.972f , 90f },
new List<float> { -12.937f , -2.880063f , 270f },
new List<float> { -12.93944f , -1.208094f , 270f },
new List<float> { -13.479f , -1.178063f , 90f },
new List<float> { -12.948f , -6.777f , 270f },
new List<float> { -13.47656f , -5.647031f , 90f },
new List<float> { -12.937f , -6.894f , 270f },
new List<float> { -13.47656f , -6.769f , 90f },
new List<float> { -12.937f , -7.409f , 270f },
new List<float> { -13.482f , -7.418f , 90f },
new List<float> { -5.930684f , 0.7555955f , 180f },
new List<float> { -5.413342f , 0.7557977f , 180f },
new List<float> { -5.421f , 0.95f , 0f },
new List<float> { -4.887f , 0.944f , 0f },
new List<float> { -4.879342f , 0.7497978f , 180f },
new List<float> { -8.640814f , 5.524913f , 180f },
new List<float> { -8.464f , 5.511f , 180f },
new List<float> { -10.29565f , 6.01f , 0f },
new List<float> { -8.473558f , 5.150032f , 90f },
new List<float> { -8.394f , 6.015f , 0f },
new List<float> { -12.95781f , 5.524913f , 180f },
new List<float> { -10.82581f , 6.01f , 0f },
new List<float> { -9.202732f , 6.02f , 0f },
new List<float> { -8.476f , 3.467063f , 90f },
new List<float> { -6.159f , -5.441968f , 90f },
new List<float> { -6.159f , -6.001937f , 90f },
new List<float> { -6.159f , -6.001937f , 90f },
new List<float> { -5.619441f , -5.472f , 270f },
new List<float> { -5.619441f , -6.031969f , 270f },
new List<float> { -6.15656f , -6.553968f , 90f },
new List<float> { -5.617001f , -4.908968f , 270f },
new List<float> { -6.15f , -7.38f , 90f },
new List<float> { -6.164001f , -7.026f , 90f },
new List<float> { -4.726f , -3.528203f , 180f },
new List<float> { -4.201342f , -3.528203f , 180f },
new List<float> { -4.209f , -3.334f , 0f },
new List<float> { -5.617f , -6.584f , 270f },
new List<float> { -5.603f , -7.064f , 270f },
new List<float> { -1.27f , -3.522f , 180f },
new List<float> { -17.57956f , -1.083968f , 90f },
new List<float> { -17.57956f , -1.083968f , 90f },
new List<float> { -17.57956f , -0.5219678f , 90f },
new List<float> { -17.04f , 0.007968962f , 270f },
new List<float> { -17.57956f , 0.03800064f , 90f },
new List<float> { -17.57956f , 0.03800064f , 90f },
new List<float> { -17.04f , -1.673968f , 270f },
new List<float> { -17.04f , -1.673968f , 270f },
new List<float> { -17.57956f , -1.643937f , 90f },
new List<float> { -17.57556f , -2.163999f , 90f },
new List<float> { -17.03356f , -3.865999f , 270f },
new List<float> { -17.03356f , -3.865999f , 270f },
new List<float> { -17.036f , -2.753999f , 270f },
new List<float> { -17.036f , -2.753999f , 270f },
new List<float> { -17.57556f , -2.723968f , 90f },
new List<float> { -17.03356f , -3.306031f , 270f },
new List<float> { -13.47656f , -3.412031f , 90f },
new List<float> { -17.57556f , -2.723968f , 90f },
new List<float> { -17.036f , -2.194031f , 270f },
new List<float> { -17.57556f , -2.163999f , 90f },
new List<float> { -13.479f , -1.738031f , 90f },
new List<float> { -17.04f , 2.242969f , 270f },
new List<float> { -17.04f , 2.242969f , 270f },
new List<float> { -17.04244f , 0.5600005f , 270f },
new List<float> { -17.04f , 1.683001f , 270f },
new List<float> { -17.57956f , 2.273001f , 90f },
new List<float> { -13.483f , 0.4639689f , 90f },
new List<float> { -13.483f , 1.023937f , 90f },
new List<float> { -13.48544f , 2.135937f , 90f },
new List<float> { -12.94588f , 2.105906f , 270f },
new List<float> { -12.94344f , 2.668937f , 270f },
new List<float> { -12.94588f , 1.545937f , 270f },
new List<float> { -12.94344f , 0.9939057f , 270f },
new List<float> { -13.48544f , 1.575969f , 90f },
new List<float> { -12.94344f , -0.1280631f , 270f },
new List<float> { -17.04244f , 0.5600005f , 270f },
new List<float> { -17.04244f , 1.119969f , 270f },
new List<float> { -17.57956f , 2.273001f , 90f },
new List<float> { -17.04f , -1.114f , 270f },
new List<float> { -17.04f , -1.114f , 270f },
new List<float> { -17.04f , -0.5519995f , 270f },
new List<float> { -17.04f , -0.5519995f , 270f },
new List<float> { -17.036f , -2.194031f , 270f },
new List<float> { -13.483f , -0.0980314f , 90f },
new List<float> { -13.483f , -0.658f , 90f },
new List<float> { -13.47656f , -2.290063f , 90f },
new List<float> { -12.94344f , -0.6880317f , 270f },
new List<float> { -17.036f , -5.551f , 270f },
new List<float> { -17.03356f , -4.427999f , 270f },
new List<float> { -17.03356f , -4.427999f , 270f },
new List<float> { -17.03356f , -4.987968f , 270f },
new List<float> { -17.03356f , -4.987968f , 270f },
new List<float> { -13.479f , -5.095f , 90f },
new List<float> { -12.937f , -5.677063f , 270f },
new List<float> { -12.93944f , -5.125031f , 270f },
new List<float> { -12.93944f , -1.768063f , 270f },
new List<float> { -12.937f , -2.320094f , 270f },
new List<float> { -17.57312f , -4.397968f , 90f },
new List<float> { -17.57312f , -4.397968f , 90f },
new List<float> { -17.57312f , -4.957937f , 90f },
new List<float> { -17.57556f , -5.520968f , 90f },
new List<float> { -17.57556f , -5.520968f , 90f },
new List<float> { -13.47656f , -7.328969f , 90f },
new List<float> { -17.04f , 1.683001f , 270f },
new List<float> { -12.562f , 0.846f , 180f },
new List<float> { -17.57312f , -4.957937f , 90f },
new List<float> { -17.57956f , -1.643937f , 90f },
new List<float> { -17.57956f , -0.5219678f , 90f },
new List<float> { -17.57956f , 1.713032f , 90f },
new List<float> { -17.57956f , 1.713032f , 90f },
new List<float> { -12.937f , -6.237031f , 270f },
new List<float> { -13.47656f , -6.207f , 90f },
new List<float> { -20.30444f , -0.9900007f , 270f },
new List<float> { -20.30444f , -1.549969f , 270f },
new List<float> { -20.30444f , -1.549969f , 270f },
new List<float> { -20.30444f , -0.9900007f , 270f },
new List<float> { -20.814f , -1.643937f , 90f },
new List<float> { -20.814f , -1.083968f , 90f },
new List<float> { -20.814f , -1.083968f , 90f },
new List<float> { -20.81f , -2.163999f , 90f },
new List<float> { -20.30044f , -2.070032f , 270f },
new List<float> { -20.30044f , -2.070032f , 270f },
new List<float> { -20.814f , -1.643937f , 90f },
new List<float> { -17.582f , 0.5900322f , 90f },
new List<float> { -17.582f , 0.5900322f , 90f },
new List<float> { -20.30444f , -0.4280005f , 270f },
new List<float> { -20.30444f , -0.4280005f , 270f },
new List<float> { -20.30444f , 0.131968f , 270f },
new List<float> { -20.30688f , 0.6839995f , 270f },
new List<float> { -20.30688f , 0.6839995f , 270f },
new List<float> { -20.814f , -0.5219678f , 90f },
new List<float> { -20.30444f , 0.131968f , 270f },
new List<float> { -20.814f , 0.03800064f , 90f },
new List<float> { -20.814f , -0.5219678f , 90f },
new List<float> { -20.814f , 0.03800064f , 90f },
new List<float> { -20.80756f , -3.275999f , 90f },
new List<float> { -20.80756f , -3.835968f , 90f },
new List<float> { -20.80756f , -3.275999f , 90f },
new List<float> { -20.80756f , -3.835968f , 90f },
new List<float> { -20.30444f , -3.692968f , 270f },
new List<float> { -20.30444f , -4.252937f , 270f },
new List<float> { -20.30444f , -4.252937f , 270f },
new List<float> { -20.298f , -3.182032f , 270f },
new List<float> { -20.298f , -3.182032f , 270f },
new List<float> { -20.80756f , -4.397968f , 90f },
new List<float> { -20.80756f , -4.397968f , 90f },
new List<float> { -20.30044f , -2.630001f , 270f },
new List<float> { -20.30044f , -2.630001f , 270f },
new List<float> { -20.81f , -2.723968f , 90f },
new List<float> { -20.81f , -2.723968f , 90f },
new List<float> { -20.30044f , -4.773f , 270f },
new List<float> { -20.30044f , -4.773f , 270f },
new List<float> { -12.66766f , -4.279798f , 0f },
new List<float> { -12.66f , -4.474f , 180f },
new List<float> { -12.937f , -4.002031f , 270f },
new List<float> { -20.30444f , 1.807f , 270f },
new List<float> { -20.30444f , 1.807f , 270f },
new List<float> { -20.30444f , 2.366968f , 270f },
new List<float> { -20.814f , 2.273001f , 90f },
new List<float> { -20.30688f , 1.243968f , 270f },
new List<float> { -20.30688f , 1.243968f , 270f },
new List<float> { -20.814f , 2.273001f , 90f },
new List<float> { -17.582f , 1.150001f , 90f },
new List<float> { -20.814f , 1.713032f , 90f },
new List<float> { -20.814f , 1.713032f , 90f },
new List<float> { -20.81f , -2.163999f , 90f },
new List<float> { -20.30444f , -3.692968f , 270f },
new List<float> { -20.80756f , -4.957937f , 90f },
new List<float> { -20.80756f , -4.957937f , 90f },
new List<float> { -17.04244f , 1.119969f , 270f },
new List<float> { -17.57312f , -3.835968f , 90f },
new List<float> { -17.57312f , -3.835968f , 90f },
new List<float> { -17.57312f , -3.275999f , 90f },
new List<float> { -17.04f , 0.007968962f , 270f },
new List<float> { -17.03356f , -3.306031f , 270f },
new List<float> { -17.57312f , -3.275999f , 90f },
new List<float> { -17.036f , -5.551f , 270f },
new List<float> { -20.81f , -5.520968f , 90f },
new List<float> { -20.81f , -5.520968f , 90f },
new List<float> { -20.307f , -5.485f , 270f },
new List<float> { -20.30044f , -5.332968f , 270f },
new List<float> { -20.30044f , -5.332968f , 270f },
new List<float> { -17.04f , 2.804969f , 270f },
new List<float> { -17.04f , 2.804969f , 270f },
new List<float> { -17.57956f , 3.394969f , 90f },
new List<float> { -17.57956f , 3.394969f , 90f },
new List<float> { -17.04f , 3.364938f , 270f },
new List<float> { -17.57956f , 2.835001f , 90f },
new List<float> { -17.04244f , 4.476937f , 270f },
new List<float> { -17.04944f , 4.974968f , 270f },
new List<float> { -17.04944f , 4.974968f , 270f },
new List<float> { -17.04244f , 3.916969f , 270f },
new List<float> { -17.04244f , 3.916969f , 270f },
new List<float> { -17.589f , 5.005f , 90f },
new List<float> { -17.589f , 5.005f , 90f },
new List<float> { -17.04944f , 6.689968f , 270f },
new List<float> { -17.04944f , 6.689968f , 270f },
new List<float> { -17.04944f , 6.13f , 270f },
new List<float> { -17.589f , 6.72f , 90f },
new List<float> { -17.589f , 5.564968f , 90f },
new List<float> { -17.589f , 5.564968f , 90f },
new List<float> { -17.582f , 6.115f , 90f },
new List<float> { -17.589f , 6.72f , 90f },
new List<float> { -17.582f , 3.947001f , 90f },
new List<float> { -17.582f , 3.947001f , 90f },
new List<float> { -17.04244f , 4.476937f , 270f },
new List<float> { -17.57956f , 2.835001f , 90f },
new List<float> { -17.04f , 3.364938f , 270f },
new List<float> { -17.04944f , 5.534936f , 270f },
new List<float> { -17.04944f , 5.534936f , 270f },
new List<float> { -15.16108f , 7.077f , 180f },
new List<float> { -15.169f , 7.568f , 0f },
new List<float> { -15.71508f , 7.077f , 180f },
new List<float> { -14.592f , 7.077f , 180f },
new List<float> { -14.61508f , 7.568f , 0f },
new List<float> { -13.532f , 6.05f , 90f },
new List<float> { -13.532f , 6.05f , 90f },
new List<float> { -14.07608f , 7.568f , 0f },
new List<float> { -14.029f , 7.077f , 180f },
new List<float> { -13.52144f , 7.572759f , 0f },
new List<float> { -17.582f , 4.506969f , 90f },
new List<float> { -17.582f , 4.506969f , 90f },
new List<float> { -17.581f , 7.031f , 90f },
new List<float> { -17.33816f , 7.059f , 180f },
new List<float> { -16.262f , 7.568f , 0f },
new List<float> { -16.81592f , 7.568f , 0f },
new List<float> { -16.808f , 7.077f , 180f },
new List<float> { -13.53444f , 6.602032f , 90f },
new List<float> { -13.53444f , 6.602032f , 90f },
new List<float> { -13.524f , 7.063f , 90f },
new List<float> { -16.339f , 9.744912f , 180f },
new List<float> { -15.793f , 10.23f , 0f },
new List<float> { -14.698f , 10.23f , 0f },
new List<float> { -14.69008f , 9.744912f , 180f },
new List<float> { -17.34608f , 7.55f , 0f },
new List<float> { -16.25408f , 7.077f , 180f },
new List<float> { -16.34692f , 10.23f , 0f },
new List<float> { -17.40816f , 9.744912f , 180f },
new List<float> { -18.60108f , 9.734913f , 180f },
new List<float> { -17.41608f , 10.23f , 0f },
new List<float> { -16.87708f , 10.23f , 0f },
new List<float> { -17.97f , 10.23f , 0f },
new List<float> { -18.04716f , 9.734913f , 180f },
new List<float> { -15.244f , 9.744912f , 180f },
new List<float> { -15.25192f , 10.23f , 0f },
new List<float> { -15.78508f , 9.744912f , 180f },
new List<float> { -13.62092f , 9.744912f , 180f },
new List<float> { -14.159f , 10.23f , 0f },
new List<float> { -12.605f , 9.744912f , 180f },
new List<float> { -14.15108f , 9.744912f , 180f },
new List<float> { -12.059f , 10.23f , 0f },
new List<float> { -13.62884f , 10.23f , 0f },
new List<float> { -11.51208f , 9.744912f , 180f },
new List<float> { -12.967f , 7.059f , 270f },
new List<float> { -11.91081f , 5.524913f , 180f },
new List<float> { -12.987f , 6.526f , 270f },
new List<float> { -13.483f , 3.258937f , 90f },
new List<float> { -13.483f , 2.698969f , 90f },
new List<float> { -12.94344f , 3.228906f , 270f },
new List<float> { -20.30688f , 4.040968f , 270f },
new List<float> { -20.81644f , 4.506969f , 90f },
new List<float> { -20.81644f , 3.947001f , 90f },
new List<float> { -20.81644f , 3.947001f , 90f },
new List<float> { -20.81644f , 4.506969f , 90f },
new List<float> { -15.723f , 7.568f , 0f },
new List<float> { -17.04944f , 6.085f , 270f },
new List<float> { -17.589f , 6.160032f , 90f },
new List<float> { -20.288f , 7.057f , 270f },
new List<float> { -20.81644f , 6.115f , 90f },
new List<float> { -20.265f , 6.18f , 270f },
new List<float> { -20.81544f , 7.031f , 90f },
new List<float> { -20.28f , 5.738f , 270f },
new List<float> { -20.304f , 5.047f , 270f },
new List<float> { -20.82344f , 6.160032f , 90f },
new List<float> { -20.82344f , 5.005f , 90f },
new List<float> { -20.272f , 6.56f , 270f },
new List<float> { -20.82344f , 5.005f , 90f },
new List<float> { -20.304f , 5.342f , 270f },
new List<float> { -20.82344f , 5.564968f , 90f },
new List<float> { -20.82344f , 6.72f , 90f },
new List<float> { -20.82344f , 6.72f , 90f },
new List<float> { -20.30688f , 4.600936f , 270f },
new List<float> { -20.30688f , 4.600936f , 270f },
new List<float> { -20.30688f , 4.040968f , 270f },
new List<float> { -20.814f , 3.394969f , 90f },
new List<float> { -20.30444f , 2.928968f , 270f },
new List<float> { -20.30444f , 2.928968f , 270f },
new List<float> { -20.814f , 3.394969f , 90f },
new List<float> { -20.81644f , 1.150001f , 90f },
new List<float> { -20.814f , 2.835001f , 90f },
new List<float> { -20.30444f , 3.488937f , 270f },
new List<float> { -17.582f , 1.150001f , 90f },
new List<float> { -20.82344f , 5.564968f , 90f },
new List<float> { -20.81644f , 0.5900322f , 90f },
new List<float> { -20.81644f , 0.5900322f , 90f },
new List<float> { -20.81644f , 1.150001f , 90f },
new List<float> { -20.814f , 2.835001f , 90f },
new List<float> { -20.30444f , 3.488937f , 270f },
new List<float> { -20.30444f , 2.366968f , 270f },
new List<float> { -19.13124f , 9.734913f , 180f },
new List<float> { -19.13916f , 10.22f , 0f },
new List<float> { -19.67816f , 10.22f , 0f },
new List<float> { -19.67024f , 9.734913f , 180f },
new List<float> { -20.16f , 9.71f , 180f },
new List<float> { -20.71392f , 9.71f , 180f },
new List<float> { -20.22416f , 9.734913f , 180f },
new List<float> { -20.23208f , 10.22f , 0f },
new List<float> { -20.72184f , 10.19509f , 0f },
new List<float> { -20.16792f , 10.19509f , 0f },
new List<float> { -18.609f , 10.22f , 0f },
new List<float> { -17.96208f , 9.744912f , 180f },
new List<float> { -18.05508f , 10.22f , 0f },
new List<float> { -16.86916f , 9.744912f , 180f },
},
new List<List<float>> {
new List<float> { 8.355886f , 5.250103f , 0f },
new List<float> { 13.26419f , 8.264301f , 0f },
new List<float> { 7.54168f , 14.41582f , 0f },
new List<float> { -2.7f , -1.05f , 270f },
new List<float> { 0.92f , -1.79f , 270f },
new List<float> { 14.4f , -5.06f , 270f },
new List<float> { 17.75f , -0.91f , 90f },
new List<float> { 17.75f , -3.8f , 90f },
new List<float> { 4.11f , -3.02f , 270f },
new List<float> { 4.13f , -5.68f , 270f },
new List<float> { -0.9234951f , -2.613935f , 0f },
new List<float> { 2.14f , -2.8f , 90f },
new List<float> { -3.541f , -4.92f , 90f },
new List<float> { -7.414485f , 1.655493f , 0f },
new List<float> { -7.166f , 5.231f , 270f },
new List<float> { -4.523f , 3.672f , 90f },
new List<float> { -11.602f , -3.934f , 320f },
new List<float> { -9.154f , -2.791f , 90f },
new List<float> { -4.927125f , -7.264758f , 0f },
new List<float> { -16.36f , -0.314f , 270f },
new List<float> { -16.3f , -2.96f , 270f },
new List<float> { -16.32f , 2.641f , 270f },
new List<float> { -14.142f , 1.419f , 90f },
new List<float> { -16.29f , -2.62f , 270f },
new List<float> { -14.185f , -1.44f , 90f },
new List<float> { -16.343f , -5.95f , 270f },
new List<float> { -14.156f , -4.488f , 90f },
new List<float> { -14.17f , -4.08f , 90f },
new List<float> { -14.14583f , -7.092357f , 0f },
new List<float> { -19.751f , -1.47f , 270f },
new List<float> { -18.2f , -0.47f , 90f },
new List<float> { -19.74f , 0.46f , 270f },
new List<float> { -19.344f , 0.4449999f , 270f },
new List<float> { -18.156f , -3.085f , 90f },
new List<float> { -16.3f , -2.96f , 270f },
new List<float> { -18.196f , 2.145f , 90f },
new List<float> { -18.65f , 2.15f , 90f },
new List<float> { -18.27f , -4.85f , 90f },
new List<float> { -18.644f , -4.835f , 90f },
new List<float> { -19.355f , -1.485f , 270f },
new List<float> { -16.34f , 0.05f , 270f },
new List<float> { -16.36f , -0.314f , 270f },
new List<float> { -16.32f , 2.641f , 270f },
new List<float> { -16.343f , -5.95f , 270f },
new List<float> { -19.54f , -5.22f , 270f },
new List<float> { -19.144f , -5.235f , 270f },
new List<float> { -18.61f , -3.08f , 90f },
new List<float> { -18.324f , 7.207f , 90f },
new List<float> { -19.62f , 4.18f , 270f },
new List<float> { -19.6f , 5.34f , 270f },
new List<float> { -19.204f , 5.325f , 270f },
new List<float> { -19.224f , 4.165f , 270f },
new List<float> { -16.313f , 3.137f , 270f },
},
new List<List<float>> {
},
new List<List<float>> {
new List<float> { 13.629f , -0.076f , 0f },
new List<float> { 12.87368f , -2.17f , 0f },
new List<float> { 13.573f , -2.16911f , 0f },
new List<float> { 13.92932f , -6.69911f , 0f },
new List<float> { 13.23f , -6.7f , 0f },
new List<float> { -0.27f , -4.26f , 0f },
new List<float> { 12.90897f , -0.06503192f , 0f },
new List<float> { -6.866713f , -7.248215f , 0f },
},
new List<List<float>> {
new List<float> { 2.248f , 15.08f , 0f },
new List<float> { 1.681f , 15.08f , 0f },
new List<float> { 2.789f , 15.08f , 0f },
new List<float> { 3.352f , 15.08f , 0f },
new List<float> { 4.46f , 15.08f , 0f },
new List<float> { 3.919f , 15.08f , 0f },
new List<float> { 10.73854f , 12.24f , 0f },
new List<float> { 7.878f , 10.948f , 0f },
new List<float> { 10.92f , 9.48f , 0f },
new List<float> { 4.386f , 7.22f , 0f },
new List<float> { 7.76f , 4.47f , 0f },
new List<float> { 13.79454f , 7.535f , 0f },
new List<float> { 10.791f , 6.411f , 0f },
new List<float> { 8.080001f , 13.66f , 0f },
new List<float> { 5.016766f , 15.08f , 0f },
new List<float> { 4.386f , 2.981f , 0f },
},
new List<List<float>> {
new List<float> { 11.27f , 12.24f , 0f },
new List<float> { 8.409458f , 10.948f , 0f },
new List<float> { 8.611459f , 13.66f , 0f },
new List<float> { 11.45146f , 9.48f , 0f },
new List<float> { 8.291458f , 4.47f , 0f },
new List<float> { 14.326f , 7.535f , 0f },
new List<float> { 11.32246f , 6.411f , 0f },
new List<float> { 4.917458f , 7.22f , 0f },
new List<float> { 5.588888f , 15.08f , 0f },
new List<float> { 4.917458f , 2.981f , 0f },
},
new List<List<float>> {
new List<float> { 2.775373f , -0.9182595f , 0f },
new List<float> { -3.9f , -1.638f , 90f },
new List<float> { -3.801325f , 2.911937f , 90f },
new List<float> { -0.177f , 0.706f , 90f },
new List<float> { -0.3106273f , -0.8142278f , 0f },
new List<float> { 5.617919f , -3.535086f , 90f },
new List<float> { 2.842001f , -6.409f , 90f },
new List<float> { 2.842001f , -6.409f , 90f },
new List<float> { 5.63f , -5.06f , 0f },
new List<float> { 5.64f , -3.052981f , 0f },
new List<float> { 5.63f , -5.56f , 90f },
new List<float> { -2.838753f , -4.958716f , 0f },
new List<float> { 2.836775f , -4.991493f , 0f },
new List<float> { 2.774f , -3.539f , 90f },
new List<float> { 2.774f , -3.539f , 90f },
new List<float> { -2.833817f , -5.469856f , 90f },
new List<float> { -2.808817f , -5.459856f , 90f },
new List<float> { -8.890115f , 8.174999f , 90f },
new List<float> { -8.890115f , 8.174999f , 90f },
new List<float> { -9.351f , -0.815f , 0f },
new List<float> { -9.288275f , -0.9947674f , 90f },
new List<float> { -6.163171f , -1.065041f , 0f },
new List<float> { -8.47f , -5.370861f , 0f },
new List<float> { -8.465065f , -5.882f , 90f },
new List<float> { -8.465065f , -5.882f , 90f },
new List<float> { -8.452f , -3.718f , 90f },
new List<float> { -8.464355f , -2.66306f , 0f },
new List<float> { -8.452f , -3.718f , 90f },
new List<float> { -17.57f , -6.04f , 90f },
new List<float> { -20.81f , -5.921f , 90f },
new List<float> { -17.57f , -6.04f , 90f },
new List<float> { -13.525f , 5.516999f , 90f },
new List<float> { -13.525f , 5.516999f , 90f },
new List<float> { -13.486f , 3.744f , 0f },
new List<float> { -20.8f , 7.58f , 0f },
new List<float> { -17.6333f , 7.570436f , 0f },
},
new List<List<float>> {
new List<float> { 13.79f , 0.649f , 270f },
new List<float> { -3.399f , -1.648f , 270f },
new List<float> { -3.395f , 0.967f , 0f },
new List<float> { -3.234116f , 8.664f , 0f },
new List<float> { 0.2211437f , -0.8416668f , 0f },
new List<float> { 0.3215549f , 3.380853f , 0f },
new List<float> { 13.65792f , -3.565086f , 270f },
new List<float> { 13.635f , -3.04352f , 0f },
new List<float> { 13.67f , -5.59f , 270f },
new List<float> { 13.64708f , -5.068434f , 0f },
new List<float> { 3.289999f , -3.551f , 270f },
new List<float> { 3.358f , -6.421f , 270f },
new List<float> { 3.358f , -6.421f , 270f },
new List<float> { 3.289999f , -3.551f , 270f },
new List<float> { 3.392666f , -5.01f , 0f },
new List<float> { 0.176f , -3.515f , 270f },
new List<float> { -0.03106463f , -5.493763f , 270f },
new List<float> { 13.7789f , 1.168914f , 0f },
new List<float> { 13.67f , -1.46f , 270f },
new List<float> { 13.673f , -0.968f , 0f },
new List<float> { -7.869f , 6.006f , 0f },
new List<float> { -8.319475f , 10.23357f , 0f },
new List<float> { -5.608346f , -1.111277f , 0f },
new List<float> { -7.878f , -1.01f , 270f },
new List<float> { -12.12039f , -4.273339f , 0f },
new List<float> { -12.14f , -4.47f , 270f },
new List<float> { -7.927303f , -5.384097f , 0f },
new List<float> { -7.949066f , -5.894f , 270f },
new List<float> { -7.949066f , -5.894f , 270f },
new List<float> { -7.919999f , -2.698179f , 0f },
new List<float> { -7.936f , -3.73f , 270f },
new List<float> { -7.936f , -3.73f , 270f },
new List<float> { -0.03181737f , -4.939856f , 0f },
new List<float> { -17.054f , -6.052f , 270f },
new List<float> { -17.054f , -6.052f , 270f },
new List<float> { -20.31f , -5.916f , 270f },
new List<float> { -12.95436f , 7.57557f , 0f },
new List<float> { -12.93885f , 3.723476f , 0f },
new List<float> { -12.02239f , 1.046661f , 0f },
new List<float> { -12.042f , 0.85f , 270f },
new List<float> { -20.26604f , 7.577277f , 0f },
},
new List<List<float>> {
new List<float> { -2.543568f , 4.15935f , 0f },
},
new List<List<float>> {
},
new List<List<float>> {
},
new List<List<float>> {
},
new List<List<float>> {
new List<float> { 1.204f , 15.88301f , 0f },
},

            },
            new List<List<List<float>>>  //배열 스테이지 (3)
            {
                new List<List<float>>   //아이템 코드 (0)
                    {
new List<float> { 1.29472f , -2.631999f , 0f },
new List<float> { 0.7639999f , -2.631999f , 0f },
new List<float> { -1.95f , -2.631999f , 0f },
new List<float> { -1.423f , -2.631999f , 0f },
new List<float> { -2.480721f , -2.631999f , 0f },
new List<float> { -3.559f , -2.631999f , 0f },
new List<float> { -3.032f , -2.631999f , 0f },
new List<float> { -0.8850001f , -2.631999f , 0f },
new List<float> { -0.3542798f , -2.631999f , 0f },
new List<float> { 0.1979999f , -2.631999f , 0f },
new List<float> { 1.70446f , 7.036624f , 0f },
new List<float> { 0.7531514f , 7.038039f , 0f },
new List<float> { -4.08972f , -2.631999f , 0f },
new List<float> { -3.43428f , -0.9749994f , 180f },
new List<float> { -3.89f , -0.93f , 180f },
new List<float> { -15.061f , 2.866f , 180f },
new List<float> { 0.32272f , -0.9749994f , 180f },
new List<float> { 0.88872f , -0.9749994f , 180f },
new List<float> { 1.41944f , -0.9749994f , 180f },
new List<float> { -0.2295597f , -0.9749994f , 180f },
new List<float> { -0.76028f , -0.9749994f , 180f },
new List<float> { -2.356f , -0.9749994f , 180f },
new List<float> { -1.82528f , -0.9749994f , 180f },
new List<float> { -1.29828f , -0.9749994f , 180f },
new List<float> { -2.90728f , -0.9749994f , 180f },
new List<float> { -9.672f , -4.948f , 270f },
new List<float> { -9.68f , -6.1f , 270f },
new List<float> { -9.648f , -5.536f , 270f },
new List<float> { -8.68f , -2.47f , 90f },
new List<float> { -8.69f , -3.27f , 90f },
new List<float> { -8.75f , -4.05f , 90f },
new List<float> { -15.18f , -5.19f , 180f },
new List<float> { -16.79f , -5.19f , 180f },
new List<float> { -16.278f , -5.205f , 180f },
new List<float> { -15.74228f , -5.186f , 180f },
new List<float> { -2.862587f , 6.943386f , 0f },
new List<float> { -2.200017f , 6.943386f , 0f },
new List<float> { -0.7396735f , 6.945281f , 0f },
new List<float> { -1.505f , 2.565f , 180f },
new List<float> { 0.05272043f , 7.028574f , 0f },
new List<float> { -4.183f , 7.016f , 0f },
new List<float> { -3.506226f , 6.990712f , 0f },
new List<float> { -10.65095f , 1.063464f , 0f },
new List<float> { -12.73095f , 1.023463f , 0f },
new List<float> { -13.898f , 3.834f , 270f },
new List<float> { -13.898f , 3.429f , 270f },
new List<float> { -14.61669f , 2.849993f , 180f },
new List<float> { -11.75008f , 5.301312f , 0f },
new List<float> { -9.590586f , 5.301312f , 0f },
new List<float> { -10.68284f , 5.30965f , 0f },
new List<float> { -4.107088f , 0.7469341f , 0f },
new List<float> { 4.13372f , -0.9749994f , 180f },
new List<float> { 4.68272f , -0.9749994f , 180f },
new List<float> { 5.26372f , -0.9749994f , 180f },
new List<float> { 3.57044f , -0.9749994f , 180f },
new List<float> { 3.04344f , -0.9749994f , 180f },
new List<float> { 2.51272f , -0.9749994f , 180f },
new List<float> { 1.94644f , -0.9749994f , 180f },
new List<float> { 2.159014f , 0.7368636f , 0f },
new List<float> { 4.558f , -2.631999f , 0f },
new List<float> { 2.91872f , -2.631999f , 0f },
new List<float> { 3.44572f , -2.631999f , 0f },
new List<float> { 4.009f , -2.631999f , 0f },
new List<float> { 5.139f , -2.631999f , 0f },
new List<float> { 1.82172f , -2.631999f , 0f },
new List<float> { 2.388f , -2.631999f , 0f },
new List<float> { 5.872f , -0.901f , 180f },
new List<float> { 7.204f , -0.274f , 270f },
new List<float> { 6.398f , -0.892f , 180f },
new List<float> { -1.461303f , 6.945281f , 0f },
new List<float> { 20.209f , -3.69946f , 0f },
new List<float> { 17.32075f , -3.69946f , 0f },
new List<float> { 17.889f , -3.69946f , 0f },
new List<float> { 18.475f , -3.69946f , 0f },
new List<float> { 19.043f , -3.69946f , 0f },
new List<float> { 19.612f , -3.69946f , 0f },
new List<float> { 14.514f , -6.01f , 270f },
new List<float> { 11.02f , -4.6f , 180f },
new List<float> { 14.51f , -6.361f , 270f },
new List<float> { 8.31f , -0.212f , 90f },
new List<float> { -18.96371f , -3.34222f , 0f },

                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {

                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
new List<float> { -3.085f , 1.683f , 0f },

                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {

new List<float> { -1.616f , -3.744f , 180f },
new List<float> { -2.156f , -3.753999f , 180f },
new List<float> { -3.088f , -3.752f , 180f },
new List<float> { -3.548f , -3.761999f , 180f },
new List<float> { -2.708f , -3.752f , 180f },
new List<float> { -5.329f , 6.3f , 0f },
new List<float> { -4.789001f , 6.3f , 0f },
new List<float> { -4.329f , 6.3f , 0f },
new List<float> { -3.949001f , 6.3f , 0f },
new List<float> { -5.881001f , 6.3f , 0f },
new List<float> { -7.493f , 5.715f , 90f },
new List<float> { -1.632001f , 6.3f , 0f },
new List<float> { -1.092001f , 6.3f , 0f },
new List<float> { -0.6320009f , 6.318f , 0f },
new List<float> { -2.520001f , 6.3f , 0f },
new List<float> { -2.980001f , 6.3f , 0f },
new List<float> { -6.189999f , 5.95f , 180f },
new List<float> { -5.729999f , 5.95f , 180f },
new List<float> { -5.349999f , 5.95f , 180f },
new List<float> { -6.729999f , 5.95f , 180f },
new List<float> { -6.953f , 5.72f , 270f },
new List<float> { -7.002f , 6.29f , 0f },
new List<float> { -5.91f , 6.29f , 0f },
new List<float> { -5.45f , 6.29f , 0f },
new List<float> { -6.45f , 6.29f , 0f },
new List<float> { -4.098f , -3.341999f , 0f },
new List<float> { -4.088f , -3.771999f , 180f },
new List<float> { -4.695f , -3.735f , 180f },
new List<float> { -4.315f , -3.735f , 180f },
new List<float> { -4.675f , -3.234999f , 270f },
new List<float> { -4.325001f , -3.305f , 0f },
new List<float> { -5.225f , -3.285f , 90f },
new List<float> { -5.215f , -2.854999f , 90f },
new List<float> { -4.655f , -2.885f , 270f },
new List<float> { -6.96f , 2.97f , 270f },
new List<float> { -7.5f , 2.965f , 90f },
new List<float> { -7.505f , 4.089f , 90f },
new List<float> { -7.505f , 3.53f , 90f },
new List<float> { -6.96f , 3.526f , 270f },
new List<float> { -6.972f , 5.186f , 270f },
new List<float> { -7.512f , 5.181f , 90f },
new List<float> { -7.518f , 4.654f , 90f },
new List<float> { -6.978f , 4.653f , 270f },
new List<float> { -6.982f , 4.094f , 270f },
new List<float> { 1.547f , 0.06f , 0f },
new List<float> { 1.557f , -0.3699998f , 180f },
new List<float> { 1.039f , 0.09800011f , 0f },
new List<float> { 1.049001f , -0.3320002f , 180f },
new List<float> { 0.6690004f , -0.3320002f , 180f },
new List<float> { 0.6590002f , 0.09800011f , 0f },
new List<float> { 0.1990001f , 0.08799988f , 0f },
new List<float> { 0.2090003f , -0.3419999f , 180f },
new List<float> { -0.3309996f , -0.3519997f , 180f },
new List<float> { -0.3409998f , 0.07800013f , 0f },
new List<float> { -1.14f , -0.3680004f , 180f },
new List<float> { -0.7599994f , -0.3680004f , 180f },
new List<float> { -1.61f , 0.05199963f , 0f },
new List<float> { -1.15f , 0.06199986f , 0f },
new List<float> { -2.691999f , -0.3860001f , 180f },
new List<float> { -3.072f , -0.3860001f , 180f },
new List<float> { -3.082f , 0.04400021f , 0f },
new List<float> { -3.542f , 0.03399998f , 0f },
new List<float> { -2.139999f , -0.388f , 180f },
new List<float> { -1.6f , -0.3780002f , 180f },
new List<float> { -0.7699999f , 0.06199986f , 0f },
new List<float> { -2.15f , 0.04199988f , 0f },
new List<float> { -2.702f , 0.04400021f , 0f },
new List<float> { -3.532f , -0.3959998f , 180f },
new List<float> { -4.299f , -0.3690004f , 180f },
new List<float> { -4.072f , -0.4059996f , 180f },
new List<float> { -4.659f , 0.1310001f , 270f },
new List<float> { -4.309f , 0.06099993f , 0f },
new List<float> { -4.082f , 0.02400023f , 0f },
new List<float> { -4.655f , 0.6650004f , 270f },
new List<float> { -4.655f , 1.175f , 270f },
new List<float> { -4.655f , 1.515f , 270f },
new List<float> { -4.655f , 2.325001f , 270f },
new List<float> { -4.655f , 1.985f , 270f },
new List<float> { -5.155f , 1.085f , 90f },
new List<float> { -5.145f , 1.555f , 90f },
new List<float> { -5.145f , 2.365f , 90f },
new List<float> { -5.155f , 1.895f , 90f },
new List<float> { -5.155f , 1.895f , 90f },
new List<float> { -5.145f , 2.365f , 90f },
new List<float> { -4.655f , 1.985f , 270f },
new List<float> { -4.655f , 2.325001f , 270f },
new List<float> { -4.675f , 2.795f , 270f },
new List<float> { -5.175f , 2.705f , 90f },
new List<float> { -4.625f , 3.205f , 270f },
new List<float> { -5.165f , 3.175f , 90f },
new List<float> { -4.530662f , 3.655f , 0f },
new List<float> { -3.957f , 3.655f , 0f },
new List<float> { -3.577f , 3.655f , 0f },
new List<float> { -1.645f , 3.655f , 0f },
new List<float> { -2.025f , 3.655f , 0f },
new List<float> { -2.485f , 3.655f , 0f },
new List<float> { -3.025f , 3.655f , 0f },
new List<float> { -1.216f , 3.655f , 0f },
new List<float> { -0.6760004f , 3.655f , 0f },
new List<float> { -0.2160003f , 3.655f , 0f },
new List<float> { 0.1639996f , 3.655f , 0f },
new List<float> { 1.672f , 3.673001f , 0f },
new List<float> { -14.50605f , -1.932001f , 0f },
new List<float> { -14.04605f , -1.932001f , 0f },
new List<float> { -14.083f , -2.471f , 180f },
new List<float> { -14.543f , -2.471f , 180f },
new List<float> { -15.59809f , -1.932001f , 0f },
new List<float> { -15.04405f , -1.932001f , 0f },
new List<float> { -15.081f , -2.471f , 180f },
new List<float> { -15.63505f , -2.471f , 180f },
new List<float> { -18.45f , -2.07f , 90f },
new List<float> { -19.16962f , -4.009216f , 0f },
new List<float> { -17.94595f , -3.97f , 0f },
new List<float> { -17.95f , -3.59f , 270f },
new List<float> { -18.45f , -3.68f , 90f },
new List<float> { -17.94f , 1.92f , 270f },
new List<float> { -18.44f , 1.59f , 90f },
new List<float> { -18.44f , 1.59f , 90f },
new List<float> { -17.93f , 2.41f , 270f },
new List<float> { -17.93f , 2.75f , 270f },
new List<float> { -17.93f , 3.22f , 270f },
new List<float> { -10.92439f , 4.089f , 180f },
new List<float> { -10.38639f , 4.089f , 180f },
new List<float> { -9.926387f , 4.089f , 180f },
new List<float> { -9.87f , 1.56f , 90f },
new List<float> { -9.36f , 1.56f , 270f },
new List<float> { -17.95f , -2.44f , 270f },
new List<float> { -18.44f , -2.4f , 90f },
new List<float> { -18.44f , -2.4f , 90f },
new List<float> { -17.95f , -2.44f , 270f },
new List<float> { -18.45f , -2.87f , 90f },
new List<float> { -18.45f , -2.87f , 90f },
new List<float> { -17.95f , -2.78f , 270f },
new List<float> { -17.95f , -2.78f , 270f },
new List<float> { -17.95f , -3.25f , 270f },
new List<float> { -18.53695f , -4.509f , 180f },
new List<float> { -18.70895f , -4.549f , 180f },
new List<float> { -17.98291f , -4.509f , 180f },
new List<float> { -19.16895f , -4.549f , 180f },
new List<float> { -19.70695f , -4.549f , 180f },
new List<float> { -20.261f , -4.549f , 180f },
new List<float> { -18.5f , -3.97f , 0f },
new List<float> { -19.726f , -4.002f , 0f },
new List<float> { -20.27f , -4.01f , 0f },
new List<float> { -18.672f , -4.01f , 0f },
new List<float> { -18.44f , -3.21f , 90f },
new List<float> { 0.1829998f , -3.278f , 0f },
new List<float> { 0.6429999f , -3.267999f , 0f },
new List<float> { 1.541f , -3.735999f , 180f },
new List<float> { 1.023f , -3.267999f , 0f },
new List<float> { 1.531f , -3.306f , 0f },
new List<float> { 0.6530001f , -3.698f , 180f },
new List<float> { 1.033f , -3.698f , 180f },
new List<float> { -2.718f , -3.321999f , 0f },
new List<float> { -3.558f , -3.332f , 0f },
new List<float> { -3.098f , -3.321999f , 0f },
new List<float> { -0.7860001f , -3.304f , 0f },
new List<float> { -0.7759997f , -3.734f , 180f },
new List<float> { -1.156f , -3.734f , 180f },
new List<float> { -2.166f , -3.324f , 0f },
new List<float> { -0.3570001f , -3.287999f , 0f },
new List<float> { -1.166f , -3.304f , 0f },
new List<float> { -1.626f , -3.314f , 0f },
new List<float> { -0.3469999f , -3.717999f , 180f },
new List<float> { 0.1930001f , -3.707999f , 180f },
new List<float> { -18.43f , 2.32f , 90f },
new List<float> { -18.42f , 2.79f , 90f },
new List<float> { -18.42f , 3.6f , 90f },
new List<float> { -18.43f , 3.13f , 90f },
new List<float> { -18.43f , 3.13f , 90f },
new List<float> { -18.42f , 3.6f , 90f },
new List<float> { -17.93f , 3.56f , 270f },
new List<float> { -17.93f , 3.56f , 270f },
new List<float> { -17.93f , 3.22f , 270f },
new List<float> { -17.92f , 3.93f , 270f },
new List<float> { -9.889434f , 4.628f , 0f },
new List<float> { -10.34943f , 4.628f , 0f },
new List<float> { -10.88743f , 4.628f , 0f },
new List<float> { -18.43f , 3.93f , 90f },
new List<float> { -7.58f , -5.03f , 270f },
new List<float> { -7.521f , -4.697f , 270f },
new List<float> { -7.502f , -5.02f , 270f },
new List<float> { -7.512f , -5.49f , 270f },
new List<float> { -7.51f , -6.39f , 180f },
new List<float> { -8.06f , -5.93f , 90f },
new List<float> { -8.07f , -5.46f , 90f },
new List<float> { -7.501f , -5.867f , 270f },
new List<float> { -8.07f , -4.65f , 90f },
new List<float> { -8.08f , -5.12f , 90f },
new List<float> { -8.08f , -5.12f , 90f },
new List<float> { -8.07f , -4.65f , 90f },
new List<float> { -12.304f , -6.984f , 270f },
new List<float> { -12.286f , -7.388f , 270f },
new List<float> { -12.82f , -7.363f , 90f },
new List<float> { -12.819f , -4.66f , 90f },
new List<float> { -12.3f , -4.68f , 270f },
new List<float> { -10.87f , -4.94f , 90f },
new List<float> { -10.316f , -4.935f , 270f },
new List<float> { -10.308f , -5.465f , 270f },
new List<float> { -10.862f , -5.47f , 90f },
new List<float> { -10.316f , -6.015f , 270f },
new List<float> { -8.041f , -4.32f , 90f },
new List<float> { -8.031f , -3.813f , 90f },
new List<float> { -7.473f , -4.31f , 270f },
new List<float> { -7.501f , -3.801f , 270f },
new List<float> { -7.494f , -3.305f , 270f },
new List<float> { -10.308f , -4.385f , 270f },
new List<float> { -10.842f , -1.77f , 90f },
new List<float> { -10.858f , -2.268f , 90f },
new List<float> { -10.826f , 0.375f , 0f },
new List<float> { -10.858f , -0.678f , 90f },
new List<float> { -10.842f , -3.36f , 90f },
new List<float> { -10.862f , -4.39f , 90f },
new List<float> { -7.501f , -2.775f , 270f },
new List<float> { -8.024f , -3.29f , 90f },
new List<float> { -7.996f , -2.767f , 90f },
new List<float> { -16.498f , -3.98f , 0f },
new List<float> { -15.96f , -3.98f , 0f },
new List<float> { -15.5f , -3.98f , 0f },
new List<float> { -16.53495f , -4.519f , 180f },
new List<float> { -16.98491f , -4.509f , 180f },
new List<float> { -15.53695f , -4.519f , 180f },
new List<float> { -15.99695f , -4.519f , 180f },
new List<float> { -17.44491f , -4.509f , 180f },
new List<float> { -16.94795f , -3.97f , 0f },
new List<float> { -17.40795f , -3.97f , 0f },
new List<float> { -17.94f , -2.07f , 270f },
new List<float> { -17.94f , -1.56f , 270f },
new List<float> { -17.94f , -1.22f , 270f },
new List<float> { -17.94f , -0.4100001f , 270f },
new List<float> { -17.94f , -0.75f , 270f },
new List<float> { -17.94f , -0.75f , 270f },
new List<float> { -17.94f , -0.4100001f , 270f },
new List<float> { -17.153f , 0.419f , 0f },
new List<float> { -17.68595f , 0.4105119f , 0f },
new List<float> { -17.91413f , 0.4166789f , 0f },
new List<float> { -17.924f , -0.07f , 180f },
new List<float> { -16.59895f , 0.4190001f , 0f },
new List<float> { -16.06095f , 0.4190001f , 0f },
new List<float> { -15.58695f , -0.1389995f , 180f },
new List<float> { -15.03291f , -0.1389995f , 180f },
new List<float> { -14.45795f , 0.4000001f , 0f },
new List<float> { -13.99795f , 0.4000001f , 0f },
new List<float> { -14.99595f , 0.4000001f , 0f },
new List<float> { -15.55f , 0.4f , 0f },
new List<float> { -15.55f , 0.4f , 0f },
new List<float> { -14.99595f , 0.4000001f , 0f },
new List<float> { -14.49491f , -0.1389995f , 180f },
new List<float> { -14.03491f , -0.1389995f , 180f },
new List<float> { -13.99795f , 0.4000001f , 0f },
new List<float> { -14.45795f , 0.4000001f , 0f },
new List<float> { -11.93505f , 0.4089996f , 0f },
new List<float> { -12.39505f , 0.4089996f , 0f },
new List<float> { -12.93305f , 0.4089996f , 0f },
new List<float> { -13.48709f , 0.4089995f , 0f },
new List<float> { -11.364f , 0.383f , 0f },
new List<float> { -10.248f , 0.37f , 0f },
new List<float> { -14.03491f , -0.1389995f , 180f },
new List<float> { -14.49491f , -0.1389995f , 180f },
new List<float> { -15.03291f , -0.1389995f , 180f },
new List<float> { -15.58695f , -0.1389995f , 180f },
new List<float> { -13.52405f , -0.13f , 180f },
new List<float> { -12.97f , -0.13f , 180f },
new List<float> { -12.432f , -0.13f , 180f },
new List<float> { -11.916f , -0.13f , 180f },
new List<float> { -12.8f , -5.55f , 90f },
new List<float> { -12.31f , -5.59f , 270f },
new List<float> { -12.31f , -5.12f , 270f },
new List<float> { -12.81f , -5.21f , 90f },
new List<float> { -12.81f , -5.21f , 90f },
new List<float> { -12.31f , -5.12f , 270f },
new List<float> { -12.81f , -6.02f , 90f },
new List<float> { -12.31f , -6.44f , 270f },
new List<float> { -12.31f , -5.93f , 270f },
new List<float> { -12.82f , -6.44f , 90f },
new List<float> { -12.808f , -6.99f , 90f },
new List<float> { -10.87f , -6.02f , 90f },
new List<float> { 0.89f , -6.42f , 180f },
new List<float> { 0.4300001f , -6.42f , 180f },
new List<float> { -0.1080003f , -6.42f , 180f },
new List<float> { -0.6620469f , -6.42f , 180f },
new List<float> { 0.4669529f , -5.881001f , 0f },
new List<float> { 0.9269531f , -5.881001f , 0f },
new List<float> { 1.44f , -6.45f , 180f },
new List<float> { 1.476953f , -5.911f , 0f },
new List<float> { -3.76f , -5.86f , 0f },
new List<float> { -3.3f , -5.86f , 0f },
new List<float> { -3.336953f , -6.399f , 180f },
new List<float> { -3.796953f , -6.399f , 180f },
new List<float> { -2.779f , -6.408999f , 180f },
new List<float> { 0.3920007f , 3.315f , 180f },
new List<float> { 0.9320006f , 3.315f , 180f },
new List<float> { 1.212f , 3.655f , 0f },
new List<float> { 1.392001f , 3.333f , 180f },
new List<float> { 0.6719997f , 3.655f , 0f },
new List<float> { -2.764999f , 3.315f , 180f },
new List<float> { -2.304999f , 3.315f , 180f },
new List<float> { -1.924999f , 3.315f , 180f },
new List<float> { -0.9559994f , 3.315f , 180f },
new List<float> { -1.495999f , 3.315f , 180f },
new List<float> { -3.304999f , 3.315f , 180f },
new List<float> { -3.856999f , 3.315f , 180f },
new List<float> { -0.1159995f , 3.315f , 180f },
new List<float> { -0.4959993f , 3.315f , 180f },
new List<float> { -4.237f , 3.315f , 180f },
new List<float> { -5.87f , -5.86f , 0f },
new List<float> { -6.408f , -5.86f , 0f },
new List<float> { -6.999f , -6.399f , 180f },
new List<float> { -6.962047f , -5.86f , 0f },
new List<float> { -6.444953f , -6.399f , 180f },
new List<float> { -4.852047f , -5.86f , 0f },
new List<float> { -5.906953f , -6.399f , 180f },
new List<float> { -5.446953f , -6.399f , 180f },
new List<float> { -5.41f , -5.86f , 0f },
new List<float> { -4.298f , -5.86f , 0f },
new List<float> { -4.334953f , -6.399f , 180f },
new List<float> { -4.889f , -6.399f , 180f },
new List<float> { -2.742047f , -5.87f , 0f },
new List<float> { -1.686953f , -6.408999f , 180f },
new List<float> { -1.226953f , -6.408999f , 180f },
new List<float> { -1.19f , -5.87f , 0f },
new List<float> { -1.65f , -5.87f , 0f },
new List<float> { -2.224953f , -6.408999f , 180f },
new List<float> { -2.188f , -5.87f , 0f },
new List<float> { -0.6250939f , -5.881001f , 0f },
new List<float> { -0.07104731f , -5.881001f , 0f },
new List<float> { -9.86f , 1.23f , 90f },
new List<float> { -9.87f , 0.7600002f , 90f },
new List<float> { -9.87f , 0.7600002f , 90f },
new List<float> { -9.86f , 1.23f , 90f },
new List<float> { -9.37f , 1.19f , 270f },
new List<float> { -9.37f , 0.8500004f , 270f },
new List<float> { -9.37f , 0.8500004f , 270f },
new List<float> { -9.37f , 1.19f , 270f },
new List<float> { -11.94f , 1.19f , 90f },
new List<float> { -11.95f , 0.7199998f , 90f },
new List<float> { -11.95f , 0.7199998f , 90f },
new List<float> { -11.94f , 1.19f , 90f },
new List<float> { -11.45f , 1.15f , 270f },
new List<float> { -11.45f , 0.8099999f , 270f },
new List<float> { -11.44f , 1.52f , 270f },
new List<float> { -11.95f , 1.52f , 90f },
new List<float> { -11.45f , 0.8099999f , 270f },
new List<float> { -11.45f , 1.15f , 270f },
new List<float> { -11.391f , 4.628f , 0f },
new List<float> { -11.42795f , 4.089f , 180f },
new List<float> { -18.44f , -1.65f , 90f },
new List<float> { -18.43f , -1.18f , 90f },
new List<float> { -18.43f , -0.3699999f , 90f },
new List<float> { -18.44f , -0.8399999f , 90f },
new List<float> { -18.44f , -0.8399999f , 90f },
new List<float> { -18.43f , -0.3699999f , 90f },
new List<float> { -18.44f , -0.03999996f , 90f },
new List<float> { -18.44f , 0.7799999f , 90f },
new List<float> { -17.95f , 0.7399999f , 270f },
new List<float> { -18.45f , 0.3099998f , 90f },
new List<float> { -18.32f , 6.638f , 0f },
new List<float> { -19.6f , 6.296f , 180f },
new List<float> { -19.06f , 6.298f , 180f },
new List<float> { -18.45f , 1.12f , 90f },
new List<float> { -18.45f , 1.12f , 90f },
new List<float> { -17.95f , 1.55f , 270f },
new List<float> { -17.95f , 1.21f , 270f },
new List<float> { -17.95f , 1.21f , 270f },
new List<float> { -17.95f , 1.55f , 270f },
new List<float> { -18.78f , 6.638f , 0f },
new List<float> { -19.32f , 6.636f , 0f },
new List<float> { -18.45f , 1.92f , 90f },
new List<float> { -18.6f , 6.298f , 180f },
new List<float> { -18.22f , 6.298f , 180f },
new List<float> { -17.85f , 6.288f , 180f },
new List<float> { -17.94f , 6.638f , 0f },
new List<float> { -19.833f , 6.298f , 180f },
new List<float> { -20.275f , 6.324f , 180f },
new List<float> { -19.933f , 6.656f , 0f },
new List<float> { -20.278f , 6.679f , 0f },
new List<float> { -19.553f , 6.638f , 0f },
new List<float> { 6.513f , 1.117f , 270f },
new List<float> { 6.015f , 0.6050004f , 90f },
new List<float> { 6.025f , 1.105f , 90f },
new List<float> { 6.545f , 1.515f , 270f },
new List<float> { 6.045f , 1.515f , 90f },
new List<float> { 6.035f , 1.895f , 90f },
new List<float> { 6.045f , 2.365f , 90f },
new List<float> { 6.035f , 1.895f , 90f },
new List<float> { 6.055f , 2.635f , 90f },
new List<float> { 5.955f , 0.1490002f , 90f },
new List<float> { 6.501f , 0.02099997f , 270f },
new List<float> { 5.615f , 0.03500038f , 0f },
new List<float> { 6.515f , 0.5750003f , 270f },
new List<float> { 6.535f , 1.985f , 270f },
new List<float> { 6.535f , 2.325f , 270f },
new List<float> { 6.535f , 2.325f , 270f },
new List<float> { 6.535f , 1.985f , 270f },
new List<float> { 6.045f , 2.365f , 90f },
new List<float> { 6.055f , 2.635f , 90f },
new List<float> { 5.075f , 0.02500063f , 0f },
new List<float> { 4.539999f , 0.07999998f , 0f },
new List<float> { 4.16f , 0.08f , 0f },
new List<float> { 3.7f , 0.06999975f , 0f },
new List<float> { 3.16f , 0.06f , 0f },
new List<float> { 2.927f , 0.07999998f , 0f },
new List<float> { 2.087f , 0.06999975f , 0f },
new List<float> { 2.547f , 0.07999998f , 0f },
new List<float> { -4.732f , -0.319f , 180f },
new List<float> { 10.6999f , 0.049f , 0f },
new List<float> { 10.69f , -0.4600003f , 180f },
new List<float> { 10.31f , -0.4600003f , 180f },
new List<float> { 10.3f , 0.059f , 0f },
new List<float> { 12.242f , -0.4420007f , 180f },
new List<float> { 12.622f , -0.4420007f , 180f },
new List<float> { 12.612f , 0.038f , 0f },
new List<float> { 2.097f , -0.3600001f , 180f },
new List<float> { 2.557f , -0.3500003f , 180f },
new List<float> { 4.55f , -0.3500003f , 180f },
new List<float> { 4.17f , -0.3500003f , 180f },
new List<float> { 3.71f , -0.3600001f , 180f },
new List<float> { 11.782f , -0.4520004f , 180f },
new List<float> { 11.772f , 0.048f , 0f },
new List<float> { 12.232f , 0.048f , 0f },
new List<float> { 11.242f , 0.057f , 0f },
new List<float> { 11.242f , -0.4620002f , 180f },
new List<float> { 9.88f , 0.02f , 0f },
new List<float> { 9.849999f , -0.4700001f , 180f },
new List<float> { 9.31f , -0.4799998f , 180f },
new List<float> { 6.085f , -0.3849997f , 180f },
new List<float> { 3.17f , -0.3699998f , 180f },
new List<float> { 2.937001f , -0.3500003f , 180f },
new List<float> { 5.078f , -0.355f , 180f },
new List<float> { 5.618f , -0.3519997f , 180f },
new List<float> { 6.068f , -2.943f , 270f },
new List<float> { 6.068f , -3.335999f , 270f },
new List<float> { 5.105f , -3.714f , 180f },
new List<float> { 2.921f , -3.716f , 180f },
new List<float> { 3.144f , -3.306f , 0f },
new List<float> { 3.154f , -3.735999f , 180f },
new List<float> { 3.684f , -3.296f , 0f },
new List<float> { 3.694f , -3.726f , 180f },
new List<float> { 5.634f , -2.905999f , 90f },
new List<float> { 5.646f , -3.710999f , 180f },
new List<float> { 5.534f , -3.294999f , 0f },
new List<float> { 5.059f , -3.340999f , 0f },
new List<float> { 2.531f , -3.286f , 0f },
new List<float> { 2.541f , -3.716f , 180f },
new List<float> { 2.911f , -3.286f , 0f },
new List<float> { 2.071f , -3.296f , 0f },
new List<float> { 2.081f , -3.726f , 180f },
new List<float> { 4.144f , -3.286f , 0f },
new List<float> { 4.154f , -3.716f , 180f },
new List<float> { 4.556f , -3.716f , 180f },
new List<float> { 4.523999f , -3.286f , 0f },
new List<float> { 5.709001f , -6.448999f , 180f },
new List<float> { 6.227094f , -6.448999f , 180f },
new List<float> { 6.263047f , -6.448999f , 180f },
new List<float> { 5.673047f , -6.448999f , 180f },
new List<float> { 6.801048f , -6.448999f , 180f },
new List<float> { 7.261047f , -6.448999f , 180f },
new List<float> { 7.81f , -6.47f , 180f },
new List<float> { 7.846953f , -5.931f , 0f },
new List<float> { 5.745954f , -5.91f , 0f },
new List<float> { 5.71f , -5.91f , 0f },
new List<float> { 6.264047f , -5.91f , 0f },
new List<float> { 7.298001f , -5.91f , 0f },
new List<float> { 6.838f , -5.91f , 0f },
new List<float> { 6.3f , -5.91f , 0f },
new List<float> { 1.994047f , -6.45f , 180f },
new List<float> { 2.532047f , -6.45f , 180f },
new List<float> { 2.992047f , -6.45f , 180f },
new List<float> { 3.029f , -5.911f , 0f },
new List<float> { 2.569f , -5.911f , 0f },
new List<float> { 2.031f , -5.911f , 0f },
new List<float> { 3.594906f , -5.901f , 0f },
new List<float> { 4.148952f , -5.901f , 0f },
new List<float> { 4.686953f , -5.901f , 0f },
new List<float> { 5.146953f , -5.901f , 0f },
new List<float> { 5.11f , -6.44f , 180f },
new List<float> { 4.65f , -6.44f , 180f },
new List<float> { 4.112f , -6.44f , 180f },
new List<float> { 3.557953f , -6.44f , 180f },
new List<float> { 6.802047f , -5.91f , 0f },
new List<float> { 7.262047f , -5.91f , 0f },
new List<float> { 7.225094f , -6.448999f , 180f },
new List<float> { 6.765094f , -6.448999f , 180f },
new List<float> { 8.938999f , -5.931f , 0f },
new List<float> { 8.400999f , -5.931f , 0f },
new List<float> { 8.364046f , -6.47f , 180f },
new List<float> { 9.95f , -5.91f , 0f },
new List<float> { 8.902047f , -6.47f , 180f },
new List<float> { 9.362047f , -6.47f , 180f },
new List<float> { 9.399f , -5.931f , 0f },
new List<float> { 12.01f , -6.448999f , 180f },
new List<float> { 12.56405f , -6.448999f , 180f },
new List<float> { 10.46709f , -6.448999f , 180f },
new List<float> { 9.913047f , -6.448999f , 180f },
new List<float> { 2.824999f , 3.655f , 0f },
new List<float> { 3.284999f , 3.655f , 0f },
new List<float> { 3.664999f , 3.655f , 0f },
new List<float> { 2.052f , 3.655f , 0f },
new List<float> { 2.284999f , 3.653001f , 0f },
new List<float> { 2.545f , 3.315f , 180f },
new List<float> { 2.005f , 3.313f , 180f },
new List<float> { 6.555f , 2.725001f , 270f },
new List<float> { 6.555f , 3.065f , 270f },
new List<float> { 6.555f , 3.065f , 270f },
new List<float> { 6.555f , 2.725001f , 270f },
new List<float> { 6.065f , 3.105f , 90f },
new List<float> { 6.065f , 3.105f , 90f },
new List<float> { 6.164f , -2.372f , 0f },
new List<float> { 6.715f , -2.381f , 0f },
new List<float> { 6.552f , -2.612f , 180f },
new List<float> { 3.385f , 3.315f , 180f },
new List<float> { 3.005f , 3.315f , 180f },
new List<float> { 1.772001f , 3.315f , 180f },
new List<float> { 3.755f , 3.305001f , 180f },
new List<float> { -10.304f , -0.673f , 270f },
new List<float> { -10.28f , -1.215f , 270f },
new List<float> { -10.304f , -2.263f , 270f },
new List<float> { -10.253f , -0.188f , 180f },
new List<float> { -10.834f , -1.22f , 90f },
new List<float> { -10.288f , -1.765f , 270f },
new List<float> { -10.811f , -0.18f , 180f },
new List<float> { -5.148953f , 0.3470001f , 0f },
new List<float> { -5.703f , 0.347f , 0f },
new List<float> { -5.739953f , -0.1919995f , 180f },
new List<float> { -5.15f , -0.213f , 180f },
new List<float> { -5.155f , 0.822f , 90f },
new List<float> { -10.834f , -2.81f , 90f },
new List<float> { -10.288f , -3.355f , 270f },
new List<float> { -10.28f , -2.805f , 270f },
new List<float> { 0.8370013f , 6.01f , 180f },
new List<float> { 0.2970014f , 6.01f , 180f },
new List<float> { 1.677001f , 6.01f , 180f },
new List<float> { 1.910001f , 6.008f , 180f },
new List<float> { 2.450001f , 6.01f , 180f },
new List<float> { -4.229f , 5.96f , 180f },
new List<float> { -4.609f , 5.96f , 180f },
new List<float> { -5.069f , 5.96f , 180f },
new List<float> { -5.609f , 5.96f , 180f },
new List<float> { 3.660001f , 6f , 180f },
new List<float> { -0.2109988f , 6.01f , 180f },
new List<float> { 2.19f , 6.348f , 0f },
new List<float> { 1.297001f , 6.028f , 180f },
new List<float> { 0.5770004f , 6.35f , 0f },
new List<float> { 1.117f , 6.35f , 0f },
new List<float> { 1.577f , 6.368f , 0f },
new List<float> { 1.957f , 6.35f , 0f },
new List<float> { 0.06900024f , 6.35f , 0f },
new List<float> { 2.910001f , 6.01f , 180f },
new List<float> { 3.290001f , 6.01f , 180f },
new List<float> { 3.19f , 6.35f , 0f },
new List<float> { 3.57f , 6.35f , 0f },
new List<float> { 2.73f , 6.35f , 0f },
new List<float> { -2.42f , 5.96f , 180f },
new List<float> { -1.912f , 5.96f , 180f },
new List<float> { -2.140001f , 6.3f , 0f },
new List<float> { -3.26f , 5.96f , 180f },
new List<float> { -2.8f , 5.96f , 180f },
new List<float> { -3.520001f , 6.3f , 0f },
new List<float> { -0.3109996f , 6.35f , 0f },
new List<float> { -0.5320001f , 5.96f , 180f },
new List<float> { -0.9119999f , 5.978f , 180f },
new List<float> { -3.8f , 5.96f , 180f },
new List<float> { -1.372f , 5.96f , 180f },
new List<float> { 15.755f , -3.636f , 0f },
new List<float> { 14.702f , -3.975999f , 180f },
new List<float> { 15.215f , -3.638f , 0f },
new List<float> { 13.10205f , -6.448999f , 180f },
new List<float> { 14.935f , -3.978f , 180f },
new List<float> { 15.475f , -3.975999f , 180f },
new List<float> { 15.935f , -3.975999f , 180f },
new List<float> { 14.322f , -3.958f , 180f },
new List<float> { 13.862f , -3.975999f , 180f },
new List<float> { 13.322f , -3.975999f , 180f },
new List<float> { 16.215f , -3.636f , 0f },
new List<float> { 13.591f , -0.4160002f , 180f },
new List<float> { 13.051f , -0.4259999f , 180f },
new List<float> { 14.142f , -3.636f , 0f },
new List<float> { 14.602f , -3.618f , 0f },
new List<float> { 14.982f , -3.636f , 0f },
new List<float> { 13.602f , -3.636f , 0f },
new List<float> { 13.094f , -3.636f , 0f },
new List<float> { 16.944f , -4.888f , 180f },
new List<float> { 17.495f , -4.865f , 180f },
new List<float> { 16.705f , -4.046f , 270f },
new List<float> { 16.364f , -4.326f , 90f },
new List<float> { 16.733f , -4.321f , 270f },
new List<float> { 20.197f , -4.916f , 180f },
new List<float> { 17.127f , -4.4f , 0f },
new List<float> { 18.676f , -4.4f , 0f },
new List<float> { 19.22f , -4.4f , 0f },
new List<float> { 17.671f , -4.4f , 0f },
new List<float> { 18.169f , -4.4f , 0f },
new List<float> { 19.564f , -4.901f , 180f },
new List<float> { 19.973f , -4.901f , 180f },
new List<float> { 19.782f , -4.4f , 0f },
new List<float> { 20.19f , -4.4f , 0f },
new List<float> { 16.486f , -4.048f , 180f },
new List<float> { 18.059f , -4.87f , 180f },
new List<float> { 18.569f , -4.893f , 180f },
new List<float> { 19.07f , -4.87f , 180f },
new List<float> { 13.569f , -6.449f , 180f },
new List<float> { 13.599f , -5.91f , 0f },
new List<float> { 13.139f , -5.91f , 0f },
new List<float> { 12.434f , -3.975999f , 180f },
new List<float> { 12.814f , -3.975999f , 180f },
new List<float> { 12.714f , -3.636f , 0f },
new List<float> { 11.005f , -3.976f , 180f },
new List<float> { 10.625f , -3.976f , 180f },
new List<float> { 10.905f , -3.636f , 0f },
new List<float> { 11.434f , -3.975999f , 180f },
new List<float> { 11.974f , -3.975999f , 180f },
new List<float> { 10.50405f , -5.91f , 0f },
new List<float> { 12.254f , -3.636f , 0f },
new List<float> { 11.714f , -3.636f , 0f },
new List<float> { 11.285f , -3.636f , 0f },
new List<float> { 11.46509f , -6.448999f , 180f },
new List<float> { 11.00509f , -6.448999f , 180f },
new List<float> { 11.04205f , -5.91f , 0f },
new List<float> { 11.50205f , -5.91f , 0f },
new List<float> { 13.041f , 0.003999881f , 0f },
new List<float> { 14.051f , -0.4060004f , 180f },
new List<float> { 12.601f , -5.91f , 0f },
new List<float> { 12.04695f , -5.91f , 0f },
new List<float> { 14.041f , 0.02399986f , 0f },
new List<float> { 13.581f , 0.01399963f , 0f },
new List<float> { 14.929f , 0.026f , 0f },
new List<float> { 14.939f , -0.4440001f , 180f },
new List<float> { 15.479f , -0.4340003f , 180f },
new List<float> { 15.469f , 0.036f , 0f },
new List<float> { 15.929f , 0.046f , 0f },
new List<float> { 15.939f , -0.4240006f , 180f },
new List<float> { 14.421f , 0.02399986f , 0f },
new List<float> { 14.431f , -0.4060004f , 180f },
new List<float> { 9.33f , 0.01f , 0f },
new List<float> { 10.165f , -3.975999f , 180f },
new List<float> { 9.905001f , -3.636f , 0f },
new List<float> { 10.445f , -3.636f , 0f },
new List<float> { 9.073002f , -3.975999f , 180f },
new List<float> { 9.625002f , -3.975999f , 180f },
new List<float> { 9.353001f , -3.636f , 0f },
new List<float> { 9.373f , -2.85f , 270f },
new List<float> { 8.919f , -2.859f , 90f },
new List<float> { 8.919f , -3.38f , 90f },
new List<float> { 9.373f , -3.277f , 270f },
new List<float> { 7.284f , -2.399f , 0f },
new List<float> { 7.853f , -2.39f , 0f },
new List<float> { 8.847f , -2.39f , 0f },
new List<float> { 6.986f , -2.612f , 180f },
new List<float> { 7.383f , -2.63f , 180f },
new List<float> { 7.888f , -2.63f , 180f },
new List<float> { 8.314f , -2.399f , 0f },
new List<float> { 8.43f , -2.621f , 180f },
new List<float> { -17.94f , -1.22f , 270f },
new List<float> { -17.94f , -1.56f , 270f },
new List<float> { -18.44f , -0.8399999f , 90f },
new List<float> { -18.44f , -0.8399999f , 90f },
new List<float> { -18.43f , -1.18f , 90f },
new List<float> { -18.44f , -1.65f , 90f },
new List<float> { -17.94f , -2.07f , 270f },
new List<float> { -18.45f , -2.07f , 90f },
new List<float> { -12.324f , -3.735f , 270f },
new List<float> { -12.824f , -3.825f , 90f },
new List<float> { -12.824f , -3.825f , 90f },
new List<float> { -12.324f , -3.735f , 270f },
new List<float> { -10.886f , -3.848f , 90f },
new List<float> { -10.332f , -3.843f , 270f },
new List<float> { -12.314f , -3.295f , 270f },
new List<float> { -12.833f , -3.275f , 90f },
new List<float> { -12.32f , -4.27f , 270f },
new List<float> { -12.809f , -4.284f , 90f },
new List<float> { -12.823f , -2.899f , 90f },
new List<float> { -12.32f , -2.892f , 270f },
new List<float> { -12.313f , -2.419f , 270f },
new List<float> { -13.543f , -2.471f , 180f },
new List<float> { -13.09f , -2.485f , 180f },
new List<float> { -12.853f , -2.501f , 180f },
new List<float> { -13.026f , -1.953f , 0f },
new List<float> { -13.485f , -1.946f , 0f },
new List<float> { -12.742f , -1.953f , 0f },
new List<float> { -11.353f , -0.14f , 180f },
new List<float> { -10.248f , 0.37f , 0f },
new List<float> { -10.248f , 0.37f , 0f },
new List<float> { -10.248f , 0.37f , 0f },
new List<float> { -16.09791f , -0.1199995f , 180f },
new List<float> { -16.63591f , -0.1199995f , 180f },
new List<float> { -17.94f , -0.75f , 270f },
new List<float> { -17.94f , -0.75f , 270f },
new List<float> { -17.18995f , -0.1199995f , 180f },
new List<float> { -17.757f , -0.089f , 180f },
new List<float> { -9.25f , 0.37f , 0f },
new List<float> { -9.71f , 0.37f , 0f },
new List<float> { -9.71f , 0.37f , 0f },
new List<float> { -9.25f , 0.37f , 0f },
new List<float> { -9.25f , 0.37f , 0f },
new List<float> { -9.71f , 0.37f , 0f },
new List<float> { -9.71f , 0.37f , 0f },
new List<float> { -9.25f , 0.37f , 0f },
new List<float> { -9.746953f , -0.1689996f , 180f },
new List<float> { -9.286953f , -0.1689996f , 180f },
new List<float> { -9.286953f , -0.1689996f , 180f },
new List<float> { -9.746953f , -0.1689996f , 180f },
new List<float> { -9.746953f , -0.1689996f , 180f },
new List<float> { -9.286953f , -0.1689996f , 180f },
new List<float> { -9.286953f , -0.1689996f , 180f },
new List<float> { -9.746953f , -0.1689996f , 180f },
new List<float> { -8.739141f , 0.3789994f , 0f },
new List<float> { -8.185094f , 0.3789995f , 0f },
new List<float> { -8.185094f , 0.3789995f , 0f },
new List<float> { -8.739141f , 0.3789994f , 0f },
new List<float> { -8.739141f , 0.3789994f , 0f },
new List<float> { -8.185094f , 0.3789995f , 0f },
new List<float> { -8.222047f , -0.1600001f , 180f },
new List<float> { -8.776093f , -0.1600001f , 180f },
new List<float> { -8.776093f , -0.1600001f , 180f },
new List<float> { -8.222047f , -0.1600001f , 180f },
new List<float> { -8.222047f , -0.1600001f , 180f },
new List<float> { -8.776093f , -0.1600001f , 180f },
new List<float> { -10.264f , 0.37f , 0f },
new List<float> { -9.71f , 0.37f , 0f },
new List<float> { -10.248f , 0.37f , 0f },
new List<float> { -9.746953f , -0.1689996f , 180f },
new List<float> { -9.286953f , -0.1689996f , 180f },
new List<float> { -9.25f , 0.37f , 0f },
new List<float> { -7.671f , -0.185f , 180f },
new List<float> { -7.133f , -0.185f , 180f },
new List<float> { -6.673f , -0.185f , 180f },
new List<float> { -9.71f , 0.37f , 0f },
new List<float> { -9.25f , 0.37f , 0f },
new List<float> { -9.286953f , -0.1689996f , 180f },
new List<float> { -9.746953f , -0.1689996f , 180f },
new List<float> { -7.634047f , 0.3539996f , 0f },
new List<float> { -7.634047f , 0.3539996f , 0f },
new List<float> { -6.636047f , 0.3539996f , 0f },
new List<float> { -7.096047f , 0.3539996f , 0f },
new List<float> { -7.096047f , 0.3539996f , 0f },
new List<float> { -6.636047f , 0.3539996f , 0f },
new List<float> { -5.608094f , -0.1760005f , 180f },
new List<float> { -5.571141f , 0.362999f , 0f },
new List<float> { -6.125187f , 0.3629989f , 0f },
new List<float> { -6.673f , -0.185f , 180f },
new List<float> { -7.133f , -0.185f , 180f },
new List<float> { -7.671f , -0.185f , 180f },
new List<float> { -6.16214f , -0.1760005f , 180f },



                    },
                   new List<List<float>>   //아이템 코드 (4)
                        {
new List<float> { -6.902484f , -5.119095f , 0f },
new List<float> { -16.83349f , -7.301387f , 0f },
new List<float> { -13.52974f , -7.083284f , 0f },
new List<float> { 5.408109f , 0.7728477f , 0f },
new List<float> { 19.46517f , -1.805566f , 0f },
new List<float> { 19.4f , -2.66f , 180f },
new List<float> { 14.46226f , 0.7782835f , 0f },
new List<float> { -14.257f , -4.607f , 270f },


                        },
                    new List<List<float>>   //아이템 코드 (5)
                    {

                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
new List<float> { 0.464f , 0.778f , 0f },
new List<float> { 9.598f , 0.66f , 0f },
new List<float> { 19.09f , -6.708f , 0f },
new List<float> { 16.425f , -2.856f , 0f },
new List<float> { 17.18f , -7.269f , 0f },
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {

                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {

                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {

new List<float> { -7.509337f , 6.271916f , 0f },
new List<float> { -5.185f , -3.725f , 90f },
new List<float> { -5.184867f , -2.311163f , 0f },
new List<float> { -5.085f , 3.715f , 0f },
new List<float> { -15.171f , 3.389f , 90f },
new List<float> { -14.601f , 3.359f , 180f },
new List<float> { -14.601f , 3.359f , 180f },
new List<float> { -15.14425f , 3.911539f , 0f },
new List<float> { -9.383387f , 4.08f , 180f },
new List<float> { -9.866054f , 2.055413f , 0f },
new List<float> { -18.42605f , 4.425413f , 0f },
new List<float> { -8.03f , -6.39f , 90f },
new List<float> { -10.33f , -6.46f , 180f },
new List<float> { -7.495f , 2.436f , 90f },
new List<float> { -7.002f , 2.438f , 180f },
new List<float> { -7.994172f , -2.221133f , 0f },
new List<float> { -14.99395f , -4.527999f , 180f },
new List<float> { -10.87f , -6.46f , 90f },
new List<float> { -1.241747f , 1.492461f , 180f },
new List<float> { -1.241746f , 1.492461f , 180f },
new List<float> { -1.785f , 2.045f , 0f },
new List<float> { -1.811746f , 1.522461f , 90f },
new List<float> { -11.943f , 4.627726f , 0f },
new List<float> { -11.948f , 4.086726f , 90f },
new List<float> { -11.94605f , 2.015413f , 0f },
new List<float> { -17.51f , 6.228f , 180f },
new List<float> { 7.928f , 2.578f , 90f },
new List<float> { 1.918387f , 1.486297f , 90f },
new List<float> { 2.488386f , 1.456297f , 180f },
new List<float> { 2.488387f , 1.456297f , 180f },
new List<float> { 1.945132f , 2.008836f , 0f },
new List<float> { 8.979555f , 0.03077149f , 0f },
new List<float> { 8.984f , -0.478f , 90f },
new List<float> { 6.527f , -0.368f , 180f },
new List<float> { 5.619f , -2.361999f , 0f },
new List<float> { 6.054922f , 3.550583f , 0f },
new List<float> { 4.095f , 3.245001f , 180f },
new List<float> { 4f , 5.94f , 180f },
new List<float> { 16.388f , -4.876f , 90f },
new List<float> { 14.09f , -6.45f , 180f },
new List<float> { 16.474f , -0.457f , 180f },
new List<float> { 8.875001f , -3.946f , 90f },
new List<float> { 6.031f , -3.739f , 180f },
new List<float> { -16.10711f , -1.927426f , 0f },
new List<float> { -16.058f , -2.44f , 90f },

                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
new List<float> { -4.615f , -2.354999f , 0f },
new List<float> { -17.90025f , 4.377612f , 0f },
new List<float> { -14.57439f , 3.867703f , 0f },
new List<float> { -9.340245f , 2.007612f , 0f },
new List<float> { -9.35599f , 4.628f , 0f },
new List<float> { -7.491762f , -2.248662f , 0f },
new List<float> { -14.96656f , -3.98f , 0f },
new List<float> { -1.215133f , 2.001165f , 0f },
new List<float> { -11.42025f , 1.967612f , 0f },
new List<float> { -17.43409f , 6.664748f , 0f },
new List<float> { 8.043913f , 2.682652f , 0f },
new List<float> { 2.515f , 1.965f , 0f },
new List<float> { 6.591507f , 3.51481f , 0f },
new List<float> { 4.17091f , 3.681748f , 0f },
new List<float> { 4.075911f , 6.376748f , 0f },
new List<float> { 16.705f , -3.606f , 0f },
new List<float> { 14.09f , -5.928702f , 0f },
new List<float> { 16.48203f , 0.011f , 0f },
new List<float> { 9.375f , -2.361f , 0f },
new List<float> { -12.29936f , -1.932945f , 0f },


                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
new List<float> { -19.20538f , 7.40519f , 0f },
new List<float> { 12.58117f , 0.7947462f , 0f },
new List<float> { 7.386f , -3.393f , 180f },
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
 new List<float> { 0.5159999f , -2.391999f , 0f },
new List<float> { -2.915f , -2.391999f , 0f },
new List<float> { -2.34f , -2.381999f , 0f },
new List<float> { -1.769f , -2.383f , 0f },
new List<float> { -1.197f , -2.385999f , 0f },
new List<float> { -0.6340001f , -2.388999f , 0f },
new List<float> { 1.085f , -2.388999f , 0f },
new List<float> { 1.66f , -2.388999f , 0f },
new List<float> { -3.479f , -2.388999f , 0f },
new List<float> { -4.054f , -2.394724f , 0f },
new List<float> { -0.05900012f , -2.385999f , 0f },
new List<float> { -17.34f , 2.901f , 0f },
new List<float> { -17.354f , 0.985f , 0f },
new List<float> { 3.391f , -2.400999f , 0f },
new List<float> { 3.956f , -2.397f , 0f },
new List<float> { 4.506f , -2.41f , 0f },
new List<float> { 2.243f , -2.394999f , 0f },
new List<float> { 2.816f , -2.394724f , 0f },
new List<float> { 5.085f , -2.394724f , 0f },

                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {


                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
 new List<float> { -20.16461f , -3.243812f , 0f },

                    },
            }
         },
        new List<List<List<List<float>>>> //별자리 5
        {
            new List<List<List<float>>>  //배열 스테이지 (1)
            {

               new List<List<float>>   //아이템 코드 (0)
                    {
new List<float> { -4.756769f , 0.6841141f , 0f },
new List<float> { -3.832823f , 0f , 180f },
new List<float> { -1.665161f , 1.437216f , 0f },
new List<float> { -11.33459f , -7.274414f , 0f },
new List<float> { -11.81873f , -7.274414f , 0f },
new List<float> { -10.35193f , -7.29f , 0f },
new List<float> { -10.85045f , -7.291109f , 0f },
new List<float> { -10.38f , 0.79f , 0f },
new List<float> { -10.82624f , 0.7744991f , 0f },
new List<float> { -3.345823f , 0f , 180f },
new List<float> { -2.839823f , 0f , 180f },
new List<float> { -7.960267f , 0.7673211f , 0f },
new List<float> { -6.899371f , 0.7673211f , 0f },
new List<float> { -8.79703f , -7.307803f , 0f },
new List<float> { -7.800888f , -7.307803f , 0f },
new List<float> { -8.312891f , -7.291109f , 0f },
new List<float> { -9.347948f , -7.307803f , 0f },
new List<float> { -9.848782f , -7.291109f , 0f },
new List<float> { 14.56f , -1.46f , 90f },
new List<float> { 1.805444f , 1.458705f , 0f },
new List<float> { 1.302203f , 1.437216f , 0f },
new List<float> { -1.18f , 1.458705f , 0f },
new List<float> { 0.8186817f , 1.458705f , 0f },
new List<float> { -9.914375f , 0.8001854f , 0f },
new List<float> { -9.000361f , 0.78f , 0f },
new List<float> { -9.464864f , 0.81f , 0f },
new List<float> { -7.429819f , 0.7569201f , 0f },
new List<float> { -8.49f , 0.77f , 0f },
new List<float> { 17.04f , -5.02f , 180f },
new List<float> { 17.79328f , -7.147311f , 0f },
new List<float> { 7.9f , -4.34f , 0f },
new List<float> { 16.82f , -1.44f , 270f },
new List<float> { 1.12536f , 3.456136f , 90f },
new List<float> { 0.3335209f , 1.437216f , 0f },
new List<float> { -2.148682f , 1.458705f , 0f },
new List<float> { -3.821917f , 4.589099f , 0f },
new List<float> { -4.99f , 3.84f , 90f },
new List<float> { -4.96f , 3.32f , 90f },
new List<float> { -4.328343f , 4.589099f , 0f },
new List<float> { 2.293443f , 4.205235f , 0f },
new List<float> { 1.787017f , 4.205235f , 0f },
new List<float> { 1.15536f , 2.936136f , 90f },
new List<float> { -6.777172f , -7.314212f , 0f },
new List<float> { -7.281935f , -7.31f , 0f },
new List<float> { -6.246724f , -7.324613f , 0f },
new List<float> { -0.15f , 1.458705f , 0f },
new List<float> { -0.6964791f , 1.437216f , 0f },
new List<float> { 19.69832f , 0.3814634f , 0f },
new List<float> { 18.55f , -6.5f , 90f },
new List<float> { 18.28083f , -7.147311f , 0f },
new List<float> { 13.34757f , -7.06605f , 0f },
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                       new List<float> { -6.036118f , 0.95f , 0f },
new List<float> { -5.085f , -2f , 0f },
new List<float> { -20.11185f , -5.762678f , 0f },
new List<float> { -8.769f , -4.077f , 0f },
new List<float> { -10.55708f , -2f , 0f },
new List<float> { -12.4464f , -1.972269f , 0f },
new List<float> { -13.73f , 0.15f , 0f },
new List<float> { 9.09f , -6.5f , 0f },
new List<float> { 3.608835f , -3.502015f , 0f },
new List<float> { -5.567373f , -4.219326f , 0f },
new List<float> { 6.774042f , -5.01f , 0f },
                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                       new List<float> { -0.55f , 4.08f , 0f },
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
        new List<float> { -2.77f , 0.7456906f , 0f },
new List<float> { -3.308281f , 0.7456906f , 0f },
new List<float> { -1.671696f , 0.7456906f , 0f },
new List<float> { 0.9565868f , 0.7456906f , 0f },
new List<float> { 0.3871069f , 0.7456906f , 0f },
new List<float> { -8.813144f , 0.0912599f , 0f },
new List<float> { -7.689842f , 0.0912599f , 0f },
new List<float> { -7.138593f , 0.0912599f , 0f },
new List<float> { 15.60328f , -0.9693273f , 359.2929f },
new List<float> { -2.217765f , 0.7456906f , 0f },
new List<float> { -9.861876f , 0.0912599f , 0f },
new List<float> { -10.37947f , 0.0912599f , 0f },
new List<float> { -9.344282f , 0.0912599f , 0f },
new List<float> { 13.89927f , -3.881887f , 179.2929f },
new List<float> { 17.46927f , -4.301887f , 179.2929f },
new List<float> { 17.32f , -3.77f , 359.2929f },
new List<float> { 17.32f , -3.77f , 359.2929f },
new List<float> { 13.75f , -3.35f , 359.2929f },
new List<float> { 17.46927f , -4.301887f , 179.2929f },
new List<float> { 15.75255f , -1.501214f , 179.2929f },
new List<float> { 1.81536f , 2.997602f , 90f },
new List<float> { -1.119461f , 0.7456906f , 0f },
new List<float> { -3.77f , 3.53729f , 270f },
new List<float> { -4.3f , 3.381467f , 90f },
new List<float> { 2.34536f , 3.153426f , 270f },
new List<float> { 1.472348f , 0.7456906f , 0f },
new List<float> { -8.251493f , 0.0912599f , 0f },
new List<float> { -0.62f , 0.7456906f , 0f },
new List<float> { -0.12f , 0.7456906f , 0f },
new List<float> { 19.77267f , -6.039351f , 270f },
new List<float> { 19.36314f , -0.8704237f , 179.2929f },
new List<float> { 19.24267f , -6.195175f , 90f },
new List<float> { 8.653137f , 1.609576f , 179.2929f },
new List<float> { 8.503868f , 2.141463f , 359.2929f },
new List<float> { 19.21387f , -0.3385366f , 359.2929f },
                    },
                   new List<List<float>>   //아이템 코드 (4)
                        {
                        new List<float> { -12.488f , -1.213f , 0f },
new List<float> { -13.04811f , 0.9543035f , 0f },
new List<float> { -5.600762f , -3.451382f , 0f },
new List<float> { 13.48155f , -2.577339f , 0f },
new List<float> { -3.16f , -7.11f , 0f },
new List<float> { 19.78f , -4.94f , 0f },
new List<float> { 18.90771f , 0.4049f , 0f },
                        },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                       new List<float> { -3.619f , -1.214033f , 0f },
new List<float> { -18.41145f , -7.090771f , 0f },
new List<float> { -2.925f , -1.214033f , 0f },
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { -16.66f , -6.78f , 0f },
new List<float> { -15.29f , -6.77f , 0f },
new List<float> { -15.97f , -6.78f , 0f },
new List<float> { 17.49f , -0.57f , 0f },
new List<float> { 12.57f , -6.427065f , 0f },
new List<float> { -0.62f , 2.28f , 0f },
new List<float> { -1.91f , 1.76f , 0f },
new List<float> { 13.03f , 1.73f , 0f },
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                       new List<float> { -2.839468f , -2f , 0f },
new List<float> { -3.39887f , -2f , 0f },
new List<float> { -3.950281f , -2f , 0f },
new List<float> { -7.102f , -3f , 0f },
new List<float> { -4.999762f , -4.22f , 0f },
new List<float> { -1.23f , -2f , 0f },
new List<float> { -1.742f , -2f , 0f },
new List<float> { 0.4100001f , -2f , 0f },
new List<float> { 0.98f , -2f , 0f },
new List<float> { -9.349999f , -3f , 0f },
new List<float> { -9.874f , -3f , 0f },
new List<float> { -4.517674f , -2f , 0f },
new List<float> { -0.68f , -2f , 0f },
new List<float> { -8.225705f , -3f , 0f },
new List<float> { -8.202f , -4.077f , 0f },
new List<float> { -7.658311f , -3f , 0f },
new List<float> { -8.793098f , -3f , 0f },
new List<float> { 9.647979f , -6.5f , 0f },
new List<float> { 7.332021f , -5.01f , 0f },
new List<float> { 1.55f , -2f , 0f },
new List<float> { -0.1399999f , -2f , 0f },
new List<float> { -2.302f , -2f , 0f },
new List<float> { 4.166814f , -3.502015f , 0f },
                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                       new List<float> { -19.56f , -5.762678f , 0f },
new List<float> { -10f , -2f , 0f },
new List<float> { -11.88475f , -1.972269f , 0f },
new List<float> { -13.18f , 0.15f , 0f },
new List<float> { -4.45f , -4.219326f , 0f },
new List<float> { -6.535f , -3f , 0f },
new List<float> { -7.634f , -4.077f , 0f },
new List<float> { 7.89f , -5.01f , 0f },
new List<float> { 4.724793f , -3.502015f , 0f },
new List<float> { 2.08f , -2f , 0f },
new List<float> { 10.20596f , -6.5f , 0f },
new List<float> { -5.48f , 0.95f , 0f },
                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
new List<float> { -4.954388f , -0.002347988f , 0f },
new List<float> { -3.861505f , 0.7456906f , 0f },
new List<float> { 16.93672f , -4.310673f , 89.29298f },
new List<float> { -10.90043f , 0.0912599f , 0f },
new List<float> { 14.26265f , -3.901729f , 179.2929f },
new List<float> { 17.83265f , -4.321729f , 179.2929f },
new List<float> { 16.93672f , -4.310673f , 89.29298f },
new List<float> { 16.11592f , -1.521057f , 179.2929f },
new List<float> { 15.22f , -1.51f , 89.29298f },
new List<float> { 17.83265f , -4.321729f , 179.2929f },
new List<float> { 1.8f , 2.634014f , 90f },
new List<float> { -4.31536f , 3.017878f , 90f },
new List<float> { -4.31536f , 3.913864f , 0f },
new List<float> { 1.8f , 3.53f , 0f },
new List<float> { 19.22731f , -5.662777f , 0f },
new List<float> { 19.72652f , -0.8902658f , 179.2929f },
new List<float> { 18.83059f , -0.8792094f , 89.29298f },
new List<float> { 19.22731f , -6.558763f , 90f },
new List<float> { 8.12059f , 1.60079f , 89.29298f },
new List<float> { 9.016516f , 1.589734f , 179.2929f },
new List<float> { 13.36672f , -3.890673f , 89.29298f },
new List<float> { 15.61956f , -7.342713f , 0f },
new List<float> { 10.87966f , -7.338873f , 0f },
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
new List<float> { -6.618546f , 0.0912599f , 0f },
new List<float> { -4.42f , -0.002347988f , 0f },
new List<float> { 11.42f , -7.38f , 0f },
new List<float> { 14.26727f , -3.356396f , 359.2929f },
new List<float> { 16.15989f , -7.371921f , 0f },
new List<float> { 15.23941f , -0.9907907f , 89.29298f },
new List<float> { 13.38613f , -3.371463f , 89.29298f },
new List<float> { 16.95613f , -3.791463f , 89.29298f },
new List<float> { 16.95613f , -3.791463f , 89.29298f },
new List<float> { 16.12055f , -0.9757236f , 359.2929f },
new List<float> { -3.795948f , 3.900879f , 0f },
new List<float> { -3.77f , 3.02f , 270f },
new List<float> { 2.319412f , 3.517015f , 0f },
new List<float> { 2.34536f , 2.636136f , 270f },
new List<float> { 1.988107f , 0.7456906f , 0f },
new List<float> { 19.74672f , -5.675763f , 0f },
new List<float> { 17.83727f , -3.776396f , 359.2929f },
new List<float> { 17.83727f , -3.776396f , 359.2929f },
new List<float> { 19.73114f , -0.3449329f , 359.2929f },
new List<float> { 19.77267f , -6.556641f , 270f },
new List<float> { 9.021139f , 2.135067f , 359.2929f },
new List<float> { 8.14f , 2.12f , 89.29298f },
new List<float> { 18.85f , -0.36f , 89.29298f },
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                        new List<float> { 0.5062591f , -7.043858f , 0f },
new List<float> { -8.097841f , -3.293935f , 0f },
new List<float> { 7.204319f , -7.043859f , 0f },
new List<float> { 3.778226f , -7.089377f , 0f },
new List<float> { 1.94615f , -7.089377f , 0f },
new List<float> { 5.473578f , -7.116721f , 0f },
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                       new List<float> { -9.69f , 1.15f , 0f },
new List<float> { 11f , 1.68f , 0f },
new List<float> { 16.59864f , 1.746405f , 0f },
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
new List<float> { -17.75577f , -7.348883f , 0f },
new List<float> { 1.6f , -1.47f , 0f },
new List<float> { -4.79f , -1.482f , 0f },
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                       new List<float> { -1.2f , -1.39f , 0f },
new List<float> { -17.86f , -0.16f , 0f },
new List<float> { 14.9f , -6.65f , 0f },
new List<float> { 14.02f , -6.4f , 0f },
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
new List<float> { 8.200314f , 2.90573f , 0f },
                    },
            },
             new List<List<List<float>>>  //배열 스테이지 (2)
            {
                                new List<List<float>>   //아이템 코드 (0)
                    {
                    new List<float> { -17.19633f , -7.153249f , 0f },
                    new List<float> { -1.791f , -7.149f , 0f },
                    new List<float> { 0.73f , -7.157629f , 0f },
                    new List<float> { 0.25f , -7.157629f , 0f },
                    new List<float> { -0.2694514f , -7.157629f , 0f },
                    new List<float> { 1.245472f , -7.157629f , 0f },
                    new List<float> { 6.54f , -5.82f , 90f },
                    new List<float> { 6.54f , -6.23f , 90f },
                    new List<float> { 1.801407f , -7.157629f , 0f },
                    new List<float> { 2.357343f , -7.157629f , 0f },
                    new List<float> { 6.54f , -6.72f , 90f },
                    new List<float> { 6.54f , -7.3f , 90f },
                    new List<float> { 7.33f , -5.07f , 0f },
                    new List<float> { 7.76f , -5.07f , 0f },
                    new List<float> { 15.29f , -7.15f , 0f },
                    new List<float> { 15.8f , -7.15f , 0f },
                    new List<float> { 14.22861f , -7.146472f , 0f },
                    new List<float> { 14.77f , -7.14f , 0f },
                    new List<float> { 16.25f , -7.17f , 0f },
                    new List<float> { 16.76f , -7.19f , 0f },
                    new List<float> { 17.27f , -7.2f , 0f },
                    new List<float> { 17.74f , -7.2f , 0f },

                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
new List<float> { -7.705087f , -6.685085f , 0f },
new List<float> { 8.762659f , -5.105686f , 0f },
new List<float> { 15.20589f , -2.702415f , 0f },


                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                    new List<float> { -15.8f , -6.64f , 0f },

                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
new List<float> { 7.26f , -7.17f , 90f },
new List<float> { 7.28f , -7.51f , 90f },
new List<float> { 7.26f , -6.31f , 90f },
new List<float> { 7.824f , -6.3f , 270f },
new List<float> { 7.796f , -6.806f , 270f },
new List<float> { 7.807f , -7.323f , 270f },
new List<float> { 7.26f , -6.72f , 90f },
new List<float> { 7.26f , -6.72f , 90f },
new List<float> { 15.83f , -5.78f , 180f },
new List<float> { 17.224f , -4.981f , 180f },
new List<float> { 17.254f , -5.161f , 180f },
new List<float> { 17.254f , -5.441f , 180f },
new List<float> { 17.244f , -5.711f , 180f },
new List<float> { 15.836f , -5.688f , 270f },
new List<float> { 15.8f , -4.89f , 180f },
new List<float> { 15.831f , -5.197f , 270f },
new List<float> { 15.836f , -4.658f , 270f },
new List<float> { 15.77f , -5.218f , 180f },
new List<float> { 15.781f , -5.462f , 180f },
new List<float> { 15.65f , -5.47f , 180f },
new List<float> { 15.27f , -5.54f , 180f },
new List<float> { 15.27f , -5.26f , 180f },
new List<float> { 15.18f , -5.34f , 90f },
new List<float> { 15.25f , -4.94f , 180f },
new List<float> { 15.18f , -4.9f , 90f },
new List<float> { 15.18f , -5.69f , 90f },
new List<float> { 15.27f , -5.81f , 180f },
new List<float> { 15.83f , -5.78f , 180f },
new List<float> { 15.25586f , -3.091489f , 0f },
new List<float> { 15.18f , -3.675f , 90f },
new List<float> { 15.28f , -3.67f , 180f },
new List<float> { 15.18f , -3.675f , 90f },
new List<float> { 15.27f , -3.39f , 0f },
new List<float> { 15.28f , -3.4f , 180f },
new List<float> { 15.25f , -4.3f , 180f },
new List<float> { 15.18f , -4.51f , 90f },
new List<float> { 15.31f , -4f , 180f },
new List<float> { 15.18f , -4.14f , 90f },
new List<float> { 15.27f , -4.62f , 180f },
new List<float> { 15.76f , -3.38f , 0f },
new List<float> { 15.78f , -3.4f , 180f },
new List<float> { 15.77f , -3.68f , 180f },
new List<float> { 15.71f , -4.27f , 180f },
new List<float> { 15.79f , -4.27f , 180f },
new List<float> { 15.842f , -4.125f , 270f },
new List<float> { 15.79f , -3.11f , 0f },
new List<float> { 15.861f , -3.63f , 270f },
new List<float> { 15.78f , -4.57f , 180f },
new List<float> { 15.8f , -4f , 180f },
new List<float> { 19.296f , -5.628f , 270f },
new List<float> { 19.29f , -5.72f , 180f },
new List<float> { 19.29f , -5.72f , 180f },
new List<float> { 19.11f , -5.41f , 180f },
new List<float> { 19.241f , -5.402f , 180f },
new List<float> { 19.291f , -5.137f , 270f },
new List<float> { 19.23f , -5.158f , 180f },
new List<float> { 19.26f , -4.83f , 180f },
new List<float> { 18.64f , -5.63f , 90f },
new List<float> { 18.64f , -5.28f , 90f },
new List<float> { 18.64f , -4.84f , 90f },
new List<float> { 18.64f , -4.45f , 90f },
new List<float> { 19.296f , -4.598f , 270f },
new List<float> { 19.24f , -4.51f , 180f },
new List<float> { 19.25f , -4.21f , 180f },
new List<float> { 19.17f , -4.21f , 180f },
new List<float> { 18.71f , -4.24f , 180f },
new List<float> { 19.302f , -4.065f , 270f },
new List<float> { 18.64f , -4.08f , 90f },
new List<float> { 19.26f , -3.94f , 180f },
new List<float> { 18.77f , -3.94f , 180f },
new List<float> { 18.64f , -3.615f , 90f },
new List<float> { 18.64f , -3.615f , 90f },
new List<float> { 18.74f , -3.61f , 180f },
new List<float> { 19.321f , -3.57f , 270f },
new List<float> { 19.23f , -3.62f , 180f },
new List<float> { 19.24f , -3.34f , 180f },
new List<float> { 19.22f , -3.32f , 0f },
new List<float> { 17.274f , -3.451f , 0f },
new List<float> { 17.214f , -3.421f , 0f },
new List<float> { 17.224f , -3.531f , 180f },
new List<float> { 17.244f , -3.081f , 0f },
new List<float> { 17.254f , -3.381f , 180f },
new List<float> { 17.254f , -3.701f , 180f },
new List<float> { 17.254f , -3.981f , 180f },
new List<float> { 17.254f , -4.341f , 180f },
new List<float> { 17.254f , -4.641f , 180f },
new List<float> { 18.73f , -5.75f , 180f },
new List<float> { 18.73f , -5.48f , 180f },
new List<float> { 18.73f , -5.2f , 180f },
new List<float> { 18.71f , -4.88f , 180f },
new List<float> { 18.73f , -4.56f , 180f },
new List<float> { 18.73f , -3.33f , 0f },
new List<float> { 18.74f , -3.34f , 180f },
new List<float> { 17.72f , -5.72f , 0f },
new List<float> { 18.18f , -5.72f , 180f },

                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
new List<float> { -10.25352f , -7.154822f , 0f },
new List<float> { -18.22615f , -7.143731f , 0f },
new List<float> { 4.14f , -7.08f , 0f },
new List<float> { 19.9879f , -1.96f , 0f },


                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
new List<float> { -14.624f , -7.106194f , 0f },
new List<float> { -6.691f , -7.098f , 0f },


                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
new List<float> { 1.424953f , -6.036162f , 0f },
new List<float> { 12.13908f , -4.505233f , 0f },
new List<float> { 12.57096f , -4.019372f , 0f },
new List<float> { 13.09281f , -3.515517f , 0f },
new List<float> { 13.56f , -3.083641f , 0f },


                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
new List<float> { -7.135253f , -6.685085f , 0f },
new List<float> { -6.579318f , -6.685085f , 0f },
new List<float> { -6.065078f , -6.685085f , 0f },
new List<float> { -5.578635f , -6.685085f , 0f },
new List<float> { 9.337596f , -5.105686f , 0f },
new List<float> { 9.86f , -5.105686f , 0f },
new List<float> { 10.33f , -5.105686f , 0f },
new List<float> { 10.82f , -5.105686f , 0f },
new List<float> { 11.368f , -5.105686f , 0f },
new List<float> { 15.72331f , -2.702415f , 0f },
new List<float> { 19.47842f , -2.702415f , 0f },
new List<float> { 18.94826f , -2.702415f , 0f },
new List<float> { 17.4f , -2.702415f , 0f },


                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
new List<float> { -5.008801f , -6.685085f , 0f },
new List<float> { 11.924f , -5.105686f , 0f },
new List<float> { 20.01788f , -2.702415f , 0f },


                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
new List<float> { -10.78963f , -6.234106f , 0f },
new List<float> { 7.276713f , -5.763951f , 0f },
new List<float> { 15.18033f , -3.208134f , 0f },
new List<float> { 18.64033f , -3.148134f , 0f },


                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
new List<float> { -9.78f , -6.234106f , 0f },
new List<float> { 7.806216f , -5.778262f , 0f },
new List<float> { 15.85598f , -3.123928f , 0f },
new List<float> { 19.31598f , -3.063928f , 0f },

                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
new List<float> { -14.07503f , -7.106195f , 0f },
new List<float> { -3.785743f , -7.102036f , 0f },
new List<float> { 9.15f , -7.089f , 0f },
new List<float> { 11.83f , -7.12f , 0f },
new List<float> { 19.48496f , -7.17319f , 0f },

                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
new List<float> { -10.31179f , -6.234106f , 0f },
new List<float> { 1.37f , -6.72f , 0f },
new List<float> { 0.87f , -6.72f , 0f },
new List<float> { 1.88f , -6.72f , 0f },
new List<float> { 0.2864838f , -6.72f , 0f },
new List<float> { -0.25f , -6.72f , 0f },
new List<float> { 2.36f , -6.72f , 0f },
new List<float> { 16.29661f , -2.702415f , 0f },
new List<float> { 16.83104f , -2.702415f , 0f },
new List<float> { 18.40947f , -2.702415f , 0f },
new List<float> { 17.86261f , -2.702415f , 0f },


                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
new List<float> { -5.023f , -6.134f , 0f },


                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
new List<float> { -11.46349f , -7.161092f , 0f },
new List<float> { 10.71f, -4.500163f , 0f },
new List<float> { 17.83776f , -2.066401f , 0f },


                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 17.94f , -3.24f , 0f },

                    },
            },
            new List<List<List<float>>>  //배열 스테이지 (3)
            {
                new List<List<float>>   //아이템 코드 (0)
                    {
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                        new List<float> { -15.7f, -6f, 0f }, //X, Y좌표
                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                        new List<float> { -5.9f, -7.16f, 0f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -0.85f, -7.16f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                        new List<float> { -17.5f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { -7.36f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 8.46f, -7.16f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { 10.41f, -7.25f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                        new List<float> { -15.13f, -6f, 0f }, //X, Y좌표
                        new List<float> { -14.56f, -6f, 0f }, //X, Y좌표
                        new List<float> { -14.03f, -6f, 0f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                        new List<float> { -13.5f, -6f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                        new List<float> { -10.4f, -7.16f, 0f }, //X, Y좌표
                        new List<float> { 5.16f, -7.16f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                        new List<float> { 3.3f, -6.73f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                        new List<float> { -14.21f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { -3.88f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { 1.4f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { 11.54f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { 14.6f, -7.2f, 0f }, //X, Y좌표
                        new List<float> { 17.7f, -7.2f, 0f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 19.73f, -7.1f, 0f }, //X, Y좌표
                    },
            }
        }
    };
    //첫번째 배열 별자리, 두번째 배열 스테이지
    //세번째 배열 0 가시, 1 왼잔디, 2 별자리 파편, 3 돌, 4 빨간 버섯, 5 잎, 6 박스, 7 중간잔디, 8오잔디, 9왼돌 10오돌, 11 썩은 버섯, 12 흙, 13 잘린 나무, 14 몬스터, 15도착지점  //네번째 배열은 좌표를 담습니다 으으살려주세요
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 15; i++)
        {
            for (int j = 0; j < mapData[MenuManager.starSet - 1][MenuManager.starNum - 1][i].Count; j++)
            {
                if (i == 2 && MenuManager.fragNum[MenuManager.starSet - 1, MenuManager.starNum - 1] == 1) break;
                transform.position = new Vector2(mapData[MenuManager.starSet - 1][MenuManager.starNum - 1][i][j][0], mapData[MenuManager.starSet - 1][MenuManager.starNum - 1][i][j][1]);
                Instantiate(gameObj[i], transform.position, Quaternion.Euler(0, 0, mapData[MenuManager.starSet - 1][MenuManager.starNum - 1][i][j][2]));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
