using System.Collections.Generic;
using UnityEngine;

public class MakeMap : MonoBehaviour
{
    public GameObject[] gameObj = new GameObject[16];
    List<List<List<List<List<float>>>>> mapData = new List<List<List<List<List<float>>>>>
    {
        new List<List<List<List<float>>>> //���ڸ� 1
        {
            new List<List<List<float>>>  //�迭 �������� (1)
            {
                new List<List<float>>   //������ �ڵ� (0)
                    {
                        new List<float> { -17.98f, -7.16f, 0f }, //X, Y��ǥ [1][1][0][0][0, 1]
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
                 new List<List<float>>   //������ �ڵ� (1)
                    {
                        new List<float> { -15.07f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -0.75f, -6.59f, 0f },
                    },
                 new List<List<float>>   //������ �ڵ� (2)
                    {
                        new List<float> { -14.28f, -5.5f, 0f }, //X, Y��ǥ
                    },
                  new List<List<float>>   //������ �ڵ� (3)
                    {
                        new List<float> { -5.18f, -6.66f, 0f }, //X, Y��ǥ
                        new List<float> { 6.12f, -6.72f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (4)
                    {
                        new List<float> { -15.95f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { -12.75f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { -8.83f, -5.5f, 0f }, //X, Y��ǥ
                        new List<float> { 3.81f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 6.16f, -5.97f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (5)
                    {
                    },
                   new List<List<float>>   //������ �ڵ� (6)
                    {
                        new List<float> { -2.33f, -7.2f, 0f }, //X, Y��ǥ
                        new List<float> { -2f, -6.8f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (7)
                    {
                        new List<float> { -14.53f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -14f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -0.2f, -6.59f, 0f }, //X, Y��ǥ
                        new List<float> { 0.32f, -6.59f, 0f }, //X, Y��ǥ
                        new List<float> { 0.81f, -6.59f, 0f }, //X, Y��ǥ
                        new List<float> { 1.34f, -6.59f, 0f }, //X, Y��ǥ
                        new List<float> { 1.83f, -6.59f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (8)
                    {
                        new List<float> { -13.45f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { 2.35f, -6.59f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (9)
                    {
                        new List<float> { -5.79f, -6.65f, 0f }, //X, Y��ǥ
                        new List<float> { 5.6f, -6.72f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (10)
                    {
                        new List<float> { -4.63f, -6.65f, 0f }, //X, Y��ǥ
                        new List<float> { 6.67f, -6.72f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (11)
                    {
                        new List<float> { -7.48f, -7.09f, 0f }, //X, Y��ǥ
                        new List<float> { 0.7f, -7.09f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (12)
                    {
                        new List<float> { -11.5f, -6.30f, 0f }, //X, Y��ǥ
                        new List<float> { -10.96f, -6.30f, 0f }, //X, Y��ǥ
                        new List<float> { -10.42f, -6.30f, 0f }, //X, Y��ǥ
                        new List<float> { -9.88f, -6.30f, 0f }, //X, Y��ǥ
                        new List<float> { -9.4f, -6.30f, 0f }, //X, Y��ǥ
                        new List<float> { -8.85f, -6.30f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (13)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (14)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (15)
                    {
                        new List<float> { 18.62f, -7.1f, 0f }, //X, Y��ǥ
                    },
            },
             new List<List<List<float>>>  //�迭 �������� (2)
            {
                new List<List<float>>   //������ �ڵ� (0)
                    {
                        new List<float> { -17.92f, -7.16f, 0f },
                        new List<float> { -0.9f, -6f, 0f },//X, Y��ǥ [1][1][0][0][0, 1]
                        new List<float> { 14.67f, -7.16f, 0f },
                        new List<float> { 15.19f, -7.16f, 0f },
                        new List<float> { 15.74f, -7.16f, 0f },
                        new List<float> { 16.3f, -7.16f, 0f },
                        new List<float> { 16.8f, -7.16f, 0f },
                        new List<float> { 17.32f, -7.16f, 0f },
                        new List<float> { 17.87f, -7.16f, 0f },
                    },
                 new List<List<float>>   //������ �ڵ� (1)
                    {
                        new List<float> { 6.2f, -6.25f, 0f }, //X, Y��ǥ
                    },
                 new List<List<float>>   //������ �ڵ� (2)
                    {
                        new List<float> { -11.44f, -6f, 0f }, //X, Y��ǥ
                    },
                  new List<List<float>>   //������ �ڵ� (3)
                    {
                        new List<float> { -4f, -6.6f, 0f }, //X, Y��ǥ
                        new List<float> { -3.45f, -6.6f, 0f }, //X, Y��ǥ
                        new List<float> { -2.9f, -6.6f, 0f }, //X, Y��ǥ
                        new List<float> { -2.35f, -6.6f, 0f }, //X, Y��ǥ
                        new List<float> { -1.26f, -6.6f, 0f }, //X, Y��ǥ
                        new List<float> { -1.81f, -6.6f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (4)
                    {
                        new List<float> { -5.67f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 0.7f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 2.34f, -5.76f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (5)
                    {
                        new List<float> { -15f, -7.1f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (6)
                    {
                        new List<float> { 2.33f, -6.36f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (7)
                    {
                        new List<float> { 6.74f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { 7.24f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { 7.8f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { 8.3f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { 8.87f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { 9.38f, -6.25f ,0f}, //X, Y��ǥ
                        new List<float> { 9.91f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { 10.4f, -6.25f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (8)
                    {
                        new List<float> { 11f, -6.25f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (9)
                    {
                        new List<float> { -4.52f, -6.6f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (10)
                    {
                        new List<float> { -0.74f, -6.65f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (11)
                    {
                        new List<float> { -8f, -7.09f, 0f }, //X, Y��ǥ
                        new List<float> { -3f, -7.09f, 0f }, //X, Y��ǥ
                        new List<float> { 7.29f, -7.09f, 0f }, //X, Y��ǥ
                        new List<float> { 9.7f, -7.09f, 0f }, //X, Y��ǥ
                        new List<float> { 12.76f, -7.09f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (12)
                    {
                        new List<float> { -11.42f, -6.6f, 0f }, //X, Y��ǥ
                        new List<float> { 17f, -6.4f, 0f }, //X, Y��ǥ
                        new List<float> { 17.58f, -6.4f, 0f }, //X, Y��ǥ
                        new List<float> { 18.11f, -6.4f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (13)
                    {
                        new List<float> { -3.9f, -6.1f, 0f }, //X, Y��ǥ
                        new List<float> { -2.48f, -6.1f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (14)
                    {
                        new List<float> { -12.52f, -7.1f, 0f }, //X, Y��ǥ
                        new List<float> { 8.8f, -5f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (15)
                    {
                        new List<float> { 19.34f, -7.1f, 0f }, //X, Y��ǥ
                    },
            },
            new List<List<List<float>>>  //�迭 �������� (3)
            {
                new List<List<float>>   //������ �ڵ� (0)
                    {
                    },
                 new List<List<float>>   //������ �ڵ� (1)
                    {
                        new List<float> { -15.7f, -6f, 0f }, //X, Y��ǥ
                    },
                 new List<List<float>>   //������ �ڵ� (2)
                    {
                        new List<float> { -5.9f, -7.16f, 0f }, //X, Y��ǥ
                    },
                  new List<List<float>>   //������ �ڵ� (3)
                    {
                    },
                   new List<List<float>>   //������ �ڵ� (4)
                    {
                        new List<float> { -0.85f, -7.16f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (5)
                    {
                        new List<float> { -17.5f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { -7.36f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 8.46f, -7.16f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (6)
                    {
                        new List<float> { 10.41f, -7.25f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (7)
                    {
                        new List<float> { -15.13f, -6f, 0f }, //X, Y��ǥ
                        new List<float> { -14.56f, -6f, 0f }, //X, Y��ǥ
                        new List<float> { -14.03f, -6f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (8)
                    {
                        new List<float> { -13.5f, -6f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (9)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (10)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (11)
                    {
                        new List<float> { -10.4f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 5.16f, -7.16f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (12)
                    {
                        new List<float> { 3.3f, -6.73f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (13)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (14)
                    {
                        new List<float> { -14.21f, -7.2f, 0f }, //X, Y��ǥ
                        new List<float> { -3.88f, -7.2f, 0f }, //X, Y��ǥ
                        new List<float> { 1.4f, -7.2f, 0f }, //X, Y��ǥ
                        new List<float> { 11.54f, -7.2f, 0f }, //X, Y��ǥ
                        new List<float> { 14.6f, -7.2f, 0f }, //X, Y��ǥ
                        new List<float> { 17.7f, -7.2f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (15)
                    {
                        new List<float> { 19.73f, -7.1f, 0f }, //X, Y��ǥ
                    },
            }
        },
        new List<List<List<List<float>>>> //���ڸ� 2
        {
            new List<List<List<float>>>  //�迭 �������� (1)
            {
                new List<List<float>>   //������ �ڵ� (0)
                    {
                        new List<float> { -18.92f, -7.16f, 0f }, //X, Y��ǥ [1][1][0][0][0, 1]
                        new List<float> { 5f, -7.16f, 0f },
                        new List<float> { 4.55f, -7.16f, 0f },
                    },
                 new List<List<float>>   //������ �ڵ� (1)
                    {
                        new List<float> { -5.72f, -6.25f, 0f }, //X, Y��ǥ
                    },
                 new List<List<float>>   //������ �ڵ� (2)
                    {
                        new List<float> { -8.65f, -5.4f, 0f }, //X, Y��ǥ
                    },
                  new List<List<float>>   //������ �ڵ� (3)
                    {
                        new List<float> { -10.13f, -6.3f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (4)
                    {
                        new List<float> { -13.72f, -6f, 0f }, //X, Y��ǥ
                        new List<float> { 1.62f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 6.58f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 7.21f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 7.81f, -7.16f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (5)
                    {
                        new List<float> { -5.46f, -7.1f, 0f }, //X, Y��ǥ
                        new List<float> { -3.04f, -7.1f, 0f }, //X, Y��ǥ
                        new List<float> { 0f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 11f, -7.16f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (6)
                    {
                        new List<float> { -11.4f, -7.26f, 0f }, //X, Y��ǥ
                        new List<float> { 15.8f, -7.26f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (7)
                    {
                        new List<float> { -5.16f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -4.65f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -4.1f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -3.53f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -3f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -2.44f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -1.93f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -1.38f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -0.82f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -0.27f, -6.25f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (8)
                    {
                        new List<float> { 0.27f, -6.25f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (9)
                    {
                        new List<float> { -10.68f, -6.25f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (10)
                    {
                        new List<float> { -9.58f, -6.3f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (11)
                    {
                        new List<float> { -10f, -6f, 0f }, //X, Y��ǥ
                        new List<float> { -5f, -5.5f, 0f }, //X, Y��ǥ
                        new List<float> { -2f, -5.5f, 0f }, //X, Y��ǥ
                        new List<float> { -0.67f, -5.5f, 0f }, //X, Y��ǥ
                        new List<float> { 10f, -6.8f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (12)
                    {
                        new List<float> { -18.92f, -6.7f, 0f }, //X, Y��ǥ
                        new List<float> { -13.76f, -6.7f, 0f }, //X, Y��ǥ
                        new List<float> { 4.28f, -6.7f, 0f }, //X, Y��ǥ
                        new List<float> { 4.78f, -6.7f, 0f }, //X, Y��ǥ
                        new List<float> { 5.3f, -6.7f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (13)
                    {
                        new List<float> { -18.91f, -6.2f, 0f }, //X, Y��ǥ
                        new List<float> { 9.96f, -7.33f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (14)
                    {
                        new List<float> { -16.43f, -7.2f, 0f }, //X, Y��ǥ
                        new List<float> { -4.44f, -7.2f, 0f }, //X, Y��ǥ
                        new List<float> { -1.4f, -7.2f, 0f }, //X, Y��ǥ
                        new List<float> { 7.33f, -5.6f, 0f }, //X, Y��ǥ
                        new List<float> { 14.74f, -7.28f, 0f }, //X, Y��ǥ
                        new List<float> { 16.74f, -7.23f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (15)
                    {
                        new List<float> { 18.62f, -7.1f, 0f }, //X, Y��ǥ
                    },
            },
             new List<List<List<float>>>  //�迭 �������� (2)
            {
                new List<List<float>>   //������ �ڵ� (0)
                    {
                    },
                 new List<List<float>>   //������ �ڵ� (1)
                    {
                    },
                 new List<List<float>>   //������ �ڵ� (2)
                    {
                     new List<float> { 13f, -6.1f, 0f }, //X, Y��ǥ
                    },
                  new List<List<float>>   //������ �ڵ� (3)
                    {
                    },
                   new List<List<float>>   //������ �ڵ� (4)
                    {
                        new List<float> { -6.10f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 13.37f, -7.16f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (5)
                    {
                        new List<float> { -19.16f, -7.16f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (6)
                    {
                        new List<float> { -18.83f, -7.2f, 0f }, //X, Y��ǥ
                        new List<float> { 0.8f, -7.2f, 0f }, //X, Y��ǥ
                        new List<float> { 3.6f, -7.27f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (7)
                    {
                    },
                   new List<List<float>>   //������ �ڵ� (8)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (9)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (10)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (11)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (12)
                    {
                        new List<float> { 15.21f, -6f, 0f }, //X, Y��ǥ
                        new List<float> { 15.77f, -6f, 0f }, //X, Y��ǥ
                        new List<float> { 16.32f, -6f, 0f }, //X, Y��ǥ
                        new List<float> { 16.87f, -6f, 0f }, //X, Y��ǥ
                        new List<float> { 17.41f, -6f, 0f }, //X, Y��ǥ
                        new List<float> { 17.93f, -6f, 0f }, //X, Y��ǥ
                        new List<float> { 18.49f, -6f, 0f }, //X, Y��ǥ
                        new List<float> { 14.78f, -6f, 0f }, //X, Y��ǥ
                        new List<float> { -8.1f, -6f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (13)
                    {
                        new List<float> { 8.85f, -7.3f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (14)
                    {
                         new List<float> { -18.08f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { -17.07f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { -16.08f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { -15.08f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { -14.08f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { -13.08f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { -12.08f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { -11.08f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { -9.08f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { -4.4f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { -2.4f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { 0.5f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { 5.33f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { 6.77f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { 8.10f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { 12.22f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { 10.2f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { 12.07f, -7.1f, 0f }, //X, Y��ǥ
                         new List<float> { 15.94f, -5f, 0f }, //X, Y��ǥ
                         new List<float> { 16.74f, -5f, 0f },
                         new List<float> { 17.94f, -5f, 0f },
                    },
                    new List<List<float>>   //������ �ڵ� (15)
                    {
                        new List<float> { 19.34f, -7.1f, 0f }, //X, Y��ǥ
                    },
            },
            new List<List<List<float>>>  //�迭 �������� (3)
            {
                new List<List<float>>   //������ �ڵ� (0)
                    {
                        new List<float> { -12.13f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { -17.01f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 4.14f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 4.65f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 5.18f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 5.77f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 6.28f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 6.86f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 7.38f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 7.9f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 8.43f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 8.92f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 9.45f, -7.16f, 0f }, //X, Y��ǥ
                    },
                 new List<List<float>>   //������ �ڵ� (1)
                    {
                        new List<float> { -14.6f, -6.5f, 0f }, //X, Y��ǥ
                    },
                 new List<List<float>>   //������ �ڵ� (2)
                    {
                        new List<float> { -16.16f, -7.32f, 0f }, //X, Y��ǥ
                    },
                  new List<List<float>>   //������ �ڵ� (3)
                    {
                    },
                   new List<List<float>>   //������ �ڵ� (4)
                    {
                        new List<float> { -17.70f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { -8.32f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 4.77f, -4.9f, 0f }, //X, Y��ǥ
                        new List<float> { 8.27f, -3.46f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (5)
                    {
                        new List<float> { -9.6f, -7.16f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (6)
                    {
                        new List<float> { -6.52f, -5.57f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (7)
                    {
                        new List<float> { -14.13f, -6.5f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (8)
                    {
                        new List<float> { -13.63f, -6.5f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (9)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (10)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (11)
                    {
                        new List<float> { -14.75f, -7.1f, 0f }, //X, Y��ǥ
                        new List<float> { -5.48f, -7.1f, 0f }, //X, Y��ǥ
                        new List<float> { -3f, -7.1f, 0f }, //X, Y��ǥ
                        new List<float> { -0.5f, -7.1f, 0f }, //X, Y��ǥ
                        new List<float> { 19.23f, -7.1f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (12)
                    {
                        new List<float> { -6.8f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -6.32f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -5.73f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -5.17f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -4.64f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -4.08f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -3.57f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -3.04f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -2.5f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -1.94f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -1.4f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -0.87f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { -0.31f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { 0.23f, -6.25f, 0f }, //X, Y��ǥ
                        new List<float> { 4.76f, -5.78f, 0f }, //X, Y��ǥ
                        new List<float> { 8.25f, -4.26f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (13)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (14)
                    {
                        new List<float> { -4.01f, -5.6f, 0f }, //X, Y��ǥ
                        new List<float> { -1.41f, -5.6f, 0f }, //X, Y��ǥ
                        new List<float> { 16.22f, -7.2f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (15)
                    {
                        new List<float> { 12.77f, -7.13f, 0f }, //X, Y��ǥ
                    },
            }
        },
        new List<List<List<List<float>>>> //���ڸ� 3
        {
            new List<List<List<float>>>  //�迭 �������� (1)
            {
                new List<List<float>>   //������ �ڵ� (0)
                    {
                        new List<float> { -9.62f, -7.16f, 0f }, //X, Y��ǥ [1][1][0][0][0, 1]
                        new List<float> { -7.56f, -7.16f, 0f },
                        new List<float> { 6.84f, -7.16f, 0f },
                        new List<float> { 15.38f, -7.16f, 0f },
                    },
                 new List<List<float>>   //������ �ڵ� (1)
                    {
                        new List<float> { -12.75f, -6.5f, 0f }, //X, Y��ǥ
                        new List<float> { -13.24f, -6.5f, 0f }, //X, Y��ǥ
                        new List<float> { 5.23f, -2.7f, 0f }, //X, Y��ǥ
                        new List<float> { 12.39f, -4.7f, 0f }, //X, Y��ǥ
                    },
                 new List<List<float>>   //������ �ڵ� (2)
                    {
                        new List<float> { -13.18f, -7.24f, 0f }, //X, Y��ǥ
                    },
                  new List<List<float>>   //������ �ڵ� (3)
                    {
                        new List<float> { -4.15f, -4.8f, 0f }, //X, Y��ǥ
                        new List<float> { 9.9f, -6.3f, 0f }, //X, Y��ǥ
                        new List<float> { 10.36f, -6.3f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (4)
                    {
                        new List<float> { -17.78f, -6.56f, 0f }, //X, Y��ǥ
                        new List<float> { -11.624f, -5.7f, 0f }, //X, Y��ǥ
                        new List<float> { -4f, -4.02f, 0f }, //X, Y��ǥ
                        new List<float> { 12.42f, -4f, 0f }, //X, Y��ǥ
                        new List<float> { 19.22f, -7.12f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (5)
                    {
                        new List<float> { -14.30f, -7.1f, 0f }, //X, Y��ǥ                  
                    },
                   new List<List<float>>   //������ �ڵ� (6)
                    {
                        new List<float> { -0.52f, -3.7f, 0f }, //X, Y��ǥ
                        new List<float> { 2.43f, -2.67f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (7)
                    {
                        new List<float> { -12.22f, -6.5f, 0f }, //X, Y��ǥ
                        new List<float> { -5.80f, -2.7f, 0f }, //X, Y��ǥ
                        new List<float> { -6.36f, -2.7f, 0f }, //X, Y��ǥ
                        new List<float> { -7f, -2.7f, 0f }, //X, Y��ǥ
                        new List<float> { 12.9f, -4.7f, 0f }, //X, Y��ǥ
                        new List<float> { 13.43f, -4.7f, 0f }, //X, Y��ǥ
                        new List<float> { 5.77f, -2.7f, 0f }, //X, Y��ǥ
                        new List<float> { 6.21f, -2.7f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (8)
                    {
                        new List<float> { -11.65f, -6.5f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (9)
                    {
                        new List<float> { -4.72f, -4.77f, 0f }, //X, Y��ǥ
                        new List<float> { 9.36f, -6.25f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (10)
                    {
                        new List<float> { -3.6f, -4.7f, 0f }, //X, Y��ǥ
                        new List<float> { 10.93f, -6.3f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (11)
                    {
                        new List<float> { -16.6f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { -8.56f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { -6.46f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 0.10f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 10f, -7.16f, 0f }, //X, Y��ǥ
                        new List<float> { 13.57f, -7.16f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (12)
                    {
                        new List<float> { -17.83f, -7.35f, 0f }, //X, Y��ǥ
                        new List<float> { -9.66f, -5.74f, 0f }, //X, Y��ǥ
                        new List<float> { -9.13f, -5.74f, 0f }, //X, Y��ǥ
                        new List<float> { -8.58f, -5.7f, 0f }, //X, Y��ǥ
                        new List<float> { -8.03f, -5.7f, 0f }, //X, Y��ǥ
                        new List<float> { -7.45f, -5.7f, 0f }, //X, Y��ǥ
                        new List<float> { -7f, -5.7f, 0f }, //X, Y��ǥ
                        new List<float> { -6.33f, -5.7f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (13)
                    {
                        new List<float> { -18.62f, -7.34f, 0f }, //X, Y��ǥ
                        new List<float> { -14.16f, -7.22f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (14)
                    {
                        new List<float> { -11.6f, -7.2f, 0f }, //X, Y��ǥ
                        new List<float> { -2.94f, -7.2f, 0f }, //X, Y��ǥ
                        new List<float> { 3.67f, -7.2f, 0f }, //X, Y��ǥ
                        new List<float> { 17.91f, -7.2f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (15)
                    {
                        new List<float> { 6.21f, -2f, 0f }, //X, Y��ǥ
                    },
            },
             new List<List<List<float>>>  //�迭 �������� (2)
            {
                new List<List<float>>   //������ �ڵ� (0)
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
                 new List<List<float>>   //������ �ڵ� (1)
                    {
                     new List<float> { -15.65727f , -6.610206f , 0f },
                    new List<float> { -1.75f , -5.252196f , 0f },

                    },
                 new List<List<float>>   //������ �ڵ� (2)
                    {
                     new List<float> { -12.88f , -7.14f , 0f },
                    },
                  new List<List<float>>   //������ �ڵ� (3)
                    {
                        new List<float> { -12.04728f , -6.065955f , 0f },
                        new List<float> { -12.48276f , -6.065955f , 0f },
                        new List<float> { 7.908933f , -5.328313f , 0f },
                        new List<float> { 8.457324f , -5.328313f , 0f },
                        new List<float> { 9.005787f , -5.328313f , 0f },
                    },
                   new List<List<float>>   //������ �ڵ� (4)
                    {
                        new List<float> { -7.92f , -7.11f , 0f },
                        new List<float> { 8.50472f , -7.057255f , 0f },
                        new List<float> { -1.71734f , -4.511337f , 0f },

                    },
                    new List<List<float>>   //������ �ڵ� (5)
                    {
                        new List<float> { -11.31757f , -7.10168f , 0f },
                        new List<float> { 15.35f , -7.08f , 0f },

                    },
                   new List<List<float>>   //������ �ڵ� (6)
                    {
                        new List<float> { 1.348552f , -6.100121f , 0f },
                        new List<float> { 12.03215f , -7.279532f , 0f },
                        new List<float> { 3.481184f , -7.278146f , 0f },
                        new List<float> { 16.56f , -7.238769f , 0f },

                    },
                   new List<List<float>>   //������ �ڵ� (7)
                    {
                       new List<float> { -15.13f , -6.610206f , 0f },
                        new List<float> { -0.69f , -5.252196f , 0f },
                        new List<float> { -0.2058401f , -5.252196f , 0f },
                        new List<float> { -1.18f , -5.252196f , 0f },

                    },
                   new List<List<float>>   //������ �ڵ� (8)
                    {
                       new List<float> { -14.63984f , -6.610206f , 0f },
                        new List<float> { 0.334985f , -5.252196f , 0f },

                    },
                    new List<List<float>>   //������ �ڵ� (9)
                    {
                        new List<float> { -13.02416f , -6.065955f , 0f },
                        new List<float> { 7.340231f , -5.328313f , 0f },

                    },
                    new List<List<float>>   //������ �ڵ� (10)
                    {
                        new List<float> { -11.50588f , -6.065955f , 0f },
                        new List<float> { 9.54f , -5.328313f , 0f },
                    },
                    new List<List<float>>   //������ �ڵ� (11)
                    {
                        new List<float> { -16.88456f , -7.148005f , 0f },
                        new List<float> { -12.20029f , -5.26f , 0f },
                        new List<float> { -1.95586f , -7.114934f , 0f },
                        new List<float> { 2.262537f , -7.095349f , 0f },
                    },
                    new List<List<float>>   //������ �ڵ� (12)
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
                    new List<List<float>>   //������ �ڵ� (13)
                    {
                        new List<float> { -14.63659f , -6.1f , 0f },
                        new List<float> { 1.391491f , -5.726494f , 0f },

                    },
                    new List<List<float>>   //������ �ڵ� (14)
                    {
                        new List<float> { -18.24974f , -7.341061f , 0f },
                        new List<float> { -9.9876f , -7.372381f , 0f },
                        new List<float> { 14.41238f , -6.965412f , 0f },

                    },
                    new List<List<float>>   //������ �ڵ� (15)
                    {
                        new List<float> { 18.33003f , -7.085908f , 0f },

                    },
            },
            new List<List<List<float>>>  //�迭 �������� (3)
            {
            new List<List<float>>   //������ �ڵ� (0)
                    {
                        new List<float> { -8.86256f, 1.438178f, 0f }, //X, Y��ǥ
                        new List<float> { -8.398781f, 1.44f, 0f }, //X, Y��ǥ
                    },
                 new List<List<float>>   //������ �ڵ� (1)
                    {

                    },
                 new List<List<float>>   //������ �ڵ� (2)
                    {
                        new List<float> { -18.19612f, -2.445975f, 0f }, //X, Y��ǥ
                    },
                  new List<List<float>>   //������ �ڵ� (3)
                    {
                    },
                   new List<List<float>>   //������ �ڵ� (4)
                        {
                        },
                    new List<List<float>>   //������ �ڵ� (5)
                    {
                        new List<float> { -17.90626f, -7.025797f, 0f }, //X, Y��ǥ
                        new List<float> { -14.89169f, -7.025797f, 0f }, //X, Y
                    },
                   new List<List<float>>   //������ �ڵ� (6)
                    {
                        new List<float> { -15.70331f, -6.504045f, 0f }, //X, Y��ǥ
                        new List<float> { -10.02201f, -6.562017f, 0f }, //X, Y��ǥ
                        new List<float> { -9.906064f, -2.967727f, 0f }, //X, Y��ǥ
                        new List<float> { -15.58736f, 0.8584535f, 0f }, //X, Y��ǥ
                        new List<float> { -7.181359f, 0.6845365f, 0f }, //X, Y��ǥ
                    },
                   new List<List<float>>   //������ �ڵ� (7)
                    {

                    },
                   new List<List<float>>   //������ �ڵ� (8)
                    {

                    },
                    new List<List<float>>   //������ �ڵ� (9)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (10)
                    {
                        new List<float> { -16.86276f, -6.562017f, 0f }, //X, Y��ǥ
                        new List<float> { -16.28303f, -6.562017f, 0f }, //X, Y��ǥ
                        new List<float> { -11.2974f, -6.562017f, 0f }, //X, Y��ǥ
                        new List<float> { -10.71768f, -6.562017f, 0f }, //X, Y��ǥ
                        new List<float> { -6.94947f, -6.677962f, 0f }, //X, Y��ǥ
                        new List<float> { -6.311773f, -6.735935f, 0f }, //X, Y��ǥ
                        new List<float> { -8.746615f, -4.24312f, 0f }, //X, Y��ǥ
                        new List<float> { -4.80449f, -5.866348f, 0f }, //X, Y��ǥ
                        new List<float> { -3.355179f, -4.359065f, 0f }, //X, Y��ǥ
                        new List<float> { -5.674076f, -3.721368f, 0f }, //X, Y��ǥ
                        new List<float> { -8.166891f, -4.24312f, 0f }, //X, Y��ǥ
                        new List<float> { -9.036477f,-3.141644f, 0f }, //X, Y��ǥ
                        new List<float> { -18.19612f, -3.083672f, 0f }, //X, Y��ǥ
                        new List<float> { -19.87732f, -1.576388f, 0f }, //X, Y��ǥ
                        new List<float> { -18.2541f, -0.4169399f, 0f }, //X, Y��ǥ
                        new List<float> { -16.39898f, 0.858453f, 0f }, //X, Y��ǥ
                        new List<float> { -8.86256f, 0.7425089f, 0f }, //X, Y��ǥ
                        new List<float> { -9.442285f, 0.8004813f, 0f }, //X, Y��ǥ
                        new List<float> { -10.02201f, 0.684536f, 0f }, //X, Y��ǥ
                        new List<float> { -8.398781f, 0.74f, 0f }, //X, Y��ǥ
                        new List<float> { -7.82f, 0.63f, 0f }, //X, Y��ǥ
                        new List<float> { -1.326143f, 0.3367019f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (11)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (12)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (13)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (14)
                    {
                        new List<float> { -15.99317f, -7.257687f, 0f }, //X, Y��ǥ
                        new List<float> { -13.50035f, -7.199714f, 0f }, //X, Y��ǥ
                        new List<float> { -11.47132f, -7.141742f, 0f }, //X, Y��ǥ
                    },
                    new List<List<float>>   //������ �ڵ� (15)
                    {
                        new List<float> { -1.384116f, 1.206288f, 0f }, //X, Y��ǥ
                    },
            }
         },
                new List<List<List<List<float>>>> //���ڸ� 4
        {
            new List<List<List<float>>>  //�迭 �������� (1)
            {
            new List<List<float>>   //������ �ڵ� (0)
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
                 new List<List<float>>   //������ �ڵ� (1)
                    {

                    },
                 new List<List<float>>   //������ �ڵ� (2)
                    {
        new List<float> { -10.55358f , 7.527061f , 0f }

                    },
                  new List<List<float>>   //������ �ڵ� (3)
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
                   new List<List<float>>   //������ �ڵ� (4)
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
                    new List<List<float>>   //������ �ڵ� (5)
                    {
        new List<float> { -17.63187f , -3.993119f , 0f },
        new List<float> { -11.43f , -7.08f , 0f },

                    },
                   new List<List<float>>   //������ �ڵ� (6)
                    {
        new List<float> { -17.72775f , -7.241319f , 0f },
        new List<float> { 2.45f , -7.26f , 0f },

                    },
                   new List<List<float>>   //������ �ڵ� (7)
                    {

                    },
                   new List<List<float>>   //������ �ڵ� (8)
                    {

                    },
                    new List<List<float>>   //������ �ڵ� (9)
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
                    new List<List<float>>   //������ �ڵ� (10)
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
                    new List<List<float>>   //������ �ڵ� (11)
                    {

                    },
                    new List<List<float>>   //������ �ڵ� (12)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (13)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (14)
                    {
        new List<float> { -11.51734f , -7.22305f , 0f },

                    },
                    new List<List<float>>   //������ �ڵ� (15)
                    {
        new List<float> { 12.817f , 7.722f , 0f },

                    },
            },
             new List<List<List<float>>>  //�迭 �������� (2)
            {
                new List<List<float>>   //������ �ڵ� (0)
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
                 new List<List<float>>   //������ �ڵ� (1)
                    {
new List<float> { -7.705087f , -6.685085f , 0f },
new List<float> { 8.762659f , -5.105686f , 0f },
new List<float> { 15.20589f , -2.702415f , 0f },


                    },
                 new List<List<float>>   //������ �ڵ� (2)
                    {
                    new List<float> { -15.8f , -6.64f , 0f },

                    },
                  new List<List<float>>   //������ �ڵ� (3)
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
                   new List<List<float>>   //������ �ڵ� (4)
                    {
new List<float> { -10.25352f , -7.154822f , 0f },
new List<float> { -18.22615f , -7.143731f , 0f },
new List<float> { 4.14f , -7.08f , 0f },
new List<float> { 19.9879f , -1.96f , 0f },


                    },
                    new List<List<float>>   //������ �ڵ� (5)
                    {
new List<float> { -14.624f , -7.106194f , 0f },
new List<float> { -6.691f , -7.098f , 0f },


                    },
                   new List<List<float>>   //������ �ڵ� (6)
                    {
new List<float> { 1.424953f , -6.036162f , 0f },
new List<float> { 12.13908f , -4.505233f , 0f },
new List<float> { 12.57096f , -4.019372f , 0f },
new List<float> { 13.09281f , -3.515517f , 0f },
new List<float> { 13.56f , -3.083641f , 0f },


                    },
                   new List<List<float>>   //������ �ڵ� (7)
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
                   new List<List<float>>   //������ �ڵ� (8)
                    {
new List<float> { -5.008801f , -6.685085f , 0f },
new List<float> { 11.924f , -5.105686f , 0f },
new List<float> { 20.01788f , -2.702415f , 0f },


                    },
                    new List<List<float>>   //������ �ڵ� (9)
                    {
new List<float> { -10.78963f , -6.234106f , 0f },
new List<float> { 7.276713f , -5.763951f , 0f },
new List<float> { 15.18033f , -3.208134f , 0f },
new List<float> { 18.64033f , -3.148134f , 0f },


                    },
                    new List<List<float>>   //������ �ڵ� (10)
                    {
new List<float> { -9.78f , -6.234106f , 0f },
new List<float> { 7.806216f , -5.778262f , 0f },
new List<float> { 15.85598f , -3.123928f , 0f },
new List<float> { 19.31598f , -3.063928f , 0f },

                    },
                    new List<List<float>>   //������ �ڵ� (11)
                    {
new List<float> { -14.07503f , -7.106195f , 0f },
new List<float> { -3.785743f , -7.102036f , 0f },
new List<float> { 9.15f , -7.089f , 0f },
new List<float> { 11.83f , -7.12f , 0f },
new List<float> { 19.48496f , -7.17319f , 0f },

                    },
                    new List<List<float>>   //������ �ڵ� (12)
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
                    new List<List<float>>   //������ �ڵ� (13)
                    {
new List<float> { -5.023f , -6.134f , 0f },


                    },
                    new List<List<float>>   //������ �ڵ� (14)
                    {
new List<float> { -11.46349f , -7.161092f , 0f },
new List<float> { 10.71f, -4.500163f , 0f },
new List<float> { 17.83776f , -2.066401f , 0f },


                    },
                    new List<List<float>>   //������ �ڵ� (15)
                    {
                        new List<float> { 17.94f , -3.24f , 0f },

                    },
            },
            new List<List<List<float>>>  //�迭 �������� (3)
            {
                new List<List<float>>   //������ �ڵ� (0)
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
                 new List<List<float>>   //������ �ڵ� (1)
                    {

                    },
                 new List<List<float>>   //������ �ڵ� (2)
                    {
new List<float> { -3.085f , 1.683f , 0f },

                    },
                  new List<List<float>>   //������ �ڵ� (3)
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
                   new List<List<float>>   //������ �ڵ� (4)
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
                    new List<List<float>>   //������ �ڵ� (5)
                    {

                    },
                   new List<List<float>>   //������ �ڵ� (6)
                    {
new List<float> { 0.464f , 0.778f , 0f },
new List<float> { 9.598f , 0.66f , 0f },
new List<float> { 19.09f , -6.708f , 0f },
new List<float> { 16.425f , -2.856f , 0f },
new List<float> { 17.18f , -7.269f , 0f },
                    },
                   new List<List<float>>   //������ �ڵ� (7)
                    {

                    },
                   new List<List<float>>   //������ �ڵ� (8)
                    {

                    },
                    new List<List<float>>   //������ �ڵ� (9)
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
                    new List<List<float>>   //������ �ڵ� (10)
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
                    new List<List<float>>   //������ �ڵ� (11)
                    {
new List<float> { -19.20538f , 7.40519f , 0f },
new List<float> { 12.58117f , 0.7947462f , 0f },
new List<float> { 7.386f , -3.393f , 180f },
                    },
                    new List<List<float>>   //������ �ڵ� (12)
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
                    new List<List<float>>   //������ �ڵ� (13)
                    {
                    },
                    new List<List<float>>   //������ �ڵ� (14)
                    {


                    },
                    new List<List<float>>   //������ �ڵ� (15)
                    {
 new List<float> { -20.16461f , -3.243812f , 0f },

                    },
            }
         }
    };
    //ù��° �迭 ���ڸ�, �ι�° �迭 ��������
    //����° �迭 0 ����, 1 ���ܵ�, 2 ���ڸ� ����, 3 ��, 4 ���� ����, 5 ��, 6 �ڽ�, 7 �߰��ܵ�, 8���ܵ�, 9�޵� 10����, 11 ���� ����, 12 ��, 13 �߸� ����, 14 ����, 15��������  //�׹�° �迭�� ��ǥ�� ����ϴ� ��������ּ���
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
