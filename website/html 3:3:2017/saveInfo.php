<?php
   $name  = $_POST['name'];
   $email = $_POST['email'];
   $str = "Name: ".$name."   "."Email: ".$email."\n";
   $fn = "customer_name_email.txt";
   $fp = fopen($fn,"a+") or die ("Error opening file in write mode!");
   fputs($fp,$str);
   fclose($fp) or die ("Error closing file!");
   //file_put_contents("customer_name_email.txt", $str, FILE_APPEND);

   // Multiple recipients
$to = $email; // note the comma

// Subject
$subject = 'Recent News&Events of Nanova Environmental Inc,.';

// Message
// $message = '
// <html>
// <head>
//   <title>Birthday Reminders for August</title>
// </head>
// <body>
//   <p>Here are the birthdays upcoming in August!</p>
//   <table>
//     <tr>
//       <th>Person</th><th>Day</th><th>Month</th><th>Year</th>
//     </tr>
//     <tr>
//       <td>Johny</td><td>10th</td><td>August</td><td>1970</td>
//     </tr>
//     <tr>
//       <td>Sally</td><td>17th</td><td>August</td><td>1973</td>
//     </tr>
//   </table>
// </body>
// </html>
// ';
//$message = file_get_contents('company_blog.html');

//
// $message = '<html>
// <head>
// <link rel="stylesheet" href="stylesheets/style.css" />
// <link rel="stylesheet" href="stylesheets/responsive.css" />
// <script src="scripts/jquery.min.js"></script>
// <script src="scripts/jquery.bxSlider.min.js"></script>
// <script src="scripts/jquery.faq.js"></script>
// <script src="scripts/jquery.prettyPhoto.js"></script>
// <script src="scripts/jquery.blackandwhite.min.js"></script>
// <script src="scripts/js_func.js"></script>
// </head>
// <body>
// <div class="content_block">
// <div class="wraper">
// <div id="RightSide" class="portfolio_sidebar portfolio_sidebar_right">
// <a href="index.html"><img src="images/invitation/Invitation 1.png" width = 100%>
// </img></a>
// <a href="http://pittcon.org/pittcon-2017/"><img src="images/invitation/Invitation 2.png" width = 100%>
// </img></a>
// <a href="Product_introduction.html"><img src="images/invitation/Invitation 3.png" width = 100%>
// </img></a>
// <img src="images/invitation/Invitation 4.png" width = 100%>
// </img>
// <img src="images/invitation/Invitation 5.png" width = 100%>
// </img>
// <img src="images/invitation/Invitation 6.png" width = 100%>
// </img>
// <a href="Contact.html"><img src="images/invitation/Invitation 7.png" width = 100% >
// </img></a>
// </div>
// </div>
// </div>
// </body>
// </html>
// ';
//
// // To send HTML mail, the Content-type header must be set
// $headers[] = 'MIME-Version: 1.0';
// $headers[] = 'Content-type: text/html; charset=iso-8859-1';
//
// // Additional headers
// //$headers[] = 'To: '.$email;
// $headers[] = 'From: Nanovaenv Environmental Inc,. <info@nanovaenv.com>';
// $headers[] = 'Cc: websitefeedback@nanovaenv.com';
// $headers[] = 'Bcc: websitefeedback@nanovaenv.com';

// Mail it
//mail($to, $subject, $message, implode("\r\n", $headers));

require "/root/vendor/phpmailer/phpmailer/PHPMailerAutoload.php";
$smtp->Debugoutput = function($str, $level) {echo "debug level $level; message: $str";};
$mail = new PHPMailer();

//Tell PHPMailer to use SMTP
$mail->isSMTP();
//Enable SMTP debugging
// 0 = off (for production use)
// 1 = client messages
// 2 = client and server messages
$mail->SMTPDebug = 2;
//Ask for HTML-friendly debug output
$mail->Debugoutput = 'html';
//Set the hostname of the mail server
$mail->Host = 'smtp.gmail.com';
// use
// $mail->Host = gethostbyname('smtp.gmail.com');
// if your network does not support SMTP over IPv6
//Set the SMTP port number - 587 for authenticated TLS, a.k.a. RFC4409 SMTP submission
$mail->Port = 587;
//Set the encryption system to use - ssl (deprecated) or tls
$mail->SMTPSecure = 'tls';
//Whether to use SMTP authentication
$mail->SMTPAuth = true;
//Username to use for SMTP authentication - use full email address for gmail
$mail->Username = "angelinana0408@gmail.com";
//Password to use for SMTP authentication
$mail->Password = "~Yy18722069967";


$mail->From="info@nanovaenv.com";
$mail->FromName="Nanovaenv Environmental Inc,.";
$mail->Sender="info@nanovaenv.com";
$mail->AddReplyTo("info@nanovaenv.com", "Replies for my site");

$mail->AddAddress($email);
$mail->Subject = $subject;

$mail->IsHTML(true);
// $mail->AddEmbeddedImage('images/invitation/Invitation 1.png', 'one', 'images/invitation/Invitation 1.png');
// $mail->AddEmbeddedImage('images/invitation/Invitation 2.png', 'two', 'images/invitation/Invitation 2.png');
// $mail->AddEmbeddedImage('images/invitation/Invitation 3.png', 'three', 'images/invitation/Invitation 3.png');
// $mail->AddEmbeddedImage('images/invitation/Invitation 4.png', 'four', 'images/invitation/Invitation 4.png');
// $mail->AddEmbeddedImage('images/invitation/Invitation 5.png', 'five', 'images/invitation/Invitation 5.png');
// $mail->AddEmbeddedImage('images/invitation/Invitation 6.png', 'six', 'images/invitation/Invitation 6.png');
// $mail->AddEmbeddedImage('images/invitation/Invitation 7.png', 'seven', 'images/invitation/Invitation 7.png');
//
// $mail->Body = '
// <html>
// <head>
// <link rel="stylesheet" href="stylesheets/style.css" />
// <link rel="stylesheet" href="stylesheets/responsive.css" />
// <script src="scripts/jquery.min.js"></script>
// <script src="scripts/jquery.bxSlider.min.js"></script>
// <script src="scripts/jquery.faq.js"></script>
// <script src="scripts/jquery.prettyPhoto.js"></script>
// <script src="scripts/jquery.blackandwhite.min.js"></script>
// <script src="scripts/js_func.js"></script>
// </head>
// <body>
// <div class="content_block">
// <div class="wraper">
// <div id="RightSide" class="portfolio_sidebar portfolio_sidebar_right">
// <a href="index.html"><img src="cid:one" width = 100%>
// </img></a>
// <a href="http://pittcon.org/pittcon-2017/"><img src="cid:two" width = 100%>
// </img></a>
// <a href="Product_introduction.html"><img src="cid:three" width = 100%>
// </img></a>
// <img src="cid:four" width = 100%>
// </img>
// <img src="cid:five" width = 100%>
// </img>
// <img src="cid:six" width = 100%>
// </img>
// <a href="Contact.html"><img src="cid:seven" width = 100% >
// </img></a>
// </div>
// </div>
// </div>
// </body>
// </html>
// ';

$mail->Body="This is text only alternative body.";
$smtp->Debugoutput = function($str, $level) {echo "debug level $level; message: $str";};

if(!$mail->Send())
{
   echo "Error sending: " . $mail->ErrorInfo;;
}
else
{
   echo "Letter is sent";
}
$smtp->Debugoutput = function($str, $level) {echo "debug level $level; message: $str";};

echo "<script>window.location.href='Contact.html';</script>";
?>
