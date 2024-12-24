using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIItemSlot : MonoBehaviour
{
    [SerializeField] UIItemElementView[] itemSlotViews;

    private int currentSlotNumber = 0;

    private void Start()
    {
        foreach(var item in itemSlotViews)
        {
            item.onEndSpin += PlaySlot;
        }
        PlaySlot(itemSlotViews[0]);
    }
    
    public void PlaySlot(UIItemElementView itemView)
    {
        if (currentSlotNumber >= itemSlotViews.Length) return;

        itemView = itemSlotViews[currentSlotNumber];
        currentSlotNumber++;
        StartCoroutine(itemView.SpinItem());
    }
}
