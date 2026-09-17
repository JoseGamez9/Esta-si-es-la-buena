Algoritmo BonificacionFinal
	definir unidadesVendidas, antiguedad Como Entero
	Definir sueldoBase, bonificacion, sueldoFinal Como Real
	sueldoBase <- 2200000
	bonificacion <- 200000
	sueldoFinal <- sueldoBase 
	Escribir "ingrese la cantidad de unidades vendidas en el mes: ";
	Leer unidadesVendidas
	Escribir "ingrese los años de antiguedad en la empresa: ";
	leer antiguedad;
	
	si unidadesVendidas > 50 y antiguedad > 2 Entonces
		sueldoFinal <- sueldoBase + bonificacion;
		escribir "¡FELICIDADES ha cumplido con las metas de ventas! tienes una bonificacion de: $" , bonificacion;
	FinSi
	escribir "tu salario fianl de este mes es de: $" sueldoFinal 
	
FinAlgoritmo
