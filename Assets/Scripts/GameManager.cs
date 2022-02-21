using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int[] jellyGoleList;
    public Vector3[] PointList;
    public RuntimeAnimatorController[] LvAc;

    public void ChangeAc(Animator anim, int level)
    {
        anim.runtimeAnimatorController = LvAc[level - 1];
    }
}
