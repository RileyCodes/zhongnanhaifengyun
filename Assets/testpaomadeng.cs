using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testpaomadeng : MB_Singleton<testpaomadeng>
{


    public GameObject noticeTip_Panel;

    /// <summary>
    /// 先对noticeTip_Panel进行初始化操作.
    /// </summary>
    public void PreInit()
    {
        if (!noticeTip_Panel.activeSelf)
        {
            noticeTip_Panel.SetActive(true);
            NoticeController.Instance.Init();
        }
    }
    public void press()
    {
        PreInit();
        //noticeTip_Panel.GetComponent<NoticeController>().AddMessage("年三年实打实的 阿萨德高压闪光灯哈桑的话是对哈撒啊是否打算");
        NoticeController.Instance.AddMessage("年三年实打实的 阿萨德高压闪光灯哈桑的话是对哈撒啊是否打算");
    }
    public void press2()
    {
        PreInit();
        NoticeController.Instance.AddMessage("1111111111111111");
    }

}
