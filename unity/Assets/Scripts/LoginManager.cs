using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoginManager : MonoBehaviour
{
    // ユーザー名
    public Text usernameText;
    // パスワード
    public Text passwordText;
    private wsLogin ws;
    public string url;
    private long result = 0;

    // Start is called before the first frame update
    void Start()
    {
        ws = new wsLogin(RequestCallBack);
    }


    /// <summary>
    /// ログイン
    /// </summary>
    public void OnLogin() {
        StartCoroutine(ws.PostRequest("http://" + url + ":10000/api/login", usernameText.text,passwordText.text));
    }

    /// <summary>
    /// ユーザー作成
    /// </summary>
    public void OnCreate() {
        StartCoroutine(ws.PostRequest("http://" + url + ":10000/api/create", usernameText.text, passwordText.text));
    }

    void RequestCallBack(long _result, string _data){
        result = _result;
        if (result == 200) {
            UserRes res = JsonUtility.FromJson<UserRes>(_data);
            UserData.user_id = res.id;
            // シーンの変更
            SceneManager.LoadScene("MeatScene");
        }
    }

}