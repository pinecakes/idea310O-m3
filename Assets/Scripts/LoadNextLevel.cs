using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour {

    public string LevelToLoad = "Level2-Green";
    
    private void OnTriggerEnter(Collider other) {

        if(other.CompareTag("Player")) {
            Debug.Log("NextLevel executed");
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
