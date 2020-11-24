#pragma checksum "c:\Users\Neati\Desktop\SampleGet-master\SampleProject\Controllers\PayController.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04b231165b838ced369b206f03be86c24a1b8f71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Controllers_PayController), @"mvc.1.0.view", @"/Controllers/PayController.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04b231165b838ced369b206f03be86c24a1b8f71", @"/Controllers/PayController.cshtml")]
    public class Controllers_PayController : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"using System.Data;
using System;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
     using System.Threading.Tasks;
     using DataLayer.Context;
     using DataLayer.Entities;
     using Dto.Payment;
     using Microsoft.AspNetCore.Mvc;
     using ViewModel.Entities;
     using ZarinPal.Class;
     using Microsoft.AspNetCore.Hosting;


     namespace Sample.Controllers {
         ////////////////////////////////////////////////////////////////////database

         public class PayController : Controller {

             private readonly Context_db db;
             private readonly IWebHostEnvironment env;
      
             private readonly Payment _payment;
             private readonly Authority _authority;
             private readonly Transactions _transactions;
             public static string msg;
             public PayController (Context_db _db,IWebHostEnvironment _env) {
                 var expose = new Expose ();
                 _payment = expose.CreatePayment (");
            WriteLiteral(@");
                 _authority = expose.CreateAuthority ();
                 _transactions = expose.CreateTransactions ();

                  db=_db;
                 env=_env;
             }
             /////////////////////////////////////////////////////////////////////

             public IActionResult Index () {

                 if (msg != null) {
                     ViewBag.msg = msg;
                     msg = null;
                 }

                 return View ();
             }
                 ///////////////////////////////////////////////////////////////////////////////////Add Request Informations

             public async Task<IActionResult> Request (Vm_Pay model) {

                 var tb = new Tbl_Pay(){
                     Name=model.Name,
                     Email=model.Email,
                     Amonnt=model.Amonnt,
                     Tel=model.Tel,
                Date = DateTime.Today,
                     Status = false,
                 };
                //  var ttb = new ");
            WriteLiteral(@"Tbl_Pay();
                //  ttb.Amonnt = model.Amonnt;
                //  ttb.Tel = model.Tel;
                //  ttb.Email = model.Email;
                //  ttb.Name = model.Name;
                db.Add(tb);
                db.SaveChanges();
                id = db.Tbl_Pay.OrderByDescending(a=>a.Id).Take(1).SingleOrDefault().Id;
                amount= Convert.ToInt32(model.Amonnt);
           
                 var result = await _payment.Request (new DtoRequest () {
                     Mobile = ""09121112222"",
                         CallbackUrl = ""https://localhost:5001/pay/validate"",
                         Description = model.Name,
                         Email = model.Email,
                         Amount = Convert.TpInt32( model.Amonnt),
                         MerchantId = ""XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX""
                 }, ZarinPal.Class.Payment.Mode.sandbox);
                 return Redirect ($""https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}"");
             }

         ");
            WriteLiteral(@"    ///////////////////////////////////////////////////////////////////////////اعتبارسنجی پرداخت
             public async Task<IActionResult> Validate (string authority, string status) {
                 var verification = await _payment.Verification (new DtoVerification {
                     Amount = amount,
                         MerchantId = ""XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"",
                         Authority = authority
                 }, Payment.Mode.sandbox);

                 if (verification.Status == 100) {
                     var x=db.Tbl_pay.Where(a=>a.Id=id).SingleOrDefault();
                     x.Status=true;
                     db.Tbl_Pay.Update(x);
                     db.SaveChanges();

                     msg = ""s"";
                     return RedirectToAction (""Index"");

                 } else {
                     var x =db.Tbl_Pay.Where(a=>a.Id=id).SingleOrDefault();
                     x.Status=false;
                     db.Tbl_Pay.Update(x);
                     db.Sa");
            WriteLiteral(@"veChanges();

                     msg = ""e"";
                     return RedirectToAction (""Index"");
                 }

             }

             ///////////////////////////////////////////////////////////////////////////////////Enter Informations
             public IActionResult Pay () {

                 return View ();

             }
             ///////////////////////////////////////////////////////////////////////////////////End Enter Informations

         
         }
     }");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591