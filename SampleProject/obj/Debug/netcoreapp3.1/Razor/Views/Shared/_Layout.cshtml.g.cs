#pragma checksum "c:\Users\Neati\Desktop\SampleGet-master\SampleProject\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb4b0444e93640efd896f87fbf782464b881359b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#nullable restore
#line 1 "c:\Users\Neati\Desktop\SampleGet-master\SampleProject\Views\_ViewImports.cshtml"
using SampleProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Neati\Desktop\SampleGet-master\SampleProject\Views\_ViewImports.cshtml"
using SampleProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb4b0444e93640efd896f87fbf782464b881359b", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df601d310eda16fa7f62db71a7390b20b6a3918b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("horizontal-layout horizontal-menu 2-columns  navbar-floating footer-static  "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-open", new global::Microsoft.AspNetCore.Html.HtmlString("hover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-menu", new global::Microsoft.AspNetCore.Html.HtmlString("horizontal-menu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-col", new global::Microsoft.AspNetCore.Html.HtmlString("2-columns"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!DOCTYPE html>
<!--
Template Name: Vuexy - Vuejs, HTML & Laravel Admin Dashboard Template
Author: PixInvent
Website: http://www.pixinvent.com/
Contact: hello@pixinvent.com
Follow: www.twitter.com/pixinvents
Like: www.facebook.com/pixinvents
Purchase: https://www.rtl-theme.com/vuexy-admin-html-template/
Renew Support: https://www.rtl-theme.com/vuexy-admin-html-template/
License: You must have a valid license purchased only from themeforest(the above link) in order to legally use the theme for your project.

-->
<html class=""loading"" lang=""en"" data-textdirection=""rtl"">
  <!-- BEGIN: Head-->
  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb4b0444e93640efd896f87fbf782464b881359b5313", async() => {
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui"">
    <meta name=""description"" content=""Vuexy admin is super flexible, powerful, clean &amp; modern responsive bootstrap 4 admin template with unlimited possibilities."">
    <meta name=""keywords"" content=""admin template, Vuexy admin template, dashboard template, flat admin template, responsive admin template, web app"">
    <meta name=""author"" content=""PIXINVENT"">
    <title>Sample</title>
    <link rel=""apple-touch-icon"" href=""../../../app-assets/images/ico/apple-icon-120.png"">
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""..\..\..\app-assets\images\ico\favicon.ico"">
    <link href=""..\..\..\app-assets\images\fonts.googleapis.css"" rel=""stylesheet"">

    <!-- BEGIN: Vendor CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\vendors\css\vendors-rtl.");
                WriteLiteral(@"min.css"">
    <!-- END: Vendor CSS-->

    <!-- BEGIN: Theme CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\bootstrap.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\bootstrap-extended.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\colors.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\components.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\themes\dark-layout.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\themes\semi-dark-layout.min.css"">

    <!-- BEGIN: Page CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\core\menu\menu-types\horizontal-menu.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\core\colors\palette-gradient.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rt");
                WriteLiteral(@"l\plugins\forms\validation\form-validation.css"">
    <!-- END: Page CSS-->

    <!-- BEGIN: Custom CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\custom-rtl.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""../assets/css/style-rtl.css"">
    <!-- END: Custom CSS-->

    <!-- BEGIN: Vendor CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\vendors\css\file-uploaders\dropzone.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\vendors\css\tables\datatable\datatables.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\vendors\css\tables\datatable\extensions\dataTables.checkboxes.css"">
    <!-- END: Vendor CSS-->


    <!-- BEGIN: Page CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\plugins\file-uploaders\dropzone.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\pages\data-list-view.min.css"">
    <!-- END: Page CSS-->
");
                WriteLiteral("\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n  <!-- END: Head-->\n\n  <!-- BEGIN: Body-->\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb4b0444e93640efd896f87fbf782464b881359b9645", async() => {
                WriteLiteral(@"

    <!-- BEGIN: Header-->
    <nav class=""header-navbar navbar-expand-lg navbar navbar-with-menu navbar-fixed navbar-shadow navbar-brand-center"">
      <div class=""navbar-header d-xl-block d-none"">
        <ul class=""nav navbar-nav flex-row"">
          <li class=""nav-item""><a class=""navbar-brand"" href=""index.html"">
              <div class=""brand-logo""></div></a></li>
        </ul>
      </div>
      <div class=""navbar-wrapper"">
        <div class=""navbar-container content"">
          <div class=""navbar-collapse"" id=""navbar-mobile"">
            <div class=""mr-auto float-left bookmark-wrapper d-flex align-items-center"">
              <ul class=""nav navbar-nav"">
                <li class=""nav-item mobile-menu d-xl-none mr-auto""><a class=""nav-link nav-menu-main menu-toggle hidden-xs"" href=""#""><i class=""ficon feather icon-menu""></i></a></li>
              </ul>
         
              <ul class=""nav navbar-nav"">
                <li class=""nav-item d-none d-lg-block""><a class=""nav-link bookmark-star""><i class=""f");
                WriteLiteral(@"icon feather icon-star warning""></i></a>
                  <div class=""bookmark-input search-input"">
                    <div class=""bookmark-input-icon""><i class=""feather icon-search primary""></i></div>
                    <input class=""form-control input"" type=""text"" placeholder=""جستجو در Vuexy ..."" tabindex=""0"" data-search=""template-list"">
                    <ul class=""search-list search-list-bookmark""></ul>
                  </div>
                </li>
              </ul>
            </div>
            <ul class=""nav navbar-nav float-right"">
              <li class=""dropdown dropdown-language nav-item""><a class=""dropdown-toggle nav-link"" id=""dropdown-flag"" href=""#"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><i class=""flag-icon flag-icon-ir""></i><span class=""selected-language"">فارسی</span></a>
                <div class=""dropdown-menu"" aria-labelledby=""dropdown-flag""><a class=""dropdown-item"" href=""../../ltr/horizontal-menu-template"" data-language=""en""><i class=""flag-icon flag-icon-");
                WriteLiteral(@"us""></i> انگلیسی</a><a class=""dropdown-item"" href=""#"" data-language=""fa""><i class=""flag-icon flag-icon-ir""></i>فارسی</a><a class=""dropdown-item"" href=""#"" data-language=""de""><i class=""flag-icon flag-icon-de""></i>آلمان</a><a class=""dropdown-item"" href=""#"" data-language=""pt""><i class=""flag-icon flag-icon-pt""></i>پرتغال</a></div>
              </li>
              <li class=""nav-item d-none d-lg-block""><a class=""nav-link nav-link-expand""><i class=""ficon feather icon-maximize""></i></a></li>
              <li class=""nav-item nav-search""><a class=""nav-link nav-link-search""><i class=""ficon feather icon-search""></i></a>
                <div class=""search-input"">
                  <div class=""search-input-icon""><i class=""feather icon-search primary""></i></div>
                  <input class=""input"" type=""text"" placeholder=""جستجو در Vuexy ..."" tabindex=""-1"" data-search=""template-list"">
                  <div class=""search-input-close""><i class=""feather icon-x""></i></div>
                  <ul class=""search-list search-li");
                WriteLiteral(@"st-main""></ul>
                </div>
              </li>
              <li class=""dropdown dropdown-notification nav-item""><a class=""nav-link nav-link-label"" href=""#"" data-toggle=""dropdown""><i class=""ficon feather icon-bell""></i><span class=""badge badge-pill badge-primary badge-up"">5</span></a>
                <ul class=""dropdown-menu dropdown-menu-media dropdown-menu-right"">
                  <li class=""dropdown-menu-header"">
                    <div class=""dropdown-header m-0 p-2"">
                      <h3 class=""white"">5 اعلان </h3><span class=""notification-title"">جدید برنامه</span>
                    </div>
                  </li>
                  <li class=""scrollable-container media-list""><a class=""d-flex justify-content-between"" href=""javascript:void(0)"">
                      <div class=""media d-flex align-items-start"">
                        <div class=""media-left""><i class=""feather icon-plus-square font-medium-5 primary""></i></div>
                        <div class=""media-body"">
              ");
                WriteLiteral(@"            <h6 class=""primary media-heading"">شما سفارش جدید دارید !</h6><small class=""notification-text"">آیا قصد دارید امشب با من ملاقات کنید؟</small>
                        </div><small>
                          <time class=""media-meta"" datetime=""2015-06-11T18:29:20+08:00"">9 ساعت پیش</time></small>
                      </div></a><a class=""d-flex justify-content-between"" href=""javascript:void(0)"">
                      <div class=""media d-flex align-items-start"">
                        <div class=""media-left""><i class=""feather icon-download-cloud font-medium-5 success""></i></div>
                        <div class=""media-body"">
                          <h6 class=""success media-heading red darken-1"">99% ظرفیت سرور پر است</h6><small class=""notification-text"">شما سفارش جدیدی از کالاها را دریافت کردید</small>
                        </div><small>
                          <time class=""media-meta"" datetime=""2015-06-11T18:29:20+08:00"">5 ساعت پیش</time></small>
                      </div></a><a class=""d-flex ");
                WriteLiteral(@"justify-content-between"" href=""javascript:void(0)"">
                      <div class=""media d-flex align-items-start"">
                        <div class=""media-left""><i class=""feather icon-alert-triangle font-medium-5 danger""></i></div>
                        <div class=""media-body"">
                          <h6 class=""danger media-heading yellow darken-3"">اعلان های هشدار</h6><small class=""notification-text"">سرور 99% CPU را اشغال کرده</small>
                        </div><small>
                          <time class=""media-meta"" datetime=""2015-06-11T18:29:20+08:00"">امروز</time></small>
                      </div></a><a class=""d-flex justify-content-between"" href=""javascript:void(0)"">
                      <div class=""media d-flex align-items-start"">
                        <div class=""media-left""><i class=""feather icon-check-circle font-medium-5 info""></i></div>
                        <div class=""media-body"">
                          <h6 class=""info media-heading"">کار را تکمیل کنید</h6><small class=""no");
                WriteLiteral(@"tification-text"">کاپ کیک کنجد</small>
                        </div><small>
                          <time class=""media-meta"" datetime=""2015-06-11T18:29:20+08:00"">هفته گذشته</time></small>
                      </div></a><a class=""d-flex justify-content-between"" href=""javascript:void(0)"">
                      <div class=""media d-flex align-items-start"">
                        <div class=""media-left""><i class=""feather icon-file font-medium-5 warning""></i></div>
                        <div class=""media-body"">
                          <h6 class=""warning media-heading"">تهیه گزارش ماهانه</h6><small class=""notification-text"">لورم ایپسوم متن ساختگی با تولید سادگی.</small>
                        </div><small>
                          <time class=""media-meta"" datetime=""2015-06-11T18:29:20+08:00"">ماه اخیر</time></small>
                      </div></a></li>
                  <li class=""dropdown-menu-footer""><a class=""dropdown-item p-1 text-center"" href=""javascript:void(0)"">دیدن تمام اعلان ها</a></li>
           ");
                WriteLiteral(@"     </ul>
              </li>
              <li class=""dropdown dropdown-user nav-item""><a class=""dropdown-toggle nav-link dropdown-user-link"" href=""#"" data-toggle=""dropdown"">
                  <div class=""user-nav d-sm-flex d-none""><span class=""user-name text-bold-600"">کریم نعمتی</span><span class=""user-status"">دردسترس</span></div><span><img class=""round"" src=""..\..\..\app-assets\images\portrait\small\avatar-s-11.jpg"" alt=""avatar"" height=""40"" width=""40""></span></a>
                <div class=""dropdown-menu dropdown-menu-right""><a class=""dropdown-item"" href=""page-user-profile.html""><i class=""feather icon-user""></i> ویرایش نمایه</a><a class=""dropdown-item"" href=""app-email.html""><i class=""feather icon-mail""></i> صندوق ورودی من</a><a class=""dropdown-item"" href=""app-todo.html""><i class=""feather icon-check-square""></i> برنامه ها</a><a class=""dropdown-item"" href=""app-chat.html""><i class=""feather icon-message-square""></i> گفتگوها</a>
                  <div class=""dropdown-divider""></div><a class=""dropdown-item"" hre");
                WriteLiteral(@"f=""auth-login.html""><i class=""feather icon-power""></i> خروج</a>
                </div>
              </li>
            </ul>
          </div>
        </div>
      </div>
    </nav>
    <ul class=""main-search-list-defaultlist d-none"">
      <li class=""d-flex align-items-center""><a class=""pb-25"" href=""#"">
          <h6 class=""text-primary mb-0"">فایل ها</h6></a></li>
      <li class=""auto-suggestion d-flex align-items-center cursor-pointer""><a class=""d-flex align-items-center justify-content-between w-100"" href=""#"">
          <div class=""d-flex"">
            <div class=""mr-50""><img src=""..\..\..\app-assets\images\icons\xls.png"" alt=""png"" height=""32""></div>
            <div class=""search-data"">
              <p class=""search-data-title mb-0"">دو مورد جدید ثبت شد</p><small class=""text-muted"">مدیر فروش</small>
            </div>
          </div><small class=""search-data-size mr-50 text-muted"">&apos;17kb</small></a></li>
      <li class=""auto-suggestion d-flex align-items-center cursor-pointer""><a class=""d-flex align");
                WriteLiteral(@"-items-center justify-content-between w-100"" href=""#"">
          <div class=""d-flex"">
            <div class=""mr-50""><img src=""..\..\..\app-assets\images\icons\jpg.png"" alt=""png"" height=""32""></div>
            <div class=""search-data"">
              <p class=""search-data-title mb-0"">52 فایل عکس تهیه شده است</p><small class=""text-muted"">توسعه دهنده FrontEnd</small>
            </div>
          </div><small class=""search-data-size mr-50 text-muted"">&apos;11kb</small></a></li>
      <li class=""auto-suggestion d-flex align-items-center cursor-pointer""><a class=""d-flex align-items-center justify-content-between w-100"" href=""#"">
          <div class=""d-flex"">
            <div class=""mr-50""><img src=""..\..\..\app-assets\images\icons\pdf.png"" alt=""png"" height=""32""></div>
            <div class=""search-data"">
              <p class=""search-data-title mb-0"">25 فایل PDF بارگذاری شده است</p><small class=""text-muted"">مدیر دیجیتال مارکتینگ</small>
            </div>
          </div><small class=""search-data-size mr-50 text");
                WriteLiteral(@"-muted"">&apos;150kb</small></a></li>
      <li class=""auto-suggestion d-flex align-items-center cursor-pointer""><a class=""d-flex align-items-center justify-content-between w-100"" href=""#"">
          <div class=""d-flex"">
            <div class=""mr-50""><img src=""..\..\..\app-assets\images\icons\doc.png"" alt=""png"" height=""32""></div>
            <div class=""search-data"">
              <p class=""search-data-title mb-0"">Anna_Strong</p><small class=""text-muted"">طراح وب سایت</small>
            </div>
          </div><small class=""search-data-size mr-50 text-muted"">&apos;256kb</small></a></li>
      <li class=""d-flex align-items-center""><a class=""pb-25"" href=""#"">
          <h6 class=""text-primary mb-0"">اعضا</h6></a></li>
      <li class=""auto-suggestion d-flex align-items-center cursor-pointer""><a class=""d-flex align-items-center justify-content-between py-50 w-100"" href=""#"">
          <div class=""d-flex align-items-center"">
            <div class=""avatar mr-50""><img src=""..\..\..\app-assets\images\portrait\small\ava");
                WriteLiteral(@"tar-s-8.jpg"" alt=""png"" height=""32""></div>
            <div class=""search-data"">
              <p class=""search-data-title mb-0"">کریم نعمتی </p><small class=""text-muted"">طراح رابط کاربری</small>
            </div>
          </div></a></li>
      <li class=""auto-suggestion d-flex align-items-center cursor-pointer""><a class=""d-flex align-items-center justify-content-between py-50 w-100"" href=""#"">
          <div class=""d-flex align-items-center"">
            <div class=""avatar mr-50""><img src=""..\..\..\app-assets\images\portrait\small\avatar-s-1.jpg"" alt=""png"" height=""32""></div>
            <div class=""search-data"">
              <p class=""search-data-title mb-0"">مسعود اصغرزاده</p><small class=""text-muted"">توسعه دهنده FrontEnd</small>
            </div>
          </div></a></li>
      <li class=""auto-suggestion d-flex align-items-center cursor-pointer""><a class=""d-flex align-items-center justify-content-between py-50 w-100"" href=""#"">
          <div class=""d-flex align-items-center"">
            <div class=""avatar");
                WriteLiteral(@" mr-50""><img src=""..\..\..\app-assets\images\portrait\small\avatar-s-14.jpg"" alt=""png"" height=""32""></div>
            <div class=""search-data"">
              <p class=""search-data-title mb-0"">محمد نوریان</p><small class=""text-muted"">مدیر دیجیتال مارکتینگ</small>
            </div>
          </div></a></li>
      <li class=""auto-suggestion d-flex align-items-center cursor-pointer""><a class=""d-flex align-items-center justify-content-between py-50 w-100"" href=""#"">
          <div class=""d-flex align-items-center"">
            <div class=""avatar mr-50""><img src=""..\..\..\app-assets\images\portrait\small\avatar-s-6.jpg"" alt=""png"" height=""32""></div>
            <div class=""search-data"">
              <p class=""search-data-title mb-0"">هانیه برخوردار</p><small class=""text-muted"">طراح وب سایت</small>
            </div>
          </div></a></li>
    </ul>
    <ul class=""main-search-list-defaultlist-other-list d-none"">
      <li class=""auto-suggestion d-flex align-items-center justify-content-between cursor-pointer""><a c");
                WriteLiteral(@"lass=""d-flex align-items-center justify-content-between w-100 py-50"">
          <div class=""d-flex justify-content-start""><span class=""mr-75 feather icon-alert-circle""></span><span>نتیجه ای پیدا نشد</span></div></a></li>
    </ul>
    <!-- END: Header-->


    <!-- BEGIN: Main Menu-->
    <div class=""horizontal-menu-wrapper"">
      <div class=""header-navbar navbar-expand-sm navbar navbar-horizontal floating-nav navbar-light navbar-without-dd-arrow navbar-shadow menu-border"" role=""navigation"" data-menu=""menu-wrapper"">
        <div class=""navbar-header"">
          <ul class=""nav navbar-nav flex-row"">
            <li class=""nav-item mr-auto""><a class=""navbar-brand"" href=""index.html"">
                <div class=""brand-logo""></div>
                <h2 class=""brand-text mb-0"">Vuexy</h2></a></li>
            <li class=""nav-item nav-toggle""><a class=""nav-link modern-nav-toggle pr-0"" data-toggle=""collapse""><i class=""feather icon-x d-block d-xl-none font-medium-4 primary toggle-icon""></i><i class=""toggle-icon feather i");
                WriteLiteral(@"con-disc font-medium-4 d-none d-xl-block collapse-toggle-icon primary"" data-ticon=""icon-disc""></i></a></li>
          </ul>
        </div>
        <!-- Horizontal menu content-->
        <div class=""navbar-container main-menu-content"" data-menu=""menu-container"">
          <!-- include ../../../includes/mixins-->
          <ul class=""nav navbar-nav"" id=""main-menu-navigation"" data-menu=""menu-navigation"">
            <li class=""dropdown nav-item"" data-menu=""dropdown""><a class=""dropdown-toggle nav-link"" href=""index.html"" data-toggle=""dropdown""><i class=""feather icon-home""></i><span data-i18n=""Dashboard"">پیشخوان</span></a>
              <ul class=""dropdown-menu"">
                <li data-menu=""""><a class=""dropdown-item"" href=""/home/index"" data-toggle=""dropdown"" data-i18n=""Analytics""><i class=""feather icon-activity""></i>ثبت اطلاعات</a>
                </li>
                <li data-menu=""""><a class=""dropdown-item"" href=""/home/list"" data-toggle=""dropdown"" data-i18n=""eCommerce""><i class=""feather icon-shopping-cart""><");
                WriteLiteral(@"/i>مشاهده اطلاعات </a>
                </li>
              </ul>
            </li>
        
           
           
         
     
          </ul>
        </div>
      </div>
    </div>
    <!-- END: Main Menu-->

    <!-- BEGIN: Content-->
    <div class=""app-content content"">
        
      <div class=""content-overlay""></div>
      <div class=""header-navbar-shadow""></div>
      <div class=""content-wrapper"">
        <div class=""content-header row"">
      
          <div class=""content-header-right text-md-right col-md-3 col-12 d-md-block d-none"">
            <div class=""form-group breadcrum-right"">

            </div>
          </div>
        </div>
        <div class=""content-body"">

<!-- Multiple Rules Validation start -->
");
#nullable restore
#line 285 "c:\Users\Neati\Desktop\SampleGet-master\SampleProject\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
<!-- Multiple Rule Validation end -->

        </div>
      </div>
    </div>
    <!-- END: Content-->



    <!-- Buynow Button-->

    </div>
    <div class=""sidenav-overlay""></div>
    <div class=""drag-target""></div>

    <!-- BEGIN: Footer-->
    <footer class=""footer footer-static footer-light navbar-shadow"">
      <p class=""clearfix blue-grey lighten-2 mb-0""><span class=""float-md-left d-block d-md-inline-block mt-25"">حقوق کپی رایت &copy; 1399<a class=""text-bold-800 grey darken-2"" href=""https://hampadcoteam.ir/"" target=""_blank"">   تیم همپاد سیستم آسیا</a>کلیه حقوق محفوظ است</span><span class=""float-md-right d-none d-md-block"">دست ساز و ساخته شده با<i class=""feather icon-heart pink""></i></span>
        <button class=""btn btn-primary btn-icon scroll-top"" type=""button""><i class=""feather icon-arrow-up""></i></button>
      </p>
    </footer>
    <!-- END: Footer-->


    <!-- BEGIN: Vendor JS-->
    <script src=""..\..\..\app-assets\vendors\js\vendors.min.js""></script>
    <!-- BEGIN Vendor JS-->

    <!-- B");
                WriteLiteral(@"EGIN: Page Vendor JS-->
    <script src=""..\..\..\app-assets\vendors\js\ui\jquery.sticky.js""></script>
    <script src=""..\..\..\app-assets\vendors\js\forms\validation\jqBootstrapValidation.js""></script>
    <!-- END: Page Vendor JS-->

    <!-- BEGIN: Theme JS-->
    <script src=""..\..\..\app-assets\js\core\app-menu.min.js""></script>
    <script src=""..\..\..\app-assets\js\core\app.min.js""></script>
    <script src=""..\..\..\app-assets\js\scripts\components.min.js""></script>
    <script src=""..\..\..\app-assets\js\scripts\customizer.min.js""></script>
    <script src=""..\..\..\app-assets\js\scripts\footer.min.js""></script>
    <!-- END: Theme JS-->

    <!-- BEGIN: Page JS-->
    <script src=""..\..\..\app-assets\js\scripts\forms\validation\form-validation.js""></script>
    <!-- END: Page JS-->


    <!-- BEGIN: Page Vendor JS-->
    <script src=""..\..\..\app-assets\vendors\js\extensions\dropzone.min.js""></script>
    <script src=""..\..\..\app-assets\vendors\js\tables\datatable\datatables.min.js""></script>
   ");
                WriteLiteral(@" <script src=""..\..\..\app-assets\vendors\js\tables\datatable\datatables.buttons.min.js""></script>
    <script src=""..\..\..\app-assets\vendors\js\tables\datatable\datatables.bootstrap4.min.js""></script>
    <script src=""..\..\..\app-assets\vendors\js\tables\datatable\buttons.bootstrap.min.js""></script>
    <script src=""..\..\..\app-assets\vendors\js\tables\datatable\dataTables.select.min.js""></script>
    <script src=""..\..\..\app-assets\vendors\js\tables\datatable\datatables.checkboxes.min.js""></script>
    <!-- END: Page Vendor JS-->
   
    <!-- BEGIN: Page JS-->
    <script src=""..\..\..\app-assets\js\scripts\ui\data-list-view.min.js""></script>
    <!-- END: Page JS-->

  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n  <!-- END: Body-->\n</html>\n");
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
