using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFX_Explosion : MonoBehaviour
{
    // Start is called before the first frame update
	[SerializeField]
	private float delay = 5.0f;
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject,delay);
    }
}
