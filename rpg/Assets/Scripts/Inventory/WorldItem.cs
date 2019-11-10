using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldItem : MonoBehaviour
{
    public bool selected;
    public Item item;
    
    private void Update () {
        if(!selected)
        {
            return;
        }

        GameController.instance.crosshair.SetActive(false);
    }

    public void Select () {
        selected = true;

        string text = "(E) to take:\n" + item.name;
        GameController.instance.Notify(text);

        if(Input.GetButtonDown("Interact"))
        {
            PickUp();
        }
    }

    private void PickUp () {
        GameController.instance.Notify(null);
        GameController.instance.inventoryController.AddItem(item);

        Destroy(this.gameObject);
    }
}
