using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public int moneyReward = 10; // �|�����Ƃ��ɓ����邨���̊z
    public TextManager textManager; // �e�L�X�g�X�V�p�̎Q��

    // �G���|���ꂽ�Ƃ�
    public void Die()
    {
        // �e�L�X�g���X�V���Ă��������Z
        if (textManager != null)
        {
            textManager.AddMoney(moneyReward);
        }
    }
}
