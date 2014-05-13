<link href='css/estilo.css' rel='stylesheet' type='text/css' />
<!doctype html>
<html>
<head>
<meta charset="utf-8">


<title>Sistema de Login</title>



</head>

<body>

	<div class=formularioLogin">
    	<h1>Formulário de Login</h1>
		<form action= "verifica_login.php" method="POST">
    
    		<label>
    		<span>Usuario: </span>
        	<input type="text" name="usuario"/>
  			</label>
    
    		<label>
    		<span>senha: </span>
        	<input type="password" name="senha"/>
    		</label>
    
    		<input type="submit" value="Logar">
    		<input type="hidden" name="acao" value="fazer_login"/>

		</form>
	</div>

</body>

</html>