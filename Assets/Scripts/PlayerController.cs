using UnityEngine;
using static UnityEditor.Progress;

public class PlayerController : MonoBehaviour
{
    private int currentItemIndex = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SwitchItem(-1);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            SwitchItem(1);
        }
    }

    void SwitchItem(int direction)
    {
        currentItemIndex = (currentItemIndex + direction + InventoryManager.instance.inventory.Count) % InventoryManager.instance.inventory.Count;
        Item currentItem = InventoryManager.instance.inventory[currentItemIndex];
 
    }
}
