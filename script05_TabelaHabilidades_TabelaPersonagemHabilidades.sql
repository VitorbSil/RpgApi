﻿BEGIN TRANSACTION;
GO

UPDATE [TB_USUARIOS] SET [PasswordHash] = 0x46159668F7B89399CC06656A3A6E3FE324927123B016D8C49BDC15D20D852BA1723D6EEFE43042C426495B9030F5AC776DEAC1E47ECBBD5EFB9472C2A9800D11, [PasswordSalt] = 0x252FD55B5E804F8E438738B04571B6A3D38CB0E5715DF567B8051567CA29501AF87CD277E842132EE1B7023068356D17B4D0AF2B0517B782E38D769430ADBE8D1F7349567FC0D591C5923F6FC77939FC7928D0BD37C5217BBB0FA6C54CC25225A7B68FD1B322DC9A12F52F66A87F0DFC1F06D9A3F19026AAF9998E459F143006
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241002222927_MigracaoMuitosParaMuitos', N'8.0.8');
GO

COMMIT;
GO

