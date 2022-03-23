using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour, ISelect
{

    public Sprite normal;
    public Sprite highlighted;

    float rotSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    /// <summary>
    /// When mouse hover over platform, switch to highlight sprite.
    /// Use mouse and drag to change angle of platform
    /// </summary>
    public void OnHover()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = highlighted;

        void OnMouseDrag()
        {
            if (Input.GetMouseButtonDown(0))
            {
                float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
                gameObject.transform.Rotate(Vector2.up, rotX);
            }
        }
    }

    public void OffHover()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = normal;
    }


}
