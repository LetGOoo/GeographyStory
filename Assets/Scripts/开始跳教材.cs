using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 开始跳教材 : MonoBehaviour {
    public GameObject button;
	// Use this for initialization
	void Start () {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(onclick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onclick()
    {
        Application.LoadLevel("教材选择");

    }
}
