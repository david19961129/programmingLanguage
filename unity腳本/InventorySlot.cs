﻿using UnityEngine;
using UnityEngine.UI;

namespace NEDDY
{
    /// <summary>
    /// 背包腳本設定[背包/父物件>口袋/子物件>]
    /// 口袋/子物件、
    /// 確認各個口袋/子物件是否佔用狀態
    /// 確認口袋/子物件 使用的UI圖片正確
    /// </summary>
    [System.Serializable]
    public class InventorySlot : MonoBehaviour
    {
        public bool 佔用狀態 = false; // 子物件的狀態

        void Update()
        {
            // 檢查是否有子物件
            佔用狀態 = transform.childCount > 0;

            // 如果有物品，確保 UI 圖示正確
            if (佔用狀態)
            {
                Item item = transform.GetChild(0).GetComponent<Item>();
                if (item != null)
                {
                    GetComponent<Image>().sprite = item.icon;
                    GetComponent<Image>().enabled = true;
                }
            }
            else
            {
                GetComponent<Image>().sprite = null;
                GetComponent<Image>().enabled = false;
            }
        }
    }
}
