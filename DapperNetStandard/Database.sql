/****** Object:  Table [dbo].[PlaceLanguages]    Script Date: 18/02/2018 12:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlaceLanguages](
	[PlaceLanguageId] [int] IDENTITY(1,1) NOT NULL,
	[PlaceId] [int] NOT NULL,
	[LanguageCode] [char](2) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Description] [varchar](max) NULL,
 CONSTRAINT [PK_PlaceLanguages] PRIMARY KEY CLUSTERED 
(
	[PlaceLanguageId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_PlaceLanguages] UNIQUE NONCLUSTERED 
(
	[PlaceId] ASC,
	[LanguageCode] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Places]    Script Date: 18/02/2018 12:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Places](
	[PlaceId] [int] IDENTITY(1,1) NOT NULL,
	[Tag] [varchar](120) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[ProjectId] [uniqueidentifier] NOT NULL,
	[ImageUrl] [varchar](255) NULL,
 CONSTRAINT [PK_Places] PRIMARY KEY CLUSTERED 
(
	[PlaceId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PlaceLanguages]  WITH CHECK ADD  CONSTRAINT [FK_PlaceLanguages_Places] FOREIGN KEY([PlaceId])
REFERENCES [dbo].[Places] ([PlaceId])
GO
ALTER TABLE [dbo].[PlaceLanguages] CHECK CONSTRAINT [FK_PlaceLanguages_Places]
GO
