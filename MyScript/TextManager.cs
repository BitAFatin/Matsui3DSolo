using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    public int currentMoney = 0; // �v���C���[�̏�����
    public UnityEngine.UI.Text moneyText; // UI�ɕ\������e�L�X�g

    // ���������Z���A�e�L�X�g���X�V����
    public void AddMoney(int amount)
    {
        currentMoney += amount;
        UpdateMoneyText();
    }

    // �e�L�X�g���X�V����
    private void UpdateMoneyText()
    {
        if (moneyText != null)
        {
            moneyText.text = "������: " + currentMoney.ToString();
        }
    }
}
