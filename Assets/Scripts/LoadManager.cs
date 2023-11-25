using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Loding());
    }

    IEnumerator Loding()
    {
        // Slider 라는 이름을 가진 자식 객체를 찾은 후 자식 객체가 가진 실린더 속성을 객체로 변환
        Slider slider = transform.GetChild(0).GetChild(0).GetComponent<Slider>();

        AsyncOperation oper = SceneManager.LoadSceneAsync("Main");

        // 실린더 값 증가
        while (!(oper.progress >= 0.99f))
        {
            slider.value += oper.progress;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
