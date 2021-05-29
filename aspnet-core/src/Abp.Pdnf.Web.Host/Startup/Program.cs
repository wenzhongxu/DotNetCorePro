using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Abp.Pdnf.Web.Host.Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //webhost 开启
            BuildWebHost(args).Run();
        }

        /// <summary>
        /// CreateDefaultBuilder配置kestrel服务器 iis相关 其他配置
        /// UseStartup启用用户配置的参数 包括注册的服务、组件和请求处理管道相关内容
        /// 创建webhost
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        }
    }
}
