using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    bool isPaused = false;
    [SerializeField] GameObject Menu;

    public void Continue()
    {
        Debug.Log("Continued");
        Time.timeScale = 1;
        Menu.SetActive(false);
        isPaused = false;
    }
    public void Options()
    {

    }

    public void QuitSession()
    {
        SceneManager.LoadScene(0);
    }
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (isPaused)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }

    }

    private void Pause()
    {
        Time.timeScale = 0;
        Menu.SetActive(true);
        isPaused = true;
        Debug.Log("Paused");
    }
}
