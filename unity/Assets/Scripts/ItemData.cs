using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct ItemData
{
    public int id;
    public string name;
    public int price;
    public string exp;
    public string tag;

    public ItemData(int _id,string _name,int _price,string _exp,string _tag) {
        id = _id;
        name = _name;
        price = _price;
        exp =_exp;
        tag = _tag;
    }
}