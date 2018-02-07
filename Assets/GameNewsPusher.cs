using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameNewsPusher : MonoBehaviour {

    GameObject thePlayer;
    GlobalDataFunc glodata;
    public GameObject noticeTip_Panel;
    bool isPushedToday = false;

    List<string> DatetimePushedNews = new List<string>();

    // Use this for initialization
    void Start()
    {
        thePlayer = GameObject.Find("游戏世界控制器");
        glodata = thePlayer.GetComponent<GlobalDataFunc>();

    }

    public void PreInit()
    {
        if (!noticeTip_Panel.activeSelf)
        {
            noticeTip_Panel.SetActive(true);
            NoticeController.Instance.Init();
        }
    }
    public void PushNews(string newsmessage)
    {
        DatetimePushedNews.Add(glodata.CurrentInGameDatetimeToString());

        //noticeTip_Panel.GetComponent<NoticeController>().AddMessage("年三年实打实的 阿萨德高压闪光灯哈桑的话是对哈撒啊是否打算");
        NoticeController.Instance.AddMessage(newsmessage);
    }

    private void Update()
    {
        if(glodata.CurrentInGameDatetime.Year == 2013 && glodata.CurrentInGameDatetime.Month == 03 && glodata.CurrentInGameDatetime.Day == 15 )
        {
            string tmp = glodata.CurrentInGameDatetimeToString();
            if (!DatetimePushedNews.Contains(tmp))
            {
                PushNews("第一条新闻");
                isPushedToday = true;
            }
           
        }
    }
}
