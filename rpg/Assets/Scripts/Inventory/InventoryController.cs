using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public bool inventoryOpen;
    public GameObject inventoryUI, content;
    public List<Item> items = new List<Item>();
    GameController gameController;

    private void Awake () {
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

    public void AddItem (Item item) {
        items.Add(item);
    }
}
