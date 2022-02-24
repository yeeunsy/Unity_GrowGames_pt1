using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int[] jellyGoldList;
    public int[] jellyGelatinList;
    public Sprite[] jellySpriteList;
    public string[] jellyNameList;

    public Vector3[] PointList;

    public RuntimeAnimatorController[] LvAc;

    public void ChangeAc(Animator anim, int level)
    {
        anim.runtimeAnimatorController = LvAc[level - 1];
    }
}
