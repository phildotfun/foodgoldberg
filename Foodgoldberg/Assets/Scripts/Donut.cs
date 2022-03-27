using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Donut : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField] Text payerScore;
    [SerializeField] Text gameState;
    [SerializeField] GameObject startPosition;
   

    int score = 0;

    //required score for big god to open mouth
    public int reqScore = 50;

    string inGoal;


    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //reset donut to original position when space is presssed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = startPosition.transform.position;
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0;

            score = 0;
            payerScore.text = "0";
        }
    }

    //when donut hits a platform add to the score
    //player must reach a certain score level before they can feed
    //the monster
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Platform")
        {
            score += 10;
            int finalScore = Mathf.Clamp(score, 0, reqScore);
            payerScore.text = finalScore.ToString();
        }
    }


    //if donut hits the goal trigger
    //send Win string to text
    //game manager will check the text and go into win mode
    public void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.name == "Goal")
        {
            inGoal = "Win";
            gameState.text = inGoal;
        }
    }

}
