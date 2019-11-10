using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    public Camera cam;
    public Transform selected;
    public float range;

    private void Update() {
        if(selected != null)
        {
            selected.GetComponent<WorldItem>().selected = false;

            GameController.instance.crosshair.SetActive(true);
            GameController.instance.Notify(null);

        }

        RaycastHit hit;
        
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            if(hit.transform.tag == "Selectable")
            {
                selected = hit.transform;

                if(hit.transform.GetComponent<WorldItem>())
                {
                    hit.transform.GetComponent<WorldItem>().Select();
                }
            }
        }
    }
}
