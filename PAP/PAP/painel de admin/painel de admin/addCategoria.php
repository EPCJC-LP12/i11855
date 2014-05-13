<link href='css/estilo.css' rel='stylesheet' type='text/css' />
<meta charset="utf-8">
<div class="formularioPainel">
    
		<form action= "" method="POST" enctype="multipart/form-data">
    
    		<label>
    		<span>Categoria: </span>
        	<input type="text" name="categoria"/>
  			</label>
    
    
    		<input type="submit" value="Cadastrar">
    		<input type="hidden" name="acao" value="cadastrar_categoria"/>

		</form>
        
<?php
		
			
			if(isset($_POST['acao']) && $_POST ['acao'] == "cadastrar_categoria"){
			
			$categoria = $_POST['categoria'];
			
			
				if($categoria == ""){
					echo "<script>alert('Os campos  categoria não pode ser vazio!')</script>";	

				}else{
					$selectCat = mysql_query("SELECT * FROM categorias WHERE categoria == '$categoria'");
					
					if(mysql_num_rows($selectCat) == 1){
						echo "<script>alert('Esta categoria já existe!')</script>";
					
					}else{
						$inserirCat = mysql_query("INSERT INTO categorias (categoria) VALUES ('$categoria')");
						echo "<script>alert('Categoria adicionado com sucesso!')</script>";
					}
				}
			
			}
				
		
		?>
        
</div>