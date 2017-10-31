function showHiddenElement(eName) {
  return function() {
    if ($(eName).is( ":hidden" )) {
        $(eName).slideDown(200);
      }
  }  
}

$(document).ready(function(){
  $("#reg-btn").click(showHiddenElement("#reg-elements"));
});