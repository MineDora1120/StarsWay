using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPendants : MonoBehaviour
{
    [SerializeField] int pendantNum;
    // Update is called once per frame
    void OnMouseDown()
    {
        if(MenuManager.pendants != pendantNum) MenuManager.pendants = pendantNum;
        else MenuManager.pendants = 0;
    }
}
