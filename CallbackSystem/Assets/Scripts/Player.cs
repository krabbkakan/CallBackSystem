using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    
    #region Singelton
    private static Player _instance;

    public static Player Instace
    {
        get
        {

            if (_instance == null)
            {
                GameObject go = new GameObject("Player");
                go.AddComponent<Player>();
            }

            return _instance;

        }

    }
    #endregion
 
    public delegate void ChangeEnemyColor(Color color);
    public static event ChangeEnemyColor OnEnemyHit;

    private void Awake()
    {
        _instance = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            // Damage enemy when space key is down

            if (OnEnemyHit != null) {
                OnEnemyHit(Color.red);
            }


        }


    }


}
