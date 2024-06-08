SET IDENTITY_INSERT [dbo].[tblUsers] ON
INSERT INTO [dbo].[tblUsers] ([UserID], [Username], [Password], [Department]) VALUES (1, N'Waqar Ali', N'12345', N'Stock Management')
INSERT INTO [dbo].[tblUsers] ([UserID], [Username], [Password], [Department]) VALUES (2, N'Amanullah', N'abc12345', N'Staff management')
INSERT INTO [dbo].[tblUsers] ([UserID], [Username], [Password], [Department]) VALUES (3, N'Archie', N'24680', N'Supplier management')
SET IDENTITY_INSERT [dbo].[tblUsers] OFF
