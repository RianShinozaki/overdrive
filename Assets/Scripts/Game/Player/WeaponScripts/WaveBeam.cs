using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveBeam : PlayerWeaponBase
{
    public GameObject normalBullet;
    public float bulletSpeed;

    public override void SpawnBullet() {
        base.SpawnBullet();

        int mult = weaponData.rarity + 1;
        float startPos = (mult - 1) * 0.15f;

        for (int i = 0; i < 2; i++) {
            Transform playertrans = PlayerController.Instance.transform;
            Vector3 pos = playertrans.position + new Vector3(playertrans.localScale.x * 7.5f / 16f, -1.5f / 16f, 0);
            Vector3 vel = Vector3.right * playertrans.localScale.x * bulletSpeed;
            WaveBullet bullet = Instantiate(normalBullet, pos, Quaternion.identity).GetComponent<WaveBullet>();
            bullet.velocity = vel;
            bullet.transform.localScale = playertrans.localScale;
            bullet.damage = weaponData.level + 1;

            bullet.t = 180 * i;
        }

        audioSource.PlayOneShot(shootSound, 1);
    }
}
