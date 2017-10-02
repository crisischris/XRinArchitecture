using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelExplode : MonoBehaviour
{

      public GameObject roof;
      public GameObject wallN;
      public GameObject wallS;
      public GameObject wallE;
      public GameObject wallW;

    
    private bool isClicked = false;
    private bool isClickedRevert = false;

    
    private float i = 0;


    // Use this for initialization
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        if(isClicked == true)
        {
            StartCoroutine(Explode());
        }

        if (isClickedRevert == true)
        {
            StartCoroutine(Reconstruct());
        }

    }
    


    public void Clicked()
    {
  
       
        if(i == 0)
        {
            isClicked = true;
            this.GetComponent<GvrAudioSource>().Play();


        }
        else if (i == 1)
        {
            isClickedRevert = true;
            this.GetComponent<GvrAudioSource>().Play();

        }
        
               

    }

    IEnumerator Explode()
    {
        if (isClicked == true)
        {
            roof.transform.Translate(Vector3.up * Time.deltaTime / 8);
            wallN.transform.Translate(Vector3.left * Time.deltaTime / 8);
            wallS.transform.Translate(Vector3.right * Time.deltaTime / 8);
            wallE.transform.Translate(Vector3.forward * Time.deltaTime / 8);
            wallW.transform.Translate(Vector3.forward * Time.deltaTime / 8);
            yield return new WaitForSeconds(3);
            isClicked = false;
            i = 1;

        }
    }


        IEnumerator Reconstruct()
    {
            if (isClickedRevert == true)
            {
                roof.transform.Translate(Vector3.down * Time.deltaTime / 8);
                wallN.transform.Translate(Vector3.right * Time.deltaTime / 8);
                wallS.transform.Translate(Vector3.left * Time.deltaTime / 8);
                wallE.transform.Translate(Vector3.back * Time.deltaTime / 8);
                wallW.transform.Translate(Vector3.back * Time.deltaTime / 8);
                yield return new WaitForSeconds(3);
                isClickedRevert = false;
                i = 0;

            }


        }

}

