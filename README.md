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

#### 环境准备
1. 安装node.js
2. 安装cnpm
```shell
npm install -g cnpm --registry=https://registry.npm.taobao.org
# npm config set registry https://registry.npm.taobao.org
```
3. 全局安装vue
```shell
cnpm install –g vue-cli
```

#### 项目搭建
```
    cd/d F:\MyProject\DotNetCorePro\vue
    npm install -g yarn
    yarn install 
```

#### 启动
```
    yarn serve
```

