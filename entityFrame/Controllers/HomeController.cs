using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {

        private MusicianDBContext db;

        public HomeController(MusicianDBContext Mus)
        {
            db = Mus;
        }
        

        public async Task<IActionResult> Index()
        {
            int max = 0;
            List<string> maxi = new();
            var bb = await db.Musicians.Include(a => a.Instruments).ToListAsync();
            foreach(Musician m in bb)
            {
                if (max < m.Instruments.Count) 
                { 
                    max = m.Instruments.Count;
                    maxi.Clear();
                    maxi.Add(m.FirstName + " " + m.LastName);
                }
                else if(max == m.Instruments.Count) maxi.Add(m.FirstName + " " + m.LastName);
            }
            ViewBag.Maxi = maxi;
            return View(bb);
        }
        public IActionResult Create()
        {
            ViewBag.Ins = db.Instruments;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Musician mus,string[] instr)
        {
            foreach (string s in instr)
            {
                int id = Int32.Parse(s);
                Instrument? i = await db.Instruments.FirstOrDefaultAsync(i => i.InstrumentId == id);
                mus.Instruments.Add(i);
            }
            db.Musicians.Add(mus);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EditMus(int? id)
        {
            if (id != null)
            {
                Musician mus = await db.Musicians.Include(a => a.Instruments).FirstOrDefaultAsync(p => p.MusicianId == id);
                ViewBag.Ins = db.Instruments;
                if (mus != null)
                    return View(mus);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EditMus(Musician m,string[] instr)
        {
            if (ModelState.IsValid)
            {
                db.Musicians.Update(m);
                db.SaveChanges();
                Musician ms = db.Musicians.Include(s => s.Instruments).FirstOrDefault(k => k.LastName == m.LastName);
                ms.Instruments.Clear();
                foreach (string s in instr)
                {
                    int id = Int32.Parse(s);
                    Instrument? i = await db.Instruments.FirstOrDefaultAsync(i => i.InstrumentId == id);
                    ms.Instruments.Add(i);
                }

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult DeleteMus(Musician m)
        {
            db.Musicians.Attach(m);
            db.Musicians.Remove(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Instru()
        {
            int duh = 0;
            int st = 0;
            int bam = 0;
            int kl = 0;
            var bb = await db.Instruments.Include(a => a.Musicians).ToListAsync();
            foreach(Instrument i in bb)
            {
                switch (i.Categ)
                {
                    case "духовые": duh += i.Musicians.Count; break;
                    case "струнные": st += i.Musicians.Count;break;
                    case "ударные": bam += i.Musicians.Count; break;
                    case "клавишные": kl += i.Musicians.Count;break;
                }
            }
            Dictionary<string, int> top= new();
            top.Add("духовые", duh);
            top.Add("струнные", st);
            top.Add("ударные", bam);
            top.Add("клавишные", kl);
            top = top.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            ViewBag.Top = top;
            return View(bb);
        }

        public IActionResult CreateIns()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateIns(Instrument mus,string name,string cat)
        {
            if (name.Trim()!="" && name!=null)
            {
                mus.Name = name;
                mus.Categ = cat;
                db.Instruments.Add(mus);
                await db.SaveChangesAsync();
                return RedirectToAction("Instru");
            }
            return View(mus);
        }

        public IActionResult DeleteInst(Instrument m)
        {
            db.Instruments.Attach(m);
            db.Instruments.Remove(m);
            db.SaveChanges();
            return RedirectToAction("Instru");
        }

        public async Task<IActionResult> EditIns(int? id)
        {
            if (id != null)
            {
                Instrument mus = await db.Instruments.Include(a => a.Musicians).FirstOrDefaultAsync(p => p.InstrumentId == id);
                if (mus != null)
                    return View(mus);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EditIns(Instrument m)
        {
            if (ModelState.IsValid)
            {
                db.Instruments.Update(m);
                db.SaveChanges();
                
                return RedirectToAction("Instru");
            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
