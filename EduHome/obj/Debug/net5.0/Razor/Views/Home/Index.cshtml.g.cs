#pragma checksum "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "463b50349372ef404f90ca7bac576f011df00979"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463b50349372ef404f90ca7bac576f011df00979", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98c5becdebf98bcd12e5fb9b6debed59b5ea534", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("default-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teachers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("default-btn d-block mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BlogDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Background Area Start -->\r\n        <section id=\"slider-container\" class=\"slider-area two\"> \r\n            <div class=\"slider-owl owl-theme owl-carousel\"> \r\n          \r\n");
#nullable restore
#line 6 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
                 foreach (Slider slider in Model.Sliders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <!-- Start Slingle Slide -->\r\n            <div class=\"single-slide item\"");
            BeginWriteAttribute("style", " style=\"", 342, "\"", 400, 4);
            WriteAttributeValue("", 350, "background-image:", 350, 17, true);
            WriteAttributeValue(" ", 367, "url(../img/slider/", 368, 19, true);
#nullable restore
#line 9 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
WriteAttributeValue("", 386, slider.Image, 386, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 399, ")", 399, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                <!-- Start Slider Content -->
                <div class=""slider-content-area"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-10 col-md-offset-1"">
                                <div class=""slide-content-wrapper"">
                                    <div class=""slide-content text-center"">
                                        <h2>");
#nullable restore
#line 17 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
                                       Write(slider.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n                                        <p>");
#nullable restore
#line 18 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
                                      Write(slider.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463b50349372ef404f90ca7bac576f011df009797638", async() => {
                WriteLiteral("Learn more");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Start Slider Content -->
            </div>
            <!-- End Slingle Slide -->
");
#nullable restore
#line 29 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </section>\r\n\t\t<!-- Background Area End -->\r\n        <!-- Service Start -->\r\n                <div class=\"service-area two pt-150 pb-150\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 37 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
                     foreach (Service service in Model.Services)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 col-sm-4 col-xs-12\">\r\n                    <div class=\"single-service\">\r\n                        <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463b50349372ef404f90ca7bac576f011df0097910255", async() => {
#nullable restore
#line 41 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
                                                                       Write(service.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 42 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
                      Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 45 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   
                </div>
            </div>
        </div>
        <!-- Service End -->
        <!-- About Start -->
        <div class=""about-area pb-155"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-6 col-sm-6"">
                        <div class=""about-content"">
                    <h2>");
#nullable restore
#line 57 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.About.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    ");
#nullable restore
#line 58 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
               Write(Html.Raw(Model.About.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463b50349372ef404f90ca7bac576f011df0097913275", async() => {
                WriteLiteral("About Us");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-6 col-sm-6\">\r\n                        <div class=\"about-img\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2806, "\"", 2840, 2);
            WriteAttributeValue("", 2812, "img/about/", 2812, 10, true);
#nullable restore
#line 64 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
WriteAttributeValue("", 2822, Model.About.Image, 2822, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""about"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- About End -->
        <!-- Courses Area Start -->
        <div class=""courses-area two pt-150 pb-150 text-center"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <div class=""section-title"">
                            <img src=""img/icon/section1.png"" alt=""section-title"">
                            <h2>COURSES WE OFFER</h2>
                  
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-4 col-sm-6 col-xs-12"">
                        <div class=""single-course"">
                            <div class=""course-img"">
                                <a href=""course-details.html""><img src=""img/course/course1.jpg"" alt=""course"">
                              ");
            WriteLiteral(@"      <div class=""course-hover"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </a>
                            </div>
                            <div class=""course-content"">
                                <h3><a href=""course-details.html"">CSE ENGINEERING</a></h3>
                                <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness</p>
                                <a class=""default-btn"" href=""course-details.html"">read more</a>

                            </div>   
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12"">
                        <div class=""single-course"">
                            <div class=""course-img"">
                                <a href=""course-details.html""><img src=""img/course/course2.jpg"" alt=""course"">
             ");
            WriteLiteral(@"                       <div class=""course-hover"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </a>
                            </div>
                            <div class=""course-content"">
                                <h3><a href=""course-details.html"">political science</a></h3>
                                <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness</p>
                                <a class=""default-btn"" href=""course-details.html"">read more</a>
                            </div>   
                        </div>
                    </div>
                    <div class=""col-md-4 hidden-sm col-xs-12"">
                        <div class=""single-course"">
                            <div class=""course-img"">
                                <a href=""course-details.html""><img src=""img/course/course3.jpg"" alt=""cours");
            WriteLiteral(@"e"">
                                    <div class=""course-hover"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </a>
                            </div>
                            <div class=""course-content"">
                                <h3><a href=""course-details.html"">micro biology</a></h3>
                                <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness</p>
                                <a class=""default-btn"" href=""course-details.html"">read more</a>
                            </div>
                
                        </div>
            
                    </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463b50349372ef404f90ca7bac576f011df0097919419", async() => {
                WriteLiteral("view all courses");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
   
            </div>
   
        </div>
        <!-- Courses Area End -->
        <!-- Notice Start -->
        <section class=""notice-area two pt-140"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-6 col-sm-6 col-xs-12"">
                        <div class=""notice-right-wrapper mb-25 pb-25"">
                            <h3>TAKE A VIDEO TOUR</h3>
                            <div class=""notice-video"">
                                <div class=""video-icon video-hover"">
                                    <a class=""video-popup"" href=""https://www.youtube.com/watch?v=to6Ghf8UL7o"">
                                        <i class=""zmdi zmdi-play""></i>
                                    </a>
                                </div>
                            </div>
                        </div> 
                    </div>
                    <div class=""col-md-6 col-sm-6 col-xs-12"">
                     ");
            WriteLiteral(@"   <div class=""notice-left-wrapper"">  
                            <h3>notice board</h3>
                            <div class=""notice-left"">
                                <div class=""single-notice-left mb-23 pb-20"">
                                    <h4>5, June 2017</h4>
                                    <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                                </div>
                                <div class=""single-notice-left hidden-sm mb-23 pb-20"">
                                    <h4>4, June 2017</h4>
                                    <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                                </div>
                                <div class=""single-notice-left pb-70"">
                                    <h4>3, June 2017</h4>
                                   ");
            WriteLiteral(@" <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                                </div>
                                <div class=""single-notice-left mb-23 pb-20"">
                                    <h4>5, June 2017</h4>
                                    <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                                </div>
                                <div class=""single-notice-left hidden-sm mb-23 pb-20"">
                                    <h4>4, June 2017</h4>
                                    <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                                </div>
                                <div class=""single-notice-left pb-70"">
                                    <h4>3, June 2017</h4>
  ");
            WriteLiteral(@"                                  <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                                </div>
                            </div>
                        </div>    
                    </div>
                </div>
            </div>
        </section>
        <!-- Notice End -->
        <!-- Event Area Start -->
        <div class=""event-area two text-center pt-100 pb-145"">
            <div class=""container"">
                <div class=""row"">
                     <div class=""col-xs-12"">
                        <div class=""section-title"">
                            <img src=""img/icon/section.png"" alt=""section-title"">
                            <h2>UPCOMMING EVENTS</h2>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-6 col-sm-12 col-xs-12"">
                        <div ");
            WriteLiteral(@"class=""single-event mb-35"">
                            <div class=""event-img"">
                                <a href=""event-details.html""><img src=""img/event/event1.jpg"" alt=""event""></a>
                            </div>
                            <div class=""event-content text-left"">
                                <h3>20 June 2017</h3>
                                <h4><a href=""event-details.html"">ADVANCE PHP WORKSHOP</a></h4>
                                <ul>
                                    <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                    <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                                </ul>
                                <div class=""event-content-right"">
                                    <a class=""default-btn"" href=""event-details.html"">join now</a>
                                </div>
                            </div>
                        </div>
                    </div>
            ");
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <!-- Event Area End -->
        <!-- Testimonial Area Start -->
        <div class=""testimonial-area pt-110 pb-105 text-center"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""testimonial-owl owl-theme owl-carousel"">
                        <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                            <div class=""single-testimonial"">
                                <div class=""testimonial-info"">
                                    <div class=""testimonial-img"">
                                        <img src=""img/testimonial/testimonial.jpg"" alt=""testimonial"">
                                    </div>
                                    <div class=""testimonial-content"">
                                        <p>I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and I will give you a coete account of the system, and");
            WriteLiteral(@" expound the actual</p>
                                        <h4>David Morgan</h4>
                                        <h5>Student, CSE</h5>
                                    </div>
                                </div>
                            </div>
                        </div> 
                    </div>
                </div>
            </div>
        </div>
        <!-- Testimonial Area End -->
        <!-- Blog Area Start -->
        <div class=""blog-area pt-150 pb-150"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <div class=""section-title text-center"">
                            <img src=""img/icon/section.png"" alt=""section-title"">
                            <h2>LATEST FROM BLOG</h2>
                        </div>
                    </div>
                </div>
                <div class=""row"">
");
#nullable restore
#line 264 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
               foreach (Blog blog in Model.Blogs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                    <div class=\"single-blog\">\r\n                        <div class=\"blog-img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463b50349372ef404f90ca7bac576f011df0097928717", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 14212, "\"", 14238, 2);
                WriteAttributeValue("", 14218, "img/blog/", 14218, 9, true);
#nullable restore
#line 269 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
WriteAttributeValue("", 14227, blog.Image, 14227, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"blog\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"blog-hover\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463b50349372ef404f90ca7bac576f011df0097930625", async() => {
                WriteLiteral("<i class=\"fa fa-link\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"blog-content\">\r\n                            <div class=\"blog-top\">\r\n                                <p>By ");
#nullable restore
#line 276 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
                                 Write(blog.By);

#line default
#line hidden
#nullable disable
            WriteLiteral("  /  ");
#nullable restore
#line 276 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
                                              Write(blog.CreateTime.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" /<i class=\"fa fa-comments-o\"></i> 4</p>\r\n                            </div>\r\n                            <div class=\"blog-bottom\">\r\n                                <h2>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463b50349372ef404f90ca7bac576f011df0097932926", async() => {
#nullable restore
#line 279 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"
                                                                                  Write(blog.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h2>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463b50349372ef404f90ca7bac576f011df0097934537", async() => {
                WriteLiteral("read more");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div> \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 285 "C:\Users\MacBook\Desktop\108\EduHome\EduHome\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <!-- Blog Area End -->\r\n    ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
