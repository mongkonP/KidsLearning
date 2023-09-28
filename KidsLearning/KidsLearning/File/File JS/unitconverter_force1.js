var ab=[["newton [N]",1],["meganewton [MN]",1e6],["kilonewton [kN]",1000],["sthene (=kN)",1000],["dyne",1e-5],["tonne force",9806.65],["ton force (UK)",9964.01641818352],["ton force (US)",8896.443230521],["kilogram force",9.80665],["pound force",4.4482216152605],["kip",4448.222],["poundal",0.138255]];var bb;function hh(db){var eb=window.onload;if(typeof window.onload!="function"){window.onload=db;}
else{window.onload=function(){eb();db();}
}
;}
function ih(db){var gb=window.onunload;if(typeof window.onunload!="function"){window.onunload=db;}
else{window.onunload=function(){gb();db();}
}
;}
hh(jh);ih(kh);function lh(kb,value,lb){var mb=new Date();mb.setDate(mb.getDate()+lb);document.cookie=kb+"="+escape(value)+((lb==null)?"":";expires="+mb.toGMTString());}
function mh(kb){if(document.cookie.length>0){ob=document.cookie.indexOf(kb+"=");if(ob!=-1){ob=ob+kb.length+1;pb=document.cookie.indexOf(";",ob);if(pb==-1)pb=document.cookie.length;return unescape(document.cookie.substring(ob,pb));}
}
return"";}
function jh(){nh();if(document.getElementById('valuetoforce1')){oh();cc_force1();}
}
function nh(){bb=ph();}
function oh(){var tb=qh("selectfromforce1",0);var vb=qh("selecttoforce1",0);rh('selectfromforce1',tb);rh('selecttoforce1',vb);document.getElementById('valuefromforce1').value=qh("valuefromforce1",1);}
function kh(){if(document.getElementById('valuetoforce1')){var xb;xb=document.getElementById('selectfromforce1');lh('selectfromforce1',xb.options[xb.selectedIndex].value,365);xb=document.getElementById('selecttoforce1');lh('selecttoforce1',xb.options[xb.selectedIndex].value,365);xb=document.getElementById('valuefromforce1');lh('valuefromforce1',xb.value,365);}
}
function rh(yb,zb){var xb=document.getElementById(yb);if((zb>=0)&&(zb<xb.options.length)){xb.selectedIndex=zb;}
}
function sh(_b,X){X=(!X?6:X);return Math.round(_b*Math.pow(10,X))/Math.pow(10,X);}
function qh(ac,bc){var cc=mh(ac);if(cc===false){return bc;}
else{return cc;}
}
function ph(){return parseInt(qh("floatnumber",6));}
function th(ec){var ValidChars="0123456789.";for(i=0;i<ec.length;i++){if(ValidChars.indexOf(ec.charAt(i))==-1){return false;}
}
return true;}
function ins_force1(fc){document.writeln('<select name="'+fc+'" id="'+fc+'" size="1" onchange="cc_force1()">');for(i=0;i<ab.length;i++){document.writeln('<option value="'+i+'">'+ab[i][0]+'</option>');}
document.writeln('</select>');}
function uh(hc,vv,ic){var jc=ab[hc];var kc=ab[ic];;if(th(jc[1])){vv=vv*jc[1];}
else{vv=eval(jc[1]);}
if(th(kc[1])){vv=vv/kc[1];}
else{vv=eval(kc[2]);}
return sh(vv,bb);}
function cc_force1(){var lc=parseFloat(document.getElementById('valuefromforce1').value);if(isNaN(lc)){document.getElementById('valuetoforce1').value='';}
else{var tb=document.getElementById('selectfromforce1').selectedIndex;var vb=document.getElementById('selecttoforce1').selectedIndex;document.getElementById('valuetoforce1').value=uh(tb,lc,vb);mc=document.getElementById('valueresultforce1').tagName;if(mc=="SPAN")document.getElementById('valueresultforce1').innerHTML=lc+" "+nc(document.getElementById('selectfromforce1').options[document.getElementById('selectfromforce1').selectedIndex].text)+" = "+document.getElementById('valuetoforce1').value+" "+nc(document.getElementById('selecttoforce1').options[document.getElementById('selecttoforce1').selectedIndex].text);else
document.getElementById('valueresultforce1').value=lc+" "+nc(document.getElementById('selectfromforce1').options[document.getElementById('selectfromforce1').selectedIndex].text)+" = "+document.getElementById('valuetoforce1').value+" "+nc(document.getElementById('selecttoforce1').options[document.getElementById('selecttoforce1').selectedIndex].text);}
}
function ccb_force1(){var lc=parseFloat(document.getElementById('valuetoforce1').value);if(isNaN(lc)){document.getElementById('valuefromforce1').value='';}
else{var tb=document.getElementById('selecttoforce1').selectedIndex;var vb=document.getElementById('selectfromforce1').selectedIndex;document.getElementById('valuefromforce1').value=uh(tb,lc,vb);document.getElementById('valueresultforce1').value=document.getElementById('valuefromforce1').value+" "+nc(document.getElementById('selectfromforce1').options[document.getElementById('selectfromforce1').selectedIndex].text)+" = "+lc+" "+nc(document.getElementById('selecttoforce1').options[document.getElementById('selecttoforce1').selectedIndex].text);}
}
function nc(oc){return oc;var pc;if((oc.indexOf('(')==-1)&&(oc.indexOf('[')==-1))pc=oc.split();else{var qc=oc.indexOf(' ');if(qc==-1)qc=999;var rc=oc.indexOf('(');if(rc==-1)rc=999;var sc=oc.indexOf('[');if(sc==-1)sc=999;var tc=' ';if(rc<qc){tc='(';if(sc<rc){tc='[';}
}
else{tc=' ';if(sc<qc){tc='[';}
}
pc=oc.split(tc);}
return pc[0];}
