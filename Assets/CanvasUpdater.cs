using System;
using TMPro;
using UnityEngine;

public class CanvasUpdater : MonoBehaviour
{
    [SerializeField] Inventory inventory;
    [SerializeField] private TMP_Text diamondTextAmount;
    [SerializeField] private TMP_Text goldTextAmount;


    private void Start()
    {
        inventory.ONCanvasUpdate += InventoryOnONCanvasUpdate;
    }


    private void OnDisable()
    {
        inventory.ONCanvasUpdate -= InventoryOnONCanvasUpdate;
    }



    private void InventoryOnONCanvasUpdate(int diamondAmmount, int goldAmmount)
    {
        diamondTextAmount.text = diamondAmmount.ToString();
        goldTextAmount.text = goldAmmount.ToString();
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



