using UnityEngine;

public class CollectBlorb : MonoBehaviour {
    
    private void OnTriggerEnter(Collider other) {

        if(other.CompareTag("Player")) {
            Debug.Log("Blorb Collected");

            FindFirstObjectByType<ScoreUI>().IncreaseScore();

            Destroy(gameObject);
        }
    }
}
