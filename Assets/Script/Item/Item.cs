using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
   private ItemData data { get; set; }
   [SerializeField] 
   private TextMeshProUGUI priceText;

   public float weight;
   public bool isStackable;
   public int amount = 1;
   private void Start()
   {
      priceText.text = data.price;
   }
}
