using System;
using System.ComponentModel.DataAnnotations;

public class SolicitudRetiro
{
	public int NumeroSolicitud { get; set; }

	[Required]
	public int CodigoProducto { get; set; }

	[Required]
	[DataType(DataType.Date)]
	public DateTime FechaEntrega { get; set; }

	[Required]
	[Range(0, int.MaxValue)]
	public int Cantidad { get; set; }
}
