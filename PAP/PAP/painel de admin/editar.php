<link href='css/estilo.css' rel='stylesheet' type='text/css' />
<meta charset="utf-8">
<div class="formularioPainel">

<?php
 
	session_star();
	include("conexao.php");
	include("funcoes.php");
	protegePagina();

	$id = $_GET ['id'];
	$selectUsuario = mysql_query("SELECT * FROM usuarios WHERE id='$id'");
	
	if (isset($_POST['acao']) &&  $_POST['acao'] == 'editar_usuario') {
		
		$usuario = $_POST['usuario'];
		$senha = $_POST['senha'];
		$nivel = $_POST['nivel'];
		
	
		if ($usuario == "" || $senha == ""){
			echo "<script>alert('Os campos não podem ficar vazios!') </script>";
		}else{
			$editaUsuario = mysql_query("UPDATE usuarios SET usuario = '$usuario', senha = '$senha', nivel = '$nivel'");
			if ($editaUsuario){
				echo "<script>alert('Usuário $usuario modificados com sucesso!'); location.href = 'painel.php </script>";
			}else{
				echo "<script>alert('Erro ao editar!') ; location.href = 'painel.php' </script>";
			}
		}
	}
	
	
	
?>

    <form action= "" method="POST" enctype="multipart/form-data">
        
        
        <?php 
		
			while ($linha = mysql_fetch_array($selectUsuario)){
				$nomeUsuario = $linha['usuario'];
				$senhaUsuario = $linha['senha'];
				$nivelUsuario = $linha['nivel'];
			
		?>
      
      
  
                <label>
                <span>Usuario: </span>
                <input type="text" name="usuario" value="<?php echo $nomeUsuario; ?>" />
                </label>
        
                <label>
                <span>senha: </span>
                <input type="text" name="senha" value="<?php echo $senhaUsuario; ?>" />
                </label>
                
                <label>
                <span>Tipo de usuário: </span>
				<select name ="nivel">
            		<option value="Membro"> Membro </option>
                    <option value="Administrador"> Administrador </option>
            	</select>
            	</label>
            
 
      <?php )  ?>
                <input type="submit" value="editar">
                <input type="hidden" name="acao" value="editar_usuario"/>
    
     </form>
      
 </div>