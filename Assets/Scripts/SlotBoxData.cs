using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BoxData", menuName = "ScriptableObject/方块数据", order = 0)]
public class SlotBoxData : ScriptableObject
{
    [Header("====box类型====")]
    public BoxType type;//类型

    [Header("====build分类====")]
    public BuildType buildtype;

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



    public List<SlotBoxData> gunMagazine = new List<SlotBoxData>();

    public List<SlotBoxData> magicMagazine = new List<SlotBoxData>();







    public enum BoxType
    {
        攻击,    
        防御,     
        恢复,
        消耗,
    }

    public enum BuildType
    {
        默认,
        枪械流,
        魔法流,
    }
    public enum AttackType
    {
        普通,     //普通
        穿刺,   //穿刺
    }

    public enum AttackAim
    {
        敌人,
        自己,
    }

    public static explicit operator GameObject(SlotBoxData v)
    {
        throw new NotImplementedException();
    }
}
