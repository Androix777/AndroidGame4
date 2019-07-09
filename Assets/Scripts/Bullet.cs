using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IKillable
{
    [SerializeField]
    float lifeTime = 5, damage = 2, speedVertical = 1, speedHorizontal = 0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Kill", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(speedHorizontal, speedVertical));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IDamageable damageable = collision.GetComponent<IDamageable>();
        if(damageable != null)
        {
            damageable.Damage(damage);
            Kill();
        }
    }

    public void Kill()
    {
        Destroy(gameObject);
    }

    public void SetParameters(float damage, float speedVertical, float speedHorizontal, float lifeTime)
    {
        this.damage = damage;
        this.speedVertical = speedVertical;
        this.speedHorizontal = speedHorizontal;
        this.lifeTime = lifeTime;
        CancelInvoke("Kill");
        Invoke("Kill", lifeTime);
    }
}
