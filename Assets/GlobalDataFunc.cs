using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalDataFunc : MonoBehaviour
{
    enum 国策{维稳I};

    public System.DateTime CurrentInGameDatetime;

    public  Canvas canvas_mainUI;
    public  Canvas canvas_NewDetail;
    public  Canvas canvas_SkillTree;
    public  GameObject GO_overseanewes;
    public  GameObject GO_VedioPlane;

    static List<Canvas> GameUIPages = new List<Canvas>();

    void Start()
    {
        GameUIPages.Add(canvas_mainUI);
        GameUIPages.Add(canvas_NewDetail);
        GameUIPages.Add(canvas_SkillTree);
    }

    public void DisplaySkillInfo(int SkillIndex,string BtnName)
    {
        if(SkillIndex == (int)国策.维稳I)
        {
            
        }
    }


    public void PlayVideo(int videoIndex)
    {
        GameObject VedioPlane = Instantiate(GO_VedioPlane) as GameObject;

    }

    public void HideAllUI()
    {
        for (int i = 0; i < GameUIPages.Count; i++)
        {
            GameUIPages[i].GetComponent<CanvasGroup>().alpha = 0;
            GameUIPages[i].GetComponent<CanvasGroup>().interactable = false;
            GameUIPages[i].GetComponent<CanvasGroup>().blocksRaycasts = false;
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

    public void ShowSkillTreeUI()
    {
        HideAllUI();
        canvas_SkillTree.GetComponent<CanvasGroup>().alpha = 1;
        canvas_SkillTree.GetComponent<CanvasGroup>().interactable = true;
        canvas_SkillTree.GetComponent<CanvasGroup>().blocksRaycasts = true;
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
