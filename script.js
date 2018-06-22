var fname = document.getElementById('f_name');
var lname= document.getElementById('l_name');
var email=document.getElementById('eid');
var address=document.getElementById('address');
var uname=document.getElementById('u_name');
var pass=document.getElementById('pass');
var gender=document.getElementById('gender').value;
var gen;
if(gender =='male'){
    gen = document.getElementById('male').value;
}
else
{
    gen = document.getElementById('female').value;

}

var qualification=document.getElementById('qualification');
var experience=document.getElementById('experience');

 var checkboxes = document.getElementsByName('codelist');
  var checkboxesChecked = [];
  for (var i=0; i<checkboxes.length; i++) {
     if (checkboxes[i].checked==true) {
        checkboxesChecked.push(checkboxes[i].value);
     }
  }

document.querySelector('form.myform').addEventListener('submit', function (e) {

    //prevent the normal submission of the form
    e.preventDefault();

    console.log("First name: "+fname.value);
	console.log("Last name: "+lname.value);    
	console.log("Email: "+email.value);
	console.log("Address: "+address.value);
	console.log("User name: "+uname.value);
	console.log("Password: "+pass.value);
	console.log("Gender: "+gen);
	console.log("Qualification: "+qualification.value);
	console.log("Experience: "+experience.value);
	console.log("Coding Languages: "+checkboxesChecked);
});