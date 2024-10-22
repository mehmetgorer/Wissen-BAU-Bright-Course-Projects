using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.PersonelTakibi
{
    public class PersonelService : IPersonelService
    {
        List<Personel> liste = new List<Personel>()
        {
            new() {Id=1, Adi="Ali", Soyadi="Uçar"},
            new() {Id=2, Adi="Ayşe", Soyadi="Koşar"},
            new() {Id=3, Adi="Neşe", Soyadi="Sever"},
            new() {Id=4, Adi="Necati", Soyadi="Demir"}
        };
        public List<Personel> GetAllPersonel()
        {
            return liste;
        }
        public Personel GetPersonelById(int id)
        {
            //return liste.Find(x => x.Id == id);
            foreach (Personel p in liste)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }

            return new Personel();
        }
        public void AddPersonel(Personel personel)
        {
            liste.Add(personel);
        }
        public void DeletePersonel(Personel personel)
        {
            liste.Remove(personel);
        }
        public void DeletePersonelById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
