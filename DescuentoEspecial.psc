// Jose gamez jimenez
Algoritmo DescuentoEspecial
	Definir montoCompra, descuento, montoFinal Como Real;
	Escribir "ingrese el valor total de su compra"
	leer montoCompra;
	montoFinal <- montoCompra;
	si montoCompra > 111 Entonces
		descuento <- montoCompra * 0.11;
		montoFinal <- montoCompra - descuento
		Escribir "¡FELICIDADES ha recibido un descuento de $", descuento;
	FinSi
	si montoCompra <= 111 Entonces
		Escribir "recuerde que hay un descuento por compras superiores a 111"
	FinSi
	Escribir "total a pagar es de $" , montoFinal
	escribir "gracias por su compra" 
FinAlgoritmo
