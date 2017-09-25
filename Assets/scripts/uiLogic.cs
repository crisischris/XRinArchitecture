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
        gameObject.SetActive(false);
        isClicked.numClicked();


    }
}
