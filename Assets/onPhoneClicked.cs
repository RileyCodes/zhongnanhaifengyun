using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onPhoneClicked : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    IEnumerator showPhoneUI()
    {
        //This is a coroutine
        //Wait one frame

        GameObject PhoneCallUI;
        PhoneCallUI = GameObject.Find("PhoneCallUI");


        for (int i = 0; i < PhoneCallUI.transform.childCount; i++)
        {
            float time = Time.deltaTime;
            GameObject phonebtn = PhoneCallUI.transform.GetChild(i).gameObject;
            Animator anima;
            anima = phonebtn.GetComponent<Animator>();
            anima.enabled = true;
            int isHideHash = Animator.StringToHash("ShowButtons");
            anima.SetTrigger(isHideHash);
            yield return new WaitForSecondsRealtime(0.1f);

        }
    }

    IEnumerator hidePhoneUI()
    {
        //This is a coroutine
        //Wait one frame

        GameObject PhoneCallUI;
        PhoneCallUI = GameObject.Find("PhoneCallUI");


        for (int i = 0; i < PhoneCallUI.transform.childCount; i++)
        {
            float time = Time.deltaTime;
            GameObject phonebtn = PhoneCallUI.transform.GetChild(i).gameObject;
            Animator anima;
            anima = phonebtn.GetComponent<Animator>();
            anima.enabled = true;
            int isHideHash = Animator.StringToHash("HideButtons");
            anima.SetTrigger(isHideHash);
            yield return new WaitForSecondsRealtime(0.1f);

        }
    }


    void OnMouseUp()
    {
        GameObject theGameWorld;
        theGameWorld = GameObject.Find("WorldControler");
        WorldControler glodata;
        glodata = theGameWorld.GetComponent<WorldControler>();
        if (!glodata.isPhoneUIOn)
        {
            glodata.isPhoneUIOn = true;
            StartCoroutine(showPhoneUI());
        }
        else
        {
            glodata.isPhoneUIOn = false;
            StartCoroutine(hidePhoneUI());
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
