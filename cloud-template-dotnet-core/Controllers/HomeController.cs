using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cloud_template_dotnet_core.Models;
using KenticoCloud.Delivery;
using KenticoCloud.Models;
using System.Threading.Tasks;
using cloud_template_dotnet_core.ViewModels;
using System.Linq;

namespace cloud_template_dotnet_core.Controllers
{
    public class HomeController : Controller
    {
        private IDeliveryClient _deliveryClient;

        public HomeController(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public async Task<IActionResult> Index()
        {
            var deliveryApi = await _deliveryClient
                .GetItemAsync<ApiSpecification>(
                "delivery_api",
                new DepthParameter(4)
                );

            var viewModel = new DeliveryApiSpecificationViewModel()
            {
                Title = deliveryApi.Item.Title,
                Description = deliveryApi.Item.Description,
                Version = deliveryApi.Item.Version,
                Categories = deliveryApi.Item.Categories.OfType<ApiCategory>().Select(category =>
                new CategoryViewModel()
                {
                    Name = category.Name,
                    Description = category.Description
                }),
                EndPoints = deliveryApi.Item.Servers,
                Paths = deliveryApi.Item.Paths.OfType<ApiPath>().Select(apiPath =>
                new ApiPathViewModel()
                {
                    Path = apiPath.Path,
                    PathOperations = apiPath.PathOperations.OfType<ApiPathOperation>().Select(pathOperation => new PathOperationViewModel()
                    {
                        Description = pathOperation.Description,
                        Summary = pathOperation.Summary,
                        Operation = pathOperation.PathOperation,
                        Parameters = pathOperation.Parameters.OfType<ApiParameter>().Select(parameter => 
                        new ApiParameterViewModel()
                        {
                            Name = parameter.Name,
                            Description = parameter.Description,
                            Location = parameter.In.FirstOrDefault().Name ?? "N/A",
                            Schema = parameter.Schema.Take(1).Select(item =>
                            {
                                switch (item)
                                {
                                    case ApiSchemaString _:
                                        return "String";
                                    case ApiSchemaArray _:
                                        return "Array";
                                    case ApiSchemaBoolean _:
                                        return "Boolean";
                                    case ApiSchemaInteger _:
                                        return "Integer";
                                    case ApiSchemaObject _:
                                        return "Object";
                                    case ApiSchemaOneof _:
                                        return "One of";
                                    case ApiSchemaAllof _:
                                        return "All of";
                                    default:
                                        return "N/A";
                                }
                            }).FirstOrDefault()                                    
                        })
                    })
                })
            };

            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
