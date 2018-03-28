using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 八上章节跳课程 : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    // Use this for initialization
    void Start()
    {
        Button btn_1 = button1.GetComponent<Button>();
        btn_1.onClick.AddListener(onclick1);
        Button btn_2 = button2.GetComponent<Button>();
        btn_2.onClick.AddListener(onclick2);
        Button btn_3 = button2.GetComponent<Button>();
        btn_3.onClick.AddListener(onclick3);
        Button btn_4 = button2.GetComponent<Button>();
        btn_4.onClick.AddListener(onclick4);
        Button btn_5 = button2.GetComponent<Button>();
        btn_4.onClick.AddListener(onclick5);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onclick1()
    {
        SceneManager.LoadScene("疆域");

    }
    public void onclick2()
    {
        SceneManager.LoadScene("地形和地势");

    }
    public void onclick3()
    {
        SceneManager.LoadScene("交通运输");

    }
    public void onclick4()
    {
        SceneManager.LoadScene("八上期末复习");

    }
    public void onclick5()
    {
        SceneManager.LoadScene("教材选择");

    }
}