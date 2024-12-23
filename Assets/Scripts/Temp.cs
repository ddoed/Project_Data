using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temp : MonoBehaviour
{
    ItemData currentData;

    public Image image;

    private void Start()
    {
        currentData = GameManager.Instance.Data.GetItemData(3);

        image.sprite = currentData.itemIcon;
    }
}
