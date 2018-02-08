using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIControl : MonoBehaviour {

    GameObject theGameWorld;
    GlobalDataFunc glodata;


    // Use this for initialization
    void Start () {
        theGameWorld = GameObject.Find("游戏世界控制器");
        glodata = theGameWorld.GetComponent<GlobalDataFunc>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Escape))
            glodata.ShowMainUI();


    }
}
