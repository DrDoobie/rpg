using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public bool inventoryOpen;
    private GameObject inventoryUI;
    GameController gameController;

    private void Awake () {
        inventoryUI = GameObject.FindWithTag("InventoryUI");
        gameController = FindObjectOfType<GameController>();

        inventoryUI.SetActive(false);
    }

    private void Update ()
    {
        Controller();
    }

    private void Controller () {
        if(Input.GetButtonDown("Inventory") && !(gameController.pauseUI.activeInHierarchy))
        {
            OpenCloseInv();
        }
    }

    public void OpenCloseInv () {
        inventoryOpen = !inventoryOpen;

        gameController.Pause();
        inventoryUI.SetActive(inventoryOpen);
    }
}
