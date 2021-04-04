using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColourController : MonoBehaviour
{
    public void SetYellowBall()
    {
        PlayerPrefs.SetInt("BallColour", 0);
    }
    public void SetWhiteBall()
    {
        PlayerPrefs.SetInt("BallColour", 1);
    }
    public void SetRedBall()
    {
        PlayerPrefs.SetInt("BallColour", 2);
    }
    public void SetBlackBall()
    {
        PlayerPrefs.SetInt("BallColour", 3);
    }
}
