using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : EventTrigger {

    float offsetX, offsetY;

    public void BeginDrag () {
        offsetX = transform.position.x - Input.mousePosition.x;
        offsetY = transform.position.y - Input.mousePosition.y;
    }

    public void OnDrag () {
        transform.position = new Vector2(offsetX + Input.mousePosition.x, offsetY + Input.mousePosition.y);
    }
}
