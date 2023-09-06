ALTER TABLE Adua.tbDocumentosDeSoporte
ALTER COLUMN doso_PaisEmision INT NULL;

ALTER TABLE Adua.tbDocumentosDeSoporte
ALTER COLUMN doso_LineaAplica CHAR(4) NULL;

ALTER TABLE Adua.tbDuca
DROP COLUMN duca_Id;

ALTER TABLE Adua.tbDuca
DROP CONSTRAINT [FK_Adua_tbDeclaraciones_Valor_deva_Id_Adua_tbDuca_deva_Id]

ALTER TABLE Adua.tbDuca
DROP COLUMN [deva_Id]

ALTER TABLE [Adua].[tbItemsDEVAPorDuca]
ADD CONSTRAINT [FK_Adua_tbItemsDEVAPorDuca_duca_No_DUCA_Adua_tbDuca_duca_No_Duca] FOREIGN KEY ([duca_No_DUCA]) REFERENCES [Adua].[tbDuca]([duca_No_Duca])

ALTER TABLE [Adua].[tbItemsDEVAPorDuca]
ADD  [duca_No_DUCA] NVARCHAR(100)

ALTER TABLE [Adua].[tbItemsDEVAPorDuca]
DROP COLUMN duca_Id;

ALTER TABLE [Prod].[tbPedidosOrden]
ADD CONSTRAINT [FK_Prod_tbPedidosOrden_tbDuca_Duca_Id] FOREIGN KEY ([duca_Id]) REFERENCES [Adua].[tbDuca]([duca_Id])

ALTER TABLE [Adua].[tbDocumentosDeSoporte]
ADD CONSTRAINT FK_Adua_tbDocumentosDeSoporte_Adua_tbDuca_duca_Id FOREIGN KEY (duca_Id) REFERENCES Adua.tbDuca(duca_Id),

ALTER TABLE [Adua].[tbBoletinPago]
ADD CONSTRAINT [FK_Adua_tbBoletinPago_tbDuca_Duca_Id] FOREIGN KEY ([duca_Id]) REFERENCES [Adua].[tbDuca]([duca_Id])

ALTER TABLE [Adua].[tbLiquidacionGeneral]
DROP CONSTRAINT [FK_Adua_tbDuca_duca_Id_Adua_tbLiquidacionGeneral_duca_Id] FOREIGN KEY ([duca_Id]) REFERENCES [Adua].[tbDuca]([duca_No_Duca])

ALTER TABLE [Prod].[tbFacturasExportacion]
ADD CONSTRAINT [FK_Prod_tbFacturasExportacion_Adua_tbDuca]

ALTER TABLE [Adua].[tbLiquidacionGeneral]
ADD CONSTRAINT [FK_Adua_tbDuca_duca_Id_Adua_tbLiquidacionGeneral_duca_Id] FOREIGN KEY (duca_Id) REFERENCES Adua.tbDuca(duca_Id)


ALTER TABLE [Adua].[tbLiquidacionGeneral]
ADD duca_Id INT NOT NULL

ALTER TABLE Adua.tbDuca
ADD CONSTRAINT [PK_Adua_tbDuca_duca_No_Duca] PRIMARY KEY([duca_No_Duca])

ALTER TABLE Adua.tbDuca
DROP CONSTRAINT PK_Adua_tbDuca_duca_No_Duca

ALTER TABLE [Adua].[tbItemsDEVAPorDuca]
ADD CONSTRAINT FK_Adua_tbItemsDEVAPorDuca_Adua_tbDuca_duca_Id FOREIGN KEY(duca_Id) REFERENCES Adua.tbDuca([duca_Id])

