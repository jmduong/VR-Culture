using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{
    public scoring enemyScore;
    public Text score;
    int scoreValue;
    bool wait = false;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score: " + 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreValue % 5 == 0)
        {
            // Win bet.
            enemyScore.scoreValue = 0;
            scoreValue = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Foot Ball")
        {
            //wait = true;
            scoreValue++;
            print("Y");
            score.text = "Score: " + scoreValue.ToString();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Foot Ball")
        {
            //wait = true;
            scoreValue++;
            print("Y");
            score.text = "Score: " + scoreValue.ToString();
        }
    }
}
