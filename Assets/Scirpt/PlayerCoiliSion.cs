using UnityEngine;

public class PlayerCoiliSion : MonoBehaviour
{
    private GameManager gameManager;
    private AudioMannager audioMannager;
    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        audioMannager = FindAnyObjectByType<AudioMannager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            audioMannager.PlayCoinSound();
            gameManager.AddScore(1);

        }
        else if (collision.CompareTag("Trap")) 
        {
            gameManager.GameOver();
        }
        else if (collision.CompareTag("Enemy"))
        {
            gameManager.GameOver();
        }
        else if (collision.CompareTag("Exit"))
        {
            Destroy(collision.gameObject);
            gameManager.GameWin();

        }
    } 
}
