using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool paused;
    public float health, stamina, mana;
    public GameObject pauseUI;
    public InventoryController inventoryController;
    public Text notificationsText;
    public static GameController instance;

    private void Awake () {
        if(instance == null)
        {
            DontDestroyOnLoad(this);
            instance = this;

        } else if(instance != this) {
            Destroy(gameObject);
        }

        paused = false;
        CursorLock(true);
    }

   private void Update () {
        if(Input.GetButtonDown("Pause"))
        {
            if(inventoryController.inventoryOpen)
            {
                inventoryController.OpenCloseInv();
                
                return;
            }

           Pause();
        }
   }

    public void CursorLock (bool con) {
        Cursor.visible = paused;

       if(con)
       {
            Cursor.lockState = CursorLockMode.Locked;

       } else {
            Cursor.lockState = CursorLockMode.None;
       }
   }

   public void Pause () {
        paused = !paused;

        
        Time.timeScale = paused ? 0 : 1;
        CursorLock(!paused);

        if(!inventoryController.inventoryOpen)
            pauseUI.SetActive(paused);
   }

   public void QuitGame () {
       Debug.Log("Quitting Game");
       Application.Quit();
   }
}
