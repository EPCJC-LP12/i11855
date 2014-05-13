<link href='css/estilo.css' rel='stylesheet' type='text/css' />

<meta charset="utf-8">
<?php

	session_star();
	include("conexao.php");
	
	$usuario = $_POST['usuario'];
	$senha = $_POST['senha'];
	
	if(isset($_POST['acao']) && $_POST['acao'] == 'fazer_login') {
		
		if ($_usuario == "" || $senha == "") {	
			echo "<script> alerta('Os campos não podem ficar vazios!'); location.href = 'index.php'</script>";
			
		}else{
			$selectlogin = mysql_query(" SELECT * FROM usuarios WHERE usuario = '$usuario' AND senha = '$senha'");
			$fetchLogin = mysql_fetch_array($selectLogin);
			
			
			
			if(mysql_num_rows($selectlogin) > 0){
				$_SESSION['usuario'] = $selectLogin['$usuario'];
				$_SESSION['senha'] = $selectLogin['$senha'];
				
				echo "<script> location.href='painel.php'</script>";
			}else{
				echo "<script> alert ('Login Incorreto'); location.href='index.php'</script>";
			}
		}
		
	}

?>