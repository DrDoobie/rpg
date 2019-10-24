using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool paused;
    public GameObject pauseUI;

   private void Update () {
       CursorController();
       PauseController();
   }

   private void CursorController () {
       Cursor.lockState = CursorLockMode.Locked;
       Cursor.visible = false;
   }

   private void PauseController () {
       if(Input.GetButtonDown("Pause"))
       {
           paused = !paused;
       }

       if(paused)
       {
           Pause(true);

       } else {
           Pause(false);
       }
   }

   public void Pause (bool con) {
       if(con)
       {
            Time.timeScale = 0.0f;
            pauseUI.SetActive(false);

       } else {
            Time.timeScale = 1.0f;
            pauseUI.SetActive(true);
       }
   }
}
