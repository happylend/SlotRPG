using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAssets : MonoBehaviour
{
    //调用背包
    private Backpack backpackScript;
    private PlayerAttribute playerattributeScript;

    //临时背包
    private List<GameObject> TemporaryBackpack = new List<GameObject>();

    //声明所有box位置
    private Transform[,] Chains = new Transform[4, 5];

    //桌面上的item列表
    private List<GameObject> ChainsItem = new List<GameObject>();

    //桌面box数量
    int limitNum;

    //重复位置检测列表
    List<int> SameArray = new List<int>();

    void Awake()
    {

        //获取所有桌面box
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
        //最大box数量
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
        //清空玩家属性列表（此功能后期移动到游戏管理脚本，改为不同回合）
        playerattributeScript.Attribute_Turn.Clear();

        //清空临时背包
        TemporaryBackpack.Clear();
        //清空重复检测列表
        SameArray.Clear();

        //将背包内的道具放入临时背包中
        foreach (GameObject child in backpackScript.BackpackItem)
        {
            TemporaryBackpack.Add(child);
        }

        Debug.Log("Do");

        //清空桌面
        for (int i = 0; i < Chains.GetLength(0); i++)
        {
            for (int j = 0; j < Chains.GetLength(1); j++)
            {
                foreach (Transform child in Chains[i, j].transform.GetChild(0))
                {
                    if (child != null)
                    {
                        Destroy(child.gameObject);
                    }

                }
            }
        }

        //随机位置并放置box
        for (int limit = 0; limit < limitNum;)
        {
            //随机位置
            int i = Random.Range(0, Chains.GetLength(0));
            int j = Random.Range(0, Chains.GetLength(1));

            //检测位置重复
            if (CheckSame(i, j))
            {
                //随机道具ID
                int itemID = Random.Range(0, TemporaryBackpack.Count);

                //创建物体
                GameObject box = Instantiate(TemporaryBackpack[itemID],
                                             new Vector2(Chains[i, j].transform.GetChild(0).position.x, Chains[i, j].transform.GetChild(0).position.y),
                                             Chains[i, j].transform.GetChild(0).rotation,
                                             Chains[i, j].transform.GetChild(0));
                limit++;

                //加入到当前桌面列表中
                ChainsItem.Add(TemporaryBackpack[itemID]);

                //加到玩家表中
                playerattributeScript.Attribute_Turn.Add(TemporaryBackpack[itemID].transform);

                //从临时背包暂时移除
                TemporaryBackpack.Remove(TemporaryBackpack[itemID]);
            }

            //如果临时背包内没有道具了则终止
            if (TemporaryBackpack.Count <= 0)
            {
                break;
            }
            Debug.Log("limit: " + limit);

        }

        //玩家计算属性（此功能后期移动到游戏管理脚本，改为不同回合）
        playerattributeScript.UpdateAttribute();
    }

    //重复位置检测
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
        Debug.Log(x * 10 + y);

        return true;
    }
}
