﻿using UnityEngine;
using UnityEngine.UI;

namespace NEDDY
{
    /// <summary>
    /// 背包腳本設定[背包/父物件>口袋/子物件>]
    /// 道具設定對應UI圖片、名稱、物品描述
    /// 確認各個口袋/子物件是否佔用狀態
    /// </summary>
    
    public class Item : MonoBehaviour
    {
        public string itemName;   // 道具名稱
        public Sprite icon;       // 道具縮圖
        public string description; // 道具描述

        private GameObject player;
        private InventoryManager inventoryManager;

        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
            inventoryManager = GameObject.FindObjectOfType<InventoryManager>();
        }

        void Update()
        {
            CheckPickupLetter(); // 每幀檢查是否撿起道具
        }

        private void CheckPickupLetter()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                float distanceToLetter = Vector3.Distance(transform.position, player.transform.position);
                if (distanceToLetter < 2.0f)
                {
                    PlaceItemInPocket(); // 找到合適的口袋並存放道具
                }
            }
        }

        private void PlaceItemInPocket()
        {
            if (inventoryManager == null || inventoryManager.itemSlotsParent == null)
            {
                Debug.LogError("InventoryManager 或 itemSlotsParent 未正確設置！");
                return;
            }

            var slots = inventoryManager.slots;

            // foreach (Transform pocket in inventoryManager.itemSlotsParent) // 遍歷所有口袋
            foreach (InventorySlot slot in slots) // 遍歷所有口袋
            {
                // InventorySlot slot = pocket.GetComponent<InventorySlot>(); // 獲取口袋的狀態腳本
                if (slot != null && !slot.佔用狀態) // 如果口袋是空的
                {
                    Debug.Log($"將 {itemName} 放入 {slot.name}");
                    transform.SetParent(slot.transform, false); // 設置道具為該口袋的子物件
                    transform.localPosition = Vector3.zero; // 重設位置

                    slot.佔用狀態 = true; // 設置口袋為已佔用
                    slot.GetComponent<Image>().sprite = icon; // 直接更新 UI
                    slot.GetComponent<Image>().enabled = true; // 確保顯示

                    gameObject.SetActive(false); // 撿起後隱藏

                    Debug.Log($"道具 {itemName} 已存入 {slot.name}");
                    return; // 成功放入後，結束函式
                }
            }

            Debug.Log("所有口袋已滿，無法存放道具！");
        }
    }
}
