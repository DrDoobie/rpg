using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
   private void Update () {
       CursorController();
   }

   private void CursorController () {
       Cursor.lockState = CursorLockMode.Locked;
       Cursor.visible = false;
   }
}
