using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeMap : MonoBehaviour
{
    public GameObject[] gameObj = new GameObject[16];
    List<List<List<List<List<float>>>>> mapData = new List<List<List<List<List<float>>>>>
    {
        new List<List<List<List<float>>>> //º°ÀÚ¸® 1
        {
            new List<List<List<float>>>  //¹è¿­ ½ºÅ×ÀÌÁö (1)
            {
                new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (0)
                    {
                        new List<float> { -17.98f, -7.16f, 0f }, //X, YÁÂÇ¥ [1][1][0][0][0, 1]
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
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (1)
                    {
                        new List<float> { -15.07f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -0.75f, -6.59f, 0f },
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (2)
                    {
                        new List<float> { -14.28f, -5.5f, 0f }, //X, YÁÂÇ¥
                    },
                  new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (3)
                    {
                        new List<float> { -5.18f, -6.66f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 6.12f, -6.72f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (4)
                    {
                        new List<float> { -15.95f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -12.75f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -8.83f, -5.5f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 3.81f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 6.16f, -5.97f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (5)
                    {
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (6)
                    {
                        new List<float> { -2.33f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -2f, -6.8f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (7)
                    {
                        new List<float> { -14.53f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -14f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -0.2f, -6.59f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 0.32f, -6.59f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 0.81f, -6.59f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 1.34f, -6.59f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 1.83f, -6.59f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (8)
                    {
                        new List<float> { -13.45f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 2.35f, -6.59f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (9)
                    {
                        new List<float> { -5.79f, -6.65f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 5.6f, -6.72f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (10)
                    {
                        new List<float> { -4.63f, -6.65f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 6.67f, -6.72f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (11)
                    {
                        new List<float> { -7.48f, -7.09f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 0.7f, -7.09f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (12)
                    {
                        new List<float> { -11.5f, -6.30f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -10.96f, -6.30f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -10.42f, -6.30f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -9.88f, -6.30f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -9.4f, -6.30f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -8.85f, -6.30f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (13)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (14)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (15)
                    {
                        new List<float> { 18.62f, -7.1f, 0f }, //X, YÁÂÇ¥
                    },
            },
             new List<List<List<float>>>  //¹è¿­ ½ºÅ×ÀÌÁö (2)
            {
                new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (0)
                    {
                        new List<float> { -17.92f, -7.16f, 0f },
                        new List<float> { -0.9f, -6f, 0f },//X, YÁÂÇ¥ [1][1][0][0][0, 1]
                        new List<float> { 14.67f, -7.16f, 0f },
                        new List<float> { 15.19f, -7.16f, 0f },
                        new List<float> { 15.74f, -7.16f, 0f },
                        new List<float> { 16.3f, -7.16f, 0f },
                        new List<float> { 16.8f, -7.16f, 0f },
                        new List<float> { 17.32f, -7.16f, 0f },
                        new List<float> { 17.87f, -7.16f, 0f },
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (1)
                    {
                        new List<float> { 6.2f, -6.25f, 0f }, //X, YÁÂÇ¥
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (2)
                    {
                        new List<float> { -11.44f, -6f, 0f }, //X, YÁÂÇ¥
                    },
                  new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (3)
                    {
                        new List<float> { -4f, -6.6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -3.45f, -6.6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -2.9f, -6.6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -2.35f, -6.6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -1.26f, -6.6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -1.81f, -6.6f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (4)
                    {
                        new List<float> { -5.67f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 0.7f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 2.34f, -5.76f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (5)
                    {
                        new List<float> { -15f, -7.1f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (6)
                    {
                        new List<float> { 2.33f, -6.36f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (7)
                    {
                        new List<float> { 6.74f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 7.24f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 7.8f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 8.3f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 8.87f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 9.38f, -6.25f}, //X, YÁÂÇ¥
                        new List<float> { 9.91f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 10.4f, -6.25f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (8)
                    {
                        new List<float> { 11f, -6.25f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (9)
                    {
                        new List<float> { -4.52f, -6.6f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (10)
                    {
                        new List<float> { -0.74f, -6.65f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (11)
                    {
                        new List<float> { -8f, -7.09f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -3f, -7.09f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 7.29f, -7.09f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 9.7f, -7.09f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 12.76f, -7.09f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (12)
                    {
                        new List<float> { -11.42f, -6.6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 17f, -6.4f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 17.58f, -6.4f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 18.11f, -6.4f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (13)
                    {
                        new List<float> { -3.9f, -6.1f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -2.48f, -6.1f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (14)
                    {
                        new List<float> { -12.52f, -7.1f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 8.8f, -5f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (15)
                    {
                        new List<float> { 19.34f, -7.1f, 0f }, //X, YÁÂÇ¥
                    },
            },
            new List<List<List<float>>>  //¹è¿­ ½ºÅ×ÀÌÁö (3)
            {
                new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (0)
                    {
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (1)
                    {
                        new List<float> { -15.7f, -6f, 0f }, //X, YÁÂÇ¥
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (2)
                    {
                        new List<float> { -5.9f, -7.16f, 0f }, //X, YÁÂÇ¥
                    },
                  new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (3)
                    {
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (4)
                    {
                        new List<float> { -0.85f, -7.16f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (5)
                    {
                        new List<float> { -17.5f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -7.36f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 8.46f, -7.16f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (6)
                    {
                        new List<float> { 10.41f, -7.25f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (7)
                    {
                        new List<float> { -15.13f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -14.56f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -14.03f, -6f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (8)
                    {
                        new List<float> { -13.5f, -6f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (9)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (10)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (11)
                    {
                        new List<float> { -10.4f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 5.16f, -7.16f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (12)
                    {
                        new List<float> { 3.3f, -6.73f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (13)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (14)
                    {
                        new List<float> { -14.21f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -3.88f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 1.4f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 11.54f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 14.6f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 17.7f, -7.2f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (15)
                    {
                        new List<float> { 19.73f, -7.1f, 0f }, //X, YÁÂÇ¥
                    },
            }
        },
        new List<List<List<List<float>>>> //º°ÀÚ¸® 2
        {
            new List<List<List<float>>>  //¹è¿­ ½ºÅ×ÀÌÁö (1)
            {
                new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (0)
                    {
                        new List<float> { -18.92f, -7.16f, 0f }, //X, YÁÂÇ¥ [1][1][0][0][0, 1]
                        new List<float> { 5f, -7.16f, 0f },
                        new List<float> { 4.55f, -7.16f, 0f },
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (1)
                    {
                        new List<float> { -5.72f, -6.25f, 0f }, //X, YÁÂÇ¥
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (2)
                    {
                        new List<float> { -8.65f, -5.4f, 0f }, //X, YÁÂÇ¥
                    },
                  new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (3)
                    {
                        new List<float> { -10.13f, -6.3f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (4)
                    {
                        new List<float> { -13.72f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 1.62f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 6.58f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 7.21f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 7.81f, -7.16f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (5)
                    {
                        new List<float> { -5.46f, -7.1f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -3.04f, -7.1f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 0f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 11f, -7.16f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (6)
                    {
                        new List<float> { -11.4f, -7.26f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 15.8f, -7.26f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (7)
                    {
                        new List<float> { -5.16f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -4.65f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -4.1f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -3.53f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -3f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -2.44f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -1.93f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -1.38f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -0.82f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -0.27f, -6.25f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (8)
                    {
                        new List<float> { 0.27f, -6.25f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (9)
                    {
                        new List<float> { -10.68f, -6.25f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (10)
                    {
                        new List<float> { -9.58f, -6.3f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (11)
                    {
                        new List<float> { -10f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -5f, -5.5f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -2f, -5.5f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -0.67f, -5.5f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 10f, -6.8f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (12)
                    {
                        new List<float> { -18.92f, -6.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -13.76f, -6.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 4.28f, -6.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 4.78f, -6.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 5.3f, -6.7f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (13)
                    {
                        new List<float> { -18.91f, -6.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 9.96f, -7.33f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (14)
                    {
                        new List<float> { -16.43f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -4.44f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -1.4f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 7.33f, -5.6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 14.74f, -7.28f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 16.74f, -7.23f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (15)
                    {
                        new List<float> { 18.62f, -7.1f, 0f }, //X, YÁÂÇ¥
                    },
            },
             new List<List<List<float>>>  //¹è¿­ ½ºÅ×ÀÌÁö (2)
            {
                new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (0)
                    {
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (1)
                    {
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (2)
                    {
                     new List<float> { 13f, -6.1f, 0f }, //X, YÁÂÇ¥
                    },
                  new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (3)
                    {
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (4)
                    {
                        new List<float> { -6.10f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 13.37f, -7.16f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (5)
                    {
                        new List<float> { -19.16f, -7.16f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (6)
                    {
                        new List<float> { -18.83f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 0.8f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 3.6f, -7.27f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (7)
                    {
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (8)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (9)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (10)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (11)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (12)
                    {
                        new List<float> { 15.21f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 15.77f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 16.32f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 16.87f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 17.41f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 17.93f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 18.49f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 14.78f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -8.1f, -6f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (13)
                    {
                        new List<float> { 8.85f, -7.3f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (14)
                    {
                         new List<float> { -18.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -17.07f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -16.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -15.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -14.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -13.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -12.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -11.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -9.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -4.4f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -2.4f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 0.5f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 5.33f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 6.77f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 8.10f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 12.22f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 10.2f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 12.07f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 15.94f, -5f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 16.74f, -5f, 0f },
                         new List<float> { 17.94f, -5f, 0f },
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (15)
                    {
                        new List<float> { 19.34f, -7.1f, 0f }, //X, YÁÂÇ¥
                    },
            },
            new List<List<List<float>>>  //¹è¿­ ½ºÅ×ÀÌÁö (3)
            {
                new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (0)
                    {
                        new List<float> { -12.13f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -17.01f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 4.14f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 4.65f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 5.18f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 5.77f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 6.28f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 6.86f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 7.38f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 7.9f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 8.43f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 8.92f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 9.45f, -7.16f, 0f }, //X, YÁÂÇ¥
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (1)
                    {
                        new List<float> { -14.6f, -6.5f, 0f }, //X, YÁÂÇ¥
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (2)
                    {
                        new List<float> { -16.16f, -7.32f, 0f }, //X, YÁÂÇ¥
                    },
                  new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (3)
                    {
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (4)
                    {
                        new List<float> { -17.70f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -8.32f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 4.77f, -4.9f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 8.27f, -3.46f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (5)
                    {
                        new List<float> { -9.6f, -7.16f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (6)
                    {
                        new List<float> { -6.52f, -5.57f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (7)
                    {
                        new List<float> { -14.13f, -6.5f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (8)
                    {
                        new List<float> { -13.63f, -6.5f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (9)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (10)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (11)
                    {
                        new List<float> { -14.75f, -7.1f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -5.48f, -7.1f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -3f, -7.1f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -0.5f, -7.1f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 19.23f, -7.1f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (12)
                    {
                        new List<float> { -6.8f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -6.32f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -5.73f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -5.17f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -4.64f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -4.08f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -3.57f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -3.04f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -2.5f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -1.94f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -1.4f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -0.87f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -0.31f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 0.23f, -6.25f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 4.76f, -5.78f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 8.25f, -4.26f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (13)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (14)
                    {
                        new List<float> { -4.01f, -5.6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -1.41f, -5.6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 16.22f, -7.2f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (15)
                    {
                        new List<float> { 12.77f, -7.13f, 0f }, //X, YÁÂÇ¥
                    },
            }
        },
        new List<List<List<List<float>>>> //º°ÀÚ¸® 3
        {
            new List<List<List<float>>>  //¹è¿­ ½ºÅ×ÀÌÁö (1)
            {
                new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (0)
                    {
                        new List<float> { -9.62f, -7.16f, 0f }, //X, YÁÂÇ¥ [1][1][0][0][0, 1]
                        new List<float> { -7.56f, -7.16f, 0f },
                        new List<float> { 6.84f, -7.16f, 0f },
                        new List<float> { 15.38f, -7.16f, 0f },
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (1)
                    {
                        new List<float> { -12.75f, -6.5f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -13.24f, -6.5f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 5.23f, -2.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 12.39f, -4.7f, 0f }, //X, YÁÂÇ¥
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (2)
                    {
                        new List<float> { -13.18f, -7.24f, 0f }, //X, YÁÂÇ¥
                    },
                  new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (3)
                    {
                        new List<float> { -4.15f, -4.8f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 9.9f, -6.3f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 10.36f, -6.3f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (4)
                    {
                        new List<float> { -17.78f, -6.56f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -11.624f, -5.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -4f, -4.02f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 12.42f, -4f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 19.22f, -7.12f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (5)
                    {
                        new List<float> { -14.30f, -7.1f, 0f }, //X, YÁÂÇ¥                  
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (6)
                    {
                        new List<float> { -0.52f, -3.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 2.43f, -2.67f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (7)
                    {
                        new List<float> { -12.22f, -6.5f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -5.80f, -2.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -6.36f, -2.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -7f, -2.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 12.9f, -4.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 13.43f, -4.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 5.77f, -2.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 6.21f, -2.7f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (8)
                    {
                        new List<float> { -11.65f, -6.5f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (9)
                    {
                        new List<float> { -4.72f, -4.77f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 9.36f, -6.25f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (10)
                    {
                        new List<float> { -3.6f, -4.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 10.93f, -6.3f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (11)
                    {
                        new List<float> { -16.6f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -8.56f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -6.46f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 0.10f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 10f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 13.57f, -7.16f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (12)
                    {
                        new List<float> { -17.83f, -7.35f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -9.66f, -5.74f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -9.13f, -5.74f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -8.58f, -5.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -8.03f, -5.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -7.45f, -5.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -7f, -5.7f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -6.33f, -5.7f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (13)
                    {
                        new List<float> { -18.62f, -7.34f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -14.16f, -7.22f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (14)
                    {
                        new List<float> { -11.6f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -2.94f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 3.67f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 17.91f, -7.2f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (15)
                    {
                        new List<float> { 6.21f, -2f, 0f }, //X, YÁÂÇ¥
                    },
            },
             new List<List<List<float>>>  //¹è¿­ ½ºÅ×ÀÌÁö (2)
            {
                new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (0)
                    {
                        new List<float> { -16.22f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -13f, -6.8f, 180f }, //X, YÁÂÇ¥
                        new List<float> { -12.51f, -6.8f, 180f }, //X, YÁÂÇ¥
                        new List<float> { -12.05f, -6.8f, 180f }, //X, YÁÂÇ¥
                        new List<float> { -11.53f, -6.8f, 180f }, //X, YÁÂÇ¥
                        new List<float> { -13f, -6.8f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -6f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -5.7f, -5.4f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -3f, -6.8f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 7.48f, -4.65f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 8f, -4.66f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 8.5f, -4.64f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 9f, -6.6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 9.47f, -4.6f, 0f }, //X, YÁÂÇ¥
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (1)
                    {
                     new List<float> { -15.65f, -6.61f, 0f }, //X, YÁÂÇ¥
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (2)
                    {
                     new List<float> { 13f, -6.1f, 0f }, //X, YÁÂÇ¥
                    },
                  new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (3)
                    {
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (4)
                    {
                        new List<float> { -6.10f, -7.16f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 13.37f, -7.16f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (5)
                    {
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (6)
                    {
                        new List<float> { -18.83f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 0.8f, -7.2f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 3.6f, -7.27f, 0f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (7)
                    {
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (8)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (9)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (10)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (11)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (12)
                    {
                        new List<float> { 15.21f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 15.77f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 16.32f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 16.87f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 17.41f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 17.93f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 18.49f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 14.78f, -6f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -8.1f, -6f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (13)
                    {
                        new List<float> { 8.85f, -7.3f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (14)
                    {
                         new List<float> { -18.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -17.07f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -16.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -15.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -14.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -13.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -12.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -11.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -9.08f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -4.4f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { -2.4f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 0.5f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 5.33f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 6.77f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 8.10f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 12.22f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 10.2f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 12.07f, -7.1f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 15.94f, -5f, 0f }, //X, YÁÂÇ¥
                         new List<float> { 16.74f, -5f, 0f },
                         new List<float> { 17.94f, -5f, 0f },
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (15)
                    {
                        new List<float> { 19.34f, -7.1f, 0f }, //X, YÁÂÇ¥
                    },
            },
            new List<List<List<float>>>  //¹è¿­ ½ºÅ×ÀÌÁö (3)
            {
                new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (0)
                    {
                    new List<float> { -14.15f, -7.17f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -16.21f, 0.34f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -15.60f, 0.41f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -8.98f, 11.23f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -8.57f, 11.26f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -8.95f, -7.12f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -5.41f, -3.93f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -4.83f, -3.99f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -4.31f, -3.98f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -8.46f, -7.12f, 0f }, //X, YÁÂÇ¥ 
		            new List<float> { -7.92f, -7.14f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -7.39f, -7.13f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -6.86f, -7.12f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -13.56f, -7.18f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -5.5f, -2.33f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -4.91f, -2.32f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -4.34f, -2.35f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -0.75f, -4.01f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -0.274f, -4.03f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -1.45f, -4.77f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -1.43f, -5.19f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -0.3f, -7.165f, 0f }, //X, YÁÂÇ¥
		            new List<float> { 4.44f, -6.51f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -18.77f, -5.568f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -4.839f, -3.994f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -18.26f, -5.57f, 0f }, //X, YÁÂÇ¥
		            new List<float> { -17.78f, -5.57f, 0f }, //X, YÁÂÇ¥
		            new List<float> { 4.41f, -5.98f, 0f }, //X, YÁÂÇ¥
		            new List<float> { 4.37f, -5.45f, 0f }, //X, YÁÂÇ¥
		            new List<float> { 4.41f, -4.88f, 0f }, //X, YÁÂÇ¥
		            new List<float> { 1.59f, -2.454f, 0f }, //X, YÁÂÇ¥
		            new List<float> { 1.199f, -2.444f, 0f }, //X, YÁÂÇ¥
		            new List<float> { 7.23f, 0.33f, 0f }, //X, YÁÂÇ¥
		            new List<float> { 7.59f, 0.32f, 0f }, //X, YÁÂÇ¥
		            new List<float> { 6.188f, -7.13f, 0f }, //X, YÁÂÇ¥
                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (1)
                    {

                    },
                 new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (2)
                    {

                    },
                  new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (3)
                    {
                        new List<float> { -7.43f, -4.716f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -8.43f, -5.093f, 180f }, //X, YÁÂÇ¥
		                new List<float> { -7.93f, -5.103f, 180f }, //X, YÁÂÇ¥
		                new List<float> { -7.5f, -5.10f, 180f }, //X, YÁÂÇ¥
		                new List<float> { 3.52f, -2.789f, 180f }, //X, YÁÂÇ¥
		                new List<float> { 3.19f, -2.789f, 180f }, //X, YÁÂÇ¥
		                new List<float> { 1.76f, -6.25f, 180f }, //X, YÁÂÇ¥
		                new List<float> { 1.43f, -6.25f, 180f }, //X, YÁÂÇ¥
		                new List<float> { 7.171f, -3.115f, 90f }, //X, YÁÂÇ¥
		                new List<float> { 7.63f, -2.615f, -90f }, //X, YÁÂÇ¥
		                new List<float> { -18.86f, -3.954f, 90f }, //X, YÁÂÇ¥
		                new List<float> { -17.86f, -4.969f, 180f }, //X, YÁÂÇ¥
		                new List<float> { -13.966f, 1.114f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -15.02f, 0.132f, 90f }, //X, YÁÂÇ¥
		                new List<float> { -16.36f, -0.53f, 180f }, //X, YÁÂÇ¥
		                new List<float> { -16.86f, 0.623f, -90f }, //X, YÁÂÇ¥
		                new List<float> { -11.539f, 0.823f, 180f }, //X, YÁÂÇ¥
		                new List<float> { -10.99f, 0.839f, 180f }, //X, YÁÂÇ¥
		                new List<float> { -10.422f, 1.39f, -90f }, //X, YÁÂÇ¥
		                new List<float> { -11.52f, 1.157f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -10.414f, 1.945f, -90f }, //X, YÁÂÇ¥
		                new List<float> { -10.414f, 2.459f, -90f }, //X, YÁÂÇ¥
		                new List<float> { -10.414f, 3.01f, -90f }, //X, YÁÂÇ¥
		                new List<float> { -10.414f, 3.52f, -90f }, //X, YÁÂÇ¥
		                new List<float> { -10.414f, 4.075f, -90f }, //X, YÁÂÇ¥
		                new List<float> { -10.882f, 3.48f, 80f }, //X, YÁÂÇ¥
		                new List<float> { -9.21f, 6.82f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -8.56f, 8.93f, -90f }, //X, YÁÂÇ¥
		                new List<float> { -9.03f, 10.21f, 90f }, //X, YÁÂÇ¥
		                new List<float> { -13.104f, -1.796f, 90f }, //X, YÁÂÇ¥
		                new List<float> { 5.13f, -5.285f, 90f }, //X, YÁÂÇ¥
		                new List<float> { 1.165f, -4.869f, 90f }, //X, YÁÂÇ¥
		                new List<float> { 1.625f, -3.164f, -90f }, //X, YÁÂÇ¥
		                new List<float> { 3.42f, -1.083f, -90f }, //X, YÁÂÇ¥
		                new List<float> { 3.429f, -0.74f, -90f }, //X, YÁÂÇ¥
		                new List<float> { 3.429f, -0.484f, -90f }, //X, YÁÂÇ¥
		                new List<float> { 2.5f, -0.35f, 180f }, //X, YÁÂÇ¥
		                new List<float> { 2.05f, -0.34f, 180f }, //X, YÁÂÇ¥
		                new List<float> { 1.52f, -0.313f, 180f }, //X, YÁÂÇ¥
		                new List<float> { 1.01f, -0.33f, 180f }, //X, YÁÂÇ¥
		                new List<float> { 0.5f, -0.33f, 180f }, //X, YÁÂÇ¥
		                new List<float> { -0.033f, -0.313f, 180f }, //X, YÁÂÇ¥
		                new List<float> { 11.51f, -6.62f, -180f }, //X, YÁÂÇ¥
		                new List<float> { 12.01f, 6.62f, -180f }, //X, YÁÂÇ¥
                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (4)
                        {
        new List<float> { 4.01f, -1611f, 0f }, //X, YÁÂÇ¥
                        },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (5)
                    {

                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (6)
                    {

                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (7)
                    {

                    },
                   new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (8)
                    {

                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (9)
                    {
                        new List<float> { -9.02f, -5.073f, 90f }, //X, YÁÂÇ¥
		                new List<float> { 6.13f, -3.516f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -16.874f, -0.838f, 180f }, //X, YÁÂÇ¥
		                new List<float> { -9.02f, -6.79f, 90f }, //X, YÁÂÇ¥
		                new List<float> { 11.334f, 6.899f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (10)
                    {
                        new List<float> { -3.065f, -6.658f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -0.267f, -4.69f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -6.92f, -6.423f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -6.925f, -4.706f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -6.97f, -5.11f, -90f }, //X, YÁÂÇ¥
		                new List<float> { 2.185f, -6.06f, 0f }, //X, YÁÂÇ¥
		                new List<float> { 3.969f, -2.344f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -4.04f, -3.023f, 0f }, //X, YÁÂÇ¥
		                new List<float> { 7.63f, -3.908f, -90f }, //X, YÁÂÇ¥
		                new List<float> { 7.635f, -0.376f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -14.827f, -6.048f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -18.30f, -3.122f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -16.91f, 1.181f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -17.46f, -4.709f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -8.52f, 10.6f, 0f }, //X, YÁÂÇ¥
		                new List<float> { 5.59f, -4.79f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -6.97f, -6.83f, -90f }, //X, YÁÂÇ¥
		                new List<float> { 1.63f, -3.12f, 0f }, //X, YÁÂÇ¥
		                new List<float> { -12.58f, -0.98f, 0f }, //X, YÁÂÇ¥
		                new List<float> { 3.43f, 0f, 0f }, //X, YÁÂÇ¥
		                new List<float> { 12.95f, 6.92f, 0f }, //X, YÁÂÇ¥
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (11)
                    {
                        new List<float> { -14.75f, -7.1f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -5.48f, -7.1f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -3f, -7.1f, 0f }, //X, YÁÂÇ¥
                        new List<float> { -0.5f, -7.1f, 0f }, //X, YÁÂÇ¥
                        new List<float> { 19.23f, -7.1f, 0f }, //X, YÁÂÇ¥
		
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (12)
                    {

                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (13)
                    {
                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (14)
                    {

                    },
                    new List<List<float>>   //¾ÆÀÌÅÛ ÄÚµå (15)
                    {

                    }
            }
         }
    };
    //Ã¹¹øÂ° ¹è¿­ º°ÀÚ¸®, µÎ¹øÂ° ¹è¿­ ½ºÅ×ÀÌÁö
    //¼¼¹øÂ° ¹è¿­ 0 °¡½Ã, 1 ¿ŞÀÜµğ, 2 º°ÀÚ¸® ÆÄÆí, 3 µ¹, 4 »¡°£ ¹ö¼¸, 5 ÀÙ, 6 ¹Ú½º, 7 Áß°£ÀÜµğ, 8¿ÀÀÜµğ, 9¿Şµ¹ 10¿Àµ¹, 11 ½âÀº ¹ö¼¸, 12 Èë, 13 Àß¸° ³ª¹«, 14 ¸ó½ºÅÍ, 15µµÂøÁöÁ¡  //³×¹øÂ° ¹è¿­Àº ÁÂÇ¥¸¦ ´ã½À´Ï´Ù À¸À¸»ì·ÁÁÖ¼¼¿ä
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(MenuManager.starSet);
        Debug.Log(MenuManager.starNum);
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
