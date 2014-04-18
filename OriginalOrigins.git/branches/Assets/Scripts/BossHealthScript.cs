﻿using UnityEngine;
using System.Collections;

public class BossHealthScript : MonoBehaviour {

    //public EdgeCollider2D bossCollider;
    public int bossHealth = 10;

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("BossHealth", bossHealth);
	}
	
	// Update is called once per frame
	void Update () {
        //print(PlayerPrefs.GetInt("BossHealth"));
	    if(PlayerPrefs.GetInt("BossHealth") <= 0)
        {
            //loads the end cutscene
            Application.LoadLevel(17);
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        /*
        //if (coll.gameObject.tag == "BossBird")
        if (coll.collider == collid)
        {
            PlayerPrefs.SetInt("BossHealth", PlayerPrefs.GetInt("BossHealth") - damage);
            Destroy(gameObject);
        }
        */

        ShotScript shot = coll.gameObject.GetComponent<ShotScript>();
        if(shot != null)
        {
            PlayerPrefs.SetInt("BossHealth", PlayerPrefs.GetInt("BossHealth") - shot.damage);
            Destroy(shot.gameObject);
        }
    }
}
