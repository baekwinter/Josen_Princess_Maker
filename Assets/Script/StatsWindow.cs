using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsWindow : MonoBehaviour
{
    public Text healthText;
    public Text attackText;
    public Text defenseText;

    private int health = 100;
    private int attack = 10;
    private int defense = 5;

    void Start()
    {
        UpdateStatsUI();
    }

    void UpdateStatsUI()
    {
        healthText.text = "ü��: " + health.ToString();
        attackText.text = "���ݷ�: " + attack.ToString();
        defenseText.text = "����: " + defense.ToString();
    }

    // ������ �����ϴ� ���� �޼ҵ�
    public void IncreaseHealth(int amount)
    {
        health += amount;
        UpdateStatsUI();
    }

    public void IncreaseAttack(int amount)
    {
        attack += amount;
        UpdateStatsUI();
    }

    public void IncreaseDefense(int amount)
    {
        defense += amount;
        UpdateStatsUI();
    }
}
