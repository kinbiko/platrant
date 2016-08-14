﻿using UnityEngine;
using System.Collections;

public class Abyss : MonoBehaviour {

    private const string PLAYER_TAG = "Player";

    [SerializeField]
    private PlayerHealthHandler playerHealthHandler;
    

    void OnTriggerEnter2D(Collider2D coll)
    {
        coll.gameObject.SendMessage("Rotate");
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == PLAYER_TAG)
           playerHealthHandler.LoseLife();
    }
}