var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
  return new bootstrap.Tooltip(tooltipTriggerEl)
})

$("#mensagem").hide();
$("#mensagemDiv").hide();

function cadastrar(e)
{
  e.preventDefault();
  var informacoes = $("#cadastro").serialize();
  $.post('/Home/Cadastrar', informacoes, function(data){
        if(data == "OK")
        {
            $("#mensagem").html("Cadastro Realizado com sucesso!");
            $("#formulario").hide();
            $("#mensagem").show();
        }
        else
        {
            window.location.href = '/Erro/500';
        }
    });
  
}

function teste(e)
{
  e.preventDefault();
  $("#mensagem").html("Cadastro Realizado com sucesso!");
  $("#formulario").hide();
  $("#mensagem").show();
}
$("#cadastro").on("submit", cadastrar);
$("#btnTeste").on("click", teste);