using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


//will run the awake & update method within the editor when something changes

public class Platform : MonoBehaviour, IHoverable
{
    bool isHovering;
    bool isRotating;

    public Sprite normal;
    public Sprite highlighted;

    SpriteRenderer spriteRenderer;

    [SerializeField] float rotSpeed = 1000;

    void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = normal;
    }

    void Update()
    {
        if (isHovering && Input.GetMouseButtonDown(0))
        {
            isRotating = true;
        }

        if (isRotating && !Input.GetMouseButton(0))
        {
            isRotating = false;
        }

        if (isRotating)
        {
            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            gameObject.transform.Rotate(Vector3.forward, -rotX);
        }

        if (isRotating || isHovering)
        {
            spriteRenderer.sprite = highlighted;
        }
        else
        {
            spriteRenderer.sprite = normal;
        }
    }

    /// <summary>
    /// When mouse hover over platform, switch to highlight sprite.
    /// Use mouse and drag to change angle of platform
    /// </summary>
    public void OnHover()
    {
        isHovering = true;
    }

    public void OnHoverEnd()
    {
        isHovering = false;
    }
}
