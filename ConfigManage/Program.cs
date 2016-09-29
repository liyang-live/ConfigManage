using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfigManage
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = CommonConfigs.Instance.ConfigString(new ConfigString
            {
                Name = "测试",
                ButtonType = EnumButtonType.TextBox,
                Classify = "测试|测试类",
                Parameter = "1",
                Remark = "aaaaaaaaaaaaaaaaaaaa"
            });


            Console.WriteLine("测试:" + result);

            var result1 = CommonConfigs.Instance.ConfigInteger(new ConfigInteger
            {
                Name = "测试qq",
                ButtonType = EnumButtonType.TextBox,
                Classify = "测试|测试类",
                Parameter = 1111,
                Remark = "aaaaaaaaaaaaaaaaaaaa"
            });

            Console.WriteLine("测试qq:" + result1);

            var result2 = CommonConfigs.Instance.ConfigList(new ConfigList
            {
                Name = "测试dd",
                ButtonType = EnumButtonType.TextBox,
                Classify = "测试|测试类",
                Parameter = new List<string> { "1", "2", "3" },
                Remark = "aaaaaaaaaaaaaaaaaaaa"
            });

            Console.WriteLine("测试dd：" + string.Join(";", result2));

            var result3 = CommonConfigs.Instance.ConfigList(new ConfigList
            {
                Name = "测试ff",
                ButtonType = EnumButtonType.TextBox,
                Classify = "测试|测试类",
                Parameter = new List<string> { },
                Remark = "aaaaaaaaaaaaaaaaaaaa"
            });


            Console.WriteLine("测试ff：" + string.Join(";", result3));


            var result4 = CommonConfigs.Instance.ConfigList(new ConfigList
            {
                Name = "测试gg",
                ButtonType = EnumButtonType.TextBox,
                Classify = "测试|测试类",
                Parameter = null,
                Remark = "aaaaaaaaaaaaaaaaaaaa"
            });


            Console.WriteLine("测试gg：" + string.Join(";", result4));

            // CommonConfigs.AddServiceProvider(new OracleServiceProvider());

            var result5 = CommonConfigs.Instance.ConfigBoolean(new ConfigBoolean
            {
                Name = "测试bbbbb",
                ButtonType = EnumButtonType.TextBox,
                Classify = "测试|测试类",
                Parameter = false,
                Remark = "aaaaaaaaaaaaaaaaaaaa"
            });


            Console.WriteLine("测试bbbbb：" + result5);


            ////并发
            //Parallel.For(0, 10000, f =>
            //{

            //    CommonConfigs.Instance.ConfigBoolean(new ConfigBoolean
            //    {
            //        Name = f.ToString(),
            //        ButtonType = EnumButtonType.TextBox,
            //        Classify = "测试|测试类",
            //        Parameter = (f % 2 > 0 ? false : true),
            //        Remark = "aaaaaaaaaaaaaaaaaaaa"
            //    });

            //});



            //for (int i = 0; i < 10000; i++)
            //{
            //    var result5 = CommonConfigs.Instance.ConfigBoolean(new ConfigBoolean
            //    {
            //        Name = i.ToString(),
            //        ButtonType = EnumButtonType.TextBox,
            //        Classify = "测试|测试类",
            //        Parameter = false,
            //        Remark = "aaaaaaaaaaaaaaaaaaaa"
            //    });


            //Console.WriteLine("list33类型测试" + result5);
            //}

            Console.ReadKey();
        }

        public class OracleServiceProvider : IServiceProvider
        {
            public bool CreateConfig(ConfigModel config)
            {
                return true;
            }

            public List<ConfigModel> GetConfigList()
            {
                return new List<ConfigModel>();
            }
        }
    }
}
