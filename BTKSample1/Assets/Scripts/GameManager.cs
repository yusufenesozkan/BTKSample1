using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private PlayerController playerController;
    private float respawnDelay = 2f; 
    public bool isGameEnding = false;
    public int score = 0;
    public Text scoreText ;
    public GameObject WinnerUI;
    public Text WinText;
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        scoreText.text = "0";
    }

    public void RespawnPlayer()
    {
        if (isGameEnding)
        {
            isGameEnding = false;
            StartCoroutine("RespawnCoroutine");
        }
        
    }
    public IEnumerator RespawnCoroutine()
    {
        playerController.gameObject.SetActive(false);
        yield return new WaitForSeconds(respawnDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ///playerController.transform.position = playerController.respawnPoint;
        //playerController.gameObject.SetActive(true);
        isGameEnding = false;

    }


    public void AddScore(int point)
    {
        score += point;
        scoreText.text = score.ToString();
    }
   
    public void LevelUp()
    {
        Time.timeScale = 0f;
        this.WinText.text = "Tebrikler" + scoreText.text;
        WinnerUI.SetActive(true);

        wait();

        NextLevel();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
    }
}
