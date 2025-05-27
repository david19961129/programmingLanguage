using Fungus;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NEDDY
{
    /// <summary>
    /// 遊戲初始畫面腳本、加遊戲初始對話框顯示
    /// </summary>
    public class GameStart : MonoBehaviour
    {
        public Flowchart flowchart;
        public string messageName = "遊戲開始對話";
        public GameObject titleUI;
        public void StartGame()
        {
            //SceneManager.LoadScene("遊戲開始封面"); // 這裡替換成你的遊戲場景名稱
            Debug.Log("123");
            titleUI.SetActive(false);
            flowchart.SendFungusMessage(messageName);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}

