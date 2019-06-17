using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class InputManager : MonoBehaviour
{
    InputField inputField;
    private wsLogin ws;
    public string url;
    private long result = 0;

    /// <summary>
    /// Startメソッド
    /// InputFieldコンポーネントの取得および初期化メソッドの実行
    /// </summary>
    void Start()
    {
        ws = new wsLogin(RequestCallBack);
        inputField = GetComponent<InputField>();

        InitInputField();
    }



    /// <summary>
    /// Log出力用メソッド
    /// 入力値を取得してLogに出力し、初期化
    /// </summary>


    public void InputLogger()
    {

        string inputValue = inputField.text;
        StartCoroutine(ws.PostRequest("http://" + url + ":10000/api/create", inputValue, ""));

        Debug.Log(inputValue);

        InitInputField();
    }



    /// <summary>
    /// InputFieldの初期化用メソッド
    /// 入力値をリセットして、フィールドにフォーカスする
    /// </summary>


    void InitInputField()
    {

        // 値をリセット
        inputField.text = "";

        // フォーカス
        inputField.ActivateInputField();
    }


    void RequestCallBack(long _result, string _data)
    {
        result = _result;
        if (result == 200)
        {
            UserRes res = JsonUtility.FromJson<UserRes>(_data);
            UserData.user_id = res.id;
            // シーンの変更
            SceneManager.LoadScene("MeatScène");
        }
    }
}


public struct UserRes
{
    public int id;
}