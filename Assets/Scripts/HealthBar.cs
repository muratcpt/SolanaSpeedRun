using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private int health = 3;
    private int MAX_HEALTH = 3;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy1")) // "Enemy1" etiketini düþman objelerine eklediðinizden emin olun
        {

            TakeDamage(1); // Düþmanla temas ettiðinde caný 1 azalacak þekilde ayarlanmýþtýr. Ýstediðiniz deðeri kullanabilirsiniz.
            Debug.Log("Karakterin mevcut caný: " + health);
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