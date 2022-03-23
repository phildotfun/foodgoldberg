using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public float rotSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        SelectedObject();
    }



    void SelectedObject()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        

        //highlight the object
        if (hit.collider.gameObject.tag == "Platform")
        {
            hit.transform.gameObject.GetComponent<ISelect>().OnHover();
        }
        

    }
}


