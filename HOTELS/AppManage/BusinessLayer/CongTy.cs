using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class CongTy
    {
        Entities db;
        public CongTy() // Ham constructor
        {
            db = Entities.CreateEntities();
        }
        public tb_CONGTY GetItem(string MaCongTy)
        {
            return db.tb_CONGTY.FirstOrDefault(x => x.MACTY == MaCongTy);
        }
        public List<tb_CONGTY> GetAll()
        {
            return db.tb_CONGTY.ToList();
        }
        public void Add(tb_CONGTY AddCT)
        {
            try
            {
                db.tb_CONGTY.Add(AddCT);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again now!" + ex.Message);
            }
        }
        public void Update(tb_CONGTY UpdateCT)
        {
            tb_CONGTY _CT = db.tb_CONGTY.FirstOrDefault(x => x.MACTY == UpdateCT.MACTY);
            _CT.TENCTY = UpdateCT.TENCTY;
            _CT.DIENTHOAI = UpdateCT.DIENTHOAI;
            _CT.FAX = UpdateCT.FAX;
            _CT.EMAIL = UpdateCT.EMAIL;
            _CT.DIACHI = UpdateCT.DIACHI;
            _CT.DISABLED = UpdateCT.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Delete(string MaCongTy)
        {
            tb_CONGTY _CT = db.tb_CONGTY.FirstOrDefault(x => x.MACTY == MaCongTy);
            db.tb_CONGTY.Remove(_CT);
            try
            {
                db.SaveChanges(); // save all
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
             
            }
        }
    }
}