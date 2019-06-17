//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class ButtonManager : MonoBehaviour
//{
//    private ButtonScript _buttonScript;

//    private bool _menuMove = false;

//    public float _positionX = 0;

//    ////[SerializeField]
//    ////public GameObject[] _button;

//    public float GetPositionX()
//    {
//        return _positionX;
//    }

//    // Start is called before the first frame update
//    void Start()
//    {
//        _buttonScript = gameObject.GetComponent<ButtonScript>();
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        _positionX = _button[0].GetComponent<RectTransform>().localPosition.x;
//        //_menuMove = _buttonScript.GetMenuMove();
//        Debug.Log(_menuMove);

//        if (_button[0].GetComponent<RectTransform>().localPosition.x < -200)
//            if (_menuMove)
//                for (int i = 0; i < 5; i++)
//                    _button[i].GetComponent<RectTransform>().localPosition += new Vector3(10, 0, 0);

//        if (!_menuMove)
//        {
//            _button[0].GetComponent<RectTransform>().localPosition = new Vector3(-600, 560, 0);
//            _button[1].GetComponent<RectTransform>().localPosition = new Vector3(-600, 460, 0);
//            _button[2].GetComponent<RectTransform>().localPosition = new Vector3(-600, 360, 0);
//            _button[3].GetComponent<RectTransform>().localPosition = new Vector3(-600, 260, 0);
//            _button[4].GetComponent<RectTransform>().localPosition = new Vector3(-600, 160, 0);
//        }
//    }
//}
