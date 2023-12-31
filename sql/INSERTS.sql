USE [DesafioFiapDb]
GO
SET IDENTITY_INSERT [dbo].[TB_ALUNOS] ON 
INSERT [dbo].[TB_ALUNOS] ([Id_Aluno], [Nome], [Usuario], [Senha]) VALUES (1, N'Wagner Lima', N'wagner', N'10000.zDq9yQA=.PQW+B4HQo5RVpw==                             ')
INSERT [dbo].[TB_ALUNOS] ([Id_Aluno], [Nome], [Usuario], [Senha]) VALUES (2, N'Lionel Messi', N'messi', N'10000.MyZQ668=.lyw774cSgs5T2w==                             ')
INSERT [dbo].[TB_ALUNOS] ([Id_Aluno], [Nome], [Usuario], [Senha]) VALUES (3, N'Cristiano Ronaldo', N'cr7', N'10000.LxCCqas=.a3UrhMOOwrTnAQ==                             ')
INSERT [dbo].[TB_ALUNOS] ([Id_Aluno], [Nome], [Usuario], [Senha]) VALUES (4, N'Ronaldo Nazario', N'fenomeno', N'10000.zOTcuBI=.j4FzWwdmMfsp8w==                             ')
INSERT [dbo].[TB_ALUNOS] ([Id_Aluno], [Nome], [Usuario], [Senha]) VALUES (5, N'Edson Arantes do Nascimento', N'pelé', N'10000.dYtW9kQ=.cZ+we790MsInRA==                             ')
SET IDENTITY_INSERT [dbo].[TB_ALUNOS] OFF

SET IDENTITY_INSERT [dbo].[TB_TURMAS] ON 
INSERT [dbo].[TB_TURMAS] ([Id_Turma], [Id_Curso], [Nome_Turma], [Ano]) VALUES (1, 1, N'Turma .NET com Azure 2023', 2023)
INSERT [dbo].[TB_TURMAS] ([Id_Turma], [Id_Curso], [Nome_Turma], [Ano]) VALUES (2, 2, N'Turma Data Analytics 2023', 2023)
INSERT [dbo].[TB_TURMAS] ([Id_Turma], [Id_Curso], [Nome_Turma], [Ano]) VALUES (3, 3, N'Turma .NET com Azure 2024', 2024)
INSERT [dbo].[TB_TURMAS] ([Id_Turma], [Id_Curso], [Nome_Turma], [Ano]) VALUES (4, 4, N'Turma SoftwareArchitecture 2023', 2023)
INSERT [dbo].[TB_TURMAS] ([Id_Turma], [Id_Curso], [Nome_Turma], [Ano]) VALUES (5, 5, N'Turma Java 2025', 2025)
SET IDENTITY_INSERT [dbo].[TB_TURMAS] OFF

INSERT [dbo].[TB_ALUNOS_TURMAS] ([AlunoId], [TurmaId]) VALUES (1, 1)
INSERT [dbo].[TB_ALUNOS_TURMAS] ([AlunoId], [TurmaId]) VALUES (2, 2)
INSERT [dbo].[TB_ALUNOS_TURMAS] ([AlunoId], [TurmaId]) VALUES (1, 3)
INSERT [dbo].[TB_ALUNOS_TURMAS] ([AlunoId], [TurmaId]) VALUES (3, 3)
INSERT [dbo].[TB_ALUNOS_TURMAS] ([AlunoId], [TurmaId]) VALUES (4, 3)
INSERT [dbo].[TB_ALUNOS_TURMAS] ([AlunoId], [TurmaId]) VALUES (5, 5)
