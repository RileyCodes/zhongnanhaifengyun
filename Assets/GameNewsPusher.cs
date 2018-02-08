using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameNewsPusher : MonoBehaviour {

    GameObject thePlayer;
    GlobalDataFunc glodata;
    public GameObject noticeTip_Panel;
    public GameObject NewsListPanel;
    bool isPushedToday = false;
    public GameObject Image_NewsListbg;


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

    public void MoveAllOldNewes()
    {
       
        //NewsBG.transform.position = new Vector3(-19, 45, 0);

        for (int i = 0; i < NewsListPanel.transform.childCount; i++)
        {
            GameObject OldNews = NewsListPanel.transform.GetChild(i).gameObject;

            int yAxis_2 = (i - 1) * 94;
            OldNews.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -66 + yAxis_2, 0);
        }
    }

    public void PushNews(string newsmessage)
    {   
        DatetimePushedNews.Add(glodata.CurrentInGameDatetimeToString());

        GameObject NewsBG = Instantiate(Image_NewsListbg) as GameObject;
        GameObject OverseaNews = Instantiate(glodata.GO_overseanewes) as GameObject;

        

        MoveAllOldNewes();

        NewsBG.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -66, 0);
        NewsBG.GetComponent<RectTransform>().sizeDelta = new Vector2(800, 60);

        Text News_DateTimeText = NewsBG.transform.GetChild(1).gameObject.GetComponent<Text>(); ;
        Text News_NewsTitleText = NewsBG.transform.GetChild(0).gameObject.GetComponent<Text>(); ;
        News_DateTimeText.text = glodata.GetCurrentInGameDatetimeToFormatedString();
        News_NewsTitleText.text = newsmessage;

        NewsBG.transform.SetParent(NewsListPanel.transform,false);

        NewsInfomation controlscript = OverseaNews.GetComponent<NewsInfomation>();
        controlscript.isOverSeaNews = true;
        controlscript.NewsTitle = newsmessage;
        controlscript.transform.position = new Vector3(209.7f,247, 0);


        OverseaNews.transform.SetParent(NewsBG.transform, false);


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
                PushNews("第二条新闻");
                isPushedToday = true;
            }
           
        }
    }
}
