using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldItem : MonoBehaviour
{
    public bool inRange;
    public string itemName;
    public GameObject obj;

    private void Update () {
        Controller();
    }

    private void Controller () {
        if(inRange)
        {
            GameController.instance.notificationsText.text = "'e' to pick up " + itemName;
            GameController.instance.notificationsText.text = "'e' to pick up " + itemName;

            if(Input.GetButtonDown("Interact"))
            {
                PickUp();
            }

            return;
        }

        GameController.instance.notificationsText.text = null;
    }

    private void OnTriggerEnter (Collider other) {
        if(other.tag == "Player")
        {
            inRange = true;
        }
    }

    private void OnTriggerExit (Collider other) {
        if(other.tag == "Player")
        {
            inRange = false;
        }
    }

    private void PickUp () {
        GameController.instance.notificationsText.text = null;
        GameController.instance.inventoryController.AddItem(obj);
        
        Destroy(this.gameObject);
    }
}
