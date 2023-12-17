using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject creditsImage;

    public void PlayButtonPressed()
    {
        SceneManager.LoadScene("The Skeld", LoadSceneMode.Single);
    }

    public void ExitButtonPressed()
    {
        Application.Quit();
    }

    public void IntroSceneButtonPressed()
    {
        SceneManager.LoadScene("Intro", LoadSceneMode.Additive);
    }

    public void CreditsButtonPressed()
    {
        if (creditsImage.activeInHierarchy)
            creditsImage.SetActive(false);
        else
            creditsImage.SetActive(true);
    }
}
