using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public int health = 100;

    [SerializeField] private int MAX_HEALTH = 100;

    public Animator anim;
    public bool isDead = false;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int amount)
    {
        anim.SetTrigger("isHurt");
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot Have Negative Damage");
        }

        this.health -= amount;

        //if (GetComponent<Hearts>() != null)
        //{
        //    Hearts hearts = GetComponent<Hearts>();
        //    hearts.Damage(1);
        //}

        if(health <= 0 && isDead == false)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot Have Negative Healing");
        }

        bool wouldOverheal = health + amount > MAX_HEALTH;

        if (wouldOverheal)
        {
            this.health = MAX_HEALTH;
        }

        this.health += amount;
    }

    private void Die()
    {
        Debug.Log("I am Dead!");
        anim.ResetTrigger("isHurt");
        anim.SetBool("isDying", true);
        isDead = true;
        //if (GetComponent<MonsterMovement>() != null)
        //{
        //    GetComponent<MonsterMovement>().enabled = false;
        //}
        if (GetComponent<Movement>() != null)
        {
            GetComponent<Movement>().enabled = false;
        }
    }

}
