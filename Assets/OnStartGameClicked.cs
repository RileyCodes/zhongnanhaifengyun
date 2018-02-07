using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnStartGameClicked : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnMouseUp()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
