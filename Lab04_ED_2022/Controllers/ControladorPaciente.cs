using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab04_ED_2022.Helpers;
using Lab04_ED_2022.Models;
using Lab04_ED_2022.Estructura_de_Datos;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Globalization;
using CsvHelper;

namespace Lab04_ED_2022.Controllers
{
    public class ControladorPaciente : Controller
    {
        // GET: ControladorPaciente
        public ActionResult Index()
        {
            return View(Data.Instance.HeapMostrar);
        }

      

        // GET: ControladorPaciente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ControladorPaciente/Create
        public ActionResult Create()
        {
            return View(new ModeloPaciente());
        }

        public ActionResult Atender()
        {
            return View(Models.ModeloPaciente.Atender());
        }

        // POST: ControladorPaciente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                ModeloPaciente.Save(new ModeloPaciente
                {
                    Nombres = collection["Nombres"],
                    Apellidos = collection["Apellidos"],
                    Género = bool.Parse(collection["Género"]),
                    Especializacion = int.Parse(collection["Especializacion"]),
                    Ingreso = bool.Parse(collection["Ingreso"]),
                    Hora = TimeSpan.Parse(collection["Hora"]),
                    FechaDeNacimiento = DateTime.Parse(collection["FechaDeNacimiento"]),

                });

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ControladorPaciente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ControladorPaciente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ControladorPaciente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ControladorPaciente/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //cargar csv solo para arbol avl
        //leer csv
        //[HttpGet]
        //public IActionResult Upload(Heap<ModeloPaciente> paciente = null)
        //{
        //    paciente = paciente == null ? new Heap<ModeloPaciente>() : paciente;
        //    return View(Data.Instance.miHeap.compPrioridad);
        //}

        //[HttpPost]
        //public IActionResult Upload(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
        //{
        //    // Upload CSV 
        //    string fileName = $"{ hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
        //    using (FileStream fileStream = System.IO.File.Create(fileName))
        //    {
        //        file.CopyTo(fileStream);
        //        fileStream.Flush();
        //    }
        //    //

        //    var paciente = this.UploadCsv(file.FileName);
        //    return Upload(paciente);
        //}

        //private Heap<ModeloPaciente> UploadCsv(string fileName)
        //{
        //    Heap<ModeloPaciente> paciente = new Heap<ModeloPaciente>(); //modificado aqui tambien 

        //    // Read CSV
        //    var path = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\files"}" + "\\" + fileName;
        //    using (var reader = new StreamReader(path))
        //    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))

        //    {
              
        //        csv.Read();
        //        csv.ReadHeader();
        //        while (csv.Read())
        //        {
        //            var pacientes = csv.GetRecord<ModeloPaciente>(); //modificado aqui

        //            //arbol avl
                    
        //            Data.Instance.miHeap.Insertar(pacientes);
        //        }

        //        return paciente;

        //    }



        //}
    }
}
