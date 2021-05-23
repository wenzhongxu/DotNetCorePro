# DotNetCorePro
.net 5.0 project and vue study

## 项目介绍

### 基础框架

#### 后端
* <a href="https://aspnetboilerplate.com/" target="_blank">abp</a>
> ABP 提供了一个应用程序开发模型，用于最佳实践。它拥有基础类、接口和工具使我们容易建立起可维护的大规模的应用程序。



## 开始

### 后端
#### 修改配置并编译
1. 修改**projectName.Web.Host**的appsettings.json中数据库连接；
2. 设置**projectName.Web.Host**为启动程序，并编译；
3. VS2019 选择“菜单>工具>NuGet包管理器>程序包管理器控制台”，打开程序包管理器控制台；
4. 选择默认项目为**projectName.EntityFrameworkCore**，并执行Update-Database创建数据库；
5. 运行程序，启动API


### 前端

#### 安装依赖
```
    cd vue
    npm install yarn
    yarn install 
```

#### 启动
```
    yarn serve
```

