using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public Text firstText, selectTextNotice, selectText, infoText;
    private string[] starName = new string[5] { "쌍둥이자리", "양자리", "천칭자리", "북두칠성", "카시오페아자리" };
    private string[,] starNote = new string[,] { { "가장 기본이 되는 행성.", "새로운 생명체가 존재하는 행성.", "대도시 같은 행성." }, { "신비로운 외계 블록을 활용하는 행성", "..? 지금 나를 공격하는건가?", "신기한게 많은 고대행성" }, { "오르막길이 있는 행성??", "모험할 맛이 나는 행성!", "고대 기믹 행성..?" }, { "혁신적인 행성..!", "보호장치가 잘되어있는 행성!", "심심할때 오면 재미질거같은 행성!" }, { "뒤죽박죽 어지러운 행성", "많이 힘든 행성", "쉬어가는 행성. 모두 수고하셨습니다!" } };
    private char[] starOneName = new char[5] { '쌍', '양', '천', '북', '카' };
    private string[] pendantsInfo = new string[5] {"둥실", "속력", "구일", "스몰", "혼합"};
    private int overNum = 0, pendantNum;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        firstText.text = starName[MenuManager.starSet - 1];
        selectText.text = starOneName[MenuManager.starSet-1] + "-" + MenuManager.starNum.ToString();
        selectTextNotice.text = starNote[MenuManager.starSet - 1, MenuManager.starNum - 1];
        overNum = 0;
        for(int i = 0; i < 3; i++)
        {
            overNum += MenuManager.fragNum[MenuManager.starSet - 1, i];
        }
        if (SlotManager.clickPendantSlot)
        {
            if(MenuManager.pendants == 0) infoText.text = "펜던트 적용 대기";
            else infoText.text = pendantsInfo[MenuManager.pendants-1] + " 펜던트 적용됨.";
        } else
        {
            if (overNum >= 3) infoText.text = pendantsInfo[MenuManager.starSet - 1] + " 펜던트 획득완료!";
            else infoText.text = pendantsInfo[MenuManager.starSet - 1] + " 펜던트 획득까지 " + (3 - overNum).ToString() + "조각 남음";
        }
    }
}
