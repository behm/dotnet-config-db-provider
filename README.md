# Introduction 
This is a demonstration of using a ConfigurationProvider that will read configuration settings from a database.

This is a copy of an older repo for archive purposes.  If this is used in the future, it should be updated to a supported version of .NET.

# Getting Started
This code uses .NET Secrets to provide the SettingsDb connection string in the DEV environment.  To set this up, right-click on the project in Solution Explorer and then click on "Manage User Secrets".

This can also be done with the dotnet command-line but might be easier to copy/paste in an editor.

The secrets.json file should look like this when you are done (with the exception of having a proper connection string of course):

'
{
  "ConnectionStrings": {
    "SettingsDb": "your-connection-string-value-goes-here"
  }
}
`

The settings table can be created using the followng script:

`
/****** Object:  Table [dbo].[Settings]    Script Date: 10/29/2019 9:32:10 PM ******/
SET ANSI_NULLS ON  
GO  

SET QUOTED_IDENTIFIER ON  
GO  

CREATE TABLE [dbo].[Settings](  
	[SettingId] [int] IDENTITY(1,1) NOT NULL,  
	[Key] [nvarchar](50) NOT NULL,  
	[Value] [nvarchar](100) NULL,  
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED   
(  
	[SettingId] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,   ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
) ON [PRIMARY]  
GO  
`