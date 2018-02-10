using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnStartGameClicked : MonoBehaviour {

	// Use this for initialization

	void Start () {
		
	}

    public void OnMouseUp()
    {
        GameObject theGameWorld;
        theGameWorld = GameObject.Find("WorldControler");
        WorldControler glodata;
        glodata = theGameWorld.GetComponent<WorldControler>();
        glodata.mainCamAniStartGame.enabled = true;

        //SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
