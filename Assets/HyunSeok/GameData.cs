using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//다른 부분에서 저장하고 싶다면, DataController.Instance.SaveGameData()

[Serializable]
public class GameData
{
    //인게임ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    public float exp;

    public int normal_atk_lv;//표창
    public int shadow_partner_lv;//분신
    public int fire_lv;//화둔
    public int wind_lv;//풍둔
    public int talisman_lv;//부적
    public int fire_column_lv;//불기둥
    public int voltTackle_lv;//볼트태클
    public int tornado_lv;//토네이도
    public int tree_lv; // 트리
    public int boomerang_lv; // 부메랑
    public int electricity_lv; // 번개의신 번개의 왕
    public int windwall_lv; //
    //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

}

