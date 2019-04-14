using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using expensejar.Configuration;

namespace expensejar.Web.Host.Startup
{
    [DependsOn(
       typeof(expensejarWebCoreModule))]
    public class expensejarWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public expensejarWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(expensejarWebHostModule).GetAssembly());
        }
    }
}
