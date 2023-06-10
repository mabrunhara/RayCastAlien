using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raiofoguete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
            }
            if (hit.collider.tag == "alvo") {
                Debug.Log("Acertou!");
                GameObject hitObject = hit.transform.gameObject; 
                StartCoroutine(SphereIndicator(hitObject.transform.position)); 
                Destroy(hit.transform.gameObject);
            }

        }
    }
    // código para aparecer bola quando cria
    private IEnumerator SphereIndicator(Vector3 pos)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;
        yield return new WaitForSeconds(0);
        Destroy(sphere);
    }
}
