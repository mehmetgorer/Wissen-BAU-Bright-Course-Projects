using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.PersonelTakibi
{
    public interface IPersonelService
    {
        public List<Personel> GetAllPersonel();
        public Personel GetPersonelById(int id);
        public void AddPersonel(Personel personel);
        public void DeletePersonelById(int id);
        public void DeletePersonel(Personel personel);
    }
}
