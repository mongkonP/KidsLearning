var ab=[["second [s]",1],["femtosecond [fs]",1e-15],["picosecond [ps]",1e-12],["nanosecond [ns]",1e-9],["microsecond [us]",1e-6],["millisecond [ms]",1e-3],["minute [min]",60],["hour [h]",3600],["day [d]",86400],["week",604800],["month",2628000],["month (Synodic)",2551442.8896],["year [y]",31536000],["year (Sidereal)",31558149],["year (Julian)",31557600],["year (Leap)",31622400],["year (Tropical)",31556925.216],["fortnight",1209600],["millennium",31536000000],["century",3153600000],["decade",315360000],["shake",1e-8]];var bb;function jp(db){var eb=window.onload;if(typeof window.onload!="function"){window.onload=db;}
else{window.onload=function(){eb();db();}
}
;}
function kp(db){var gb=window.onunload;if(typeof window.onunload!="function"){window.onunload=db;}
else{window.onunload=function(){gb();db();}
}
;}
jp(lp);kp(mp);function np(kb,value,lb){var mb=new Date();mb.setDate(mb.getDate()+lb);document.cookie=kb+"="+escape(value)+((lb==null)?"":";expires="+mb.toGMTString());}
function op(kb){if(document.cookie.length>0){ob=document.cookie.indexOf(kb+"=");if(ob!=-1){ob=ob+kb.length+1;pb=document.cookie.indexOf(";",ob);if(pb==-1)pb=document.cookie.length;return unescape(document.cookie.substring(ob,pb));}
}
return"";}
function lp(){pp();if(document.getElementById('valuetotime1')){qp();cc_time1();}
}
function pp(){bb=rp();}
function qp(){var tb=sp("selectfromtime1",0);var vb=sp("selecttotime1",0);tp('selectfromtime1',tb);tp('selecttotime1',vb);document.getElementById('valuefromtime1').value=sp("valuefromtime1",1);}
function mp(){if(document.getElementById('valuetotime1')){var xb;xb=document.getElementById('selectfromtime1');np('selectfromtime1',xb.options[xb.selectedIndex].value,365);xb=document.getElementById('selecttotime1');np('selecttotime1',xb.options[xb.selectedIndex].value,365);xb=document.getElementById('valuefromtime1');np('valuefromtime1',xb.value,365);}
}
function tp(yb,zb){var xb=document.getElementById(yb);if((zb>=0)&&(zb<xb.options.length)){xb.selectedIndex=zb;}
}
function up(_b,X){X=(!X?6:X);return Math.round(_b*Math.pow(10,X))/Math.pow(10,X);}
function sp(ac,bc){var cc=op(ac);if(cc===false){return bc;}
else{return cc;}
}
function rp(){return parseInt(sp("floatnumber",6));}
function vp(ec){var ValidChars="0123456789.";for(i=0;i<ec.length;i++){if(ValidChars.indexOf(ec.charAt(i))==-1){return false;}
}
return true;}
function ins_time1(fc){document.writeln('<select name="'+fc+'" id="'+fc+'" size="1" onchange="cc_time1()">');for(i=0;i<ab.length;i++){document.writeln('<option value="'+i+'">'+ab[i][0]+'</option>');}
document.writeln('</select>');}
function wp(hc,vv,ic){var jc=ab[hc];var kc=ab[ic];;if(vp(jc[1])){vv=vv*jc[1];}
else{vv=eval(jc[1]);}
if(vp(kc[1])){vv=vv/kc[1];}
else{vv=eval(kc[2]);}
return up(vv,bb);}
function cc_time1(){var lc=parseFloat(document.getElementById('valuefromtime1').value);if(isNaN(lc)){document.getElementById('valuetotime1').value='';}
else{var tb=document.getElementById('selectfromtime1').selectedIndex;var vb=document.getElementById('selecttotime1').selectedIndex;document.getElementById('valuetotime1').value=wp(tb,lc,vb);mc=document.getElementById('valueresulttime1').tagName;if(mc=="SPAN")document.getElementById('valueresulttime1').innerHTML=lc+" "+nc(document.getElementById('selectfromtime1').options[document.getElementById('selectfromtime1').selectedIndex].text)+" = "+document.getElementById('valuetotime1').value+" "+nc(document.getElementById('selecttotime1').options[document.getElementById('selecttotime1').selectedIndex].text);else
document.getElementById('valueresulttime1').value=lc+" "+nc(document.getElementById('selectfromtime1').options[document.getElementById('selectfromtime1').selectedIndex].text)+" = "+document.getElementById('valuetotime1').value+" "+nc(document.getElementById('selecttotime1').options[document.getElementById('selecttotime1').selectedIndex].text);}
}
function ccb_time1(){var lc=parseFloat(document.getElementById('valuetotime1').value);if(isNaN(lc)){document.getElementById('valuefromtime1').value='';}
else{var tb=document.getElementById('selecttotime1').selectedIndex;var vb=document.getElementById('selectfromtime1').selectedIndex;document.getElementById('valuefromtime1').value=wp(tb,lc,vb);document.getElementById('valueresulttime1').value=document.getElementById('valuefromtime1').value+" "+nc(document.getElementById('selectfromtime1').options[document.getElementById('selectfromtime1').selectedIndex].text)+" = "+lc+" "+nc(document.getElementById('selecttotime1').options[document.getElementById('selecttotime1').selectedIndex].text);}
}
function nc(oc){return oc;var pc;if((oc.indexOf('(')==-1)&&(oc.indexOf('[')==-1))pc=oc.split();else{var qc=oc.indexOf(' ');if(qc==-1)qc=999;var rc=oc.indexOf('(');if(rc==-1)rc=999;var sc=oc.indexOf('[');if(sc==-1)sc=999;var tc=' ';if(rc<qc){tc='(';if(sc<rc){tc='[';}
}
else{tc=' ';if(sc<qc){tc='[';}
}
pc=oc.split(tc);}
return pc[0];}
