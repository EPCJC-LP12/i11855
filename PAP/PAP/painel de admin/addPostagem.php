<link href='css/estilo.css' rel='stylesheet' type='text/css' />
<meta charset="utf-8">
<div class="formularioPainel">
    
		<form action= "" method="POST" enctype="multipart/form-data">
    
    		<label>
    		<span>Titulo: </span>
        	<input type="text" name="categoria"/>
  			</label>
            
            <label>
    		<span>Categorias: </span>
        	<select name="categoria">
            <option value="cat"> CAT1</option>
            </select>
  			</label>
            
            <label>
    		<span>Postagem: </span>
        	<textarea name="post" rows="5" cols="30"></textarea>
  			</label>
    
    
    		<input type="submit" value="Cadastrar">
    		<input type="hidden" name="acao" value="cadastrar_postagem"/>

		</form>
        
<?php
		if(isset($_POST['acao']) && $_POST['acao'] == "cadastrar_postagem"){
		
		
		}
			

		
		?>
        
</div>