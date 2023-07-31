using System;
using System.ComponentModel.DataAnnotations;

public class Pedido
{
	public int IdPedido { get; set; }

	[Required]
	public int CodigoProducto { get; set; }

	[Required]
	[DataType(DataType.Date)]
	public DateTime FechaPedido { get; set; }

	[Required]
	[Range(0, int.MaxValue)]
	public int CantidadPedido { get; set; }

	[Required]
	[Range(0, double.MaxValue)]
	public decimal PrecioUnidad { get; set; }

	[Required]
	[DataType(DataType.Date)]
	public DateTime FechaEntrega { get; set; }

	[Required]
	[StringLength(50)]
	public string NombreEmpresa { get; set; }

	[Required]
	[StringLength(50)]
	public string NombreEntrega { get; set; }

	[Required]
	[StringLength(50)]
	public string NombreRecibe { get; set; }

	[Required]
	[StringLength(20)]
	public string NumeroFactura { get; set; }
}
