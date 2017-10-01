using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpLong : MonoBehaviour {

    public GameObject Player;
    public GameObject warp;
    public GameObject canvas;

    private float posx;
    private float posz;

	// Use this for initialization
	void Start () {

        posx = warp.transform.position.x;
        posz = warp.transform.position.z;
        canvas.transform.position = new Vector3(.96f, 498, -15);



	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoToExample()
    {
        Player.transform.position = new Vector3(1, 500, -12);
        this.GetComponent<AudioSource>().Play();

    }

    public void returnToMain()
    {
        Player.transform.position = new Vector3(posx, 2, posz);
        this.GetComponent<AudioSource>().Play();
    }
}
