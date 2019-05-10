using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour
{
   
    

    public Rigidbody shell;
    public Transform muzzle;

    public float launchForce = 10;


    public float health;
    float healthMax;
    bool isAlive;

    CharacterController cc;

    bool attacking = false;
    public float attackTime;

    Animator animator;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        cc = GetComponent<CharacterController>();
        healthMax = health;
        isAlive = true;
       
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f && isAlive)
        {
            Death();
        }
    }

  

    public void Death()
    {
        isAlive = false;
       
      
        Destroy(gameObject);
        gameObject.SetActive(false);

    }
}