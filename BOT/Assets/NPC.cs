using UnityEngine;

public class NPC : MonoBehaviour
{


    /// <summary>
    /// ���:�Ψӹ�ܪ���k�A��NPC���X�T�w�����
    /// </summary>
    /// <param name="content">��ܤ��e</param>
    private void communicate(string content)
    {

    }
    /// <summary>
    /// �}�Ұө�:�T�{�ө��O�_�}��
    /// </summary>
    public bool OpenStore()
    {
        return  true;
    }
    /// <summary>
    /// �ʶR�D��:�T�{���a����w�D�㪺�ʤJ�ƶq
    /// </summary>
    /// <param name="ItemPrice">�D�����</param>
    public int buyitems(int ItemPrice = 100)
    {
        return 0;
    }
    /// <summary>
    /// ���o����:�T�{���a���o������
    /// </summary>
    /// <param name="QuestNum">���Ƚs��</param>
    public void GetQuest(int QuestNum)
    {

    }
    /// <summary>
    /// ���ȧ�s:�ھڪ��a���W�������~���ܧ�T�{�i�ק�s
    /// </summary>
    /// <param name="QuestItem">��o���ȹD��ƶq</param>
    private int QuestUpdate(int QuestItem=1)
    {
        return 0;
    }
    /// <summary>
    /// ���ȧ���:�T�{���a���ȬO�_�w�g����
    /// </summary>
    /// <param name="QuestNum">���Ƚs��</param>
    private bool QuestComplete(int QuestNum)
    {
        return false;
    }
    private void Start()
    {
        print("�ө��}��:"+OpenStore());
        print("�ʶR�D��:"+buyitems());
        print("���ȧ�s:"+QuestUpdate());
        print("���ȧ���:" + QuestComplete(1));
    }
}
