using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locomotion : MonoBehaviour {

    public GameObject warp;
    public GameObject Player;

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

    public void Clicked()
    {
        Player.transform.position = warp.transform.position;
        print("clicked");

        Player.transform.position = new Vector3(posx, 2, posz);
        
    }
}
