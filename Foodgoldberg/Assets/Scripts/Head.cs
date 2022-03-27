using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Head : MonoBehaviour
{
    public Sprite closed;
    public Sprite open;
    public Sprite smile;

    public Text score;
    public Text maxScore;


    int scoreNum;
    int maxNum;

    public GameObject finish;

    SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = closed;

        
    }

    // Update is called once per frame
    void Update()
    {
        //convert text into integers

        scoreNum = int.Parse(score.text);
        maxNum = int.Parse(maxScore.text);

        

     
        //if the donut bounces enough times
        //open mouth
        if (scoreNum >= maxNum)
        {
            spriteRenderer.sprite = open;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            spriteRenderer.sprite = closed;
        }
    }
}
