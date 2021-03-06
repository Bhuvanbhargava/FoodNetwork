USE [master]
GO
/****** Object:  Database [testfnDb]    Script Date: 9/2/2015 10:34:16 PM ******/
CREATE DATABASE [testfnDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'testfnDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\testfnDb.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'testfnDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\testfnDb_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [testfnDb] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [testfnDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [testfnDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [testfnDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [testfnDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [testfnDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [testfnDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [testfnDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [testfnDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [testfnDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [testfnDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [testfnDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [testfnDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [testfnDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [testfnDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [testfnDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [testfnDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [testfnDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [testfnDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [testfnDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [testfnDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [testfnDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [testfnDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [testfnDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [testfnDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [testfnDb] SET  MULTI_USER 
GO
ALTER DATABASE [testfnDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [testfnDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [testfnDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [testfnDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [testfnDb] SET DELAYED_DURABILITY = DISABLED 
GO
USE [testfnDb]
GO
/****** Object:  User [BOSS22\Bhuvan]    Script Date: 9/2/2015 10:34:16 PM ******/
CREATE USER [BOSS22\Bhuvan] FOR LOGIN [BOSS22\Bhuvan] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 9/2/2015 10:34:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 9/2/2015 10:34:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[AddressId] [uniqueidentifier] NOT NULL,
	[Apartment] [nvarchar](max) NULL,
	[City] [nvarchar](max) NOT NULL,
	[ContactNumber] [nvarchar](max) NULL,
	[EmailId] [nvarchar](max) NOT NULL,
	[RestaurantId] [uniqueidentifier] NOT NULL,
	[State] [nvarchar](max) NOT NULL,
	[Street] [nvarchar](max) NOT NULL,
	[Zip] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](max) NOT NULL,
	[Country_CodeLookupId] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.Addresses] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CodeLookups]    Script Date: 9/2/2015 10:34:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodeLookups](
	[CodeLookupId] [nvarchar](128) NOT NULL,
	[Code] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](max) NOT NULL,
	[CountryName] [nvarchar](max) NULL,
	[Ethnicity] [nvarchar](max) NULL,
	[MenuCategoryName] [nvarchar](max) NULL,
	[FoodCategoryName] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Seperator] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.CodeLookups] PRIMARY KEY CLUSTERED 
(
	[CodeLookupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dishes]    Script Date: 9/2/2015 10:34:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dishes](
	[DishId] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Price] [decimal](7, 2) NOT NULL,
	[SpiceLavel] [int] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](max) NOT NULL,
	[Category_CodeLookupId] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.Dishes] PRIMARY KEY CLUSTERED 
(
	[DishId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DishMenus]    Script Date: 9/2/2015 10:34:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DishMenus](
	[Dish_DishId] [uniqueidentifier] NOT NULL,
	[Menu_MenuId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.DishMenus] PRIMARY KEY CLUSTERED 
(
	[Dish_DishId] ASC,
	[Menu_MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Menus]    Script Date: 9/2/2015 10:34:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menus](
	[MenuId] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](max) NOT NULL,
	[Category_CodeLookupId] [nvarchar](128) NULL,
	[Restaurant_RestaurantId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.Menus] PRIMARY KEY CLUSTERED 
(
	[MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Restaurants]    Script Date: 9/2/2015 10:34:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Restaurants](
	[RestaurantId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[AddressId] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](max) NOT NULL,
	[FoodType_CodeLookupId] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.Restaurants] PRIMARY KEY CLUSTERED 
(
	[RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 9/2/2015 10:34:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[ReviewId] [uniqueidentifier] NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](max) NOT NULL,
	[Rating_CodeLookupId] [nvarchar](128) NULL,
	[Restaurant_RestaurantId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.Reviews] PRIMARY KEY CLUSTERED 
(
	[ReviewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TestEntities]    Script Date: 9/2/2015 10:34:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestEntities](
	[TestEntityId] [uniqueidentifier] NOT NULL DEFAULT (newsequentialid()),
	[Name] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.TestEntities] PRIMARY KEY CLUSTERED 
(
	[TestEntityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Country_CodeLookupId]    Script Date: 9/2/2015 10:34:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Country_CodeLookupId] ON [dbo].[Addresses]
(
	[Country_CodeLookupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_RestaurantId]    Script Date: 9/2/2015 10:34:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_RestaurantId] ON [dbo].[Addresses]
(
	[RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Category_CodeLookupId]    Script Date: 9/2/2015 10:34:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Category_CodeLookupId] ON [dbo].[Dishes]
(
	[Category_CodeLookupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Dish_DishId]    Script Date: 9/2/2015 10:34:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Dish_DishId] ON [dbo].[DishMenus]
(
	[Dish_DishId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Menu_MenuId]    Script Date: 9/2/2015 10:34:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Menu_MenuId] ON [dbo].[DishMenus]
(
	[Menu_MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Category_CodeLookupId]    Script Date: 9/2/2015 10:34:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Category_CodeLookupId] ON [dbo].[Menus]
(
	[Category_CodeLookupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Restaurant_RestaurantId]    Script Date: 9/2/2015 10:34:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Restaurant_RestaurantId] ON [dbo].[Menus]
(
	[Restaurant_RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_FoodType_CodeLookupId]    Script Date: 9/2/2015 10:34:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_FoodType_CodeLookupId] ON [dbo].[Restaurants]
(
	[FoodType_CodeLookupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Rating_CodeLookupId]    Script Date: 9/2/2015 10:34:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Rating_CodeLookupId] ON [dbo].[Reviews]
(
	[Rating_CodeLookupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Restaurant_RestaurantId]    Script Date: 9/2/2015 10:34:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Restaurant_RestaurantId] ON [dbo].[Reviews]
(
	[Restaurant_RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Addresses] ADD  DEFAULT (newsequentialid()) FOR [AddressId]
GO
ALTER TABLE [dbo].[Dishes] ADD  DEFAULT (newsequentialid()) FOR [DishId]
GO
ALTER TABLE [dbo].[Menus] ADD  DEFAULT (newsequentialid()) FOR [MenuId]
GO
ALTER TABLE [dbo].[Restaurants] ADD  DEFAULT (newsequentialid()) FOR [RestaurantId]
GO
ALTER TABLE [dbo].[Reviews] ADD  DEFAULT (newsequentialid()) FOR [ReviewId]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Addresses_dbo.CodeLookups_Country_CodeLookupId] FOREIGN KEY([Country_CodeLookupId])
REFERENCES [dbo].[CodeLookups] ([CodeLookupId])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_dbo.Addresses_dbo.CodeLookups_Country_CodeLookupId]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Addresses_dbo.Restaurants_RestaurantId] FOREIGN KEY([RestaurantId])
REFERENCES [dbo].[Restaurants] ([RestaurantId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_dbo.Addresses_dbo.Restaurants_RestaurantId]
GO
ALTER TABLE [dbo].[Dishes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Dishes_dbo.CodeLookups_Category_CodeLookupId] FOREIGN KEY([Category_CodeLookupId])
REFERENCES [dbo].[CodeLookups] ([CodeLookupId])
GO
ALTER TABLE [dbo].[Dishes] CHECK CONSTRAINT [FK_dbo.Dishes_dbo.CodeLookups_Category_CodeLookupId]
GO
ALTER TABLE [dbo].[DishMenus]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DishMenus_dbo.Dishes_Dish_DishId] FOREIGN KEY([Dish_DishId])
REFERENCES [dbo].[Dishes] ([DishId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DishMenus] CHECK CONSTRAINT [FK_dbo.DishMenus_dbo.Dishes_Dish_DishId]
GO
ALTER TABLE [dbo].[DishMenus]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DishMenus_dbo.Menus_Menu_MenuId] FOREIGN KEY([Menu_MenuId])
REFERENCES [dbo].[Menus] ([MenuId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DishMenus] CHECK CONSTRAINT [FK_dbo.DishMenus_dbo.Menus_Menu_MenuId]
GO
ALTER TABLE [dbo].[Menus]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Menus_dbo.CodeLookups_Category_CodeLookupId] FOREIGN KEY([Category_CodeLookupId])
REFERENCES [dbo].[CodeLookups] ([CodeLookupId])
GO
ALTER TABLE [dbo].[Menus] CHECK CONSTRAINT [FK_dbo.Menus_dbo.CodeLookups_Category_CodeLookupId]
GO
ALTER TABLE [dbo].[Menus]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Menus_dbo.Restaurants_Restaurant_RestaurantId] FOREIGN KEY([Restaurant_RestaurantId])
REFERENCES [dbo].[Restaurants] ([RestaurantId])
GO
ALTER TABLE [dbo].[Menus] CHECK CONSTRAINT [FK_dbo.Menus_dbo.Restaurants_Restaurant_RestaurantId]
GO
ALTER TABLE [dbo].[Restaurants]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Restaurants_dbo.CodeLookups_FoodType_CodeLookupId] FOREIGN KEY([FoodType_CodeLookupId])
REFERENCES [dbo].[CodeLookups] ([CodeLookupId])
GO
ALTER TABLE [dbo].[Restaurants] CHECK CONSTRAINT [FK_dbo.Restaurants_dbo.CodeLookups_FoodType_CodeLookupId]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Reviews_dbo.CodeLookups_Rating_CodeLookupId] FOREIGN KEY([Rating_CodeLookupId])
REFERENCES [dbo].[CodeLookups] ([CodeLookupId])
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_dbo.Reviews_dbo.CodeLookups_Rating_CodeLookupId]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Reviews_dbo.Restaurants_Restaurant_RestaurantId] FOREIGN KEY([Restaurant_RestaurantId])
REFERENCES [dbo].[Restaurants] ([RestaurantId])
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_dbo.Reviews_dbo.Restaurants_Restaurant_RestaurantId]
GO
USE [master]
GO
ALTER DATABASE [testfnDb] SET  READ_WRITE 
GO
