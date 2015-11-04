using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseManager : MonoBehaviour {

    public GameObject continueText;
    public GameObject quitText;
    public GameObject pauseText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PauseGame()
    {
        Time.timeScale = 0;
        continueText.SetActive(true);
        quitText.SetActive(true);
        pauseText.SetActive(false);
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
        pauseText.SetActive(true);
        quitText.SetActive(false);
        continueText.SetActive(false);
    }

    public void QuitGame()
    {
        Time.timeScale = 1;
        Application.LoadLevel("valikko");
    }
}
