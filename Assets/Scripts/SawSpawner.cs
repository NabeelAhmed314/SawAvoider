using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class SawSpawner : MonoBehaviour
{
    public GameObject itemToShootPrefab;
    public float shootStartDelay = 0.1f;
    public float shootInterval = 2f;
    public float destroyItemDelay = 3f;
    public GameObject[] spawns;
    // Use this for initialization
    void Start ()
    {
        StartCoroutine(ShootObject(shootInterval));
    }

    private IEnumerator ShootObject(float delay)
    {
        yield return new WaitForSeconds(delay + shootStartDelay);
        shootStartDelay = 0f;
        foreach (GameObject spawn in spawns)
        {
            var item = (GameObject) PhotonNetwork.Instantiate("Saw", spawn.transform.position, transform.rotation,0);
            Destroy(item, destroyItemDelay);
            yield return new WaitForSeconds(0.3f);
        }

        StartCoroutine(ShootObject(shootInterval));
    }
}
