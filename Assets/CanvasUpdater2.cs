using TMPro;
using UnityEngine;

public class CanvasUpdater2 : MonoBehaviour
{
    [SerializeField] Inventory inventory;
    [SerializeField] private TMP_Text diamondTextAmount;


    private void OnEnable()
    {
        inventory.ONCanvasUpdate += InventoryOnCanvasUpdate;
    }



    private void OnDisable()
    {
        inventory.ONCanvasUpdate -= InventoryOnCanvasUpdate;
    }



    private void InventoryOnCanvasUpdate(int ammoutDiamonds)
    {
        diamondTextAmount.text = ammoutDiamonds.ToString();
    }
}
