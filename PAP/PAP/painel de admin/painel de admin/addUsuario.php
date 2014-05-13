<link href='css/estilo.css' rel='stylesheet' type='text/css' />
<div class="formularioPainel">
    
		<form action= "" method="POST" enctype="multipart/form-data">
    
    		<label>
    		<span>Usuario: </span>
        	<input type="text" name="usuario"/>
  			</label>
    
    		<label>
    		<span>senha: </span>
        	<input type="password" name="senha"/>
    		</label>
            
            <label>
    		<span>Tipo de usuário: </span>
        		<select name ="nivel">
            		<option value="Membro"> Membro </option>
                    <option value="Administrador"> Administrador </option>
            	</select>
    		</label>
    
    		<input type="submit" value="Cadastrar">
    		<input type="hidden" name="acao" value="cadastrar_usuario"/>

		</form>
        
		<?php
		
			
			if(isset($_POST['acao']) && $_POST ['acao'] == "cadastrar_usuario"){
			
				$usuario = trim($_POST['usuario']);
				$senha = trim($_POST['senha']);
				$nivel = trim($_POST['nivel']);
			
				if($usuario == "" || $senha == ""){
					echo "<script>alert('Os campos não podem ficar vazios!')</script>";	

					}else{
						$selectRegistro = mysql_query("SELECT * FROM usuarios WHERE usuario == '$usuario'");
						
						if(mysql_num_rows($selectRegistro) == 1){
							echo "<script>alert('Este usuário já existe!')</script>";
						
						}else{
							$inserirRegistro = mysql_query("INSERT INTO usuarios (nivel, usuario, senha) VALUES ('$nivel','$usuario','$senha')");
							echo "<script>alert('Registro adicionado com sucesso!')</script>";
					}
			
				}
			}
				
		
		?>
        
</div>