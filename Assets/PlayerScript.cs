using Mirror;
using UnityEngine;

namespace QuickStart
{
    public class PlayerScript : NetworkBehaviour
    {
        public Camera camera;

        void Start()
        {
            if (!isLocalPlayer) {
                camera.enabled = false;
            }
        }

        void Update()
        {
            if (!isLocalPlayer)
                return;
            float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * 110.0f;
            float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * 4f;
            transform.Rotate(0, moveX, 0);
            transform.Translate(0, 0, moveZ);
        }
    }
}