﻿using Bosch.Shared;
using System;
using System.Collections.Generic;

namespace Bosch.Server
{
    public class Database
    {
        public static List<Vlacek> Vlacky { get; set; } = new List<Vlacek>
        {
            new Vlacek() { Id = 0, Jmeno = "A", Kapacita = 20 },
            new Vlacek() { Id = 1, Jmeno = "B",  Kapacita = 50 },
            new Vlacek() { Id = 2, Jmeno = "C", Kapacita = 100 },
        };

        public static void EditVlacek(Vlacek vlacek)
        {
            int index = Vlacky.FindIndex(v => v.Id == vlacek.Id);
            Vlacky[index] = vlacek;
        }

        public static void RemoveVlacek(Vlacek vlacek)
        {
            Vlacky.Remove(vlacek);
        }

        public static void AddVlacek(Vlacek vlacek)
        {
            int maxIndex = Vlacky[Vlacky.Count - 1].Id;
            vlacek.Id = maxIndex + 1;

            Vlacky.Add(vlacek);

        }

        public static List<Material> Materialy { get; set; } = new List<Material>
        {
            new Material() {Id = 1, Nazev = "Uhli"},
            new Material() {Id = 2, Nazev = "Srouby"},
            new Material() {Id = 3, Nazev = "lidi"},
        };

        public static void EditMaterial(Material material)
        {
            int index = Materialy.FindIndex(m => m.Id == material.Id);
            Materialy[index] = material;
        }

        public static void RemoveMaterial(Material material)
        {
            Materialy.Remove(material);
        }

        public static void AddMaterial(Material material)
        {
            int maxIndex = Materialy[Materialy.Count - 1].Id;
            material.Id = maxIndex + 1;

            Materialy.Add(material);
        }

        public static List<Mezisklad> Mezisklady { get; set; } = new List<Mezisklad>()
        {
            new Mezisklad { Id = 0, Jmeno = "Praha", jizdniRad = null, seznamVlacku = { } },
            new Mezisklad { Id = 1, Jmeno = "Brno", jizdniRad = null, seznamVlacku = { } },
            new Mezisklad { Id = 2, Jmeno = "Ostrava", jizdniRad = null, seznamVlacku = { } },
            new Mezisklad { Id = 3, Jmeno = "Liberec", jizdniRad = null, seznamVlacku = { } },
            new Mezisklad { Id = 4, Jmeno = "Olomouc", jizdniRad = null, seznamVlacku = { } },
            new Mezisklad { Id = 5, Jmeno = "Pardubice", jizdniRad = null, seznamVlacku = { } },
        };

        public static void EditMezisklad(Mezisklad mezisklad)
        {
            int index = Mezisklady.FindIndex(m => m.Id == mezisklad.Id);
            Mezisklady[index] = mezisklad;
        }

        public static void RemoveMezisklad(Mezisklad mezisklad)
        {
            Mezisklady.Remove(mezisklad);
        }

        public static void AddMezisklad(Mezisklad mezisklad)
        {
            int maxIndex = Mezisklady[Mezisklady.Count - 1].Id;
            mezisklad.Id = maxIndex + 1;

            Mezisklady.Add(mezisklad);
        }

        public static List<Zastavka> Zastavky { get; set; } = new List<Zastavka>()
        {
            new Zastavka() {
                Mezisklad = Mezisklady[0], Cas = new DateTime(2008, 5, 1, 8, 30, 52) },
            new Zastavka() {
                Mezisklad = Mezisklady[1], Cas = new DateTime(2008, 5, 1, 8, 30, 52) },
            new Zastavka() {
                Mezisklad = Mezisklady[2], Cas = new DateTime(2008, 5, 1, 8, 30, 52) },
            new Zastavka() {
                Mezisklad = Mezisklady[3], Cas = new DateTime(2008, 5, 1, 8, 30, 52) },
            new Zastavka() {
                Mezisklad = Mezisklady[4], Cas = new DateTime(2008, 5, 1, 8, 30, 52) },
            new Zastavka() {
                Mezisklad = Mezisklady[5], Cas = new DateTime(2008, 5, 1, 8, 30, 52) },

        };


        public static List<Trasa> Trasy = new List<Trasa>
            {
                new Trasa() { Id = 0, Nazev = "A", Zastavky = Zastavky },

                new Trasa() { Id = 1, Nazev = "B", Zastavky = Zastavky },

                new Trasa() { Id = 2, Nazev = "C", Zastavky = Zastavky }
            };

        public static void EditTrasa (Trasa trasa)
        {
            int index = Trasy.FindIndex(t => t.Id == trasa.Id);
            Trasy[index] = trasa;
        }

        public static void RemoveTrasa(Trasa trasa)
        {
            Trasy.Remove(trasa);
        }

        public static void AddTrasa(Trasa trasa)
        {
            int maxIndex = Trasy[Trasy.Count - 1].Id;
            trasa.Id = maxIndex + 1;

            Trasy.Add(trasa);

        }

        public static List<JizdniRad> JizdniRady { get; set; } = new List<JizdniRad>
        {
            new JizdniRad() { Id = 1, Nazev = "Všední dny", Platnost = "Po, Út, St, Čt, Pá", Jizdy = new List<Jizda>
            {
                new Jizda() { Id = 0, Trasa = Trasy[0], Vlacek = Vlacky[0]  },
                new Jizda() { Id = 1, Trasa = Trasy[1], Vlacek = Vlacky[1]  }
            } 
            },
        };

        public static void EditJizdniRad(JizdniRad jizdniRad)
        {
            int index = JizdniRady.FindIndex(j => j.Id == jizdniRad.Id);
            JizdniRady[index] = jizdniRad;
        }

        public static void RemoveJizdniRad(JizdniRad jizdniRad)
        {
            JizdniRady.Remove(jizdniRad);
        }

        public static void AddJizdniRad(JizdniRad jizdniRad)
        {
            int maxIndex = JizdniRady[JizdniRady.Count - 1].Id;
            jizdniRad.Id = maxIndex + 1;

            JizdniRady.Add(jizdniRad);

        }

        public static List<Objednavka> Objednavky { get; set; } = new List<Objednavka>()
        {
            new Objednavka() { Id = 1, Mezisklad = Mezisklady[0], Material = Materialy[0] }
        };

        public static void RemoveObjednavka(Objednavka objednavka)
        {
            Objednavky.Remove(objednavka);
        }

        public static void AddObjednavka(Objednavka objednavka)
        {
            int maxIndex = Objednavky[Objednavky.Count - 1].Id;
            objednavka.Id = maxIndex + 1;

            Objednavky.Add(objednavka);

        }

        public static List<Uzivatel> Uzivatele { get; set; } = new List<Uzivatel>
        {
            new Uzivatel(){Id = 1, Jmeno = "David", Prijmeni = "Zeman", Login = "dz", Role = Roles.David},
            new Uzivatel(){Id = 1, Jmeno = "Petr", Prijmeni = "Smid", Login = "petr", Role = Roles.Admin}

        };

        public static void EditUzivatel(Uzivatel uzivatel)
        {
            int index = Uzivatele.FindIndex(u => u.Id == uzivatel.Id);
            Uzivatele[index] = uzivatel;
        }

        public static void RemoveUzivatel(Uzivatel uzivatel)
        {
            Uzivatele.Remove(uzivatel);
        }

        public static void AddUzivatel(Uzivatel uzivatel)
        {
            int maxIndex = Uzivatele[Uzivatele.Count - 1].Id;
            uzivatel.Id = maxIndex + 1;

            Uzivatele.Add(uzivatel);
        }
    }
}
