using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;

    [SerializeField] private Enemy enemyPrefab;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private ScoreManager scoreManager;

    private void Awake()
    {
        singleton = this;

        //Player p = FindObjectOfType<Player>();
        //p.GetHealthInformation().OnDie.AddListener(StopGame);
    }
    public ScoreManager GetScoreManager()
    {
        return scoreManager;
    }
    private void Start()
    {
        StartCoroutine(SpawnEnemiesCoroutine());
    }
    public void StopGame()
    {
        StopAllCoroutines();
        scoreManager.RegisterHighScore();
    }
    public void AddScore()
    {
        //scoreManager.IncreaseScore();
    }

    private void Update()
    {

    }

    IEnumerator SpawnEnemiesCoroutine()
    {
        yield return new WaitForSeconds(3);
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.5f, 3f));

            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)]; //random transform from a pre determined list
                                                                                      //or
            Vector2 randomPosition = Random.insideUnitCircle * 10f;

            Enemy tempEnemy = Instantiate(enemyPrefab, randomPoint.position, Quaternion.identity);
            tempEnemy.SetupEnemy(2, 4, 1);
            tempEnemy.GetHealthInformation().OnDie.AddListener(scoreManager.IncreaseScore);
            
        }

    }

}
