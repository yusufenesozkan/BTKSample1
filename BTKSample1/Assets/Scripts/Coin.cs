using UnityEngine;

public class Coin : MonoBehaviour
{
    GameManager gameManager;
    public int ScoreValue;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
       
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddScore(ScoreValue);
            Destroy(this.gameObject);
        }
       
    }
}