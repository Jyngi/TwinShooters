using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stocks : MonoBehaviour
{
	public static int totalStocks = 3;
	public int currentStock;
	[Space]
	[Header("Stock Sprite GameObjects")]
	public GameObject stock_1, stock_2, stock_3;

    // Start is called before the first frame update
    void Start()
    {
        currentStock = totalStocks;
    }

    // Update is called once per frame
    void Update()
    {
    	Debug.Log(currentStock);
        switch(currentStock){
        	case 3:
        		stock_1.gameObject.SetActive(true);
        		stock_2.gameObject.SetActive(true);
        		stock_3.gameObject.SetActive(true);
        		break;
        	case 2:
        		stock_1.gameObject.SetActive(true);
        		stock_2.gameObject.SetActive(true);
        		stock_3.gameObject.SetActive(false);
        		break;
        	case 1:
        		stock_1.gameObject.SetActive(true);
        		stock_2.gameObject.SetActive(false);
        		stock_3.gameObject.SetActive(false);
        		break;
        }
        if (currentStock <= 0){
        	GameOver();
        }
    }
    public void DeductHealth(){
    	currentStock -= 1;
    }
    public void RestartSetHealth(){
    	currentStock = totalStocks;
    }
    private void GameOver(){
    	SceneManager.LoadScene(3);
    }
}
