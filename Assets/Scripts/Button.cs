using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Button : MonoBehaviour
{
    [SerializeField] GameObject Square;
    Rotation SpinStart;
    public GameObject Manager;
    Counter total;
    public Text CountTextB;
    public int Lcount;


    public void Awake()
    {
        SpinStart = Square.GetComponent<Rotation>();
        total = Manager.GetComponent<Counter>();
    }

     void Update()
    {
        CountTextB.text = Lcount.ToString();
    }
    public void ButtonGO()
    {
       
        if(SpinStart.Go == false)
        {
            SpinStart.Go = true;
            total.Add();
            Lcount++;
        }
        else
        {
            SpinStart.Go = false;
            total.Add(); 
            Lcount++;
        }
    }
    
    public void RestartCount()
    {
        Lcount = 0;
    }
}
