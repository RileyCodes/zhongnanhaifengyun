using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldControler : MonoBehaviour {

    public GameObject mainCam;
    public bool isPhoneUIOn = false;

    // Use this for initialization

    public Animator mainCamAniStartGame;
	void Start () {
        mainCamAniStartGame = mainCam.GetComponent<Animator>();
        mainCamAniStartGame.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
