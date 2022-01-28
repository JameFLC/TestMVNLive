using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class searchForAvatar : MonoBehaviour
{
    [SerializeField] GameObject animationController;
    [SerializeField] xsens.XsStreamReader actor;
    Avatar avatar;
    // Start is called before the first frame update
    void Start()
    {

        if (GetComponent<Animator>().avatar.isHuman)
        {
            GameObject animator = Instantiate(animationController, transform);
            animator.GetComponent<xsens.XsLiveAnimator>().Setup(actor, this.transform);
        }
    }

  
}
