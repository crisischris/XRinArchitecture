﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioTest : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void clicked()
    {

        StartCoroutine(example());
               
    }

    
    IEnumerator example()
    {
        this.GetComponent<GvrAudioSource>().Play();
        yield return new WaitWhile(() => this.GetComponent<GvrAudioSource>().isPlaying);
        gameObject.SetActive(false);
    }
}
