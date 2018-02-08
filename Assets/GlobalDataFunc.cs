using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalDataFunc : MonoBehaviour
{
    public System.DateTime CurrentInGameDatetime;

    public  Canvas canvas_mainUI;
    public  Canvas canvas_NewDetail;
    public GameObject GO_overseanewes;

    static List<Canvas> GameUIPages = new List<Canvas>();

    void Start()
    {
        GameUIPages.Add(canvas_mainUI);
        GameUIPages.Add(canvas_NewDetail);
    }

    public void HideAllUI()
    {
        for (int i = 0; i < GameUIPages.Count; i++)
        {
            GameUIPages[i].GetComponent<CanvasGroup>().alpha = 0;
            GameUIPages[i].GetComponent<CanvasGroup>().interactable = false;
            canvas_NewDetail.GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
        return;
    }

    public void ShowNewsdetail()
    {
        HideAllUI();
        canvas_NewDetail.GetComponent<CanvasGroup>().alpha = 1;
        canvas_NewDetail.GetComponent<CanvasGroup>().interactable = true;
        canvas_NewDetail.GetComponent<CanvasGroup>().blocksRaycasts = true;
        return;
    }

    public void ShowMainUI()
    {
        HideAllUI();
        canvas_mainUI.GetComponent<CanvasGroup>().alpha = 1;
        canvas_mainUI.GetComponent<CanvasGroup>().interactable = true;
        canvas_mainUI.GetComponent<CanvasGroup>().blocksRaycasts = true;
        return;
    }

    public string CurrentInGameDatetimeToString()
    {
        return CurrentInGameDatetime.Year.ToString() + CurrentInGameDatetime.Month.ToString() + CurrentInGameDatetime.Day.ToString();

    }

    public string GetCurrentInGameDatetimeToFormatedString()
    {
        return CurrentInGameDatetime.Year.ToString() + " " + CurrentInGameDatetime.Month.ToString() + " " + CurrentInGameDatetime.Day.ToString();

    }
}
