<link href='css/estilo.css' rel='stylesheet' type='text/css' />
<meta charset="utf-8">
<?php

	session_star();
	include("conexao.php");
	include("funcoes.php");
	protegePagina();

	$id = $_GET ['id'];
	
	
	if (isset($id)) {
		
		$deleteUsuario = mysql_query("DELETE FROM usuarios WHERE id = '$id'");
	
		if($deletaUsuario){
			echo "<script> location.href='painel.php'</script>";
		}else{
			echo "<script>alert('Erro ao excluir!'); location.href='painel.php'</script>";
		}
	}

?>