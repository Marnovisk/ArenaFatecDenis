using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turoBuller : MonoBehaviour
{
    public GameObject bulletPrefab;
public Transform bulletSpawn;
public float bulletVida = 2.0f;
public float bulletSpeed = 6.0f;

private float currentCooldown;
public float bulletCooldown;
 
void Start()
{


}

void Update()
{
    if(currentCooldown <= bulletCooldown)
    {
        currentCooldown += Time.deltaTime;
    }
}

    void FixedUpdate()
{
     if (Input.GetKey(KeyCode.Mouse0) && currentCooldown >= bulletCooldown)
     {
         Fire();
         currentCooldown = 0;
     }
}
 
void Fire()
{
     // Cria um Bullet a partir de BulletPrefab
     var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
 
     // Adiciona velocidade a Bullet
     bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;
 
     // Destruir Bullet depois de n segundos
     Destroy(bullet, bulletVida);
}
}
