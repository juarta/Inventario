using System.ComponentModel.DataAnnotations;

public class Suministro
{
	public int CodigoProducto { get; set; }

	[Required]
	[StringLength(30)]
	public string Nombre { get; set; }

	[Required]
	[StringLength(1)]
	public string UnidadMedida { get; set; }

	[Required]
	[Range(0, int.MaxValue)]
	public int CantidadMinima { get; set; }

	[Required]
	[Range(0, int.MaxValue)]
	public int CantidadMaxima { get; set; }

	[Required]
	[Range(0, int.MaxValue)]
	public int CantidadActual { get; set; }
}
