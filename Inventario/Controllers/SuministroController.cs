using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.Controllers
{

	public class SuministroController : Controller
	{
		private static List<Suministro> Inventario = new List<Suministro>();

		// Acción para mostrar el inventario de suministros
		public ActionResult Index()
		{
			// Aquí obtenemos los datos del inventario desde la base de datos (lista en memoria)
			List<Suministro> Inventario = ObtenerInventarioDesdeLaBaseDeDatos();

			return View(Inventario);
		}

		// Acción para mostrar el formulario de ingreso de nuevos suministros
		public ActionResult Crear()
		{
			return View();
		}

		// Acción para procesar el formulario de ingreso de nuevos suministros
		[HttpPost]
		public ActionResult Crear(Suministro nuevoSuministro)
		{
			if (ModelState.IsValid)
			{
				// Aquí guardamos el nuevo suministro en la base de datos (lista en memoria)
				GuardarSuministroEnLaBaseDeDatos(nuevoSuministro);

				// Después de guardar, redirigimos al usuario a la página de inventario actualizado
				return RedirectToAction("Index");
			}

			return View(nuevoSuministro);
		}

		// Simulación de obtención del inventario desde la base de datos (lista en memoria)
		private List<Suministro> ObtenerInventarioDesdeLaBaseDeDatos()
		{
			// Supongamos que ya tenemos algunos datos en la lista (esto sería reemplazado por la consulta real a la base de datos)
			if (inventario.Count == 0)
			{
				inventario.Add(new Suministro { CodigoProducto = 1, Nombre = "Suministro 1", UnidadMedida = "u", CantidadMinima = 10, CantidadMaxima = 100, CantidadActual = 50 });
				inventario.Add(new Suministro { CodigoProducto = 2, Nombre = "Suministro 2", UnidadMedida = "l", CantidadMinima = 5, CantidadMaxima = 50, CantidadActual = 30 });
			}

			return inventario;
		}

		// Simulación de guardado del suministro en la base de datos (lista en memoria)
		private void GuardarSuministroEnLaBaseDeDatos(Suministro nuevoSuministro)
		{
			// Supongamos que asignamos un nuevo código de producto en base al último código existente (esto sería reemplazado por el código real de la base de datos)
			int nuevoCodigo = inventario.Count + 1;
			nuevoSuministro.CodigoProducto = nuevoCodigo;

			// Agregamos el nuevo suministro a la lista (esto sería reemplazado por el código real de la base de datos)
			inventario.Add(nuevoSuministro);
		}
	}
}