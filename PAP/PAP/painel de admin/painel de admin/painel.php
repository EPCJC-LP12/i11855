<link href='css/estilo.css' rel='stylesheet' type='text/css' />
<!doctype html>
<html>

<?php
	session_star();
	include("conexao.php");
	include("funcoes.php");
	protegePagina();


	if(isset($_GET['acao']) && $_GET['acao'] == 'sair'){
		sairPagina();

	}

?>


<head>

<title>Painel</title>
<meta charset="utf-8">
<link href='estilo.css' rel='stylesheet' type='text/css' />
</head>

<body>




	<div class="header">
			<div class="logo"> </div>
			<div class="extra"> 

			Olá <?php echo $_SESSION['usuario'];?>, seja bem vindo 
			</div>
		
	</div>
	<div class="menu-lado">


				 <a href = "painel.html">Home</a>
				 <a href = "painel.html?pg= addUsuario">Cadastrar Usuário</a>
				 <a href = "painel.html?pg= addCategoria">Cadastrar Categoria</a>
				 <a href = "painel.html?pg= addPostagem">Cadastrar Postagem</a>
				 <a href = "painel.html?acao=sair">Deslogar</a>


	</div>


	<div class="painel">

		<?php

			error_reporting(0);

			$parametro = $_GET["pg"];

			if (isset($parametro)){
				include("$parametro.php");
			}else{
				include("mostraUsuarios.php");
			}
		?>

	</div>

	</div> <!-- FECHAMENTO DIV PRINCIPABOX-->
</body>

</html>