using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameController : MonoBehaviour
{
    private RandomAssets randomassetsScript;
    private Backpack backpackScript;
    private SlotButton slotbuttonScript;

    public GameObject SlotButton;

    // Start is called before the first frame update
    void Start()
    {
        if (randomassetsScript == null) { randomassetsScript = Object.FindObjectOfType<RandomAssets>(); }
        if (backpackScript == null) { backpackScript = Object.FindObjectOfType<Backpack>(); }
        if (slotbuttonScript == null) { slotbuttonScript = Object.FindObjectOfType<SlotButton>(); }

        BattleTurn_Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BattleTurn_Slot();
        }
    }

    //�غϿ�ʼ
    public void BattleTurn_Start()
    {
        //��Ĭ��box���뵽ս��������
        backpackScript.BackpackItem.Clear();
        foreach (GameObject child in backpackScript.NormalBackpackItem)
        {
            backpackScript.BackpackItem.Add(child);
        }

    }

    //ҡ�ϻ���
    public void BattleTurn_Slot()
    {
        slotbuttonScript.EnterSlotButton();
    }

    //��������
    public void BattleTurn_Calculation()
    {

    }

    //ս���׶�
    public void BattleTurn_Battle()
    {

    }

}
