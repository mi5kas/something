using UnityEngine;
using System;
using System.Collections;

[RequireComponent(typeof(Animator))]

public class IKControl : MonoBehaviour
{

    protected Animator animator;

    //public bool ikActive = false;
    [SerializeField] Transform rightHandPoint = null;
    [SerializeField] Transform leftHandPoint = null;
    [SerializeField] Transform leftFootPoint = null;
    [SerializeField] Transform rightFootPoint = null;
    [SerializeField] float weight = 1;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    //a callback for calculating IK
    void OnAnimatorIK()
    {

        // Set the right hand target position and rotation, if one has been assigned
        if (rightHandPoint != null)
        {
            animator.SetIKPositionWeight(AvatarIKGoal.RightHand, weight);
            animator.SetIKRotationWeight(AvatarIKGoal.RightHand, weight);
            animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandPoint.position);
            animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandPoint.rotation);
        }
        if(leftHandPoint != null)
        {
            animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, weight);
            animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, weight);
            animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandPoint.position);
            animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHandPoint.rotation);
        }
        if (leftFootPoint != null)
        {
            animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, weight);
            animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, weight);
            animator.SetIKPosition(AvatarIKGoal.LeftFoot, leftFootPoint.position);
            animator.SetIKRotation(AvatarIKGoal.LeftFoot, leftFootPoint.rotation);
        }
        if (rightFootPoint != null)
        {
            animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, weight);
            animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, weight);
            animator.SetIKPosition(AvatarIKGoal.RightFoot, rightFootPoint.position);
            animator.SetIKRotation(AvatarIKGoal.RightFoot, rightFootPoint.rotation);
        }
    }
}
