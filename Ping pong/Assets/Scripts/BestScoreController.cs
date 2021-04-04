using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreController : MonoBehaviour
{
    Text bestScore;
    // Start is called before the first frame update
    void Start()
    {
        Text bestScore = GetComponent<UnityEngine.UI.Text>();
        bestScore.text = "BEST SCORE:" + PlayerPrefs.GetInt("BestScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
