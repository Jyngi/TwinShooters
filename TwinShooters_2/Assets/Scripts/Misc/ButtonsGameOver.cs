using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsGameOver : MonoBehaviour
{

    void Start()
    {
        
    }
    void Update(){}

    // Update is called once per frame
    public void Restart()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }
}
