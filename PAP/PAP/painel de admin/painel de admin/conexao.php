<link href='css/estilo.css' rel='stylesheet' type='text/css' />
<?php

/*conexao*/

	$servidor = "localhost";
	$bd = "videoaula";
	$usuario = "R";
	$senha = "1";
	
	mysql_connect($servidor,$usuario,$senha) or die (mysql_error());
	mysql_select_db($bd) or die (mysql_error());

?>