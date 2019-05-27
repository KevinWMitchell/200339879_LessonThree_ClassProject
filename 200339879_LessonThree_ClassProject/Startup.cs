using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200339879_LessonThree_ClassProject.Startup))]
namespace _200339879_LessonThree_ClassProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
