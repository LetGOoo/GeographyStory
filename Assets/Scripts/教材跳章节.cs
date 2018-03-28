using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 教材跳章节 : MonoBehaviour
{
    public GameObject buttonbashang;
    public GameObject buttonbaxia;
    public GameObject buttonfanhui;

    // Use this for initialization
    void Start()
    {
        Button btn_bashang = buttonbashang.GetComponent<Button>();
        btn_bashang.onClick.AddListener(onclickbashang);
        Button btn_baxia = buttonbaxia.GetComponent<Button>();
        btn_baxia.onClick.AddListener(onclickbaxia);
        Button btn_fanhui = buttonfanhui.GetComponent<Button>();
        btn_fanhui.onClick.AddListener(onclickfanhui);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onclickbashang()
    {
        SceneManager.LoadScene("八上章节选择");

    }
    public void onclickbaxia()
    {
        SceneManager.LoadScene("八下章节选择");

    }
    public void onclickfanhui()
    {
        SceneManager.LoadScene("开始界面");

    }
}
