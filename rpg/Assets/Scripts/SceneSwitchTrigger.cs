using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitchTrigger : MonoBehaviour
{
    public string scene;
    public Image fadeScreen;
    public Animator anim;

    private void OnTriggerEnter (Collider other) {
        if(other.tag == "Player")
        {
            StartCoroutine(Fade());
        }
    }

    public void SavePlayerData () {
        GameController.instance.health = FindObjectOfType<PlayerStats>().health;
        GameController.instance.stamina = FindObjectOfType<PlayerStats>().stamina;
        GameController.instance.mana = FindObjectOfType<PlayerStats>().mana;
    }

    private void SwitchScene () {
        SavePlayerData();
        SceneManager.LoadScene(scene);
    }

    private IEnumerator Fade () {
        anim.Play("Fade_Out");

        yield return new WaitForSeconds(1.0f);

        anim.Play("Fade_In");
        SwitchScene();
    }
}
