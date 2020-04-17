using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    private GameObject scoreText;
    int score = 0;
    
	// Use this for initialization
	void Start () {

        this.scoreText = GameObject.Find("ScoreText");
    }
	
	// Update is called once per frame
	void Update () {

        this.scoreText.GetComponent<Text>().text = "Score:" + this.score;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            this.score += 100;
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            this.score += 150;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            this.score += 200;
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            this.score += 250;
        }
    }


}
