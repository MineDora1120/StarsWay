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
            },
             new List<List<List<float>>>  //배열 스테이지 (2)
            {
                new List<List<float>>   //아이템 코드 (0)
                    {
                        new List<float> { -17.92f, -7.16f },
                        new List<float> { -0.9f, -6f },//X, Y좌표 [1][1][0][0][0, 1]
                        new List<float> { 14.67f, -7.16f },
                        new List<float> { 15.19f, -7.16f },
                        new List<float> { 15.74f, -7.16f },
                        new List<float> { 16.3f, -7.16f },
                        new List<float> { 16.8f, -7.16f },
                        new List<float> { 17.32f, -7.16f },
                        new List<float> { 17.87f, -7.16f },
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                        new List<float> { 6.2f, -6.25f }, //X, Y좌표
                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                        new List<float> { -11.44f, -6f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                        new List<float> { -4f, -6.6f }, //X, Y좌표
                        new List<float> { -3.45f, -6.6f }, //X, Y좌표
                        new List<float> { -2.9f, -6.6f }, //X, Y좌표
                        new List<float> { -2.35f, -6.6f }, //X, Y좌표
                        new List<float> { -1.26f, -6.6f }, //X, Y좌표
                        new List<float> { -1.81f, -6.6f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -5.67f, -7.16f }, //X, Y좌표
                        new List<float> { 0.7f, -7.16f }, //X, Y좌표
                        new List<float> { 2.34f, -5.76f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                        new List<float> { -15f, -7.1f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { 2.33f, -6.36f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                        new List<float> { 6.74f, -6.25f }, //X, Y좌표
                        new List<float> { 7.24f, -6.25f }, //X, Y좌표
                        new List<float> { 7.8f, -6.25f }, //X, Y좌표
                        new List<float> { 8.3f, -6.25f }, //X, Y좌표
                        new List<float> { 8.87f, -6.25f }, //X, Y좌표
                        new List<float> { 9.38f, -6.25f}, //X, Y좌표
                        new List<float> { 9.91f, -6.25f }, //X, Y좌표
                        new List<float> { 10.4f, -6.25f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                        new List<float> { 11f, -6.25f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                        new List<float> { -4.52f, -6.6f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                        new List<float> { -0.74f, -6.65f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                        new List<float> { -8f, -7.09f }, //X, Y좌표
                        new List<float> { -3f, -7.09f }, //X, Y좌표
                        new List<float> { 7.29f, -7.09f }, //X, Y좌표
                        new List<float> { 9.7f, -7.09f }, //X, Y좌표
                        new List<float> { 12.76f, -7.09f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                        new List<float> { -11.42f, -6.6f }, //X, Y좌표
                        new List<float> { 17f, -6.4f }, //X, Y좌표
                        new List<float> { 17.58f, -6.4f }, //X, Y좌표
                        new List<float> { 18.11f, -6.4f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                        new List<float> { -3.9f, -6.1f }, //X, Y좌표
                        new List<float> { -2.48f, -6.1f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                        new List<float> { -12.52f, -7.1f }, //X, Y좌표
                        new List<float> { 8.8f, -5f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 19.34f, -7.1f }, //X, Y좌표
                    },
            },
            new List<List<List<float>>>  //배열 스테이지 (3)
            {
                new List<List<float>>   //아이템 코드 (0)
                    {
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                        new List<float> { -15.7f, -6f }, //X, Y좌표
                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                        new List<float> { -5.9f, -7.16f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -0.85f, -7.16f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                        new List<float> { -17.5f, -7.16f }, //X, Y좌표
                        new List<float> { -7.36f, -7.16f }, //X, Y좌표
                        new List<float> { 8.46f, -7.16f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { 10.41f, -7.25f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                        new List<float> { -15.13f, -6f }, //X, Y좌표
                        new List<float> { -14.56f, -6f }, //X, Y좌표
                        new List<float> { -14.03f, -6f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                        new List<float> { -13.5f, -6f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                        new List<float> { -10.4f, -7.16f }, //X, Y좌표
                        new List<float> { 5.16f, -7.16f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                        new List<float> { 3.3f, -6.73f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                        new List<float> { -14.21f, -7.2f }, //X, Y좌표
                        new List<float> { -3.88f, -7.2f }, //X, Y좌표
                        new List<float> { 1.4f, -7.2f }, //X, Y좌표
                        new List<float> { 11.54f, -7.2f }, //X, Y좌표
                        new List<float> { 14.6f, -7.2f }, //X, Y좌표
                        new List<float> { 17.7f, -7.2f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 19.73f, -7.1f }, //X, Y좌표
                    },
            }
        },
        new List<List<List<List<float>>>> //별자리 2
        {
            new List<List<List<float>>>  //배열 스테이지 (1)
            {
                new List<List<float>>   //아이템 코드 (0)
                    {
                        new List<float> { -18.92f, -7.16f }, //X, Y좌표 [1][1][0][0][0, 1]
                        new List<float> { 5f, -7.16f },
                        new List<float> { 4.55f, -7.16f },
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                        new List<float> { -5.72f, -6.25f }, //X, Y좌표
                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                        new List<float> { -8.65f, -5.4f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                        new List<float> { -10.13f, -6.3f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -13.72f, -6f }, //X, Y좌표
                        new List<float> { 1.62f, -7.16f }, //X, Y좌표
                        new List<float> { 6.58f, -7.16f }, //X, Y좌표
                        new List<float> { 7.21f, -7.16f }, //X, Y좌표
                        new List<float> { 7.81f, -7.16f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                        new List<float> { -5.46f, -7.1f }, //X, Y좌표
                        new List<float> { -3.04f, -7.1f }, //X, Y좌표
                        new List<float> { 0f, -7.16f }, //X, Y좌표
                        new List<float> { 11f, -7.16f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { -11.4f, -7.26f }, //X, Y좌표
                        new List<float> { 15.8f, -7.26f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                        new List<float> { -5.16f, -6.25f }, //X, Y좌표
                        new List<float> { -4.65f, -6.25f }, //X, Y좌표
                        new List<float> { -4.1f, -6.25f }, //X, Y좌표
                        new List<float> { -3.53f, -6.25f }, //X, Y좌표
                        new List<float> { -3f, -6.25f }, //X, Y좌표
                        new List<float> { -2.44f, -6.25f }, //X, Y좌표
                        new List<float> { -1.93f, -6.25f }, //X, Y좌표
                        new List<float> { -1.38f, -6.25f }, //X, Y좌표
                        new List<float> { -0.82f, -6.25f }, //X, Y좌표
                        new List<float> { -0.27f, -6.25f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                        new List<float> { 0.27f, -6.25f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                        new List<float> { -10.68f, -6.25f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                        new List<float> { -9.58f, -6.3f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                        new List<float> { -10f, -6f }, //X, Y좌표
                        new List<float> { -5f, -5.5f }, //X, Y좌표
                        new List<float> { -2f, -5.5f }, //X, Y좌표
                        new List<float> { -0.67f, -5.5f }, //X, Y좌표
                        new List<float> { 10f, -6.8f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                        new List<float> { -18.92f, -6.7f }, //X, Y좌표
                        new List<float> { -13.76f, -6.7f }, //X, Y좌표
                        new List<float> { 4.28f, -6.7f }, //X, Y좌표
                        new List<float> { 4.78f, -6.7f }, //X, Y좌표
                        new List<float> { 5.3f, -6.7f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                        new List<float> { -18.91f, -6.2f }, //X, Y좌표
                        new List<float> { 9.96f, -7.33f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                        new List<float> { -16.43f, -7.2f }, //X, Y좌표
                        new List<float> { -4.44f, -7.2f }, //X, Y좌표
                        new List<float> { -1.4f, -7.2f }, //X, Y좌표
                        new List<float> { 7.33f, -5.6f }, //X, Y좌표
                        new List<float> { 14.74f, -7.28f }, //X, Y좌표
                        new List<float> { 16.74f, -7.23f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 18.62f, -7.1f }, //X, Y좌표
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
                     new List<float> { 13f, -6.1f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -6.10f, -7.16f }, //X, Y좌표
                        new List<float> { 13.37f, -7.16f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { -18.83f, -7.2f }, //X, Y좌표
                        new List<float> { 0.8f, -7.2f }, //X, Y좌표
                        new List<float> { 3.6f, -7.27f }, //X, Y좌표
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
                        new List<float> { 15.21f, -6f }, //X, Y좌표
                        new List<float> { 15.77f, -6f }, //X, Y좌표
                        new List<float> { 16.32f, -6f }, //X, Y좌표
                        new List<float> { 16.87f, -6f }, //X, Y좌표
                        new List<float> { 17.41f, -6f }, //X, Y좌표
                        new List<float> { 17.93f, -6f }, //X, Y좌표
                        new List<float> { 18.49f, -6f }, //X, Y좌표
                        new List<float> { 14.78f, -6f }, //X, Y좌표
                        new List<float> { -8.1f, -6f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                        new List<float> { 8.85f, -7.3f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                         new List<float> { -18.08f, -7.1f }, //X, Y좌표
                         new List<float> { -17.07f, -7.1f }, //X, Y좌표
                         new List<float> { -16.08f, -7.1f }, //X, Y좌표
                         new List<float> { -15.08f, -7.1f }, //X, Y좌표
                         new List<float> { -14.08f, -7.1f }, //X, Y좌표
                         new List<float> { -13.08f, -7.1f }, //X, Y좌표
                         new List<float> { -12.08f, -7.1f }, //X, Y좌표
                         new List<float> { -11.08f, -7.1f }, //X, Y좌표
                         new List<float> { -9.08f, -7.1f }, //X, Y좌표
                         new List<float> { -4.4f, -7.1f }, //X, Y좌표
                         new List<float> { -2.4f, -7.1f }, //X, Y좌표
                         new List<float> { 0.5f, -7.1f }, //X, Y좌표
                         new List<float> { 5.33f, -7.1f }, //X, Y좌표
                         new List<float> { 6.77f, -7.1f }, //X, Y좌표
                         new List<float> { 8.10f, -7.1f }, //X, Y좌표
                         new List<float> { 12.22f, -7.1f }, //X, Y좌표
                         new List<float> { 10.2f, -7.1f }, //X, Y좌표
                         new List<float> { 12.07f, -7.1f }, //X, Y좌표
                         new List<float> { 15.94f, -5f }, //X, Y좌표
                         new List<float> { 16.74f, -5f },
                         new List<float> { 17.94f, -5f },
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 19.34f, -7.1f }, //X, Y좌표
                    },
            },
            new List<List<List<float>>>  //배열 스테이지 (3)
            {
                new List<List<float>>   //아이템 코드 (0)
                    {
                        new List<float> { -12.13f, -7.16f }, //X, Y좌표
                        new List<float> { -17.01f, -7.16f }, //X, Y좌표
                        new List<float> { 4.14f, -7.16f }, //X, Y좌표
                        new List<float> { 4.65f, -7.16f }, //X, Y좌표
                        new List<float> { 5.18f, -7.16f }, //X, Y좌표
                        new List<float> { 5.77f, -7.16f }, //X, Y좌표
                        new List<float> { 6.28f, -7.16f }, //X, Y좌표
                        new List<float> { 6.86f, -7.16f }, //X, Y좌표
                        new List<float> { 7.38f, -7.16f }, //X, Y좌표
                        new List<float> { 7.9f, -7.16f }, //X, Y좌표
                        new List<float> { 8.43f, -7.16f }, //X, Y좌표
                        new List<float> { 8.92f, -7.16f }, //X, Y좌표
                        new List<float> { 9.45f, -7.16f }, //X, Y좌표
                    },
                 new List<List<float>>   //아이템 코드 (1)
                    {
                        new List<float> { -14.6f, -6.5f }, //X, Y좌표
                    },
                 new List<List<float>>   //아이템 코드 (2)
                    {
                        new List<float> { -16.16f, -7.32f }, //X, Y좌표
                    },
                  new List<List<float>>   //아이템 코드 (3)
                    {
                    },
                   new List<List<float>>   //아이템 코드 (4)
                    {
                        new List<float> { -17.70f, -7.16f }, //X, Y좌표
                        new List<float> { -8.32f, -7.16f }, //X, Y좌표
                        new List<float> { 4.77f, -4.9f }, //X, Y좌표
                        new List<float> { 8.27f, -3.46f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (5)
                    {
                        new List<float> { -9.6f, -7.16f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (6)
                    {
                        new List<float> { -6.52f, -5.57f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (7)
                    {
                        new List<float> { -14.13f, -6.5f }, //X, Y좌표
                    },
                   new List<List<float>>   //아이템 코드 (8)
                    {
                        new List<float> { -13.63f, -6.5f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (9)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (10)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (11)
                    {
                        new List<float> { -14.75f, -7.1f }, //X, Y좌표
                        new List<float> { -5.48f, -7.1f }, //X, Y좌표
                        new List<float> { -3f, -7.1f }, //X, Y좌표
                        new List<float> { -0.5f, -7.1f }, //X, Y좌표
                        new List<float> { 19.23f, -7.1f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (12)
                    {
                        new List<float> { -6.8f, -6.25f }, //X, Y좌표
                        new List<float> { -6.32f, -6.25f }, //X, Y좌표
                        new List<float> { -5.73f, -6.25f }, //X, Y좌표
                        new List<float> { -5.17f, -6.25f }, //X, Y좌표
                        new List<float> { -4.64f, -6.25f }, //X, Y좌표
                        new List<float> { -4.08f, -6.25f }, //X, Y좌표
                        new List<float> { -3.57f, -6.25f }, //X, Y좌표
                        new List<float> { -3.04f, -6.25f }, //X, Y좌표
                        new List<float> { -2.5f, -6.25f }, //X, Y좌표
                        new List<float> { -1.94f, -6.25f }, //X, Y좌표
                        new List<float> { -1.4f, -6.25f }, //X, Y좌표
                        new List<float> { -0.87f, -6.25f }, //X, Y좌표
                        new List<float> { -0.31f, -6.25f }, //X, Y좌표
                        new List<float> { 0.23f, -6.25f }, //X, Y좌표
                        new List<float> { 4.76f, -5.78f }, //X, Y좌표
                        new List<float> { 8.25f, -4.26f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (13)
                    {
                    },
                    new List<List<float>>   //아이템 코드 (14)
                    {
                        new List<float> { -4.01f, -5.6f }, //X, Y좌표
                        new List<float> { -1.41f, -5.6f }, //X, Y좌표
                        new List<float> { 16.22f, -7.2f }, //X, Y좌표
                    },
                    new List<List<float>>   //아이템 코드 (15)
                    {
                        new List<float> { 12.77f, -7.13f }, //X, Y좌표
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
