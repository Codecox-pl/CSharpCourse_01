using AppStore.Models.DTO;
using AppStore.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AppStore.Controllers
{
    public class UserAuthenticationController: Controller
    {
        private readonly IUserAuthenticationService _authService;

        public UserAuthenticationController(IUserAuthenticationService authService)
        {
            _authService = authService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel login)
        {
            if (!ModelState.IsValid)
            {
                // Esto extraerá el nombre del campo y el error específico
                var errorMessages = ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .Select(x => new { Campo = x.Key, Errores = x.Value.Errors.Select(e => e.ErrorMessage) })
                    .ToList();

                // Creamos un string con los errores para mostrarlo en pantalla
                string erroresConcatenados = string.Join(" | ", errorMessages.Select(x => $"{x.Campo}: {string.Join(", ", x.Errores)}"));

                ViewBag.ErrorMessage = "Errores detectados: " + erroresConcatenados;
                return View(login);
            }

            var resultado = await _authService.LoginAsync(login);

            if(resultado.StatusCode == 1)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Si resultado.Message llega nulo, esto nos avisará
                ViewBag.ErrorMessage = string.IsNullOrEmpty(resultado.Message)
                                       ? "El servicio devolvió un error pero sin mensaje."
                                       : resultado.Message;
                return View(login);
            }
        }

        public async Task<IActionResult> Lgout()
        {
            await _authService.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}
