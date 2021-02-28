using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyAnimation : MonoBehaviour
{
    [SerializeField] string animationName;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Animator>().Play(animationName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
