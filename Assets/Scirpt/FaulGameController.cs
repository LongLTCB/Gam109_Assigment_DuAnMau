using UnityEngine;

public class FaulGameController : MonoBehaviour
{
    public GameObject pauseMenuUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            
            //neu hien len thi an di
            if (pauseMenuUI.activeSelf == false )
            {
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0;
            } else
            {
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1;
            }
        }

    }
}
