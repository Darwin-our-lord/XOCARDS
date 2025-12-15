using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject mainUI;
    public GameObject deckBuilderUI;
    //button functions
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
    public void DeckBuilderButton()
    {
        mainUI.gameObject.SetActive(false);
        deckBuilderUI.gameObject.SetActive(true);
    }
    public void BackButton()
    {
        mainUI.gameObject.SetActive(true);
        deckBuilderUI.gameObject.SetActive(false);
    }

}
