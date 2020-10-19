function focusById(elementId) {
  var element = document.getElementById(elementId);
  if (element) {
    element.focus();
  }
}

function LimpiarFormularioLiquidacion() {
  document.getElementById("txtSueldoMensual").value = "";
  document.getElementById("txtDiasdeVacaciones").value = "";
  document.getElementById("FechaIniciodeLabores").value = "";
}
