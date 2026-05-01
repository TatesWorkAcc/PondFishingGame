using UnityEngine.UI;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour
{
    [SerializeField] InputAction openInventory;
    [SerializeField] GameObject mainInventoryUI;
    bool mainInventoryUIOpen;
    void Start()
    {
        openInventory.Enable();
        mainInventoryUIOpen = false;
        mainInventoryUI.SetActive(false);
    }

    void Update()
    {
        if (openInventory.WasPressedThisFrame())
        {
            if (!mainInventoryUIOpen)
            {
                Debug.Log("Inventory is closed, opening");

                mainInventoryUI.SetActive(true);
                mainInventoryUIOpen = true;

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                return;
            }
            if (mainInventoryUIOpen)
            {
                Debug.Log("Invetory is already open, closing");

                mainInventoryUI.SetActive(false);
                mainInventoryUIOpen = false;

                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;

                return;
            }

        }
    }
}
