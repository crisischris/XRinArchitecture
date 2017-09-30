using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerClick : MonoBehaviour
{
   
    public bool back = false;




    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Clicked1()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void Clicked0()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);       
        back = true;
                
    }

}
