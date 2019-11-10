using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public bool inventoryOpen;
    public GameObject inventoryUI;
    public Text inventoryText;
    public string invString;
    public Transform content;
    public List<Item> items = new List<Item>();
    GameController gameController;

    private void Awake () {
        gameController = FindObjectOfType<GameController>();

        inventoryUI.SetActive(false);

        UpdateText();
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
    
    private void UpdateText () {
        inventoryText.text = invString + items.Count;
    }

    public void OpenCloseInv () {
        inventoryOpen = !inventoryOpen;

        gameController.Pause();
        inventoryUI.SetActive(inventoryOpen);
    }

    public void AddItem (Item item) {
        items.Add(item);

        GameObject go = Instantiate(item.itemObj);
        go.transform.SetParent(content, false);
        
        UpdateText();
    }
}
