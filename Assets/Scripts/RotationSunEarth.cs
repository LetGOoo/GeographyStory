using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotationSunEarth : MonoBehaviour {

    public Transform TrSun;
    public Transform TrEarth;

    public float FlRotaSpeedSelf;
    public float FlRotaSpeedCommEarth;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //太阳自转
        TrSun.Rotate(Vector3.up * FlRotaSpeedSelf);
        //地球自转
        TrEarth.Rotate(Vector3.up * FlRotaSpeedSelf);
        //地球公转
        TrEarth.RotateAround(TrSun.position, Vector3.up, FlRotaSpeedCommEarth);
    }
}
