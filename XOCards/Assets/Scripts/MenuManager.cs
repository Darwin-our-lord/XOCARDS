using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject mainUI;
    public GameObject deckBuilderUI;

    public Player playerX;
    public Player playerO;
    public Player ActivePlayer;

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

    public void PlayerXButton()
    {
        ActivePlayer = playerX;
        deckBuilderUI.GetComponent<DeckUI>().UpdateDeckVisuals(playerX);
    }
    public void PlayerOButton()
    {
        ActivePlayer = playerO;
        deckBuilderUI.GetComponent<DeckUI>().UpdateDeckVisuals(playerO);
    }


}
