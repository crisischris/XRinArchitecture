using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicklogic : MonoBehaviour {

    public SceneChangerClick sceneChange;

    public GameObject Player;
    public GameObject model;
    public GameObject TestMobileVR;

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

    public GameObject sound1;

    public GameObject spotLight1;
    public GameObject spotLight2;
    public GameObject spotLight3;
    public GameObject spotLight4;
    public GameObject spotLight5;

    public GameObject mainLight;


    private int numCount = 0;


    // Use this for initialization
    void Start () {

       

        model.SetActive(false);
        
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
        sound1.SetActive(false);
                
    }
	
	// Update is called once per frame
	void Update () {

        activateSpotlights();

        if (sceneChange.back == true)
        {
            Player.transform.position = new Vector3(warp2.transform.position.x, 2, warp2.transform.position.z);
        }


        if (Player.transform.position.z == warp1.transform.position.z)
        {
            modelOn();
        }

        else modelOff();

        if (Player.transform.position.z == warp2.transform.position.z)
        {
            TestMobileVROn();
        }

        else TestMobileVROff();


        if (numCount == 1)
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
            sound1.SetActive(true);


        }

        if (numCount == 4)
        {
            panel5.SetActive(true);
            warp6.SetActive(false);
            sound1.SetActive(false);

        }             

        if (numCount == 5)
        {
            
            warp1.SetActive(true);
            warp2.SetActive(true);
            warp3.SetActive(true);
            warp4.SetActive(true);
            warp5.SetActive(true);
            warp6.SetActive(false);
            sound1.SetActive(false);

        }

        





    }

    public void numClicked()

    {
      
        numCount++;
        print(numCount);

                
    }

    public void modelOn()
    {
        model.SetActive(true);
        
    }

    public void modelOff()
    {
        model.SetActive(false);

    }



          public void TestMobileVROn()
    {
        TestMobileVR.SetActive(true);

    }

    public void TestMobileVROff()
    {
        TestMobileVR.SetActive(false);

    }

    public void activateSpotlight()
    {
        spotLight1.SetActive(true);
        mainLight.SetActive(false);

    }

    public void activateSpotlights()
    {
     

        if (Player.transform.position.z == warp1.transform.position.z)
        {

            spotLight1.SetActive(true);

            spotLight2.SetActive(false);
            spotLight3.SetActive(false);
            spotLight4.SetActive(false);
            spotLight5.SetActive(false);
            mainLight.SetActive(false);
           

        }

        else if (Player.transform.position.z == warp2.transform.position.z)
        {
            spotLight2.SetActive(true);
            spotLight1.SetActive(false);
            spotLight3.SetActive(false);
            spotLight4.SetActive(false);
            spotLight5.SetActive(false);
            mainLight.SetActive(false);
        }

        else if (Player.transform.position.z == warp3.transform.position.z)
        {
            spotLight3.SetActive(true);

            spotLight2.SetActive(false);
            spotLight1.SetActive(false);
            spotLight4.SetActive(false);
            spotLight5.SetActive(false);
            mainLight.SetActive(false);
        }

        else if (Player.transform.position.z == warp4.transform.position.z)
        {

            spotLight4.SetActive(true);

            spotLight3.SetActive(false);
            spotLight2.SetActive(false);
            spotLight1.SetActive(false);
            spotLight5.SetActive(false);
            mainLight.SetActive(false);
        }

        else if (Player.transform.position.z == warp5.transform.position.z)
        {


            spotLight5.SetActive(true);

            spotLight4.SetActive(false);
            spotLight3.SetActive(false);
            spotLight2.SetActive(false);
            spotLight1.SetActive(false);
            mainLight.SetActive(false);
        }





    }







}


