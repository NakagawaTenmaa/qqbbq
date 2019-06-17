using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BuyItem : MonoBehaviour
{
    Action<long, string> requestCallback;

    public BuyItem(Action<long, string> _repuest) {
        requestCallback = _repuest;
    }

    /// <summary>
    /// リクエスト送信
    /// </summary>
    public IEnumerator PostRequest(string _route, Item _items)
    {

        WWWForm data = new WWWForm();

        string json = JsonUtility.ToJson(_items);
         
        Debug.Log(json);
        // 注文リストの作成
        data.AddField("items", json);


        Dictionary<string, string> headers = data.headers;
        UnityWebRequest request = UnityWebRequest.Post(_route, data);
        yield return request.SendWebRequest();
        // 結果出力
        if (request.isHttpError || request.isNetworkError)
        {
            requestCallback(401, "");
            Debug.Log(request.error);
        }
        else
        {
            // 結果の設定
            requestCallback(request.responseCode, request.downloadHandler.text);
            Debug.Log(request.responseCode);
        }
    }
}