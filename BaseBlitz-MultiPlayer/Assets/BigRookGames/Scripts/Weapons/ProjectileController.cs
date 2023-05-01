using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectileController : MonoBehaviour
    {
        public float speed = 100;
        public LayerMask collisionLayerMask;
        public GameObject rocketExplosion;
        public MeshRenderer projectileMesh;
        private bool targetHit;

        public AudioSource inFlightAudioSource;

        private void Update()
        {
            if (targetHit) return;
            transform.position += transform.forward * (speed * Time.deltaTime);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (!enabled) return;

            Explode();
            projectileMesh.enabled = false;
            targetHit = true;
            inFlightAudioSource.Stop();
            foreach(Collider col in GetComponents<Collider>())
            {
                col.enabled = false;
            }
            Destroy(gameObject, 5f);
        }

        private void Explode()
        {
            rocketExplosion.transform.localScale = new Vector3(0.06f, 0.06f, 0.06f);
            GameObject newExplosion = Instantiate(rocketExplosion, transform.position, rocketExplosion.transform.rotation, null);
        }
}