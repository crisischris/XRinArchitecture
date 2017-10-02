using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generalAudio : MonoBehaviour {

  
    private AudioSource something;
        public AudioClip sound;

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void hover()

    {
        this.GetComponent<AudioSource>().Play();
    }
}
