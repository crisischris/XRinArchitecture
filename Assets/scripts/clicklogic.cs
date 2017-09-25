using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicklogic : MonoBehaviour {

    public GameObject playerLoc;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;

    public GameObject warp1;
    public GameObject warp2;
    public GameObject warp3;
    public GameObject warp4;
    public GameObject warp5;
    public GameObject warp6;

    private int numCount = 0;


    // Use this for initialization
    void Start () {

        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);


        warp1.SetActive(false);
        warp2.SetActive(false);
        warp3.SetActive(false);
        warp4.SetActive(false);
        warp5.SetActive(false);
        warp6.SetActive(false);
                
    }
	
	// Update is called once per frame
	void Update () {



    

        if(numCount == 1)
        {
            panel2.SetActive(true);

        }

        if (numCount == 2)
        {
            panel3.SetActive(true);
            
        }

        if (numCount == 3)
        {
            panel4.SetActive(true);
            warp6.SetActive(true);

        }

        if (numCount == 4)
        {
            panel5.SetActive(true);
            warp6.SetActive(false);


        }             

        if (numCount == 5)
        {
            
            warp1.SetActive(true);
            warp2.SetActive(true);
            warp3.SetActive(true);
            warp4.SetActive(true);
            warp5.SetActive(true);
            warp6.SetActive(false);
            
        }

        


    }

    public void numClicked()

    {
      
        numCount++;
        print(numCount);

                
    }
}


