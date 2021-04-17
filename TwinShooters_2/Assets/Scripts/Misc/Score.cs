using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
	public float score = 0.0f;
	private float initTime = 0.0f;
	private Scene scene;

	[SerializeField]
	private TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
    	DontDestroyOnLoad(this.gameObject);
        initTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
    	scene = SceneManager.GetActiveScene();
    	if(scene.buildIndex == 3){
    		this.gameObject.SetActive(false);
    	}
    	if(scene.buildIndex == 2){
    		this.gameObject.SetActive(true);
    	}

        score = Time.time - initTime;
        floorScore();
        scoreText.text = score.ToString();


    }
    void floorScore(){
    	score = Mathf.Floor(score * 100) / 100;
    }
    public float ReturnFinalScore(){
    	return score;
    }
}
