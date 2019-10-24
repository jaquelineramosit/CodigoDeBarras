select sum(custo) custoTotal, grupo 
from Estoque
where EstoqueDisp > 0
group by grupo
order by grupo