using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI scoreText;
     public int score=0;
    [SerializeField] private TextMeshProUGUI gameOverText;
    public bool isGameActive;
    [SerializeField] private Button restartButton;
    [SerializeField] private TextMeshProUGUI finishGameText;
     public EnergyBar energybar;
    [SerializeField] TextMeshProUGUI label;
    [SerializeField] private TextMeshProUGUI scoreTextFinal;
    [SerializeField] private TextMeshProUGUI coinTextFinal;
    [SerializeField] Image ým;
    [SerializeField] Image ýmm;
    public int coin = 0;
    int counter = 0;
    [SerializeField] Image image;
    [SerializeField] ParticleSystem particle;
    
    public static LevelManager  Instance { get; private set; }

    void Awake()
    {
        Instance = this;
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score; 

    }
    public void UpdateCoinFinal(int coinToAdd)
    {
        coin += coinToAdd;
       

    }
    
   
    public void UpdateScoreFinal()
    {
        ým.gameObject.SetActive(true);
        ýmm.gameObject.SetActive(true);
        scoreTextFinal.text =score.ToString () ;
        coinTextFinal.text = coin.ToString();

    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   public void FinishGame()
    {
        
        finishGameText.gameObject.SetActive(true);
        image.gameObject.SetActive(true);
        particle.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void FinishRound()
    {
        counter++;
        energybar.gameObject.SetActive(true);
        energybar.SetEnergy(counter);
        label.text = "Round " + counter + "/3";
        
        StartCoroutine(FinishRound2());
        
    }

    IEnumerator FinishRound2()
    {
        yield return new WaitForSeconds(4.5f);
        energybar.gameObject.SetActive(false);
    }
}
