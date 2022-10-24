using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float rotZ;
    public float RotSpeed;
    public bool ClockwiseRot;
    public bool Go = false;
    public GameObject Spin; 


    public void Awake()
    {
       
        
    }

    public void Update()
    {


        if (Go == true)
        {
            
            if (ClockwiseRot == false)
            {
                rotZ += Time.deltaTime * RotSpeed;
            }
            else
            {
                rotZ += -Time.deltaTime * RotSpeed;
            }

            transform.rotation = Quaternion.Euler(0, 0, rotZ);
        }

      
    }

    public void ResetSquare()
    {
        Spin.transform.rotation = Quaternion.Euler(0, 0, 0);
    } 

}
