var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
  return new bootstrap.Tooltip(tooltipTriggerEl)
})

function cadastrar(e)
{
  e.preventDefault();
  var informacoes = $("#cadastro").serialize();
  $.post('/Home/Cadastrar', informacoes, function(data){
        if(data == "OK")
        {
            $("#mensagem").html("Cadastro Realizado com sucesso!");
            $("#formulario").hide();
        }
        else
        {
            window.location.href = '/Erro/500';
        }
    });
}
$("#cadastro").on("submit", cadastrar);