using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public Transform player;
    public float turnspeed = 0.01f;
    Quaternion rotGoal;
    Vector3 direction;

    void Update() {
        transform.position = player.transform.position;
        float mouseX = (Input.mousePosition.x / Screen.width ) - 0.5f;
     float mouseY = (Input.mousePosition.y / Screen.height) - 0.5f;
     transform.localRotation = Quaternion.Euler (new Vector4 (-1f * (mouseY * 180f), mouseX * 360f, transform.localRotation.z));
    }
}