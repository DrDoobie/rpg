using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchTrigger : MonoBehaviour
{
    public string scene;

    private void OnTriggerEnter (Collider other) {
        if(other.tag == "Player")
        {
            SavePlayerData();
            SceneManager.LoadScene(scene);
        }
    }

    public void SavePlayerData () {
        GameController.instance.health = FindObjectOfType<PlayerStats>().health;
        GameController.instance.stamina = FindObjectOfType<PlayerStats>().stamina;
        GameController.instance.mana = FindObjectOfType<PlayerStats>().mana;
    }
}
