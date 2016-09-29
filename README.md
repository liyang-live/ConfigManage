# ConfigManage

<h1>配置管理框架</h1>
   <li>该框架进一个类文件(CommonConfigs.cs)将其拷贝进项目即可</li>
   <li>该框架自带一个基本的SqlServerServiceProvider的实现,如果使用其他数据库连接请自行实现<br/>
          实现方式：<br/>
          <ol>继承IServiceProvider接口,实现接口</ol>
          <ol>使用扩展方法（AddServiceProvider）将实例添加进去,如:CommonConfigs.AddServiceProvider(new OracleServiceProvider());</ol>
          </li>
   <li></li>
