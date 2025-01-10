using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField] 
    private GameObject shootFlameOne;
    [SerializeField]
    private GameObject shootFlameTwo;

    [SerializeField]
    private GameObject shootingPointOne;
    [SerializeField]
    private GameObject shootingPointTwo;

    [SerializeField]
    private bool canShoot = true;

    [SerializeField]
    private bool showShootFlame = false;

    [SerializeField]
    private float waitTime = 5f;

    [SerializeField]
    private float timeSinceLastShot = 0f;

    private void Start()
    {
        shootFlameOne.SetActive(false);
        shootFlameTwo.SetActive(false);
    }

    void Update()
    {
        timeSinceLastShot++;

        if (timeSinceLastShot == waitTime)
        {
            canShoot = true;
            timeSinceLastShot = 0f;
        }

        if (canShoot)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                canShoot = false;
                showShootFlame = true;

                Instantiate(bulletPrefab, shootingPointOne.transform.position, shootingPointOne.transform.rotation);
                Instantiate(bulletPrefab, shootingPointTwo.transform.position, shootingPointOne.transform.rotation);

            }else
            {
                showShootFlame = false;
            }
        }

        if (showShootFlame)
        {
            shootFlameOne.SetActive(true);
            shootFlameTwo.SetActive(true);
        }
        else
        {
            shootFlameOne.SetActive(false);
            shootFlameTwo.SetActive(false);
        }
    }
}
