﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Add view models

namespace AlphaElectric_DataAccessLayer.DA
{
    class SizeTypeDA
    {
        AlphaElectricEntitiesDB db;

        public SizeTypeDA()
        {
            db = new AlphaElectricEntitiesDB();
        }

        public List<SizeType> SelectAll()
        {
            return db.SizeTypes.ToList();
        }

        public bool InsertSizeType(SizeType sztype)
        {
            db.SizeTypes.Add(sztype);
            return db.SaveChanges() > 0 ? true : false;
        }

        //CHECK IT
        public bool Delete(int id)
        {
            var sztype = db.SizeTypes.Where(x => x.ID == id).FirstOrDefault();
            if (sztype != null)
            {
                db.SizeTypes.Remove(sztype);
            }
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Update(int id, string descrip)
        {
            var sztype = db.SizeTypes.Where(x => x.ID == id).FirstOrDefault();
            if (sztype != null)
            {
                sztype.Description = descrip;
            }
            return db.SaveChanges() > 0 ? true : false;
        }
        
        //public List<StudentViewModel> SelectFew()
        //{
        //    return (from s in db.Students
        //            select new StudentViewModel
        //            {
        //                Name = s.Name,
        //                Age = s.Age
        //            }).ToList();
        //}
        //public List<StudentViewModel> SelectFewLambda()
        //{
        //    return db.Students.Select(x => new StudentViewModel
        //    {
        //        Name = x.Name,
        //        Age = x.Age
        //    }).ToList();
        //}
        //public List<StudentViewModel> SelectFew(int id)
        //{
        //    return (from s in db.Students
        //            where s.Id == id
        //            select new StudentViewModel
        //            {
        //                Name = s.Name,
        //                Age = s.Age
        //            }).ToList();
        //}

        //public List<StudentViewModel> SelectFewLambda(int id)
        //{
        //    return db.Students.Where(z => z.Id == id)
        //        .Select(x => new StudentViewModel
        //        {
        //            Name = x.Name,
        //            Age = x.Age
        //        }).ToList();
        //}


        //public string SelectBatchNameByStudentId(int id)
        //{
        //    var batch = (from s in db.Students
        //                 join b in db.Batches on s.BatchId equals b.Id
        //                 select b
        //                     ).FirstOrDefault();
        //    return batch != null ? batch.BatchName : string.Empty;
        //}
        //public string SelectBatchNameByStudentIdLambda(int id)
        //{
        //    var obj = db.Batches.Join(db.Students,
        //        bat => bat.Id,
        //        std => std.BatchId,
        //        (bat, std) => new { batch = bat, student = std })
        //        .Where(x => x.batch.Id == x.student.BatchId).FirstOrDefault();

        //    return obj.batch != null ? obj.batch.BatchName : string.Empty;
        //}
    }
}
