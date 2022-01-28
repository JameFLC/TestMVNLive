using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edrt : MonoBehaviour
{
    [SerializeField] GameObject bossPrefab;
    [SerializeField] xsens.XsStreamReader actor;

    private Transform[] targetModel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddOtherScriptAfterAWhile());
    }

    IEnumerator AddOtherScriptAfterAWhile()
    {
        yield return new WaitForSeconds(1);

        GameObject boss = Instantiate(bossPrefab, transform);
        xsens.XsLiveAnimator ani = GetComponent<xsens.XsLiveAnimator>();
        ani.Setup(actor, boss.transform);

        
    }
}
