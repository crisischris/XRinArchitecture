using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contentZoom : MonoBehaviour {


    public float dist;


    private bool isClicked = false;
 

    private bool isClickedRevert = false;

    private int l = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(isClicked == true)
        {
            StartCoroutine(click());
        }

        if (isClickedRevert == true)
        {
            StartCoroutine(clickRevert());
        }
        
    }


    public void clicked()
    {
        if (l == 0)
        {
            isClicked = true;
        }

        if(l == 1)
        {
            isClickedRevert = true;
        }

    }

    IEnumerator click()
         
        {
            transform.Translate(Vector3.right * Time.deltaTime / 4);
            yield return new WaitForSeconds(dist);            
            isClicked = false;
            l = 1;


        }
    

    IEnumerator clickRevert()
          
        {
            transform.Translate(Vector3.left * Time.deltaTime / 4);
            yield return new WaitForSeconds(dist);            
            isClickedRevert = false;
            l = 0;

        }
   
    
}
