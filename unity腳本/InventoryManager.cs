﻿using UnityEngine;

namespace NEDDY
{
    /// <summary>
    /// 背包腳本設定[背包/父物件>口袋/子物件]
    /// 背包/父物件、開關背包列表UI
    /// </summary>
    public class InventoryManager : MonoBehaviour
    {
        public GameObject inventoryUI; // 背包 UI
        public static InventoryManager Instance;
        public Transform itemSlotsParent; // 口袋的父物件（背包 UI）
        
        public InventorySlot[] slots;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        private void Update()
        {
            // 按 Tab 键打开/关闭背包
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                inventoryUI.SetActive(!inventoryUI.activeSelf);
            }
        }

    }
}
