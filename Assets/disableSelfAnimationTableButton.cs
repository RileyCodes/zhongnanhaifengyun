using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableSelfAnimationTableButton : MonoBehaviour {

	// Use this for initialization

	void Start () {
        Animator myAnime = GetComponent<Animator>();
        myAnime.enabled = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
