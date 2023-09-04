ALTER TABLE Adua.tbDocumentosDeSoporte
ALTER COLUMN doso_PaisEmision INT NULL;

ALTER TABLE Adua.tbDocumentosDeSoporte
ALTER COLUMN doso_LineaAplica CHAR(4) NULL;

ALTER TABLE Adua.tbDuca
ADD duca_Id	INT IDENTITY (1,1);
