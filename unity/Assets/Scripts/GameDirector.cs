using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    [SerializeField]
    ButtonController button;

    [SerializeField]
    GameObject sum;

    [SerializeField]
    GameObject num;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 合計金額を格納
        int Sum = button.getSum();
        this.sum.GetComponent<Text>().text =
            "合計:" + Sum + "円";

        // 合計点数を格納
        int Num = button.getNum();
        this.num.GetComponent<Text>().text =
            "合計:" + Num + "点";

    }
}
