using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edrt : MonoBehaviour
{
    [SerializeField] xsens.XsStreamReader actor;
    // Start is called before the first frame update
    void Start()
    {
        xsens.XsLiveAnimator ani = GetComponent<xsens.XsLiveAnimator>();
        ani.Setup(actor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
