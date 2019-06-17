using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public bool menuMove;

    int money; // 金額

    public int sum; // 合計金額

    public int num; // 点数

    public int getSum()
    {
        return sum;
    }

    public int getNum()
    {
        return num;
    }

    public bool getMenuMove()
    {
        return menuMove;
    }
    
    public void OnClick(int number)
    {
        switch (number)
        {
            case 0:     // メニューボタン
                Debug.Log("メニュー");
                menuMove = true;
                break;
            case 1:     // 肉ボタン
                Debug.Log("肉");
                break;
            case 2:     // 魚ボタン
                Debug.Log("魚");
                break;
            case 3:     // 野菜ボタン
                Debug.Log("野菜");
                break;
            case 4:     // ネタボタン
                Debug.Log("ネタ");
                break;
            case 5:     // その他
                Debug.Log("その他");
                break;
            case 6:     // 詳細1ボタン
                Debug.Log("詳細1");
                break;
            case 7:     // カート1ボタン
                Debug.Log("カート1");
                money = 1000;
                sum += money;
                num++;
                break;
            case 8:     // 詳細2
                Debug.Log("詳細2");
                break;
            case 9:     // カート2ボタン
                Debug.Log("カート2");
                money = 1000;
                sum += money;
                num++;
                break;
            case 10:     // 詳細3
                Debug.Log("詳細3");
                break;
            case 11:     // カート3
                Debug.Log("カート3");
                money = 1000;
                sum += money;
                num++;
                break;
            case 12:     // 詳細4
                Debug.Log("詳細4");
                break;
            case 13:     // カート4
                Debug.Log("カート4");
                money = 1000;
                sum += money;
                num++;
                break;
            case 14:     // 詳細5
                Debug.Log("詳細5");
                break;
            case 15:     // カート5
                Debug.Log("カート5");
                money = 1000;
                sum += money;
                num++;
                break;
            case 16:     // 会計
                Debug.Log("会計");
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
