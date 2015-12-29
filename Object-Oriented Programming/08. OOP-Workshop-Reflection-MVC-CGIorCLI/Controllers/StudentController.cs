namespace WebPage.Controllers
{
    using BindingModels;
    using Core.Attributes.HttpRequestMethods;
    using Core.Controllers;
    using Core.Interfaces.Generic;
    using ViewModels;

    class StudentController : Controller
    {
        [HttpPost]
        public IViewResult<StudentViewModel> Edit(int id, StudentBindingModel bindingModel)
        {
            StudentViewModel viewModel = new StudentViewModel();
            viewModel.FullName = bindingModel.FirstName + " " + bindingModel.LastName;

            return View(viewModel);
        }
    }
}
