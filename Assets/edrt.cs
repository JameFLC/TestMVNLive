using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edrt : MonoBehaviour
{
    [SerializeField] xsens.XsStreamReader actor;
    [SerializeField] Transform boss;
    private Transform[] targetModel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddOtherScriptAfterAWhile());
    }

    IEnumerator AddOtherScriptAfterAWhile()
    {
        yield return new WaitForSeconds(1);
        xsens.XsLiveAnimator ani = GetComponent<xsens.XsLiveAnimator>();
        ani.Setup(actor, boss);

        
    }
}
