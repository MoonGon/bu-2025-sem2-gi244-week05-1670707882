using UnityEngine;

public class HealthV2 : MonoBehaviour
{
    public int maxHP = 100;
    private int accumDamage = 0;
    public void TakeDamage(int damage)
    {
        accumDamage += damage;

        if(accumDamage >= maxHP)
        {
            Destroy(gameObject);
        }
    }
}
