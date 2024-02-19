using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [Header("Set in Inspector")]
    public static float bottomY = -20f;

    public bool isBomb = false;

    public GameObject Explosion;

    public int pointVal = 100;
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            if (isBomb) 
            {
                return;
            }
            // Get a reference to the ApplePicker component of Main Camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>(); 
            // Call the public AppleDestroyed() method of apScript
            apScript.AppleDestroyed();
        }
    }

    public void GoBoom() 
    {
        Explosion.SetActive(true);
        Explosion.transform.parent = null;
    }
}
