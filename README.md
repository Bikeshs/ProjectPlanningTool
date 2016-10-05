TeamBins
========

A Project management/Planning/Customer service tool built with Microsoft technologies.


![alt text](https://f.cloud.github.com/assets/144469/2100571/faf145c4-8f49-11e3-8125-b781b5d4c52f.png "Issue listing")

![alt text](https://f.cloud.github.com/assets/144469/2100576/0584619c-8f4a-11e3-8c67-48ae551f7e32.png "Issue details")

Built with
-----------

* <del>ASP.NET MVC 6</del> Asp.Net Core 1.0
* <del>ASP.NET SignalR</del> Needs to be changed to support dot net core.
* Windows Azure (Blog storage for file upload)
* Angular JS
* jQuery
* jQuery UI
* Chart.Js
* Twitter bootstrap
* Typescript
* <del>Entity framework</del> Dapper
* Passion for developing something cool and giving to the community


Installation / Setup
--------------
You need VS2015 + Dot net core installed to run the project.

+ Download the source code from github
+ Publish the Web project
+ Create a new database, run the migration scripts against your database. I created a simple migration tool which i use to push db changes to the live hosted version. You can use the same. Go to `DbMigration/` and run the `SimpleSqlMigrate` exe. You need to input the location where you have the sql scripts(There is a sub folder called "scripts" which has the scripts needed) and the connection string.
+ Update the connection string,app settings values in your web.config
+ Profit !

###Special Thanks to
* All those wonderful people who worked behind those open source libraries 
* Jabbr friends

###How to contribute
Write your feature and send a PR ! :) 



    
