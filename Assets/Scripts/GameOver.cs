using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void RestartGame()
    {
        // Reinicia a cena atual
        SceneManager.LoadScene(PlayerPrefs.GetInt("CurrentLevel", 0));
    }

    public void QuitToMainMenu()
    {
        // Vai para o menu principal (defina a cena do menu principal como índice 0)
        SceneManager.LoadScene(0);
    }
}
