using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAssets : MonoBehaviour
{
    //���ñ���
    private Backpack backpackScript;
    private PlayerAttribute playerattributeScript;

    //��ʱ����
    private List<SlotBoxData> TemporaryBackpack = new List<SlotBoxData>();

    //��������boxλ��
    private Transform[,] Chains = new Transform[4, 5];

    //����box�ڳ��ϵ�λ��
    public SlotBoxData[,] currentBox = new SlotBoxData[4, 5];

    //�����ϵ�item�б�
    private List<SlotBoxData> ChainsItem = new List<SlotBoxData>();

    //����box����
    int limitNum;

    //�ظ�λ�ü���б�
    List<int> SameArray = new List<int>();



    void Awake()
    {

        //��ȡ��������box
        int i = 0;
        int j = 0;
        foreach (Transform child in this.transform)
        {
            Chains[i, j] = child;
            Debug.Log(i + " " + j + ": " + Chains[i, j].name);
            j++;
            if (j == Chains.GetLength(1))
            {
                i++;
                j = 0;
            }
        }
        //���box����
        limitNum = Chains.Length;

    }

    void InitialiseCheck()
    {

        if (backpackScript == null) { backpackScript = Object.FindObjectOfType<Backpack>(); }
        if (playerattributeScript == null) { playerattributeScript = Object.FindObjectOfType<PlayerAttribute>(); }
    }

    void Start()
    {
        InitialiseCheck();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }

    public void RandomBox()
    {
        //�����������б��˹��ܺ����ƶ�����Ϸ����ű�����Ϊ��ͬ�غϣ�
        playerattributeScript.Attribute_Turn.Clear();

        //�����ʱ����
        TemporaryBackpack.Clear();
        //����ظ�����б�
        SameArray.Clear();

        //�������ڵĵ��߷�����ʱ������
        foreach (SlotBoxData child in backpackScript.BackpackItem)
        {
            TemporaryBackpack.Add(child);
        }

        //�������
        for (int i = 0; i < Chains.GetLength(0); i++)
        {
            for (int j = 0; j < Chains.GetLength(1); j++)
            {
                foreach (Transform child in Chains[i, j])
                {
                    child.transform.GetComponent<SpriteRenderer>().sprite = null;

                }
            }
        }

        //���λ�ò�����box
        for (int limit = 0; limit < limitNum;)
        {
            //���λ��
            int i = Random.Range(0, Chains.GetLength(0));
            int j = Random.Range(0, Chains.GetLength(1));

            //���λ���ظ�
            if (CheckSame(i, j))
            {
                //�������ID
                int itemID = Random.Range(0, TemporaryBackpack.Count);

                //��������
                Chains[i, j].transform.GetChild(0).transform.GetComponent<SpriteRenderer>().sprite = TemporaryBackpack[itemID].image;


                limit++;

                //���뵽��ǰ�����б���
                ChainsItem.Add(TemporaryBackpack[itemID]);

                //���뵽����
                currentBox[i, j] = TemporaryBackpack[itemID];

                Debug.Log("i: " + i + ", j: " + j + ", box: " + currentBox[i, j].name);

                //�ӵ���ұ���
                playerattributeScript.Attribute_Turn.Add(TemporaryBackpack[itemID]);

                //����ʱ������ʱ�Ƴ�
                TemporaryBackpack.Remove(TemporaryBackpack[itemID]);
            }

            //�����ʱ������û�е���������ֹ
            if (TemporaryBackpack.Count <= 0)
            {
                break;
            }

        }

        //��Ҽ������ԣ��˹��ܺ����ƶ�����Ϸ����ű�����Ϊ��ͬ�غϣ�
        playerattributeScript.UpdateAttribute();
    }

    //�ظ�λ�ü��
    bool CheckSame(int x, int y)
    {
        if (SameArray == null)
        {
            SameArray.Add(x * 10 + y);
        }
        else
        {

            for (int sameNum = 0; sameNum < SameArray.Count; sameNum++)
            {
                int addNum = x * 10 + y;
                if (addNum == SameArray[sameNum])
                {
                    return false;
                }
            }
            SameArray.Add(x * 10 + y);
        }

        return true;
    }
}
