using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BoxData", menuName = "ScriptableObject/��������", order = 0)]
public class SlotBoxData : ScriptableObject
{
    [Header("====box����====")]
    public BoxType type;//����

    [Header("====box����====")]
    public string name;//����
    [Header("====boxͼƬ====")]
    public Sprite image;//ͼƬ

    [Header("====�˺�����====")]
    public AttackType attackType;//�˺�����
    [Header("====�˺�====")]
    public int attackValue;//��ֵ
    [Header("====�����˺�====")]
    public int attackExtra;//������ֵ

    [Header("====Ӱ��Ŀ�꣨�Լ������ˣ�====")]
    public AttackAim attackAim;//Ŀ��
    [Header("====Ŀ������====")]
    public int aimNum;//Ŀ������
    [Header("====�Ƿ�����ظ���һ��Ŀ���ͷ�====")]
    public bool repeat;//�Ƿ�����ظ���һ��Ŀ���ͷ�

    [Header("====�Ƿ���Ҫ����====")]
    public bool needEnergy;//���Ա�����
    [Header("====����Ϊ0ʱ�Ƿ�����====")]
    public bool canDestory;//�Ƿ��������
    [Header("====����/����ʣ�����====")]
    public int count;//ʹ�ô���

    public enum BoxType
    {
        Attack,     //����
        Defend,     //����
        Restore,    //�ָ�
    }

    public enum AttackType
    {
        Normal,     //��ͨ
        Piercing,   //����
    }

    public enum AttackAim
    {
        Self,
        Enemy
    }

    public static explicit operator GameObject(SlotBoxData v)
    {
        throw new NotImplementedException();
    }
}