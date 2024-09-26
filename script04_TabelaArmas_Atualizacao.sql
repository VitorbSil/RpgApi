BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TB_USUARIOS]') AND [c].[name] = N'Username');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [TB_USUARIOS] DROP CONSTRAINT [' + @var0 + '];');
UPDATE [TB_USUARIOS] SET [Username] = '' WHERE [Username] IS NULL;
ALTER TABLE [TB_USUARIOS] ALTER COLUMN [Username] varchar(200) NOT NULL;
ALTER TABLE [TB_USUARIOS] ADD DEFAULT '' FOR [Username];
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TB_USUARIOS]') AND [c].[name] = N'Perfil');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [TB_USUARIOS] DROP CONSTRAINT [' + @var1 + '];');
UPDATE [TB_USUARIOS] SET [Perfil] = 'Jogador' WHERE [Perfil] IS NULL;
ALTER TABLE [TB_USUARIOS] ALTER COLUMN [Perfil] varchar(200) NOT NULL;
ALTER TABLE [TB_USUARIOS] ADD DEFAULT 'Jogador' FOR [Perfil];
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TB_PERSONAGENS]') AND [c].[name] = N'Nome');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [TB_PERSONAGENS] DROP CONSTRAINT [' + @var2 + '];');
UPDATE [TB_PERSONAGENS] SET [Nome] = '' WHERE [Nome] IS NULL;
ALTER TABLE [TB_PERSONAGENS] ALTER COLUMN [Nome] varchar(200) NOT NULL;
ALTER TABLE [TB_PERSONAGENS] ADD DEFAULT '' FOR [Nome];
GO

ALTER TABLE [TB_PERSONAGENS] ADD [Derrotas] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [TB_PERSONAGENS] ADD [Disputas] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [TB_PERSONAGENS] ADD [Vitorias] int NOT NULL DEFAULT 0;
GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TB_ARMAS]') AND [c].[name] = N'Nome');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [TB_ARMAS] DROP CONSTRAINT [' + @var3 + '];');
UPDATE [TB_ARMAS] SET [Nome] = '' WHERE [Nome] IS NULL;
ALTER TABLE [TB_ARMAS] ALTER COLUMN [Nome] varchar(200) NOT NULL;
ALTER TABLE [TB_ARMAS] ADD DEFAULT '' FOR [Nome];
GO

ALTER TABLE [TB_ARMAS] ADD [PersonagemId] int NOT NULL DEFAULT 0;
GO

UPDATE [TB_ARMAS] SET [PersonagemId] = 1
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_ARMAS] SET [PersonagemId] = 2
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_ARMAS] SET [PersonagemId] = 3
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_ARMAS] SET [PersonagemId] = 4
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_ARMAS] SET [PersonagemId] = 5
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_ARMAS] SET [PersonagemId] = 6
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_ARMAS] SET [PersonagemId] = 7
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_PERSONAGENS] SET [Derrotas] = 0, [Disputas] = 0, [Vitorias] = 0
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_PERSONAGENS] SET [Derrotas] = 0, [Disputas] = 0, [Vitorias] = 0
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_PERSONAGENS] SET [Derrotas] = 0, [Disputas] = 0, [Vitorias] = 0
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_PERSONAGENS] SET [Derrotas] = 0, [Disputas] = 0, [Vitorias] = 0
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_PERSONAGENS] SET [Derrotas] = 0, [Disputas] = 0, [Vitorias] = 0
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_PERSONAGENS] SET [Derrotas] = 0, [Disputas] = 0, [Vitorias] = 0
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_PERSONAGENS] SET [Derrotas] = 0, [Disputas] = 0, [Vitorias] = 0
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_USUARIOS] SET [PasswordHash] = 0x0917FCA96794D36A7A25B5BB5050244F23EB35778AFEC5B6FA86533E310DB380127F7D3FA3E90BA6784C067444F9191134E425A499D9134E21F5798192ABA9BD, [PasswordSalt] = 0xBB9312037BEAA18EBB8C40A6C016BD28CAB81A5FCBA9121D6FD35CC7B712D5D37B922818DB820C19A39DDF60B3146869F3DF167462B8595CC1B973EA7BCDF8F5709B3C45B4779DD96AE40F57697B97CBF2DA9EB63D3A8D6024201D3BF46B82624EAFEA9A2D43C3D43AB3D792AC141FB8F4D3C9F479F8544CDDDA89E51F320EA8
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

CREATE UNIQUE INDEX [IX_TB_ARMAS_PersonagemId] ON [TB_ARMAS] ([PersonagemId]);
GO

ALTER TABLE [TB_ARMAS] ADD CONSTRAINT [FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId] FOREIGN KEY ([PersonagemId]) REFERENCES [TB_PERSONAGENS] ([Id]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240926013439_MigracaoUmParaUm', N'8.0.8');
GO

COMMIT;
GO

