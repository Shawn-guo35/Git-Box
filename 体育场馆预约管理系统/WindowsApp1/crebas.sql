/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2014                    */
/* Created on:     2019/7/3 16:17:24                            */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Lease') and o.name = 'FK_LEASE_×â½è_VENUE')
alter table Lease
   drop constraint FK_LEASE_×â½è_VENUE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Orders') and o.name = 'FK_ORDERS_ORDERS_LEASE')
alter table Orders
   drop constraint FK_ORDERS_ORDERS_LEASE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Orders') and o.name = 'FK_ORDERS_ORDERS2_USERS')
alter table Orders
   drop constraint FK_ORDERS_ORDERS2_USERS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Venue') and o.name = 'FK_VENUE_°üº¬_VTYPE')
alter table Venue
   drop constraint FK_VENUE_°üº¬_VTYPE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Lease')
            and   name  = '×â½è_FK'
            and   indid > 0
            and   indid < 255)
   drop index Lease.×â½è_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Lease')
            and   type = 'U')
   drop table Lease
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Orders')
            and   name  = 'Orders_FK'
            and   indid > 0
            and   indid < 255)
   drop index Orders.Orders_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Orders')
            and   name  = 'Orders2_FK'
            and   indid > 0
            and   indid < 255)
   drop index Orders.Orders2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Orders')
            and   type = 'U')
   drop table Orders
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Users')
            and   type = 'U')
   drop table Users
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Venue')
            and   name  = '°üº¬_FK'
            and   indid > 0
            and   indid < 255)
   drop index Venue.°üº¬_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Venue')
            and   type = 'U')
   drop table Venue
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Vtype')
            and   type = 'U')
   drop table Vtype
go

/*==============================================================*/
/* Table: Lease                                                 */
/*==============================================================*/
create table Lease (
   Vname                varchar(10)          not null,
   Vno                  varchar(10)          not null,
   Stime                datetime             not null,
   Etime                datetime             not null,
   Condition            varchar(10)          not null,
   constraint PK_LEASE primary key (Vname, Vno, Stime)
)
go

/*==============================================================*/
/* Index: ×â½è_FK                                                 */
/*==============================================================*/




create nonclustered index ×â½è_FK on Lease (Vname ASC,
  Vno ASC)
go

/*==============================================================*/
/* Table: Orders                                                */
/*==============================================================*/
create table Orders (
   ID                   varchar(20)          not null,
   Vname                varchar(10)          not null,
   Vno                  varchar(10)          not null,
   Stime                datetime             not null,
   Etime                datetime             not null,
   Ltime                int                  not null,
   Fee                  real                 not null,
   Orderno              varchar(20)          not null,
   Uname                varchar(10)          not null,
   Remark               varchar(50)          null,
   constraint PK_ORDERS primary key (ID, Vname, Vno, Stime)
)
go

/*==============================================================*/
/* Index: Orders2_FK                                            */
/*==============================================================*/




create nonclustered index Orders2_FK on Orders (ID ASC)
go

/*==============================================================*/
/* Index: Orders_FK                                             */
/*==============================================================*/




create nonclustered index Orders_FK on Orders (Vname ASC,
  Vno ASC,
  Stime ASC)
go

/*==============================================================*/
/* Table: Users                                                 */
/*==============================================================*/
create table Users (
   ID                   varchar(20)          not null,
   Uname                varchar(10)          not null,
   Uidentity            varchar(10)          not null,
   Upassword            varchar(20)          not null,
   constraint PK_USERS primary key (ID)
)
go

/*==============================================================*/
/* Table: Venue                                                 */
/*==============================================================*/
create table Venue (
   Vname                varchar(10)          not null,
   Vno                  varchar(10)          not null,
   constraint PK_VENUE primary key (Vname, Vno)
)
go

/*==============================================================*/
/* Index: °üº¬_FK                                                 */
/*==============================================================*/




create nonclustered index °üº¬_FK on Venue (Vname ASC)
go

/*==============================================================*/
/* Table: Vtype                                                 */
/*==============================================================*/
create table Vtype (
   Vname                varchar(10)          not null,
   INrental             real                 not null,
   OUTrental            real                 not null,
   Vaddress             varchar(50)          not null,
   constraint PK_VTYPE primary key (Vname)
)
go

alter table Lease
   add constraint FK_LEASE_×â½è_VENUE foreign key (Vname, Vno)
      references Venue (Vname, Vno)
go

alter table Orders
   add constraint FK_ORDERS_ORDERS_LEASE foreign key (Vname, Vno, Stime)
      references Lease (Vname, Vno, Stime)
go

alter table Orders
   add constraint FK_ORDERS_ORDERS2_USERS foreign key (ID)
      references Users (ID)
go

alter table Venue
   add constraint FK_VENUE_°üº¬_VTYPE foreign key (Vname)
      references Vtype (Vname)
go

