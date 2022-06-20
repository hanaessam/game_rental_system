/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/30/2022 3:49:09 AM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADMIN') and o.name = 'FK_ADMIN_UPDATEDET_ADMIN')
alter table ADMIN
   drop constraint FK_ADMIN_UPDATEDET_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GAME') and o.name = 'FK_GAME_ADD_ADMIN')
alter table GAME
   drop constraint FK_GAME_ADD_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GAME') and o.name = 'FK_GAME_BROWSE_CLIENT')
alter table GAME
   drop constraint FK_GAME_BROWSE_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GAME') and o.name = 'FK_GAME_UPDATE_ADMIN')
alter table GAME
   drop constraint FK_GAME_UPDATE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENT') and o.name = 'FK_RENT_RENT_CLIENT')
alter table RENT
   drop constraint FK_RENT_RENT_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENT') and o.name = 'FK_RENT_RENT2_GAME')
alter table RENT
   drop constraint FK_RENT_RENT2_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"RETURN"') and o.name = 'FK_RETURN_RETURN_CLIENT')
alter table "RETURN"
   drop constraint FK_RETURN_RETURN_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"RETURN"') and o.name = 'FK_RETURN_RETURN2_GAME')
alter table "RETURN"
   drop constraint FK_RETURN_RETURN2_GAME
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADMIN')
            and   name  = 'UPDATEDETAILS_FK'
            and   indid > 0
            and   indid < 255)
   drop index ADMIN.UPDATEDETAILS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENT')
            and   type = 'U')
   drop table CLIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GAME')
            and   name  = 'BROWSE_FK'
            and   indid > 0
            and   indid < 255)
   drop index GAME.BROWSE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GAME')
            and   name  = 'UPDATE_FK'
            and   indid > 0
            and   indid < 255)
   drop index GAME.UPDATE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GAME')
            and   name  = 'ADD_FK'
            and   indid > 0
            and   indid < 255)
   drop index GAME.ADD_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GAME')
            and   type = 'U')
   drop table GAME
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENT')
            and   name  = 'RENT2_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENT.RENT2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENT')
            and   name  = 'RENT_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENT.RENT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RENT')
            and   type = 'U')
   drop table RENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"RETURN"')
            and   name  = 'RETURN2_FK'
            and   indid > 0
            and   indid < 255)
   drop index "RETURN".RETURN2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"RETURN"')
            and   name  = 'RETURN_FK'
            and   indid > 0
            and   indid < 255)
   drop index "RETURN".RETURN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"RETURN"')
            and   type = 'U')
   drop table "RETURN"
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   EMAIL                varchar(256)         not null,
   ADM_EMAIL            varchar(256)         null,
   PASSWORD             varchar(15)          not null,
   ADDRESS              varchar(256)         not null,
   PHONE                int                  not null,
   FNAME                varchar(256)         not null,
   LNAME                varchar(256)         not null,
   constraint PK_ADMIN primary key (EMAIL)
)
go

/*==============================================================*/
/* Index: UPDATEDETAILS_FK                                      */
/*==============================================================*/




create nonclustered index UPDATEDETAILS_FK on ADMIN (ADM_EMAIL ASC)
go

/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
create table CLIENT (
   CLIENTEMAIL          varchar(256)         not null,
   CLIENTPASSWORD       varchar(15)          not null,
   CLEINTADDRESS        varchar(256)         not null,
   CLIENTFNAME          varchar(256)         not null,
   CLIENTLNAME          varchar(256)         not null,
   CLIENTPHONE          int                  not null,
   constraint PK_CLIENT primary key (CLIENTEMAIL)
)
go

/*==============================================================*/
/* Table: GAME                                                  */
/*==============================================================*/
create table GAME (
   ADM_EMAIL            varchar(256)         null,
   EMAIL                varchar(256)         not null,
   GID                  int                  not null,
   CLIENTEMAIL          varchar(256)         not null,
   GNAME                varchar(256)         not null,
   CATEGORY             varchar(256)         not null,
   YEAR                 datetime             not null,
   VNAME                varchar(256)         not null,
   PRICE                float                not null,
   constraint PK_GAME primary key (GID)
)
go

/*==============================================================*/
/* Index: ADD_FK                                                */
/*==============================================================*/




create nonclustered index ADD_FK on GAME (ADM_EMAIL ASC)
go

/*==============================================================*/
/* Index: UPDATE_FK                                             */
/*==============================================================*/




create nonclustered index UPDATE_FK on GAME (EMAIL ASC)
go

/*==============================================================*/
/* Index: BROWSE_FK                                             */
/*==============================================================*/




create nonclustered index BROWSE_FK on GAME (CLIENTEMAIL ASC)
go

/*==============================================================*/
/* Table: RENT                                                  */
/*==============================================================*/
create table RENT (
   CLIENTEMAIL          varchar(256)         not null,
   EMAIL                varchar(256)         not null,
   GID                  int                  not null,
   RENTDATE             datetime             not null,
   constraint PK_RENT primary key (EMAIL, CLIENTEMAIL, GID)
)
go

/*==============================================================*/
/* Index: RENT_FK                                               */
/*==============================================================*/




create nonclustered index RENT_FK on RENT (CLIENTEMAIL ASC)
go

/*==============================================================*/
/* Index: RENT2_FK                                              */
/*==============================================================*/




create nonclustered index RENT2_FK on RENT (GID ASC)
go

/*==============================================================*/
/* Table: "RETURN"                                              */
/*==============================================================*/
create table "RETURN" (
   CLIENTEMAIL          varchar(256)         not null,
   EMAIL                varchar(256)         not null,
   GID                  int                  not null,
   RETURNDATE           datetime             not null,
   constraint PK_RETURN primary key (EMAIL, CLIENTEMAIL, GID)
)
go

/*==============================================================*/
/* Index: RETURN_FK                                             */
/*==============================================================*/




create nonclustered index RETURN_FK on "RETURN" (CLIENTEMAIL ASC)
go

/*==============================================================*/
/* Index: RETURN2_FK                                            */
/*==============================================================*/




create nonclustered index RETURN2_FK on "RETURN" (GID ASC)
go

alter table ADMIN
   add constraint FK_ADMIN_UPDATEDET_ADMIN foreign key (ADM_EMAIL)
      references ADMIN (EMAIL)
go

alter table GAME
   add constraint FK_GAME_ADD_ADMIN foreign key (ADM_EMAIL)
      references ADMIN (EMAIL)
go

alter table GAME
   add constraint FK_GAME_BROWSE_CLIENT foreign key (CLIENTEMAIL)
      references CLIENT (CLIENTEMAIL)
go

alter table GAME
   add constraint FK_GAME_UPDATE_ADMIN foreign key (EMAIL)
      references ADMIN (EMAIL)
go

alter table RENT
   add constraint FK_RENT_RENT_CLIENT foreign key (CLIENTEMAIL)
      references CLIENT (CLIENTEMAIL)
go

alter table RENT
   add constraint FK_RENT_RENT2_GAME foreign key (GID)
      references GAME (GID)
go

alter table "RETURN"
   add constraint FK_RETURN_RETURN_CLIENT foreign key (CLIENTEMAIL)
      references CLIENT (CLIENTEMAIL)
go

alter table "RETURN"
   add constraint FK_RETURN_RETURN2_GAME foreign key (GID)
      references GAME (GID)
go

