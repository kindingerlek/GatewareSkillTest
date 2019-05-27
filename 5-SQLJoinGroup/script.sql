
-- METHOD 1
SELECT c.nome_colaborador,sum(s.valor_pago) as soma_salario, lc.uf as estados
FROM salarios S
INNER JOIN colaboradores C on C.id_colaborador = S.id_colaborador
INNER JOIN local_de_trabalho lc ON lc.id_colaborador = s.id_colaborador
WHERE s.data_pagamento BETWEEN '2014-01-01 00:00' AND '2014-12-31 23:59'
GROUP BY c.nome_colaborador, lc.uf

-- METHOD 2
SELECT c.nome_colaborador,sum(s.valor_pago) as soma_salario, lc.uf as estados
FROM salarios S
INNER JOIN colaboradores C on C.id_colaborador = S.id_colaborador
INNER JOIN local_de_trabalho lc ON lc.id_colaborador = s.id_colaborador
WHERE YEAR(s.data_pagamento) = 2014
GROUP BY c.nome_colaborador, lc.uf