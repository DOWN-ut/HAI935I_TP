using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public static class GameVariables
{
    public static float allowedTime = 90;
    public static float currentTime = allowedTime;
}

public class GameManager : MonoBehaviour
{
    [SerializeField]
    AudioSource catBotDeathSound;
    int catBotKills;
    public int CatBotKills { get { return catBotKills; } }
    [SerializeField]
 int targetKills;
 public bool EnoughCatBotKilled { get { return catBotKills >= targetKills; } }
    public void KilledCatBot()
    {
        catBotKills++;
        PlayCatBotDeath();
    }
    public void PlayCatBotDeath()
    {
        catBotDeathSound.Play();
    }
    public void ChangeScene()
 {
 if (EnoughCatBotKilled )
 {
 SceneManager.LoadScene(terrainSceneName );
 } }
    private void Start()
    {
        StartCoroutine(TimerTick());
    }

    [SerializeField]
    string sceneName;
    [SerializeField]
    string terrainSceneName;
    public float CurrentTime { get { return GameVariables.currentTime; } }
    IEnumerator TimerTick()
    {
        while (GameVariables.currentTime > 0)
        {
            yield return new WaitForSeconds(1);
            GameVariables.currentTime--;
        }
        SceneManager.LoadScene(sceneName);
    }
    public static GameManager instance;

    void Awake()
    {
        instance = this;
        GameVariables.currentTime = GameVariables.allowedTime;
    }
}