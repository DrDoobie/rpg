 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{
    public bool isEnabled;
    private Transform player;
    private Vector3 dir; 

    private void Start () {
        player = GameObject.FindWithTag("Player").transform;
    }

    private void Update () {
        if(Input.GetButtonDown("Compass"))
        {
            isEnabled = !isEnabled;
        }

        Controller();
    }

    private void Controller () {
        if(isEnabled)
        {
            GetComponent<Image>().enabled = true;

            dir.z = player.eulerAngles.y;
            transform.localEulerAngles = dir;

            return;
        }

        GetComponent<Image>().enabled = false;
    }
}
