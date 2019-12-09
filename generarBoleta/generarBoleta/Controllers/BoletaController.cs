using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using generarBoleta.Models;
namespace generarBoleta.Controllers
{
    public class BoletaController : Controller
    {
        #region Contexto
        private db_gagesoftv3Entities _contexto;
        

        public db_gagesoftv3Entities Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                {
                    _contexto = new db_gagesoftv3Entities();
                }
                return _contexto;
            }

        }
        #endregion
        // GET: Boleta
        public ActionResult Index()
        {
            IList<dataFind> modelInit = new List<dataFind>();
            var query = from b in Contexto.boleta
                            join a in Contexto.automoviles on b.carros_id equals a.carros_id
                         select new
                            {
                             b.botela_id,
                               a.propietario,
                             a.descripcion,
                               b.parkingLot_id,
                               a.placa,
                               b.inicioHora,
                               b.finalHora,
                               b.total,
                               a.tipo_carro_id

                         };
            var publishers = query.ToList();


            foreach (var publisherData in publishers)
            {
                modelInit.Add(new dataFind()
                {
                    boleta_id= publisherData.botela_id,
                    parkingLot_id = publisherData.parkingLot_id,
                    descripcion = publisherData.descripcion,
                    propietario = publisherData.propietario,
                    placa = publisherData.placa,
                    inicioHora = publisherData.inicioHora,
                    finalHora = publisherData.finalHora,
                    total = publisherData.total,
                    tipo_carro_id= publisherData.tipo_carro_id

                });
            }
            
            return View(modelInit);
        }

        // GET: Boleta/Details/5
        public ActionResult Details(int id)
        {
            IList<dataFind> modelInit = new List<dataFind>();
            var query = from b in Contexto.boleta
                        join a in Contexto.automoviles on b.carros_id equals a.carros_id where b.botela_id==id
                        select new
                        {
                            b.botela_id,
                            a.propietario,
                            a.descripcion,
                            b.parkingLot_id,
                            a.placa,
                            b.inicioHora,
                            b.finalHora,
                            b.total,
                            a.tipo_carro_id

                        };
            var publishers = query.ToList();


            foreach (var publisherData in publishers)
            {
                modelInit.Add(new dataFind()
                {
                    boleta_id = publisherData.botela_id,
                    parkingLot_id = publisherData.parkingLot_id,
                    descripcion = publisherData.descripcion,
                    propietario = publisherData.propietario,
                    placa = publisherData.placa,
                    inicioHora = publisherData.inicioHora,
                    finalHora = publisherData.finalHora,
                    total = publisherData.total,
                    tipo_carro_id = publisherData.tipo_carro_id

                });
            }
           
            return View(modelInit);
        }
        public ActionResult SomeAction()
        {
            // you could return a PartialView here if you need more complex HTML fragment
            return Content("<span>Hola mamá</span>", "text/html");
        }
        public ActionResult SearchInfo(string txtname)
        {
            IList<dataFind> modelInit = new List<dataFind>();
            var query = from b in Contexto.boleta
                        join a in Contexto.automoviles on b.carros_id equals a.carros_id where a.placa.Contains(txtname)
                        select new
                        {
                            b.botela_id,
                            a.propietario,
                            a.descripcion,
                            b.parkingLot_id,
                            a.placa,
                            b.inicioHora,
                            b.finalHora,
                            b.total,
                            a.tipo_carro_id

                        };
            var publishers = query.ToList();


            foreach (var publisherData in publishers)
            {
                modelInit.Add(new dataFind()
                {
                    boleta_id= publisherData.botela_id,
                    parkingLot_id = publisherData.parkingLot_id,
                    descripcion = publisherData.descripcion,
                    propietario = publisherData.propietario,
                    placa = publisherData.placa,
                    inicioHora = publisherData.inicioHora,
                    finalHora = publisherData.finalHora,
                    total = publisherData.total,
                    tipo_carro_id = publisherData.tipo_carro_id

                });
            }
            var Model = Contexto.automoviles.Where(p => p.placa.Contains(txtname)).Take(10).ToList();

            System.Diagnostics.Debug.WriteLine(">>>>>>>>>>" + txtname);
            System.Diagnostics.Debug.WriteLine("<<<<<<<<<<<<<"+Model.Count);
            
            if (modelInit.Count == 0)
            {
                return PartialView("notFound", modelInit);
            }
            else {
                return PartialView("_resultBusqueda", modelInit);
            }
            
        }
        public ActionResult Create()
        {

            var tipo = Contexto.tipo_automoviles.ToList();
            var list = new SelectList(tipo, "tipo_carro_id", "tipo_carro");
            ViewData["tipo"] = list;

            var local = Contexto.parkingLot.ToList();
            var list2 = new SelectList(local, "parkingLot_id", "nombre_local");
            ViewData["local"] = list2;
            return View();
        }

        [HttpPost]
        public ActionResult Create(dataFind nuevoAutomovil)
        {
            
            try
            {
                if (ModelState.IsValid)
                {
                    
                    Contexto.automoviles.Add(new automoviles() { 
                        placa = nuevoAutomovil.placa,
                        descripcion = nuevoAutomovil.descripcion,
                        propietario = nuevoAutomovil.propietario,
                        tipo_carro_id = nuevoAutomovil.tipo_carro_id
                    });
                    Contexto.SaveChanges();
                    var maxObject = Contexto.automoviles.OrderByDescending(item => item.carros_id).First();
                    
                    Contexto.boleta.Add(new boleta()
                    {
                        parkingLot_id = nuevoAutomovil.parkingLot_id,
                        carros_id = maxObject.carros_id,
                        inicioHora = DateTime.Now
                }) ;
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(nuevoAutomovil);
            }
            catch
            {
                return View();
            }
        }
        public ActionResult CreateEstacionamiento()
        {

            /*var tipo = Contexto.tipo_automoviles.ToList();
            var list = new SelectList(tipo, "tipo_carro_id", "tipo_carro");
            ViewData["tipo"] = list;

            var local = Contexto.parkingLot.ToList();
            var list2 = new SelectList(local, "parkingLot_id", "nombre_local");
            ViewData["local"] = list2;*/
            return View();
        }

        [HttpPost]
        public ActionResult CreateEstacionamiento(parkingLot nuevoAutomovil)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    Contexto.parkingLot.Add(nuevoAutomovil);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(nuevoAutomovil);
            }
            catch
            {
                return View();
            }
        }


    }




    //Crear nuevo estacionamiento


}