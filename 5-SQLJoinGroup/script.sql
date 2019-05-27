-- METHOD 1
SELECT Nome_Colaborador,sum(Valor_Pago) 
FROM Colaboradores c 
JOIN Salarios s ON s.ID_SALARIO = c.ID_SALARIO
WHERE DATA_PAGAMENTO BETWEEN '2014-01-01' AND '2014-12-31'
GROUP BY Nome_Colaborador

-- METHOD 2
SELECT Nome_Colaborador,SUM(Valor_Pago) 
FROM Colaboradores c 
JOIN Salarios s ON s.ID_SALARIO = c.ID_SALARIO
WHERE YEAR(DATA_PAGAMENTO) = 2014
GROUP BY Nome_Colaborador