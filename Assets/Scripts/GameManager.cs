using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    public Text coinText;
    int coins;

    public List<GameObject> enemiesInScreen;
    private Enemy enemy;

    void Awake()
    {
        enemy = FindObjectOfType<Enemy>().GetComponent<Enemy>();
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            foreach(GameObject enemies in enemiesInScreen)
            {
                Enemy enemyScript = enemies.GetComponent<Enemy>();
                enemyScript.Die();
            }
        }
    }

    public void GameOver()
    {
        isGameOver = true;
    }

    public void AddCoin()
    {
        coins++;
        coinText.text = coins.ToString();
    }
}
