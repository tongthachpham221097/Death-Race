using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{

    [SerializeField] private static string OBSTACLE_WHEEL = "ObstacleWheel";
    [SerializeField] private static string WHEEL_1 = "Wheel_1";

    [SerializeField] private static string OBSTACLE_CONE_BOX_FENCE = "ObstacleConeBoxFence";
    [SerializeField] private static string TRAFFIC_CONE = "TrafficCone";
    [SerializeField] private static string WOODEN_BOX = "WoodenBox";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(OBSTACLE_WHEEL))
        {
            this.CollideWithWheel(collision.transform.parent.name);
        }
        else if (collision.CompareTag(OBSTACLE_CONE_BOX_FENCE))
        {
            this.CollideWithConeBoxFence(collision.transform.parent.name);
        }
        else this.CollideWithOilSlick();
    }

    void CollideWithWheel(string name)
    {
        float value = 0;
        if (name == WHEEL_1) value = 3;
        else value = 5;
        ManagersCtrl.Instance.Player.DecreaseSpeedMax(value);
    }

    void CollideWithConeBoxFence(string name)
    {
        float value = 0;
        if (name == TRAFFIC_CONE) value = 2;
        else if (name == WOODEN_BOX) value = 3;
        else value = 5;
        ManagersCtrl.Instance.Player.DecreaseSpeedMax(value);
        ManagersCtrl.Instance.Player.IncreaseSpeedMaxByTime();
    }

    void CollideWithOilSlick()
    {
        ManagersCtrl.Instance.Player.Rotate();
    }

}
