using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class GunController : MonoBehaviour
{

    private StarterAssetsInputs _input;
    public GameObject bulletPrefab;
    public GameObject bulletPoint;
    public float bulletSpeed = 600f;

    // Start is called before the first frame update
    void Start()
    {
        _input = transform.root.GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.shoot) {
            Shoot();
            _input.shoot = false;
        }
    }

    void Shoot() {
        GameObject bullet = Instantiate(bulletPrefab, bulletPoint.transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * -bulletSpeed); 
        Destroy(bullet, 1);
    }
}
