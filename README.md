# Tymespace 
> ASP.NET Core MVC web application.
> Live demo [_here_](https://tymespace.herokuapp.com/). 
> It may take up to 2 minutes to load.

## Table of Contents
* [General Info](#general-information)
* [Technologies Used](#technologies-used)
* [Features](#features)
* [Screenshots](#screenshots)
* [Setup](#setup)
* [Project Status](#project-status)
* [Room for Improvement](#room-for-improvement)



## General Information

- The purpose of this project was to create a mockup satellite services web app that offers either satellite services from providers or a satellite availability to rent them. 
- If implemented this app should bring a new perspective towards how regular customer uses active satellites if they are available at the moment.
- My main purpose upon making this project was to learn ASP.NET MVC, implement database and user authentication.


## Technologies Used
- Microsoft ASP.NET Core - version 6.0.1
- Microsoft Entity Framework - version 6.0.1
- Microsoft Entity Framework SQL Server - version 6.0.1
- MySQL Connector - version 2.1.5
- Entity Framework Pomelo - 6.0.1
- Microsoft ASP.NET Core MVC - version 2.2.5
- MySql - version 8.0.28
- AutoMapper - version 11.0.1
- Microsoft ASP.NET Core Identity - version 2.2.0
- jQuery DataTables - version 1.11.4
- Razor pages


## Features
- Authentication -- website is protected from unauthenticated users' unwanted actions with AntiForgery Cookie.
- Authorization --  this app provides 4 different user roles: Administrator, Satellite Owner, Service Provider, and Customer. Each of them has a different accessibility level. 
  - *Customer* Role enables a user to view both lists of Service Providers and Satellites. Also, they have access to book a service or rent a Satellite.
  - *Service Provider* role gives the user the same accessibility as Customer Role with the addition of new service creation. New Service is immediately added to the service list and is visible to Customers.
  - *Satellite Owner* role gives the user the same accessibility as Customer Role with the addition of new Satellite creation. New Satellite is immediately added to Satellites list and is visible to Customers for booking.
  - *Administrator* role gives full access to the user. The administrator can create, edit and delete both Services and Satellites. 
- WEB API -- provided API gives access to users to GET, POST, EDIT and DELETE both Services and Satellites. At this stage Data Transfer Objects (DTOs) were used to ensure that only specific data would be available for users to get.
- Database -- with integrated external database all new users are registered and saved externally. That gives the application ability to remember and authenticate registered users.


## Screenshots
### Difference between Admin and Customer role view in Satellite section
![Example screenshot](/img/Customer-satellites.PNG)
![Example screenshot](/img/admin-satellite.jpg)

### Database Model
![Example screenshot](/img/DB_Model.PNG)
<!-- If you have screenshots you'd like to share, include them here. -->


## Setup
- Open project locally
- Build sollution `dotnet build` 
- Update required dependencies `Tools` => `NuGet Package Manager` => `Manage NuGet Packages for Solution` => `Updates` => `Select All` => `Update`
- Run project `dotnet run`

## Project Status
_in progress_ 


## Room for Improvement
While this is a working project there are a lot of things that need to be created or improved. 

Room for improvement:
- Home page responsiveness on smaller screens.
- User experience bugs.

To do:
- Create a service bookingform, add functionality to it.
- Create a satellite count, so when the satellite is rented users on-site can see the count change.
- Make an automatic satellite reservation button with a limited time to rent one. When time ends the count should go up by 1.


