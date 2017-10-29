using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour {

	static GameObject[] listPlateforme;
	//private float timer = 3.0f;
	//private bool contact;

	void Awake (){
		listPlateforme = GameObject.FindGameObjectsWithTag ("Platform");

	}

	/*void Update(){
		if (contact)
			timer -= Time.deltaTime;
		
		if (timer <= 0.0f) {
			foreach (GameObject plateforme in listPlateforme) {
				plateforme.GetComponent<SpriteRenderer> ().color = new Color (255, 255, 255);//au bout de 3 sec les plateformes reprennet leur couleur normal
				//Destroy (gameObject);
			}
		}
	}*/

	public interface IColor
	{
		void Colorize ();
	}

	public class GemBlue : MonoBehaviour, IColor {
		public void Colorize () {
			foreach (GameObject plateforme in listPlateforme) {
				plateforme.GetComponent<SpriteRenderer>().color = new Color (0, 0, 255);//blue  color
				Debug.Log("BLEUE");
			}
		}

	}
    public class GemRed : MonoBehaviour, IColor
    {
        public void Colorize()
        {
            foreach (GameObject plateforme in listPlateforme)
            {
                plateforme.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);//red  color
				Debug.Log("ROUGE");
            }
        }
    }

        public class GemGreen : MonoBehaviour, IColor {
            public void Colorize() {
                foreach (GameObject plateforme in listPlateforme) {
                    plateforme.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);//green  color
					Debug.Log("VERT");
                }
            }
        }
    }
