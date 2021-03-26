using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeScale : MonoBehaviour
{
	public Button botonAumentar;
	public Button botonReducir;
	public Button moverIzquierda;
	public Button moverDerecha;
	public Transform objeto1;
	public Transform objeto2;
	private Vector3 scaleChange;
	private Vector3 positionChange;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = botonAumentar.GetComponent<Button>();
        btn.onClick.AddListener(aumentarEscala);

        Button btn2 = botonReducir.GetComponent<Button>();
        btn2.onClick.AddListener(reducirEscala);

        Button btn3 = moverIzquierda.GetComponent<Button>();
        btn3.onClick.AddListener(irIzquierda);

        Button btn4 = moverDerecha.GetComponent<Button>();
        btn4.onClick.AddListener(irDerecha);

        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        positionChange = new Vector3(0.01f, 0.0f, 0.0f);
    }

    void aumentarEscala(){
    	objeto1.localScale += scaleChange ;
    	objeto2.localScale += scaleChange ;
    }

    void reducirEscala(){
    	objeto1.localScale -= scaleChange ;
    	objeto2.localScale -= scaleChange ;
    }

    void irIzquierda(){
    	objeto1.localPosition -= positionChange ;
    	objeto2.localPosition -= positionChange ;
    }

    void irDerecha(){
    	objeto1.localPosition += positionChange ;
    	objeto2.localPosition += positionChange ;
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }


}
