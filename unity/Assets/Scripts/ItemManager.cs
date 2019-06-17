using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public GameObject preItem;
    public GameObject itemList;

    public Text resultText;
    public Text countText;
    public Text expText;
    public GameObject expObj;
    public Text labelText;

    private List<GameObject> objList = new List<GameObject>();

    Dictionary<int, int> selectItem = new Dictionary<int, int>();

    int result = 0;
    int count = 0;

    public GameObject eneterObj;
    public GameObject buyTextPre;
    public GameObject buyParent;
    private List<GameObject> buyList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        resultText.text = "0 円";
        countText.text = "0 点";

        Items.CreateItem();

        foreach (var item in Items.GetItemTag("meat"))
        {
            var obj = GameObject.Instantiate<GameObject>(preItem, itemList.transform);
            obj.GetComponent<ItemController>().SetData(item.id, item.name, item.price, item.exp);
            obj.GetComponent<ItemController>().SetButtonAction(BuyActionCallBack, ExpActionCallBack);
            objList.Add(obj);
        }
        labelText.text = "肉";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick() {

    }

    public void BuyActionCallBack(int _id,int _price) {
        if (!selectItem.ContainsKey(_id)) selectItem.Add(_id, 0);

        selectItem[_id]++;
        count++;
        result += _price;

        Debug.Log("商品がカートに追加されました >> id : " + _id.ToString() + "  :  price : " + _price);
        Debug.Log("現在の合計金額は" + result.ToString() + "円です");

        var debug = Items.GetItem(_id);
        Debug.Log("id : " + debug.id.ToString() + "  name : " + debug.name + "  price : " + debug.price + "  exp  : " + debug.exp);

        countText.text = count.ToString() + " 点";
        resultText.text = result.ToString() + " 円";
    }

    public void ExpActionCallBack(string _exp) {
        expObj.SetActive(true);
        expText.text = _exp;        
    }

    public void ChangeTag(string _tag) {
        ClearObjList();
        foreach (var item in Items.GetItemTag(_tag))
        {
            var obj = GameObject.Instantiate<GameObject>(preItem, itemList.transform);
            obj.GetComponent<ItemController>().SetData(item.id, item.name, item.price, item.exp);
            obj.GetComponent<ItemController>().SetButtonAction(BuyActionCallBack, ExpActionCallBack);
            objList.Add(obj);
        }
        switch (_tag) {
            case "meat": labelText.text = "肉"; break;
            case "fish": labelText.text = "魚類"; break;
            case "vegetable": labelText.text = "野菜"; break;
            case "neta": labelText.text = "ネタ"; break;
            case "other": labelText.text = "その他"; break;
        }
    }

    public void ClearObjList() {
        for(int i = 0; i < objList.Count; i++) {
            Destroy(objList[i]);
        }
        objList.Clear();
    }



    public void OnEnterButton()
    {
        eneterObj.SetActive(true);

        foreach (KeyValuePair<int, int> pair in selectItem)
        {
            var tmp = Instantiate<GameObject>(buyTextPre, buyParent.transform);
            var item = Items.GetItem(pair.Key);
            tmp.GetComponent<BuyItemData>().SetData(item.name, (item.price * selectItem[pair.Key]).ToString(), pair.Value.ToString());
            buyList.Add(tmp);
        }

        buyList.Add(Instantiate<GameObject>(buyTextPre, buyParent.transform));
    }


    public void OnCancelButton() {
        eneterObj.SetActive(false);
        for(int i = 0; i < buyList.Count; i++) {
            Destroy(buyList[i]);
        }
        buyList.Clear();
    }

    public void OnEnd() {
        eneterObj.SetActive(false);
    }


    public List<Item> GetBuyItem() {
        List<Item> tmp = new List<Item>();
        foreach (KeyValuePair<int, int> pair in selectItem) {
            tmp.Add(new Item(pair.Key, UserData.user_id, pair.Value));
        }
        return tmp;
    }
}
