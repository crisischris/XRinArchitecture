using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class narration : MonoBehaviour {

    public GameObject audSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void clicked()
    {

        audSource.GetComponent<GvrAudioSource>().Play();
        
        
    }
}
