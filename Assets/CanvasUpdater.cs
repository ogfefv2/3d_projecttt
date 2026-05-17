using System;
using TMPro;
using UnityEngine;

public class CanvasUpdater : MonoBehaviour
{
    [SerializeField] Inventory inventory;
    [SerializeField]private TMP_Text diamondTextAmount;


    private void Start()
    {
        inventory.ONCanvasUpdate += InventoryOnONCanvasUpdate;
    }
    private void OnDisable()
    {
        inventory.ONCanvasUpdate -= InventoryOnONCanvasUpdate;
    }



    private void InventoryOnONCanvasUpdate(int diamondAmmount)
    {
        diamondTextAmount.text = diamondAmmount.ToString();
    }


    }









//private void Start()
//{
//    inventory.ONCanvasUpdate += InventoryOnONCanvasUpdate;
//}

//private void InventoryOnONCanvasUpdate(int obj)
//{
//    throw new NotImplementedException();
//}
//}



