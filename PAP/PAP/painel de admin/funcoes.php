<link href='css/estilo.css' rel='stylesheet' type='text/css' />
<?php
	
	function protegePagina(){
		if(!$_SESSION['usuario'] || !$_SESSION['senha']){
			echo "<script>alert('Ops, você não está logado!')location.href='index.php'</script>";
		}
	}
	
	function sairPagina(){
		session_destroy();
		echo "<script>location.href='index.php'</script>";	
	
	}
	
?>