use CorporeRM

select * from PFUNCAO
WHERE CODIGO = 00163

BEGIN tran
UPDATE PFUNCAO SET NOME = 'Assistente Tecnico de Seguran�a do Traba' WHERE CODIGO = 00163
COMMIT

 -- testando