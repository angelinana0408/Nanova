<?php
//$to = ‘yq7r5@mail.missouri.edu’;
//$subject = ‘A test email!’;

// To send HTML mail, the Content-type header must be set
//$headers = ‘MIME-Version: 1.0? . “\r\n”;
//$headers .= ‘Content-type: text/html; charset=iso-8859-1? . “\r\n”;
//$headers = "Content-type: text/html\n";

// fetch Remotely
//$message = file_get_contents('company_blog.html');

// Mail it
//mail($to, $subject, $message, $headers);

$to = "yq7r5@mail.missouri.edu";
$subject = "HTML email";

$message = "
<html>
<head>
<title>HTML email</title>
</head>
<body>
<p>This email contains HTML Tags!</p>
<table>
<tr>
<th>Firstname</th>
<th>Lastname</th>
</tr>
<tr>
<td>John</td>
<td>Doe</td>
</tr>
</table>
</body>
</html>
";

// Always set content-type when sending HTML email
$headers = "MIME-Version: 1.0" . "\r\n";
$headers .= "Content-type:text/html;charset=UTF-8" . "\r\n";

// More headers
$headers .= 'From: <webmaster@example.com>' . "\r\n";
$headers .= 'Cc: myboss@example.com' . "\r\n";

mail($to,$subject,$message,$headers);

?>
