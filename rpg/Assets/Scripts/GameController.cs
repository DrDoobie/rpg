using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool paused;
    public GameObject pauseUI;

   private void Update () {
        PauseController();
   }

    public void CursorLock (bool con) {
       if(con)
       {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

       } else {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
       }
   }

   private void PauseController () {
       if(Input.GetButtonDown("Pause"))
       {
           paused = !paused;

           pauseUI.SetActive(paused);
           Time.timeScale = paused ? 0 : 1;
           CursorLock(!paused);
       }
   }

   public void QuitGame () {
       Debug.Log("Quitting Game");
       Application.Quit();
   }
}
