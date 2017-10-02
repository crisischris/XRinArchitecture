using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiLogic : MonoBehaviour {

    public clicklogic isClicked;
      
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void clicked()

    {
        StartCoroutine(example());
    }

    public void hover()

    {
        this.GetComponent<GvrAudioSource>().Play();
    }


    IEnumerator example()
    {
        this.GetComponent<GvrAudioSource>().Play(); ;
        yield return new WaitWhile(() => this.GetComponent<GvrAudioSource>().isPlaying);
        gameObject.SetActive(false);
        isClicked.numClicked();
    }
}
