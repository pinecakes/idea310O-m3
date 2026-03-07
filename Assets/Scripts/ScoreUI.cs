using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreUI : MonoBehaviour {

    private int Score = 0;

    public TextMeshProUGUI ScoreText;

    public void IncreaseScore() {
        Score++;
        ScoreText.text = "Blorbs: " + Score + "/5";
    }

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update() {
        if (Keyboard.current.escapeKey.wasPressedThisFrame) {
            Debug.Log("Escape to menu called");
            SceneManager.LoadScene("MenuScene");
        }
    }

}
