using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameOnDestroy : MonoBehaviour
{

    [SerializeField]
    private float waitTime = 5f;
    
    private void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }
}
