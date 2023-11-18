using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public Text firstText, selectTextNotice, selectText;
    private string[] starName = new string[5] { "쌍둥이자리", "양자리", "천칭자리", "북두칠성", "카시오페아" };
    private string[,] starNote = new string[,] { { "오랜만에 가는 행성이군. 어떤 모습일까?", "분명 이 별은 생명체가 존재할텐데..", "생명체를 피해 조심조심 지나가야겠군."} };
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        firstText.text = starName[MenuManager.starSet - 1];
        selectTextNotice.text = starNote[MenuManager.starSet - 1, MenuManager.starNum - 1];
        selectText.text = MenuManager.starSet.ToString() + "-" + MenuManager.starNum.ToString();
    }
}
