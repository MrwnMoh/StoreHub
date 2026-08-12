using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Reviews
{
    public class DTO_Reviews
    {

        public string UserFullName { get; set; }

        public string? UserImagePath { get; set; }

        public decimal Rating { get; set; }

        public string ReviewText { get; set; }

        public DateTime Date { get; set; }

        public bool IsUserMale { get; set; }
        public bool Edited { get; set; }

        public int ReviewID { get; set; }
        public int PersonID { get; set; }

    }
}
