class employee
{
	constructor()
	{
this.fname = document.getElementById('f_name').value;
this.lname= document.getElementById('l_name').value;
this.email=document.getElementById('eid').value;
this.address=document.getElementById('address').value;
this.uname=document.getElementById('u_name').value;
this.pass=document.getElementById('pass').value;
var gender=document.getElementsByName('rgender');
for(var i=0;i<gender.length;i++)
{
if(gender[i].checked){
    this.gen = gender[i].value;
}

}
this.qualification=document.getElementById('qualification').value;
this.experience=document.getElementById('experience').value;

 var checkboxes = document.getElementsByName('codelist');
  this.checkboxesChecked = [];
  for (var i=0; i<checkboxes.length; i++) {
     if (checkboxes[i].checked==true) {
        this.checkboxesChecked.push(checkboxes[i].value);
     }
  }
	}
	}


document.querySelector('form.myform').addEventListener('submit', function (e) {

    //prevent the normal submission of the form
    e.preventDefault();
var emp=new employee();
	console.log(emp);
});