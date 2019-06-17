using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateInput : MonoBehaviour
{

    public bool judge = false;
    int i=0;
    public GameObject button_id;
    public GameObject ID;
    public GameObject button_ps;
    public GameObject PS;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(judge==true)
        {
            button_id.SetActive(false);
            ID.SetActive(true);
        }

      if(judge==false)
        {
            button_ps.SetActive(false);
            PS.SetActive(true);
        }

      
    }

    public void OnClick()
    {
        judge = true;
        i++;
    }



}
