﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable, IKillable
{
    [SerializeField]
    private float life = 10;
    [SerializeField]
    private float speedHorizontal = 0, speedVertical = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(speedHorizontal, -speedVertical));
    }

    public void Damage(float value)
    {
        life -= value;
        if (life <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        Destroy(gameObject);
    }
}
