using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehavior : MonoBehaviour
{
    bool fire;
    [SerializeField] Animator gunAnim;
    [SerializeField] Transform spawnBulletPoint;
    [SerializeField] GameObject bullet;
    [SerializeField] AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    public void Shoot()
    {
        if (!fire)
        {
            gunAnim.SetBool("isFired", true);
            fire = true;
            StartCoroutine("resetGun");
            var bulletShot = Instantiate(bullet,spawnBulletPoint.position,Quaternion.identity);
            audioSource.Play();
            bulletShot.GetComponent<Rigidbody>().AddForce(spawnBulletPoint.forward*20,ForceMode.Impulse);
        }


    }
    IEnumerator resetGun()
    {
        yield return new WaitForSeconds(0.1f);
        fire = false;
        gunAnim.SetBool("isFired", false);
    }
}
