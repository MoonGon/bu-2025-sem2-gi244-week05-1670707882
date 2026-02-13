using UnityEngine;

public class GameState : MonoBehaviour
{
    public int hitcount = 0;
    public const string ENEMY_TAG = "Enemy";
    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Enemy")
        //{
        //    hitcount++;
        //}

        if (other.gameObject.CompareTag("Enemy"))
        {
            hitcount++;
        }

        if (hitcount >= 5)
        {
            Debug.Log("Game Over");
            Time.timeScale = 0f;
        }
    }
}
