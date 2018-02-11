using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPhoneBtnClicked : MonoBehaviour {

    // Use this for initialization
    bool isPushed = false;
	void Start () {
		
	}


    void OnMouseUp()
    {
        if(!isPushed)
        {
            Animator anima;
            anima = GetComponent<Animator>();
            anima.enabled = true;
            int isHideHash = Animator.StringToHash("PushButton");
            anima.SetTrigger(isHideHash);
            isPushed = true;
        }
        else
        {
            Animator anima;
            anima = GetComponent<Animator>();
            anima.enabled = true;
            int isHideHash = Animator.StringToHash("PullButton");
            anima.SetTrigger(isHideHash);
            isPushed = false;
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
