Algoritmo PagoReciboAgua
	
	
	Definir montoTotal , recargo , montoOriginal Como Real;
	Definir  diasRetraso Como Entero;
	
	escribir "ingresa el monto original de la factura ($ - COP";
	leer montoOriginal
	escribir "ingrese los dias de retraso del pago";
	leer diasRetraso 
	
	montoTotal <- montoOriginal; 
	Si diasRetraso > 5 Entonces
		recargo <- montoOriginal * 0.05
		montoTotal <- montoOriginal + recargo
		Escribir "se ha aplicado el recargo del 5% ($" , recargo, ") por mora" ;
	FinSi
	Escribir "monto total definitivo a pagar: $" montoTotal
FinAlgoritmo
