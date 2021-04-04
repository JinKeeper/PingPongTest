using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BallController : MonoBehaviour
{
    public GameObject roundScore;
    public Rigidbody2D rigidBody;
    public Vector2 direction;
    private float randomSpeed;
    private float randomScale;
    public GameObject ball;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        roundScore = GameObject.FindGameObjectWithTag("Score");
        PlayerPrefs.SetInt("RoundScore", 0);
        score = roundScore.GetComponent<UnityEngine.UI.Text>();
        randomScale = Random.Range(0.12f, 0.17f);
        ball.transform.localScale = new Vector2(randomScale, randomScale);
        randomSpeed = Random.Range(1.5f, 3.5f);
        direction = new Vector2(Random.Range(0.5f, 1), Random.Range(0.5f, 1));
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.velocity = direction.normalized * randomSpeed;
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Friendly"))
        {
            direction.x = -direction.x;
        }
        if (other.gameObject.CompareTag("Player"))
        {
            randomSpeed = randomSpeed + 0.20f;
            direction.y = -direction.y;
            PlayerPrefs.SetInt("RoundScore", PlayerPrefs.GetInt("RoundScore") + 1);
            score.text = "SCORE:" + PlayerPrefs.GetInt("RoundScore").ToString();
        }
        if (other.gameObject.CompareTag("Unfriendly"))
        {
            if (PlayerPrefs.GetInt("BestScore") < PlayerPrefs.GetInt("RoundScore"))
            {
                PlayerPrefs.SetInt("BestScore", PlayerPrefs.GetInt("RoundScore"));
            }
            Destroy(ball);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

    }

}
