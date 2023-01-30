using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Normal : MonoBehaviour
{
    public Player_Body player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBody")
        {
            player.in_Normal = true;
            player.in_Fire = false;
            player.in_Wood = false;
            player.in_Mecha = false;
        }
    }
}
