using System;
using System.Collections.Generic;

namespace Villa.Infrastructure.ViewModel
{
    public class RoleViewModel
    {
        public string Name { get; set; }
        
        public List<UserViewModel> users { get; set; }
    }
}
