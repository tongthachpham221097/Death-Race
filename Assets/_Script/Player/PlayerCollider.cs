using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{

    [SerializeField] private static string OBSTACLE_WHEEL = "ObstacleWheel";
    [SerializeField] private static string WHEEL_1 = "Wheel_1";
    [SerializeField] private static string WHEEL_2 = "Wheel_2";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(OBSTACLE_WHEEL))
        {
            this.CollideWithWheel(collision.transform.parent.name);
        }
    }

    void CollideWithWheel(string name)
    {
        float value = 0;
        if (name == WHEEL_1) value = 3;
        if (name == WHEEL_2) value = 5;
        ManagersCtrl.Instance.Player.DeductSpeedMax(value);
    }

}
