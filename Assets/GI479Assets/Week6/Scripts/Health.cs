using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public float MaxHealth = 100;

    public UnityEvent OnTakeDamage;
    public UnityEvent OnDead;

    private float currentHealth;

   
    void Start()
    {
        currentHealth = MaxHealth;
    }

    
   
    public void TakeDamage(float damageAmount)
    {
        if (!IsDead())
        {
            OnTakeDamage?.Invoke();
            currentHealth -= damageAmount;
            if (IsDead())
            {
                OnDead?.Invoke();
            }
        }
    }

    public bool IsDead()
    {
        return currentHealth <= 0;
    }
}
