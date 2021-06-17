/*
	Date format : dd/mm/yyyy
*/
function RestrictDate(obj)
{
	newvalue="";
	for (i=0; i<obj.value.length; i++) {
		c=obj.value.substr(i,1);
		if (i==1 && (c=='/'|| c=='-'))
			newvalue='0'+newvalue+'/';
		if (i==4 && (c=='/'|| c=='-'))
			newvalue=newvalue.substr(0,3)+'0'+newvalue.substr(3,1)+'/';
		if (i==2 || i==5) {
			if (c=='/' || c=='-')
				newvalue=newvalue+'/';
			else if (c<='9' && c>='0')
				newvalue=newvalue+'/'+c;
		} else if (i>=0 && i<=9) {
			if (c<='9' && c>='0')
				newvalue=newvalue+c;
		}
	}
	if (obj.value!=newvalue)
		obj.value=newvalue;
}

/*
	SCN Format: xx-xxxxx
*/
function RestrictSCN(obj)
{
	k=0;
	newvalue="";
	for (i=0; i<obj.value.length && k<=7; i++) {
		c=obj.value.substr(i,1);
		if (c<='9' && c>='0') {
			if (k==2) {
				newvalue=newvalue+'-';
				k++;
			}
			k++;
			newvalue=newvalue+c;
		}
	}
	if (obj.value!=newvalue)
		obj.value=newvalue;
}

function RestrictHKID(obj)
{
	newvalue="";
	j=0; k=0;
	for (i=0; i<obj.value.length; i++) {
		c=obj.value.substr(i,1);
		if (j==0 && k<2 && c>='A' && c<='z') {
			newvalue=newvalue+c;
			k=k+1;
		}
		else if (k>0 && j<6 && c>='0' && c<='9') {
			newvalue=newvalue+c;
			j=j+1;
		}
		else if (j==6 && c=='(') {
			newvalue=newvalue+c;
			j=j+1;
		}
		else if (j==7 && ((c>='0' && c<='9') || (c>='A' && c<='z'))) {
			newvalue=newvalue+c;
			j=j+1;
		}
		else if (j==8 && c==')') {
			newvalue=newvalue+')';
			j=j+1;
		}
		else if (j==6 && ((c>='0' && c<='9') || (c>='A' && c<='z'))) {
			newvalue=newvalue+'('+c+')';
			j=9;
		}
	}
	if (obj.value!=newvalue)
		obj.value=newvalue;
}


function RestrictInt(obj)
{
	newvalue="";
	for (i=0; i<obj.value.length; i++) {
		c = obj.value.substr(i,1)
		if (c<='9' && c>='0' || (c=='-' && i==0))
			newvalue = newvalue + c;
	}
	if (obj.value!=newvalue)
		obj.value=newvalue;
}


function RestrictFloat(obj)
{
	newvalue="";
	k=0;
	for (i=0; i<obj.value.length; i++) {
		c = obj.value.substr(i,1)
		if ((c<='9' && c>='0') || (c=='.' && k==0) || (c=='-' && i==0)) {
			if (c=='.') k=1;
			newvalue = newvalue + c;
		}
	}
	if (obj.value!=newvalue)
		obj.value=newvalue;
}

function CapitalizeName(obj)
{
	newvalue="";
	var words=obj.value.split(" ");
	for (i=0; i<words.length; i++)
	{
		words[i] = words[i].substring(0,1).toUpperCase() + words[i].substring(1,words[i].length).toLowerCase();
	}
	newvalue = words.join(" ");
	if (obj.value!=newvalue)
		obj.value=newvalue;
}
