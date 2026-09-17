// Jose Gamez
Algoritmo ControlVelocidad
	Definir velocidad Como Real ;
	
	Escribir "ingrese la velocidad registrada del vehiculo (km/h)"
	leer velocidad;
	
	si velocidad > 80 Entonces
		Escribir "ALERTA: ha superado el limite de velocidad de 80km/h"
		Escribir "se ha generado una fotomulta automaticamente"
		
	FinSi
	si velocidad < 80 Entonces
		Escribir "limite de veloidad no exedido"
		Escribir "te salvaste"
	FinSi
	Escribir "evaluacion de transito finalizada" 
FinAlgoritmo
