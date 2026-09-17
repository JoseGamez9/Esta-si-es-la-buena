//Jose Gamez
Algoritmo ControlAForo
	definir asistentes, exceso Como Entero
	Escribir "Ingrese la cantidad de asistentes confirmados";
	leer asistentes
	si asistentes > 150 Entonces
		exceso = asistentes - 150;
		Escribir "ALERTA DE SEGURIDAD: Se ha excedido la capasidad maxima de la sala";
		Escribir "Hay ",  exceso,  " persona(s) por ensima del limite permitido."
	FinSi
	Escribir "Registro dee aforo concluido"
FinAlgoritmo
