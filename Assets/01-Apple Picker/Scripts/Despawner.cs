using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Despawner : MonoBehaviour
{

    [SerializeField]
    private float despawnTimer = 3;

    private void Awake()
    {
        StartCoroutine(DespawnObject());
    }

    private IEnumerator DespawnObject() 
    {
        yield return new WaitForSeconds(despawnTimer);
        Destroy(gameObject);
    }


}
