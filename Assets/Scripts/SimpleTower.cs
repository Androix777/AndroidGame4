using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTower : MonoBehaviour
{
    private GameObject currentBullet;
    [SerializeField]
    private float fireRate = 1f, gunsDist = 0.1f;
    [SerializeField]
    private List<gunParameters> guns;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 1 / fireRate, 1 / fireRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fire()
    {
        int gunsNum = guns.Count;
        float horizontalOffset, horizontalSum = (gunsNum - 1) * gunsDist;
        for(int i = 0; i < gunsNum; i++)
        {
            horizontalOffset = (i * gunsDist) - horizontalSum / 2;
            Debug.Log(gunsDist+" "+horizontalOffset);
            currentBullet = Instantiate(guns[i].bullet, this.transform.position + new Vector3(horizontalOffset, 0.5f, 0), Quaternion.identity);
            currentBullet.gameObject.GetComponent<Bullet>().SetParameters(guns[i].damage, guns[i].speedVertical, guns[i].speedHorizontal, guns[i].bulletLifetime);
        }
    }
}

[System.Serializable]
public struct gunParameters
{
    public GameObject bullet;
    public float damage;
    public float speedVertical;
    public float speedHorizontal;
    public float bulletLifetime;
}
