using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {
    public string StartLevel = "Level1-Blue";

    public void StartGame() {
        SceneManager.LoadScene(StartLevel);
    }

    public void QuitGame() {
        Application.Quit();
    }

    void Start() {
        Cursor.lockState = CursorLockMode.None;
    }
}
