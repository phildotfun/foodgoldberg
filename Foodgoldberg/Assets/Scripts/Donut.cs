using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Donut : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField] Text scoreText;
    [SerializeField] GameObject startPosition;

    int score = 0;

    //requiredScore
    public int reqScore = 100;


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
            scoreText.text = "0";
        }
    }

    //when donut hits a platform add to the score
    //player must reach a certain score level before they can feed
    //the monster
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Platform")
        {
            score += 10;
            int finalScore = Mathf.Clamp(score, 0, reqScore);
            scoreText.text = finalScore.ToString();
        }
    }

}
