using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ItemController : MonoBehaviour
{
    private int id = 0;
    private string name = "";
    private int price = 0;
    private string exp = "";

    public Text nameText;
    public Text priceText;

    public Button expButton;
    public Button buyButton;

    private Action<int, int> buyActionCallBack;
    private Action<string> expActionCallBack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SetData(int _id, string _name, int _price, string _exp) {
        id = _id;
        name = _name;
        nameText.text = name;
        price = _price;
        priceText.text = price.ToString();
        exp = _exp;
    }

    public void SetButtonAction(Action<int,int> _buy,Action<string> _exp) {
        buyActionCallBack = _buy;
        expActionCallBack = _exp;
    }


    public void OnBuyButton() {
        buyActionCallBack(id, price);
    }

    public void OnExpButton() {
        expActionCallBack(exp);
    }

}
