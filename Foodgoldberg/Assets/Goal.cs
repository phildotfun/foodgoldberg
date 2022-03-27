using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    [SerializeField] AudioSource gong;
    [SerializeField] AudioClip gongClip;

    bool alreadyPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //when donut enters goal trigger
    //play gong clip only once
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Donut" && !alreadyPlayed)
        {
            gong.PlayOneShot(gongClip);

            alreadyPlayed = true;
        }
    }
}
