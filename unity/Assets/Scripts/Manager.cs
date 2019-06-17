using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private BuyItem ws;
    private long result = 0;

    public string url;

    private ItemManager itemManager;

    /// <summary>
    /// 初期化 
    /// </summary>
    void Start() {
        ws = new BuyItem(RequestCallBack);
        itemManager = GetComponent<ItemManager>();
    }

    /// <summary>
    /// 注文確定
    /// </summary>
    public void Enter() {
        List<Item> itemList = itemManager.GetBuyItem();
        foreach (var item in itemList) { 
            StartCoroutine(ws.PostRequest("http://" + url + ":10000/api/order", item));
        }
    }



    void RequestCallBack(long _result,string _data) {
        result = _result;
       
        //if(result == 200)  JsonUtility.FromJson<>(_data);
    }

}
