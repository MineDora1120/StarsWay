using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public Text firstText, selectTextNotice, selectText;
    private string[] starName = new string[5] { "쌍둥이자리", "양자리", "천칭자리", "북두칠성", "카시오페아" };
    private string[,] starNote = new string[,] { { "오랜만에 가는 행성인걸!? 도키도키해!!", "생명체가 존재할건데.. 어디있을까?", "우와 생명체야!!"}, { "처음보는 행성이네, 많이 난해해 보이는걸?", "여기있는 생명체들은 무엇을 먹고 살까?", "별자리 이상이 여기까지 전파된거 같네."}, { "뭔가 간단해보이면서도 어려운 행성같아 보이네.." , "살짝이지만, 신비로움을 느꼈어!" ,"이쪽 행성은 전쟁이 난걸까? 파괴가 되어있네." }, { "문명이 발달한 행성인가? 고급진 느낌이 드는걸?", "단순한거 같으면서도 정교한 이느낌..!", "정말 혁신적인 행성이네! 이런곳은 처음봤어!"} };
    private char[] starOneName = new char[5] { '쌍', '양', '천', '북', '카' };
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        firstText.text = starName[MenuManager.starSet - 1];
        selectText.text = starOneName[MenuManager.starSet-1] + "-" + MenuManager.starNum.ToString();
        selectTextNotice.text = starNote[MenuManager.starSet - 1, MenuManager.starNum - 1];
    }
}
