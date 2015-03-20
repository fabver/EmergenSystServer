/* 
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
$(document).ready(function(){
    
    $('#bEnf').on('change',function(){
         var opc= $('#bEnf');
         var obj = $('#enfs');
         visible(opc,obj);
    });
    
     $('#bCir').on('change',function(){
         var opc= $('#bCir');
         var obj = $('#cirs');
         visible(opc,obj);
    });
    
     $('#bMed').on('change',function(){
         var opc= $('#bMed');
         var obj = $('#meds');
         visible(opc,obj);
    });
    
     $('#bAlg').on('change',function(){
         var opc= $('#bAlg');
         var obj = $('#algs');
         visible(opc,obj);
    });
    
     $('#bAnt').on('change',function(){
         var opc= $('#bAnt');
         var obj = $('#ants');
         visible(opc,obj);
    });
});

function visible(opc,obj){
            opc= opc.val();
            if (opc==="true"){
                obj.attr({'readOnly':false, 'autofocus':true});
            }else{
                obj.attr('readOnly',true);
            }
        } 
        
           function validar(obj){
        if (obj.value===""){
            obj.type="text";
            obj.placeholder="No se llenó el dato";
            //obj.css({backgroundColor: "#ff9197", borderLeft:" 2px solid red "});
            obj.style=("backgroundColor: #ff9197; borderLeft: 2px solid red");
            //obj.attr('style',"backgroundColor: #ff9197; borderLeft: 2px solid red");
            obj.required="true";
            obj.background= "url(alert-black.png)";
            //obj.addClass("Error");
            return false;
        }else{return true;}
        }
        
           function cambiar(obj) {
               if (obj.type === "text") {
                   if (obj.name === "ced") {
                       obj.type = "number";
                   } else if (obj.name === "fecha") {
                       obj.type = "date";
                   }
               }
           }