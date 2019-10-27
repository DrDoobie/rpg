using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public bool inventoryOpen;
    public GameObject inventoryUI;
    GameController gameController;

    private void Start () {
        gameController = FindObjectOfType<GameController>();
        inventoryUI.SetActive(false);
    }

    private void Update ()
    {
        Controller();
    }

    private void Controller () {
        if(Input.GetButtonDown("Inventory"))
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
