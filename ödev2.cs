<html>
<title> Roma Çevirici v1.3 </title>
<h2>Salih Özgür Ulaş Uzun 2018280050</h2>
<body>
<label> çevrilecek sayıyı giriniz </label>
<input id="sayiGirdi" type="text">
<button id="cevirButon" onClick="var n = parseInt(document.getElementById('sayiGirdi').value);document.getElementById('ciktiSayi').value = cevir(n);">Çevir!</button>
<input id="ciktiSayi" style="display:block" type="text">


<script>
var romaRakamlari = [["","I","II","III","IV","V","VI","VII","VIII","IX"],        
                    ["","X","XX","XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"],  
                    ["","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"],					
					["","M","MM","MMM"]];
function cevir(num) {
  var romaCevir = "";
  var digits = num.toString().split('').reverse();
  for (var i=0; i < digits.length; i++){
    romaCevir = romaRakamlari[i][parseInt(digits[i])] + romaCevir;
  }
  return romaCevir;  
}
//kaynak https://stackoverflow.com/questions/9083037/convert-a-number-into-a-roman-numeral-in-javascript?page=2&tab=votes#tab-top
</script>







</body>
</html>