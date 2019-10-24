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
       }

       if(paused) 
       {
           Pause();

       } else {
           Unpause();
       }
   }

   public void Pause () {
       Time.timeScale = 0.0f;
       CursorLock(false);
       pauseUI.SetActive(true);

       paused = true;
   }

   public void Unpause () {
       Time.timeScale = 1.0f;
       CursorLock(true);
       pauseUI.SetActive(false);

       paused = false;
   }

   public void QuitGame () {
       Debug.Log("Quitting Game");
       Application.Quit();
   }
}
