using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpLong : MonoBehaviour {

    public GameObject Player;
    public GameObject warp;

    private float posx;
    private float posz;

	// Use this for initialization
	void Start () {

        posx = warp.transform.position.x;
        posz = warp.transform.position.z;


	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoToExample()
    {
        Player.transform.position = new Vector3(5, 2, 500);

    }

    public void returnToMain()
    {
        Player.transform.position = new Vector3(posx, 2, posz);
    }
}
