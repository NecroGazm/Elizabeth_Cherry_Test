using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Counter : MonoBehaviour
{
    public GameObject TryAgain_Panel;
    public int Count;
    public Text CountTextL;
    public Text CountTextR;
    public GameObject Spinner;
    

    // Start is called before the first frame update

    public void Awake()
    {
        
       
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Count >= 10)
        {
            TryAgain_Panel.SetActive(true);
            Time.timeScale = 0f;
        }
        
            
        
    }

    public void Add()
    {
        Count++;
    }

    public void Restart()
    {
        Count = 0;
        CountTextL.text = Count.ToString();
        CountTextR.text = Count.ToString();
        Spinner.transform.rotation = Quaternion.Euler(0, 0, 0);

    }

    public void No()
    {
        
        Application.Quit();
    }
}
