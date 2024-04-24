using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private TextMeshProUGUI healthText;

    [SerializeField] private TextMeshProUGUI totalScoreText;
    [SerializeField] private TextMeshProUGUI highestScoreText;
    private Player player;

    // Start is called before the first frame update

    void Start()
    {


        player = FindObjectOfType<Player>();
        GameManager.singleton.GetScoreManager().OnNewHighScore.AddListener(UpdateHighestScoreText);
        GameManager.singleton.GetScoreManager().OnScoreChanged.AddListener(UpdateActualScoreText);
        player.GetHealthInformation().OnLifeChanged.AddListener(UpdateLifeText);
        player.GetHealthInformation().OnDie.AddListener(ShowGameOverScreen);

        UpdateLifeText(player.GetHealthInformation().GetHealth());
        //UpdateHighestScoreText(GameManager.singleton.GetScoreManager().GetHighScore());
    }

    void UpdateLifeText(int life)
    {
        healthText.text = "HEALTH: " + life;
    }

    void UpdateHighestScoreText(int scoreParam)
    {
        highestScoreText.text = "HIGHEST SCORE: " + scoreParam.ToString();
    }

    void UpdateActualScoreText(int scoreParam)
    {
        totalScoreText.text = "SCORE: " + scoreParam.ToString();
    }

    void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }
    public void ReloadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
