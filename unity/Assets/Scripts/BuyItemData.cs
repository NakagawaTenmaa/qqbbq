using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyItemData : MonoBehaviour
{
    public Text name;
    public Text prict;
    public Text num;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetData(string _name , string _price,string _num) {
        name.text = _name;
        prict.text = _price;
        num.text = _num;
    }
}
