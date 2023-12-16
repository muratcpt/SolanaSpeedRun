using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private int health = 3;
    private int MAX_HEALTH = 3;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy1")) // "Enemy1" etiketini d��man objelerine ekledi�inizden emin olun
        {

            TakeDamage(1); // D��manla temas etti�inde can� 1 azalacak �ekilde ayarlanm��t�r. �stedi�iniz de�eri kullanabilirsiniz.
            Debug.Log("Karakterin mevcut can�: " + health);
        }
    }

    private void TakeDamage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative damage");
        }

        Damage(amount);
    }

    public void Damage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative healing");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;
        if (wouldBeOverMaxHealth)
        {
            health = MAX_HEALTH;
        }
        else
        {
            health += amount;
        }
    }

    private void Die()
    {
        Debug.Log("I am dead");
        Destroy(gameObject);
    }

}