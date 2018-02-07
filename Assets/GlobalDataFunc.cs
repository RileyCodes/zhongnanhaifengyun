using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalDataFunc : MonoBehaviour
{
    public System.DateTime CurrentInGameDatetime;

    public string CurrentInGameDatetimeToString()
    {
        return CurrentInGameDatetime.Year.ToString() + CurrentInGameDatetime.Month.ToString() + CurrentInGameDatetime.Day.ToString();
       
    }
}
