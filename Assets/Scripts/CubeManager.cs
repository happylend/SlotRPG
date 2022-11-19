using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 老虎机方块类
/// </summary>
[Serializable]
public struct cubeAttribute
{
    [Header("====box类型====")]
    public BoxType type;//类型

    [Header("====box名称====")]
    public string name;//名称
    [Header("====box图片====")]
    public Sprite image;//图片

    [Header("====伤害类型====")]
    public AttackType attackType;//伤害类型
    [Header("====伤害====")]
    public int attackValue;//数值
    [Header("====额外伤害====")]
    public int attackExtra;//额外数值

    [Header("====影响目标（自己、敌人）====")]
    public AttackAim attackAim;//目标
    [Header("====目标数量====")]
    public int aimNum;//目标数量
    [Header("====是否可以重复对一个目标释放====")]
    public bool repeat;//是否可以重复对一个目标释放

    [Header("====是否需要充能====")]
    public bool needEnergy;//可以被消耗
    [Header("====次数为0时是否销毁====")]
    public bool canDestory;//是否可以销毁
    [Header("====充能/销毁剩余次数====")]
    public int count;//使用次数


}
public enum BoxType
{
    Attack,     //攻击
    Defend,     //防御
    Restore,    //恢复
}

public enum AttackType
{
    Normal,     //普通
    Piercing,   //穿刺
}

public enum AttackAim
{
    Self,
    Enemy
}

public class CubeManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
