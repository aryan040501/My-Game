﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;

    private void start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppedItem()
    {
        Vector2 PlayerPos = new Vector2(player.position.x, player.position.y + 3);
        Instantiate(item, PlayerPos, Quaternion.identity);
    }
}
