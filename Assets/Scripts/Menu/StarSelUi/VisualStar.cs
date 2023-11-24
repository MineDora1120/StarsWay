using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualStar : MonoBehaviour
{
    [SerializeField] int isType;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        MenuManager.starNum = isType;
    }
}
