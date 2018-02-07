using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 游戏时间转换为游戏内日期 : MonoBehaviour {


    public Text Game_Year;
    public Text Game_Month;
    public Text Game_Day;

    int GameSpeed = 10000;

    GameObject thePlayer;
    GlobalDataFunc glodata;


    public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
    {
        // Unix timestamp is seconds past epoch
        System.DateTime dtDateTime = new DateTime(2013, 03, 14, 0, 0, 0, 0, System.DateTimeKind.Utc);
        dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
        return dtDateTime;
    }

    // Use this for initialization
    void Start () {
        thePlayer = GameObject.Find("游戏世界控制器");
        glodata = thePlayer.GetComponent<GlobalDataFunc>();
    }
	
	// Update is called once per frame
	void Update () {
        float __time = Time.time;


        glodata.CurrentInGameDatetime = UnixTimeStampToDateTime((int)__time * GameSpeed);
        Game_Year.text = glodata.CurrentInGameDatetime.Year.ToString();
        Game_Month.text = glodata.CurrentInGameDatetime.Month.ToString();
        Game_Day.text = glodata.CurrentInGameDatetime.Day.ToString();
    }
}
