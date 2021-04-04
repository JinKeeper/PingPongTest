using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInstantiatorController : MonoBehaviour
{
    public GameObject yellowBall;
    public GameObject whiteBall;
    public GameObject redBall;
    public GameObject blackBall;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("BallColour") == 0)
        {
            Instantiate(yellowBall);
        }
        if (PlayerPrefs.GetInt("BallColour") == 1)
        {
            Instantiate(whiteBall);
        }
        if (PlayerPrefs.GetInt("BallColour") == 2)
        {
            Instantiate(redBall);
        }
        if (PlayerPrefs.GetInt("BallColour") == 3)
        {
            Instantiate(blackBall);
        }
    }

}
