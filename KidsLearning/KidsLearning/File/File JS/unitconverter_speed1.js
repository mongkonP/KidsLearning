var ab=[["meter/second [m/s]",1],["meter/minute",0.016666666666666666],["meter/hour",0.0002777777777777778],["centimeter/second",0.01],["centimeter/minute",0.00016666666666666666],["kilometer/second",1000],["kilometer/hour",0.2777777777777778],["mile/second",1609.344],["mile/minute",26.8224],["mile/hour",0.44704],["inch/second",0.0254],["inch/minute",0.0004233341800016934],["foot/second",0.3048],["foot/minute",0.00508],["foot/hour",0.00008466683600033866],["yard/second",0.9144],["yard/minute",0.01524],["yard/hour",0.000254000508001016],["knot",0.5144444444444444444],["nautical mile/hour",0.5144444444444444444],["Mach number (ISA/Sea level)",340.2933],["speed of light",2.9979e8]];var bb;function hn(db){var eb=window.onload;if(typeof window.onload!="function"){window.onload=db;}
else{window.onload=function(){eb();db();}
}
;}
function jn(db){var gb=window.onunload;if(typeof window.onunload!="function"){window.onunload=db;}
else{window.onunload=function(){gb();db();}
}
;}
hn(kn);jn(ln);function mn(kb,value,lb){var mb=new Date();mb.setDate(mb.getDate()+lb);document.cookie=kb+"="+escape(value)+((lb==null)?"":";expires="+mb.toGMTString());}
function nn(kb){if(document.cookie.length>0){ob=document.cookie.indexOf(kb+"=");if(ob!=-1){ob=ob+kb.length+1;pb=document.cookie.indexOf(";",ob);if(pb==-1)pb=document.cookie.length;return unescape(document.cookie.substring(ob,pb));}
}
return"";}
function kn(){on();if(document.getElementById('valuetospeed1')){pn();cc_speed1();}
}
function on(){bb=qn();}
function pn(){var tb=rn("selectfromspeed1",0);var vb=rn("selecttospeed1",0);sn('selectfromspeed1',tb);sn('selecttospeed1',vb);document.getElementById('valuefromspeed1').value=rn("valuefromspeed1",1);}
function ln(){if(document.getElementById('valuetospeed1')){var xb;xb=document.getElementById('selectfromspeed1');mn('selectfromspeed1',xb.options[xb.selectedIndex].value,365);xb=document.getElementById('selecttospeed1');mn('selecttospeed1',xb.options[xb.selectedIndex].value,365);xb=document.getElementById('valuefromspeed1');mn('valuefromspeed1',xb.value,365);}
}
function sn(yb,zb){var xb=document.getElementById(yb);if((zb>=0)&&(zb<xb.options.length)){xb.selectedIndex=zb;}
}
function tn(_b,X){X=(!X?6:X);return Math.round(_b*Math.pow(10,X))/Math.pow(10,X);}
function rn(ac,bc){var cc=nn(ac);if(cc===false){return bc;}
else{return cc;}
}
function qn(){return parseInt(rn("floatnumber",6));}
function un(ec){var ValidChars="0123456789.";for(i=0;i<ec.length;i++){if(ValidChars.indexOf(ec.charAt(i))==-1){return false;}
}
return true;}
function ins_speed1(fc){document.writeln('<select name="'+fc+'" id="'+fc+'" size="1" onchange="cc_speed1()">');for(i=0;i<ab.length;i++){document.writeln('<option value="'+i+'">'+ab[i][0]+'</option>');}
document.writeln('</select>');}
function vn(hc,vv,ic){var jc=ab[hc];var kc=ab[ic];;if(un(jc[1])){vv=vv*jc[1];}
else{vv=eval(jc[1]);}
if(un(kc[1])){vv=vv/kc[1];}
else{vv=eval(kc[2]);}
return tn(vv,bb);}
function cc_speed1(){var lc=parseFloat(document.getElementById('valuefromspeed1').value);if(isNaN(lc)){document.getElementById('valuetospeed1').value='';}
else{var tb=document.getElementById('selectfromspeed1').selectedIndex;var vb=document.getElementById('selecttospeed1').selectedIndex;document.getElementById('valuetospeed1').value=vn(tb,lc,vb);mc=document.getElementById('valueresultspeed1').tagName;if(mc=="SPAN")document.getElementById('valueresultspeed1').innerHTML=lc+" "+nc(document.getElementById('selectfromspeed1').options[document.getElementById('selectfromspeed1').selectedIndex].text)+" = "+document.getElementById('valuetospeed1').value+" "+nc(document.getElementById('selecttospeed1').options[document.getElementById('selecttospeed1').selectedIndex].text);else
document.getElementById('valueresultspeed1').value=lc+" "+nc(document.getElementById('selectfromspeed1').options[document.getElementById('selectfromspeed1').selectedIndex].text)+" = "+document.getElementById('valuetospeed1').value+" "+nc(document.getElementById('selecttospeed1').options[document.getElementById('selecttospeed1').selectedIndex].text);}
}
function ccb_speed1(){var lc=parseFloat(document.getElementById('valuetospeed1').value);if(isNaN(lc)){document.getElementById('valuefromspeed1').value='';}
else{var tb=document.getElementById('selecttospeed1').selectedIndex;var vb=document.getElementById('selectfromspeed1').selectedIndex;document.getElementById('valuefromspeed1').value=vn(tb,lc,vb);document.getElementById('valueresultspeed1').value=document.getElementById('valuefromspeed1').value+" "+nc(document.getElementById('selectfromspeed1').options[document.getElementById('selectfromspeed1').selectedIndex].text)+" = "+lc+" "+nc(document.getElementById('selecttospeed1').options[document.getElementById('selecttospeed1').selectedIndex].text);}
}
function nc(oc){return oc;var pc;if((oc.indexOf('(')==-1)&&(oc.indexOf('[')==-1))pc=oc.split();else{var qc=oc.indexOf(' ');if(qc==-1)qc=999;var rc=oc.indexOf('(');if(rc==-1)rc=999;var sc=oc.indexOf('[');if(sc==-1)sc=999;var tc=' ';if(rc<qc){tc='(';if(sc<rc){tc='[';}
}
else{tc=' ';if(sc<qc){tc='[';}
}
pc=oc.split(tc);}
return pc[0];}
