using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour 
{

  
    public float Height;


    void Start()
    {

        

    }



    void Update()
	{
        // occilate the Y position
      

        transform.position = new Vector3(transform.position.x, (Height) + (Mathf.Sin(Time.time)/10), transform.position.z);
       

  

    }



}
