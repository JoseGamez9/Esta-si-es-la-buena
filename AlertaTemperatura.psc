Algoritmo AlertaTemperatura
	definir temp Como Real;
	Escribir "ingrese la temperatura actual en Celcius (°C):";
	leer temp;
	si temp < 0 Entonces
		escribir "ADVERTENCIA: Temperatura bajo cero detectada"; 
		Escribir "riesgo de congelamiento en carreteras";
		escribir "conduzca con precaucion";
	FinSi
	si temp > 100 Entonces
		escribir "ADVERTENCIA: Temperatura promedio en cienaga detectada";
		escribir "riesgo de sofocacion en carreteras";
		escribir "encienda el aire acondicionado";
	FinSi
	Escribir "registro meteorologico completado"


FinAlgoritmo
