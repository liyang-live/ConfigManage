<h1><a href="http://www.liyang.live/" target="_blank">官方网站</a></h1>


<h3>配置管理框架</h3>
   <li>该框架仅一个类文件(CommonConfigs.cs)将其拷贝进项目即可</li>
   <li>该框架自带一个基本的SqlServerServiceProvider的实现,如果使用其他数据库连接请自行实现<br/><br/><br/>
         <b> 实现方式：</b><br/>
          <ol>
          <li>继承IServiceProvider接口,实现接口</li>
          <li>使用扩展方法（AddServiceProvider）将实例添加进去,如:CommonConfigs.AddServiceProvider(new OracleServiceProvider());</li>
          </ol>
          </li>
   <br/><br/>       
   <li><b>使用方法：</b><br/><br/>
 调用  CommonConfigs.Instance的扩展方法即可<br/><br/>
 <b>该实例的扩展方法有4种：ConfigInteger、ConfigList、ConfigBoolean、ConfigString</b>
 <ol>
 <li>ConfigInteger：返回int32类型的值，默认返回0</li>
 <li>ConfigString：返回字符串类型的值，默认返回空字符串</li>
 <li>ConfigBoolean：返回布尔类型的值，默认返回false</li>
  <li>ConfigList：返回List<string>类型，默认空实例而不是null,从而避免使用者出错</li>
 </ol>
   </li>



