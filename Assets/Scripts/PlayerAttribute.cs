using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerAttribute : MonoBehaviour
{
    private RandomAssets randomassetsScript;

    [HideInInspector]
    public  List<Transform> Attribute_Turn = new List<Transform>();

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

    //更新属性
    public void UpdateAttribute()
    {
        int atk_value = 0;
        int def_value = 0;
        int res_value = 0;

        //攻击力计算
        foreach (Transform child in Attribute_Turn)
        {
            if (child.GetComponent<CubeAttribute>().boxAttribute.type == BoxType.Attack)
            {
                atk_value += child.GetComponent<CubeAttribute>().boxAttribute.attackValue;
            }
        }
        Debug.Log("atk_value: " + atk_value);

        atk_value_str.text = atk_value.ToString();

        //防御力计算
        foreach (Transform child in Attribute_Turn)
        {
            if (child.GetComponent<CubeAttribute>().boxAttribute.type == BoxType.Defend)
            {
                def_value += child.GetComponent<CubeAttribute>().boxAttribute.attackValue;
            }
        }
        Debug.Log("atk_value: " + def_value);

        def_value_str.text = def_value.ToString();

        //生命恢复计算
        foreach (Transform child in Attribute_Turn)
        {
            if (child.GetComponent<CubeAttribute>().boxAttribute.type == BoxType.Restore)
            {
                res_value += child.GetComponent<CubeAttribute>().boxAttribute.attackValue;
            }
        }
        Debug.Log("atk_value: " + res_value);

        res_value_str.text = res_value.ToString();
    }


}
