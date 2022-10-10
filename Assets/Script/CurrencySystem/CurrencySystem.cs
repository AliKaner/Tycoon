using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrencySystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    private int _money;
    private void Awake()
    {
        RefreshText();
    }
    
    public void IncreaseCurrency(int amount)
    {
        PlayerPrefs.SetInt("Money",PlayerPrefs.GetInt("Money",100) + amount);
        Debug.Log($"money increases amount of: {amount}");
        RefreshText();
    }

    public void DecreaseCurrency(int amount)
    {
        PlayerPrefs.SetInt("Money",PlayerPrefs.GetInt("Money",100) - amount);
        Debug.Log($"money decreases amount of: {amount}");
        RefreshText();
    }

    private void RefreshText()
    {
        text.text = PlayerPrefs.GetInt("Money", 100).ToString();
    }
}
