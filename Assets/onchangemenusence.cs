using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onchangemenusence : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void changemenuscene(string scrnename)
    {
        Application.LoadLevel(scrnename);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
