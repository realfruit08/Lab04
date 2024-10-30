using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public class PlayerAreaTrigger : MonoBehaviour
    {
        public TMPro.TextMeshProUGUI titleText;
        public TMPro.TextMeshProUGUI byLineText;
        public void OnTriggerEnter2D(Collider2D collision)
        {
            titleText.text = collision.gameObject.name;
        }
    }
}

