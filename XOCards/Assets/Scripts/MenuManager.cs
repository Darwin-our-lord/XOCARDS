using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{


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


}
