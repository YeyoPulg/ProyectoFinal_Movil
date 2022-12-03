using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProyectoFinal_Movil.Model
{
    public class UserModel
    {
        [PrimaryKey,AutoIncrement]
        public int UserId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string UserEmail { get; set; }

        [MaxLength(100)]
        public string UserAge { get; set; }

        [MaxLength(100)]
        public string UserWight { get; set; }

        [MaxLength(100)]
        public string UserPlan { get; set; }

        [MaxLength(50)]
        public string UserName { get; set; }

        [MaxLength(50)]
        public string UserPass { get; set; }
    }
}
