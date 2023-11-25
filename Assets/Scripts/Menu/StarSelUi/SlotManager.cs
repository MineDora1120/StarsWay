using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : MonoBehaviour
{
    [SerializeField] GameObject pendantSlot, pendantsSelObj;
    private SpriteRenderer spr;
    [SerializeField] Sprite[] pendantsSprites;
    [SerializeField] GameObject[] pendants;
    static public bool clickPendantSlot;
    private float tmp, originX;
    // Start is called before the first frame update
    void Start()
    {
        clickPendantSlot = false;
        spr = pendantsSelObj.GetComponent<SpriteRenderer>();
        for(int i = 0; i  < 5; i++)
        {
            pendants[i].SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        spr.sprite = pendantsSprites[MenuManager.pendants];
        pendantSlot.SetActive(clickPendantSlot);
        if(clickPendantSlot)
        {
            originX = -6.4f;
            
            for(int j = 0; j < 5; j++)
            {
                tmp = 0;
                for (int i = 0; i < 3; i++)
                {
                    tmp += MenuManager.fragNum[j, i];
                }
                if (tmp >= 3)
                {
                    originX += 1f;
                    pendants[j].transform.position = new Vector3(originX, pendants[j].transform.position.y, 0);
                    pendants[j].SetActive(true);
                }
            }
        } else
        {
            for (int i = 0; i < 5; i++)
            {
                pendants[i].SetActive(false);
            }
        }
    }


    // Update is called once per frame
    void OnMouseDown()
    {
        if(clickPendantSlot) clickPendantSlot = false;
        else clickPendantSlot = true;
    }
}
