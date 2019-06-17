using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonScript : MonoBehaviour
{
    private bool _menuMove = false;

    private bool _menuBack = false;

    public ItemManager itemManager;

    public GameObject expObj;


    

    [SerializeField]
    private GameObject[] _button = new GameObject[5];

    void Start()
    {
        Debug.Log(_button.Length);
    }

    // Update is called once per frame
    void Update()
    {

        if (_button[0].GetComponent<RectTransform>().localPosition.x <= -200)
            if (_menuMove)
                for (int i = 0; i < 5; i++)
                    _button[i].GetComponent<RectTransform>().localPosition += new Vector3(10, 0, 0);

        if (_menuBack)
            for (int i = 0; i < 5; i++)
            {
                _button[i].GetComponent<RectTransform>().localPosition = new Vector3(-600, 560 - (i * 100), 0);
            }
    }
    public void OnClick(int number)
    {
        switch (number)
        {
            case 0:     // メニューボタン
                _menuMove = true;
                _menuBack = false;
                if (_button[0].GetComponent<RectTransform>().localPosition.x >= -200)
                {
                    _menuMove = false;
                    _menuBack = true;
                }
                break;
            case 1:     // 肉ボタン
                itemManager.ChangeTag("meat");
                break;
            case 2:     // 魚ボタン
                itemManager.ChangeTag("fish");
                break;
            case 3:     // 野菜ボタン
                itemManager.ChangeTag("vegetable");
                break;
            case 4:     // ネタボタン
                itemManager.ChangeTag("neta");
                break;
            case 5:     // その他
                itemManager.ChangeTag("other");
                break;
        }


    }


    public void OnCloseExp() {
        expObj.SetActive(false);
    }


}
