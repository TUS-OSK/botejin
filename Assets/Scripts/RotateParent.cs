using System.Collections;
using UnityEngine;

public class RotateParent : MonoBehaviour
{
    private float RotateAngle = 90;
    private float RotateTime = 1;
    public void Rotate(float rotateAngle = 90,float rotateTime = 3)
    {
        RotateAngle = rotateAngle;
        RotateTime = rotateTime;
        StartCoroutine(RotateAnimation());
    }

    private IEnumerator RotateAnimation()
    {
        var time = 0.0f;
        var rotateSpeed = RotateAngle / RotateTime;
        var startRotation = transform.rotation;
        var rotateAxis = transform.right;
        while(time <= RotateTime)
        {
            transform.rotation = Quaternion.AngleAxis(rotateSpeed * time, rotateAxis) * startRotation;
            yield return false;
            time += Time.deltaTime;
        }
    }
}
