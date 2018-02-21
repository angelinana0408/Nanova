//Javascript validation
<head>
function validate_form1 ( ) {
    valid = true;
	var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
   	var address = document.form.Email.value;
	if(document.form.Name.value == "") {
      alert('Please enter your name');
      return false;
   } else if ( document.form.Email.value == "" ) {
	alert ( "Please enter your email address" );
	valid = false;
	} else if(reg.test(address) == false) {
      alert('Invalid Email Address');
      return false;
   } else if(document.form.subject.value == "") {
      alert('Please enter the message subject');
      return false;
   } else if(document.form.message.value == "") {
      alert('Please enter the message you wish to send');
      return false;
   }
	return valid;
}


</script>
</head>
<body>
//The form
			 <h1>Form</h1> <br />
<?PHP
//Show the form
$show_form=true;
//Check is the form was submitted
if(isset($_POST['Submit']))
{
//Set var's
	$namefield = $_POST['Name'];
	$emailfield = $_POST['Email'];
	$subjectfield = $_POST['subject'];
	$messagefield = $_POST['message'];
	$priorityfield = $_POST['priority'];
	$IPADDR = $_SERVER['REMOTE_ADDR'];
	$date = date("H:i:s D d M Y");

//The email body
	$body = <<<EOD
$date
Name: $namefield
Email: $emailfield
Subject: $subjectfield
Message: $messagefield
Priority: $priorityfield
$IPADDR
EOD;

//Email info
$to      = 'admin@yourdomain.com';
$subject = $_POST['subjectfield'];
$headers = 'From: support@yourdomain.com' . "\r\n" .
    'Reply-To: ' . $emailfield . '' . "\r\n" .
    'X-Mailer: PHP/' . phpversion();

//Send the mail
$success = mail($to, $subject, $body, $headers);
//Success text
        echo "<h2>Form Submited! <br /> Thank You for contacting support. We will get back to you as soon as we can.</h2>";
		//Hide the form
        $show_form=false;
    }
//Check if the form should be shown
if(true == $show_form)
{
?>
<form name="form" action="<?php echo $_SERVER['PHP_SELF']; ?>" method="POST" onsubmit="return validate_form1 ( );">
Your name: <br />
<input type="text" name="Name" size="30" maxlength="30" />
<br />
Email address: <br />
<input type="text" name="Email" size="30" maxlength="30" />
<br />
Subject: <br />
<input type="text" name="subject" size="30" maxlength="50" />
<br />
Message:<br />
<textarea rows="8" cols="80" name="message"></textarea>
<br />
Priority: <br />
<select id="priority" name="priority">
<option value=" High">High</option>
<option value=" Medium">Medium</option>
<option value=" Low" selected="selected">Low</option>
</select>
<br /> <br />
<span class="red">All Fields Required *</span><br /> <br />
<p><input type="submit" name="Submit" class="formbutton" value="Send" /></p>
</form>
<?PHP
}//true == $show_form
?>
</body>
