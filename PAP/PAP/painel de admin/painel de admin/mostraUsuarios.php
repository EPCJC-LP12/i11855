<link href='css/estilo.css' rel='stylesheet' type='text/css' />
<meta charset="utf-8">



<table width="900"  cellspacing="5" cellspacing="5" class="tbl_mostraUsuarios" >

	<tr bgcolor="#036">
    	<td>ID</td>
        <td>Usuário</td>
        <td>Nivel</td>
        <td>Editar</td>
        <td>Deletar</td>
	</tr>
    
    
    <?php

		$selectUsuarios = mysql_query("SELECT * FROM usuarios ORDER BY id DESC");
		
		if (mysql_num_rows($selectUsuarios) == 0){
			echo "<tr><td>Nenhum registro encontrado!</td></tr>";
		}else{
			while($linha = mysql_fetch_array($selectUsuarios)) {
				$idUsuario = $linha['id'];
				$nomeUsuario = $linha['nome'];
				$nivelUsuario = $linha['nivel'];
		
			echo "
				<tr>
				<td>$idUsuario</td>
				<td>$nomeUsuario</td>
				<td>$nivelUsuario</td>
				<td><a href= 'edita.php?id=$idUsuario'><img src= 'img/editar.png' width='50' height='50'/></a></td>
				<td><a href= 'excluir.php?id=$idUsuario'><img src= 'img/remover.png' width='50' height='50'/></a></td>
				</tr>
				";
			
			}
		
		}
		
	?>
    
</table>

