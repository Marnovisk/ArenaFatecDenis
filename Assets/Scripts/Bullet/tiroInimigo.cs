using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiroInimigo : MonoBehaviour
{
    public GameObject bulletInimigoPrefab;
    public Transform bulletInimigoSpawn;
    public float bulletInimigoVida = 2.0f;
    public float bulletInimigoSpeed = 6.0f;

    void Start()
    {
        InvokeRepeating("FireInimigo", 3f, 3f);
    }

    void FixedUpdate()
    {
        
    }

    void FireInimigo()
    {
        // Cria um Bullet a partir de BulletPrefab
        var bullet = (GameObject)Instantiate(bulletInimigoPrefab, bulletInimigoSpawn.position, bulletInimigoSpawn.rotation);

        // Adiciona velocidade a Bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletInimigoSpeed;

        // Destruir Bullet depois de n segundos
        Destroy(bullet, bulletInimigoVida);
    }
}
