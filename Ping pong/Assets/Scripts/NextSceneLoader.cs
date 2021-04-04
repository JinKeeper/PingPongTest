using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("BestScore", 0);
        Invoke("LoadSceneMenu", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void LoadSceneMenu()
    {
        SceneManager.LoadScene(1);
    }
}
