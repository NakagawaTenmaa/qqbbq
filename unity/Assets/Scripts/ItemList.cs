using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 商品
/// </summary>
[SerializeField]
public class Item
{
    [SerializeField]
    public int userid;
    [SerializeField]
    public int id;
    [SerializeField]
    public int num;

    public Item(int _id,int _userid,int _num) {
        id = _id;
        num = _num;
        userid = _userid;
    }
}