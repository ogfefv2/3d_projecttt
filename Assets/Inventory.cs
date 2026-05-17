using System;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int _diamondAmmount;
    public event Action<int> ONCanvasUpdate;


    public void AddDiamond()
    {
        _diamondAmmount++;
        ONCanvasUpdate?.Invoke(_diamondAmmount);
        Debug.Log(_diamondAmmount);
    }
}
