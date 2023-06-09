using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class GameManager : MonoBehaviour
{
    private int level;
    public bool isOver;
    public Button restartButton;
    public TextMeshProUGUI levelText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateLevel(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UpdateLevel(int level)
    {
        this.level = level; 
        levelText.SetText("Level: " + level);
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        isOver = true;
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        restartButton.gameObject.SetActive(false);
    }
}
