using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Switch : MonoBehaviour
{
    public Camera Cam;
    private Vector3 screenPos;
    private float angleoffset;
    private Collider2D col;
    public Text CountTextl;
    public int rcount;
    public GameObject Square;
    Rotation Clock;
    public Transform LocalTrans;
    public int minYRot= 90;
    public int maxYRot = 180;
    public GameObject Manager;
    Counter total;

    public bool isOver = false;
    // Start is called before the first frame update

    public void Awake()
    {
        Clock = Square.GetComponent<Rotation>();
        total = Manager.GetComponent<Counter>();
    }

    void Start()
    {
        LocalTrans = GetComponent<Transform>();
        Cam = Camera.main;
    }

    
    public void Update()
    {

            CountTextl.text = rcount.ToString();
            Vector3 mousePos = Cam.ScreenToWorldPoint(Input.mousePosition);

        if (isOver == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (col == Physics2D.OverlapPoint(mousePos))
                {
                    screenPos = Cam.WorldToScreenPoint(transform.position);
                    Vector3 vec3 = Input.mousePosition - screenPos;
                    angleoffset = (Mathf.Atan2(transform.right.y, transform.right.x) - Mathf.Atan2(vec3.y, vec3.x)) * Mathf.Rad2Deg;
                }

            }
            if (Input.GetMouseButtonUp(0))
            {

                if (col == Physics2D.OverlapPoint(mousePos))
                {
                    Vector3 vec3 = Input.mousePosition - screenPos;
                    float angle = Mathf.Atan2(vec3.y, vec3.x) * Mathf.Rad2Deg;
                    transform.eulerAngles = new Vector3(0, 0, -47);
                }
                StartCoroutine(ReturnToStart(1));

            }
        }
    }

    private void OnMouseEnter()
    {
        isOver = true;
    }

    private void OnMouseExit()
    {
        isOver = false;
    }

    public IEnumerator ReturnToStart(float time)
    {
        if (Clock.ClockwiseRot == false)
        {
            Clock.ClockwiseRot = true;
        }
        else
        {
            Clock.ClockwiseRot = false;
        }
        total.Add();
        rcount++;
        yield return new WaitForSeconds(1);
        transform.eulerAngles = new Vector3(0, 0, 60);
    }

    public void RestartCount()
    {
        rcount = 0;
    }

}
