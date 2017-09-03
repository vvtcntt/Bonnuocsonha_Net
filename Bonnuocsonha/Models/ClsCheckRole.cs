using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bonnuocsonha.Models;
namespace Bonnuocsonha.Models
{
    public class ClsCheckRole
    {
         public static bool  CheckQuyen(int Module,int Role,int idUser)
        {
            BonnuocsonhaContext db = new BonnuocsonhaContext();
            var listRight = db.tblRights.Where(p => p.idUser == idUser && p.idModule == Module && p.Role ==Role).ToList();
            if (listRight.Count > 0)
            {
                
                 return true;
            }
            else
                return false;
        }
    }
 
}