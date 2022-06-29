using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WMS.Pages.Account
{
    public class CodigoVerificadorModel : PageModel
    {
        [BindProperty]
        public string Input { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                var ced = ((ClaimsIdentity)User.Identity).Claims.Where(d => d.Type == "Codigo").Select(s1 => s1.Value).FirstOrDefault();
                
                if(Input != ced)
                
                {
                    throw new Exception("El codigo no coincide con el brindado");
                }
                 
                return Redirect("../Index");

                //return Redirect("../Index");
            }

            catch (Exception ex)
            {

                ModelState.AddModelError(string.Empty, ex.Message);
                //return Redirect("/Error");
                return Page();
            }
        }
    }
}
