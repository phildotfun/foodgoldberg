using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public float rotSpeed = 10;
    GameObject lastHit;

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

        if (hit.collider != null)
        {
            lastHit = hit.transform.gameObject;

            //highlight the object
            if (hit.collider.gameObject.tag == "Platform")
            {
                hit.transform.gameObject.GetComponent<IHoverable>().OnHover();
            }
        }
        else
        {
            //Debug.Log(lastHit);
            if (lastHit != null)
            {
                lastHit.GetComponent<IHoverable>().OnHoverEnd();
                lastHit = null;
            }
          
        }
    }
}


