using Portifolio_backend.Models;
using Portifolio_backend.DAO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Portifolio_backend.Controllers{

            public class FotoController : PadraoController<FotoModel>
            {
                public FotoController(){DAO = new FotoDAO();}

            public override async Task<IActionResult> Save(FotoModel model,bool checkIdBeforeInsertion = true)
            {
                return base.Save(model,checkIdBeforeInsertion).Result;
            }
            
            }

}