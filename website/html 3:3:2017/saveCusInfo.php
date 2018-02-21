<?php
   $name  = $_POST['name'];
   $email = $_POST['email'];
   $website = $_POST['website'];
   $message = $_POST['message'];

   $str = "Name: ".$name."   "."Email: ".$email."   "."website: ".$website."   "."message: ".$message."\n";
   $fn = "customer_name_email_website_message.txt";
   $fp = fopen($fn,"a+") or die ("Error opening file in write mode!");
   fputs($fp,$str);
   fclose($fp) or die ("Error closing file!");
   //file_put_contents("customer_name_email.txt", $str, FILE_APPEND);
?>
