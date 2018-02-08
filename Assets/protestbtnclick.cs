using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protestbtnclick : MonoBehaviour {

    public void PlayVideo2(int vedioIndex)
    {
        GameObject theGameWorld;
        theGameWorld = GameObject.Find("游戏世界控制器");
        GlobalDataFunc glodata;
        glodata = theGameWorld.GetComponent<GlobalDataFunc>();
        glodata.PlayVideo(vedioIndex);
        glodata.ShowMainUI();
    }


    // Use this for initialization
    void Start () {
		
	}


    // Update is called once per frame
    void Update () {
		
	}
}
