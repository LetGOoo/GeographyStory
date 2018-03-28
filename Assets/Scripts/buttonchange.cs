using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using EasyAR;

public class buttonchange : MonoBehaviour {

    public GameObject button_left;
    public GameObject button_right;
    public int maximum = 5;
    public GameObject model1;
    public GameObject model2;
    public GameObject model3;
    public GameObject model4;
    public GameObject model5;
    private int modelAmount = 1;

    // Use this for initialization
    void Start () {
        Button btn_left = button_left.GetComponent<Button>();
        Button btn_right = button_right.GetComponent<Button>();
        btn_left.onClick.AddListener(OnClickButtonLeft);
        btn_right.onClick.AddListener(OnClickButtonRight);
        model2.SetActive(false);
        model3.SetActive(false);
        model4.SetActive(false);
        model5.SetActive(false);

        model1.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickButtonLeft()
    {
        ++modelAmount;
     //   if(modelAmount > maximum)
      //  {
      //      modelAmount = 1;
      //  }
        if(modelAmount %5== 1)
        {
            model1.SetActive(true);
            model2.SetActive(false);
            model3.SetActive(false);
            model4.SetActive(false);
            model5.SetActive(false);
        }
        else if(modelAmount % 5 == 2)
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

    public void OnClickButtonRight()
    {
        modelAmount+=4;
        //   if(modelAmount > maximum)
        //  {
        //      modelAmount = 1;
        //  }
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
