using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using EasyAR;


public class 上一个下一个 : MonoBehaviour {
    public GameObject buttonshang;
    public GameObject buttonxia;
    public GameObject buttonfanhui;
    public int maximum = 5;
    public GameObject model1;
    public GameObject model2;
    public GameObject model3;
    public GameObject model4;
    public GameObject model5;
    private int modelAmount = 1;
    // Use this for initialization
    void Start () {
        model2.SetActive(false);
        model3.SetActive(false);
        model4.SetActive(false);
        model5.SetActive(false);

        model1.SetActive(true);
        Button btn_xia = buttonxia.GetComponent<Button>();
		Button btn_shang= buttonshang.GetComponent<Button>();
        btn_shang.onClick.AddListener(onclickshang);
        btn_xia.onClick.AddListener(onclickxia);
        Button btn_fanhui = buttonfanhui.GetComponent<Button>();
        btn_fanhui.onClick.AddListener(onclickfanhui);


    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onclickfanhui()
    {
        Application.LoadLevel("八上章节选择");
    }
    public void onclickshang()
    {
        modelAmount = modelAmount +4;
        if(modelAmount%5==1)
        {
            model1.SetActive(true);
            model2.SetActive(false);
            model3.SetActive(false);
            model4.SetActive(false);
            model5.SetActive(false);
        }
        else if (modelAmount % 5 == 2)
        {
            model2.SetActive(true);
            model1.SetActive(false);
            model3.SetActive(false);
            model4.SetActive(false);
            model5.SetActive(false);
        }
        else if (modelAmount % 5 == 3)
        {
            model3.SetActive(true);
            model1.SetActive(false);
            model2.SetActive(false);
            model4.SetActive(false);
            model5.SetActive(false);
        }
        else if (modelAmount % 5 == 4)
        {
            model4.SetActive(true);
            model1.SetActive(false);
            model3.SetActive(false);
            model2.SetActive(false);
            model5.SetActive(false);
        }
        else if (modelAmount % 5 == 0)
        {
            model5.SetActive(true);
            model1.SetActive(false);
            model3.SetActive(false);
            model4.SetActive(false);
            model2.SetActive(false);
        }
    }
    public void onclickxia()
    {
        modelAmount = modelAmount + 1;
        if (modelAmount % 5 == 1)
        {
            model1.SetActive(true);
            model2.SetActive(false);
            model3.SetActive(false);
            model4.SetActive(false);
            model5.SetActive(false);
        }
        else if (modelAmount % 5 == 2)
        {
            model2.SetActive(true);
            model1.SetActive(false);
            model3.SetActive(false);
            model4.SetActive(false);
            model5.SetActive(false);
        }
        else if (modelAmount % 5 == 3)
        {
            model3.SetActive(true);
            model1.SetActive(false);
            model2.SetActive(false);
            model4.SetActive(false);
            model5.SetActive(false);
        }
        else if (modelAmount % 5 == 4)
        {
            model4.SetActive(true);
            model1.SetActive(false);
            model3.SetActive(false);
            model2.SetActive(false);
            model5.SetActive(false);
        }
        else if (modelAmount % 5 == 0)
        {
            model5.SetActive(true);
            model1.SetActive(false);
            model3.SetActive(false);
            model4.SetActive(false);
            model2.SetActive(false);
        }
    }
}
