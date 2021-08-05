using UnityEngine;

public class NPC : MonoBehaviour
{


    /// <summary>
    /// 對話:用來對話的方法，讓NPC說出固定的對話
    /// </summary>
    /// <param name="content">對話內容</param>
    private void communicate(string content)
    {

    }
    /// <summary>
    /// 開啟商店:確認商店是否開啟
    /// </summary>
    public bool OpenStore()
    {
        return  true;
    }
    /// <summary>
    /// 購買道具:確認玩家對指定道具的購入數量
    /// </summary>
    /// <param name="ItemPrice">道具價錢</param>
    public int buyitems(int ItemPrice = 100)
    {
        return 0;
    }
    /// <summary>
    /// 取得任務:確認玩家取得的任務
    /// </summary>
    /// <param name="QuestNum">任務編號</param>
    public void GetQuest(int QuestNum)
    {

    }
    /// <summary>
    /// 任務更新:根據玩家身上相關物品的變更確認進度更新
    /// </summary>
    /// <param name="QuestItem">獲得任務道具數量</param>
    private int QuestUpdate(int QuestItem=1)
    {
        return 0;
    }
    /// <summary>
    /// 任務完成:確認玩家任務是否已經完成
    /// </summary>
    /// <param name="QuestNum">任務編號</param>
    private bool QuestComplete(int QuestNum)
    {
        return false;
    }
    private void Start()
    {
        print("商店開啟:"+OpenStore());
        print("購買道具:"+buyitems());
        print("任務更新:"+QuestUpdate());
        print("任務完成:" + QuestComplete(1));
    }
}
