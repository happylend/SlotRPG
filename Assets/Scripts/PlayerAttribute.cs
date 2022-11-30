using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static SlotBoxData;

public class PlayerAttribute : MonoBehaviour
{
    private RandomAssets randomassetsScript;

    [HideInInspector]
    public  List<SlotBoxData> Attribute_Turn = new List<SlotBoxData>();

    public GameObject ATK_Num;
    public GameObject DEF_Num;
    public GameObject RES_Num;

    TextMeshPro atk_value_str;
    TextMeshPro def_value_str;
    TextMeshPro res_value_str;

    // Start is called before the first frame update
    void Start()
    {
        atk_value_str = ATK_Num.GetComponent<TextMeshPro>();
        def_value_str = DEF_Num.GetComponent<TextMeshPro>();
        res_value_str = RES_Num.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //��������
    public void UpdateAttribute()
    {
        int atk_value = 0;
        int def_value = 0;
        int res_value = 0;

        //����������
        foreach (SlotBoxData child in Attribute_Turn)
        {
            if (child.type == BoxType.����)
            {
                atk_value += child.attackValue;
            }
        }
        Debug.Log("atk_value: " + atk_value);

        atk_value_str.text = atk_value.ToString();

        //����������
        foreach (SlotBoxData child in Attribute_Turn)
        {
            if (child.type == BoxType.����)
            {
                def_value += child.attackValue;
            }
        }
        Debug.Log("atk_value: " + def_value);

        def_value_str.text = def_value.ToString();

        //�����ָ�����
        foreach (SlotBoxData child in Attribute_Turn)
        {
            if (child.type == BoxType.�ָ�)
            {
                res_value += child.attackValue;
            }
        }
        Debug.Log("atk_value: " + res_value);

        res_value_str.text = res_value.ToString();
    }


}
