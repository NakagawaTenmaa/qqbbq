using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class wsLogin : MonoBehaviour
{
    Action<long, string> requestCallback;

    public wsLogin(Action<long, string> _repuest)
    {
        requestCallback = _repuest;
    }

    /// <summary>
    /// リクエスト送信
    /// </summary>
    public IEnumerator PostRequest(string _route, string _name,string _pass)
    {

        WWWForm data = new WWWForm();

        data.AddField("name" ,_name);
        data.AddField("pass", _pass);


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
