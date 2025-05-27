using UnityEngine;


namespace NEDDY
{
    /// <summary>
    /// 觸發場景特效與範圍腳本，
    /// <returns></returns>
    
    public class TriggerLightEffect : MonoBehaviour
    {
        public GameObject 全域空間_場景特效; // 光源特效对象
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            // 检查进入触发区域的对象是否是玩家
            if (other.CompareTag("Player"))
            {

                // 开启光源特效
                全域空間_場景特效.SetActive(true);
                Debug.Log("进入触发区域，光源特效已开启。");
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            // 检查离开触发区域的对象是否是玩家
            if (other.CompareTag("Player"))
            {
                // 关闭光源特效
                全域空間_場景特效.SetActive(false);
                Debug.Log("离开触发区域，光源特效已关闭。");
            }
        }
    }
}
