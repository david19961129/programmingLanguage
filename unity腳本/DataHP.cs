using UnityEngine;

namespace NEDDY
{
    /// <summary>
    /// 血量設定腳本
    /// </summary>
    [CreateAssetMenu(menuName = "NEDDY/DataHP")]
    public class DataHP : ScriptableObject
    {
        [Header("血量最大值"), Range(0, 5000)]
        public float hpmax = 10;
    }
}

