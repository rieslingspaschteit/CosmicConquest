using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using TMPro;

public class GunController : MonoBehaviour
{

    private StarterAssetsInputs _input;
    public GameObject bulletPrefab;
    public GameObject bulletPoint;
    public float bulletSpeed = 600f;
    private int ammo;
    public TextMeshProUGUI ammoText;

    // Start is called before the first frame update
    void Start()
    {
        ammo = 30;
        _input = transform.root.GetComponent<StarterAssetsInputs>();
        SetAmmoText();
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.shoot) {

            if (ammo > 0) {
                Shoot();
                _input.shoot = false;
                ammo -= 1;
                SetAmmoText();
            }
        }

        if (_input.pickUp) {
            _input.pickUp = false;
            ammo = 30;
            SetAmmoText();
        }
    }

    void SetAmmoText() {
        ammoText.text = "Ammo: " + ammo.ToString();
    }

    void Shoot() {
        GameObject bullet = Instantiate(bulletPrefab, bulletPoint.transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * -bulletSpeed); 
        Destroy(bullet, 1);
    }
}
